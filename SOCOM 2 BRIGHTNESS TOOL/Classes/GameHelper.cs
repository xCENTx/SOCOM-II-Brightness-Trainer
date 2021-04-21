using System;

namespace SOCOM_II_MULTI_TOOL.Helpers
{
    public static class GameHelper
    {
        /// <summary>
        /// BRIGHTNESS ADJUSTMENTS
        /// </summary>

        //Brightness Address 1
        public static IntPtr BRIGHTNESS1 = new IntPtr(0x204B858C);

        //Brightness Address 2
        public static IntPtr BRIGHTNESS2 = new IntPtr(0x204B859C);

        //Brightness Address 3
        public static IntPtr BRIGHTNESS3 = new IntPtr(0x204B85AC);

        /// <summary>
        /// SOCOM 2 Discord RPC ////
        /// Credit to various members of the community 
        /// who found these long before I did ////
        /// </summary>

        public static IntPtr PlayerPointer = new IntPtr(0x2044D648);
        public static IntPtr GameEndAddress = new IntPtr(0x20694C44);
        public static IntPtr CurrentMap = new IntPtr(0x204417C0);
        public static IntPtr SealWins = new IntPtr(0x20695388);
        public static IntPtr TerrWins = new IntPtr(0x2069539C);
        public static IntPtr RoomName = new IntPtr(0x21FFBBE0);

        public static int PlayerKills = 0x550;
        public static int PlayerDeaths = 0x556;
    }
}
