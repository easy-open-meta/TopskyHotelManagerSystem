using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using TSHotelManagerSystem.Models;
using TSHotelManagerSystem.Properties;

namespace TSHotelManagerSystem
{
    public partial class RoomOption : Form
    {
        public RoomOption()
        {
            InitializeComponent();
        }
        public static string wk_WorkerNo;
        public static string rm_CanUse;

        

        private void picBou_Click(object sender, EventArgs e)
        {
            

        }

        private void RoomOption_Load(object sender, EventArgs e)
        {
            pnlRoomMID.Controls.Clear();
            FrmRoomManager frm1 = new FrmRoomManager();
            frm1.TopLevel = false;
            pnlRoomMID.Controls.Add(frm1);
            frm1.Show();
            
        }

        

        
        //FrmReserManager frm = new FrmReserManager();
        

       
    }
}
