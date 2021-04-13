using System;

namespace SOCOM_II_MULTI_TOOL.Helpers
{
    public static class GameHelper
    {
        /// <summary>
        /// BRIGHTNESS ADJUSTMENTS
        /// </summary>

        //Player Object Stuff
        public static IntPtr sPlayerPointer = new IntPtr(0x2044d648);

        //Brightness Address 1
        public static IntPtr BRIGHTNESS1 = new IntPtr(0x204B858C);
        
        //Prevents Brightness Reset on Start Menu
        public static IntPtr BRIGHTNESS1_LOCK1 = new IntPtr(0x201EFB2C);
        public static IntPtr BRIGHTNESS1_LOCK2 = new IntPtr(0x201EFD5C);
        
        //Prevents Brightness Reset on Death
        public static IntPtr BRIGHTNESS1_RESET = new IntPtr(0x201EF950);

        //Brightness Address 2
        public static IntPtr BRIGHTNESS2 = new IntPtr(0x204B859C);
        
        //Prevents Brightness Reset on Start Menu
        public static IntPtr BRIGHTNESS2_LOCK1 = new IntPtr(0x201EFB3C);
        public static IntPtr BRIGHTNESS2_LOCK2 = new IntPtr(0x201EFD6C);
        
        //Prevents Brightness Reset on Death
        public static IntPtr BRIGHTNESS2_RESET = new IntPtr(0x201EF960);

        //Brightness Address 3
        public static IntPtr BRIGHTNESS3 = new IntPtr(0x204B85AC);

        //Prevents Brightness Reset on Start Menu
        public static IntPtr BRIGHTNESS3_LOCK1 = new IntPtr(0x201EFBA0);
        public static IntPtr BRIGHTNESS3_LOCK2 = new IntPtr(0x201EFDD0);
        public static IntPtr BRIGHTNESS3_LOCK3 = new IntPtr(0x20265068);

        //Prevents Brightness Reset on Death
        public static IntPtr BRIGHTNESS3_RESET = new IntPtr(0x201EF9C0);
        public static IntPtr BRIGHTNESS3_RESETA = new IntPtr(0x20265068);
    }
}
