using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM
{
    internal class CustomFonts
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection fonts = new PrivateFontCollection();

        public static Font heeboFont { get; set; }

        public static void init()
        {
            //load font
            byte[] fontData = Properties.Resources.Heebo_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Heebo_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Heebo_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            heeboFont = new Font(fonts.Families[0], 16.0F);
        }

        public static Font GetFont(float fontSize,FontStyle fontStyle = FontStyle.Regular)
        {
            return new Font(fonts.Families[0], fontSize, fontStyle);
        }
    }
}
