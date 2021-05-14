using Binarysharp.MemoryManagement;
using SOCOM_II_MULTI_TOOL.Helpers;
using DiscordRPC;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SOCOM_II_MULTI_TOOL;
using System.Text.RegularExpressions;

namespace SOCOM_II_TOOL
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// MemorySharp //Start
        /// </summary>
        MemorySharp m = null;
        private const string PCSX2PROCESSNAME = "pcsx2";
        bool pcsx2Running;

        /// <summary>
        /// HotKey C++ Import
        /// </summary>
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        /// <summary>
        /// Discord Presence //Start
        /// CREDIT 1UP (his source code)
        /// </summary>

        bool gameStarted = false;
        private static RichPresence presence = new RichPresence()
        {
            Details = "Not currently in a game.",
            State = "",
            Assets = new Assets()
            {
                LargeImageKey = "default",
                LargeImageText = "Not in a room.",
                SmallImageKey = "default"
            }
        };
        public DiscordRpcClient client;

        public Form1()
        {
            InitializeComponent();
            client = new DiscordRpcClient("774318933880209449");
            client.Initialize();
            client.SetPresence(presence);
        }

        private void setPresence(int sealWins, int terrorWins, short kills, short deaths)
        {
            if (sealWins == -1 && terrorWins == -1)
            {
                presence.Details = "Not currently in a game.";
            }
            else
            {
                presence.Details = "Seals: " + sealWins + " || Terrorist: " + terrorWins;
                presence.State = "Kills: " + kills + " Deaths: " + deaths;
            }
            presence.Assets = new Assets();
            presence.Assets.LargeImageKey = "1";
            presence.Assets.SmallImageKey = "green";
            //presence.Assets.LargeImageText = 
            //presence.Assets.SmallImageText = 
            client.SetPresence(presence);
        }

        private void resetPresence()
        {
            presence.Timestamps = null;
            setPresence(-1, -1, -1, -1);
            gameStarted = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!pcsx2Running)
            {
                return;
            }
            m = new MemorySharp(Process.GetProcessesByName(PCSX2PROCESSNAME).First());
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            Process[] pcsx2 = Process.GetProcessesByName(PCSX2PROCESSNAME);

            if (pcsx2.Length > 0)
            {
                //Color Status +Label Text ON
                pcsx2Status.Text = "PCSX2 CONNECTED";
                pnl_PCSX2Detected.BackColor = Color.FromArgb(0, 100, 0);
                pcsx2Running = true;
                return;
            }
            //Color Status +Label Text OFF
            pcsx2Status.Text = "PCSX2 NOT DETECTED";
            pnl_PCSX2Detected.BackColor = Color.FromArgb(100, 0, 0);
            pcsx2Running = false;
        }

        private void DiscordTimer_Tick(object sender, EventArgs e)
        {
            if (!pcsx2Running)
            {
                return;
            }
            m = new MemorySharp(Process.GetProcessesByName(PCSX2PROCESSNAME).First());
            if (checkBox1.Checked)
            {
                try
                {
                    if ((m.Read<byte>(GameHelper.PlayerPointer, 4, false) != null) && (!m.Read<byte>(GameHelper.PlayerPointer, 4, false).SequenceEqual(new byte[] { 0, 0, 0, 0 })))
                    {
                        if (m.Read<byte>(GameHelper.GameEndAddress, false) == 0)
                        {
                            IntPtr playerObjectAddress = new IntPtr(m.Read<int>(GameHelper.PlayerPointer, false)) + 0x20000000;
                            short kills = m.Read<short>(playerObjectAddress + GameHelper.PlayerKills, false);
                            short deaths = m.Read<short>(playerObjectAddress + GameHelper.PlayerDeaths, false);
                            int sealsRoundsWon = m.Read<byte>(GameHelper.SealWins, false);
                            int terroristRoundsWon = m.Read<byte>(GameHelper.TerrWins, false);
                            if (!gameStarted)
                            {
                                presence.Timestamps = new Timestamps()
                                {
                                    Start = DateTime.UtcNow

                                };

                                gameStarted = true;
                            }
                            setPresence(sealsRoundsWon, terroristRoundsWon, kills, deaths);
                        }
                        else
                        {
                            m.Write<byte>(GameHelper.GameEndAddress, new byte[] { 0x00 }, false);
                            resetPresence();
                        }
                    }
                    else
                    {
                        m.Write<byte>(GameHelper.GameEndAddress, new byte[] { 0x00 }, false);
                        resetPresence();
                    }
                }
                catch (Exception)
                {
                    //This only happens if the game isn't actually running but pcsx2 is. It would result in a crash but there's no reason to inform the user
                    resetPresence();
                }
            }
        }

        private void HotkeyTimer_Tick(object sender, EventArgs e)
        {
            if (!pcsx2Running)
            {
                return;
            }
            m = new MemorySharp(Process.GetProcessesByName(PCSX2PROCESSNAME).First());

            //Numpad Brightness Toggle ON
            if (GetAsyncKeyState(Keys.NumPad1) < 0)
            {
                var cheatString = @"204B858C 40800000
                    204B859C 40800000
                    204B85AC 40800000";

                var cheat = ParseCheat(cheatString);

                foreach (var code in cheat.Codes)
                {
                    m.Write<int>(code.Address, code.Data, false);
                }
            }

            //Numpad Brightness Toggle OFF
            if (GetAsyncKeyState(Keys.NumPad0) < 0)
            {
                var cheatString = @"204B858C 00000000
                    204B859C 00000000
                    204B85AC 00000000";

                var cheat = ParseCheat(cheatString);

                foreach (var code in cheat.Codes)
                {
                    m.Write<int>(code.Address, code.Data, false);
                }
            }

            //Single Player Brightness Adjustments
            if (GetAsyncKeyState(Keys.Add) < 0)
            {
                IntPtr address = GameHelper.BRIGHTNESS1;
                float oldValue = m.Read<float>(address, false);
                float newValue = oldValue + 2;
            }

            if (GetAsyncKeyState(Keys.Subtract) < 0)
            {
                IntPtr address = GameHelper.BRIGHTNESS1;
                float oldValue = m.Read<float>(address, false);
                float newValue = oldValue - 2;
                m.Write(address, value: newValue, false);
            }
        }

        /// DEFAULT BRIGHTNESS
        private void BLow_Click(object sender, EventArgs e)
        {
            if (!pcsx2Running)
            {
                return;
            }

            var cheatString = @"204B858C 00000000
                    204B859C 00000000
                    204B85AC 00000000";

            var cheat = ParseCheat(cheatString);

            foreach (var code in cheat.Codes)
            {
                m.Write<int>(code.Address, code.Data, false);
            }
        }

        /// SLIGHT BRIGHTNESS ADJUSTMENT
        private void PerfectBrightness_Click(object sender, EventArgs e)
        {
            if (!pcsx2Running)
            {
                return;
            }

            var cheatString = @"204B858C 40800000
                    204B859C 40800000
                    204B85AC 40800000";

            var cheat = ParseCheat(cheatString);

            foreach (var code in cheat.Codes)
            {
                m.Write<int>(code.Address, code.Data, false);
            }
        }

        private Cheat ParseCheat(string cheatText)
        {
            var matches = Regex.Matches(cheatText, "([0-9a-fA-F]{8}) ([0-9a-fA-F]{8})");

            if (matches.Count > 0)
            {
                return new Cheat()
                {
                    Codes = matches.Cast<Match>()
                    .Select(m => new Code()
                    {
                        Address = new IntPtr(Convert.ToInt32(m.Groups[1].Value, 16)),
                        Data = Convert.ToInt32(m.Groups[2].Value, 16)
                    }).ToList()
                };
            }
            return null;
        }
    }
}
