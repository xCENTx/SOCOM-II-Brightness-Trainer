using Binarysharp.MemoryManagement;
using SOCOM_II_MULTI_TOOL.Helpers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SOCOM_II_TOOL
{
    public partial class Form1 : Form
    {
        MemorySharp m = null;
        private const string PCSX2PROCESSNAME = "pcsx2";
        bool pcsx2Running;

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public Form1()
        {
            InitializeComponent();
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
                pcsx2Status.Text = "PCSX2 CONNECTED";
                pnl_PCSX2Detected.BackColor = Color.FromArgb(0, 100, 0);
                pcsx2Running = true;
                return;
            }
            pcsx2Status.Text = "PCSX2 NOT DETECTED";
            pnl_PCSX2Detected.BackColor = Color.FromArgb(100, 0, 0);
            pcsx2Running = false;
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
                int newValue = 0x40800000;
                m.Write<Int32>(GameHelper.BRIGHTNESS1, newValue, false);
                m.Write<Int32>(GameHelper.BRIGHTNESS2, newValue, false);
                m.Write<Int32>(GameHelper.BRIGHTNESS3, newValue, false);
            }

            //Numpad Brightness Toggle OFF
            if (GetAsyncKeyState(Keys.NumPad0) < 0)
            {
                int nop = 0x00000000;
                m.Write<Int32>(GameHelper.BRIGHTNESS1, nop, false);
                m.Write<Int32>(GameHelper.BRIGHTNESS2, nop, false);
                m.Write<Int32>(GameHelper.BRIGHTNESS3, nop, false);
            }

            //Single Player Brightness Adjustments
            if (GetAsyncKeyState(Keys.Add) < 0)
            {
                IntPtr address = GameHelper.BRIGHTNESS1;
                float oldValue = m.Read<float>(address, false);
                float newValue = oldValue + 2;
                m.Write(address, value: newValue, false);
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
            int nop = 0x00000000;
            m.Write<Int32>(GameHelper.BRIGHTNESS1, nop, false);
            m.Write<Int32>(GameHelper.BRIGHTNESS2, nop, false);
            m.Write<Int32>(GameHelper.BRIGHTNESS3, nop, false);  
        }

        /// SLIGHT BRIGHTNESS ADJUSTMENT
        private void PerfectBrightness_Click(object sender, EventArgs e)
        {
            if (!pcsx2Running)
            {
                return;
            }
             int newValue = 0x40800000;
             m.Write<Int32>(GameHelper.BRIGHTNESS1, newValue, false);
             m.Write<Int32>(GameHelper.BRIGHTNESS2, newValue, false);
             m.Write<Int32>(GameHelper.BRIGHTNESS3, newValue, false);
        }
    }
}
