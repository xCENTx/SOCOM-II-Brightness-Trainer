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
    }
}
