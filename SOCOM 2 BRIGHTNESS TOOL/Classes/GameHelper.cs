using System;

namespace SOCOM_II_MULTI_TOOL.Helpers
{
    public static class GameHelper
    {
        /// <summary>
        /// Discord RPC Information
        /// </summary>

        public static IntPtr PlayerPointer = new IntPtr(0x2044D648);
        public static int PlayerKills = 0x550;
        public static int PlayerDeaths = 0x556;

        public static IntPtr GameEndAddress = new IntPtr(0x20694C44);
        public static IntPtr CurrentMap = new IntPtr(0x204417C0);
        public static IntPtr SealWins = new IntPtr(0x20695388);
        public static IntPtr TerrWins = new IntPtr(0x2069539C);
        public static IntPtr RoomName = new IntPtr(0x21FFBBE0);

        //Brightness Address 1
        public static IntPtr BRIGHTNESS1 = new IntPtr(0x204B858C);
    }
}
