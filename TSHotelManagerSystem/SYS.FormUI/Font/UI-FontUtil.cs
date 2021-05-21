﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SYS.FormUI
{
    public static class UI_FontUtil
    {

        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static ResourceManager rm = new ResourceManager("SYS.FormUI.Resource", Assembly.GetExecutingAssembly());
        private static Assembly assembly = Assembly.GetExecutingAssembly();
        /// <summary>
        /// 子控件字体
        /// </summary>
        public static Font childControlFont = null;
        public static Font mainFont = null;
        public static Font scorllingFont = null;
        public static Font controlFont = null;
        public static Font roomControlFont = null;
        
        static UI_FontUtil()
        {
            //var wreq = HttpWebRequest.Create("http://134.175.239.108:8085/ftp/puhuiti.ttf") as HttpWebRequest;
            //HttpWebResponse response = wreq.GetResponse() as HttpWebResponse;
            Stream stream = assembly.GetManifestResourceStream("SYS.FormUI.Resources.Alibaba-PuHuiTi-Regular.ttf");
            //Stream stream = response.GetResponseStream(); 
            byte[] fontdata = new byte[stream.Length];
            stream.Read(fontdata, 0, (int)stream.Length);
            stream.Close();
            unsafe
            {
                fixed (byte* pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                }
            }
            childControlFont = new Font(pfc.Families[0], 11);
            mainFont = new Font(pfc.Families[0], 11);
            scorllingFont = new Font(pfc.Families[0], 12);
            controlFont = new Font(pfc.Families[0], 15);
            roomControlFont = new Font(pfc.Families[0], 10);
        }


    }
}