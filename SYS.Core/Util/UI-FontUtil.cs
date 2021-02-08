using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    public class UI_FontUtil
    {
        public static Font SetMainFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            ResourceManager rm = new ResourceManager("SYS.Core.Resource", Assembly.GetExecutingAssembly());
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("SYS.Core.Resources.GFont.otf");
            byte[] fontData = new byte[stream.Length];
            stream.Read(fontData, 0, (int)stream.Length);
            stream.Close();

            unsafe
            {
                fixed (byte* pFontData = fontData)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontData.Length);
                }
            }
            FontFamily family = new FontFamily(pfc.Families[0].Name);
            Font myFont = new Font(family, 12);
            return myFont;
        }

        public static Font SetControlFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            ResourceManager rm = new ResourceManager("SYS.Core.Resource", Assembly.GetExecutingAssembly());
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("SYS.Core.Resources.GFont.otf");
            byte[] fontData = new byte[stream.Length];
            stream.Read(fontData, 0, (int)stream.Length);
            stream.Close();

            unsafe
            {
                fixed (byte* pFontData = fontData)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontData.Length);
                }
            }
            FontFamily family = new FontFamily(pfc.Families[0].Name);
            Font myFont = new Font(family, 14);
            return myFont;
        }

        public static Font SetChildControlsFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            ResourceManager rm = new ResourceManager("SYS.Core.Resource", Assembly.GetExecutingAssembly());
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("SYS.Core.Resources.GFont.otf");
            byte[] fontData = new byte[stream.Length];
            stream.Read(fontData, 0, (int)stream.Length);
            stream.Close();

            unsafe
            {
                fixed (byte* pFontData = fontData)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontData.Length);
                }
            }
            FontFamily family = new FontFamily(pfc.Families[0].Name);
            Font myFont = new Font(family, 12);
            return myFont;
        }

        public static Font SetRoomControlsFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            ResourceManager rm = new ResourceManager("SYS.Core.Resource", Assembly.GetExecutingAssembly());
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("SYS.Core.Resources.GFont.otf");
            byte[] fontData = new byte[stream.Length];
            stream.Read(fontData, 0, (int)stream.Length);
            stream.Close();

            unsafe
            {
                fixed (byte* pFontData = fontData)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontData.Length);
                }
            }
            FontFamily family = new FontFamily(pfc.Families[0].Name);
            Font myFont = new Font(family, 10);
            return myFont;
        }

        
    }
}
