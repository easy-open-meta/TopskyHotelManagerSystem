using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class FrmBackAdmin : Form
    {
        public FrmBackAdmin()
        {
            InitializeComponent();
        }




        private void picExitSystem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void picLockSystem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定要锁定屏幕吗？锁定后不能做任何操作!", "锁屏", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new FrmUnLockSystem().ShowDialog();
            }


        }

        private void llbCheckGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void llbUpLoadLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLook.Controls.Clear();
            FrmUpLoad frm1 = new FrmUpLoad();
            frm1.TopLevel = false;
            pnlLook.Controls.Add(frm1);
            frm1.Show();
            pnlWorkerPage.Visible=false;
        }

        private void llbWorkerManager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLook.Controls.Clear();
            FrmTopChange frm1 = new FrmTopChange();
            frm1.TopLevel = false;
            pnlLook.Controls.Add(frm1);
            frm1.Show();
            pnlWorkerPage.Visible = false;
        }

        private void llbAddRoom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLook.Controls.Clear();
            FrmAddRoom frm1 = new FrmAddRoom();
            frm1.TopLevel = false;
            pnlLook.Controls.Add(frm1);
            frm1.Show();
            pnlRoomPage.Visible = false;
        }

        private void FrmBackAdmin_Deactivate(object sender, EventArgs e)
        {
           
        }

        private void llbWorkerUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void llbCashList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLook.Controls.Clear();
            FrmCustoSpend frm1 = new FrmCustoSpend();
            frm1.TopLevel = false;
            pnlLook.Controls.Add(frm1);
            frm1.Show();
            pnlCustoPage.Visible = false;
        }

        private void FrmBackAdmin_Load(object sender, EventArgs e)
        {
            label5.Text = AdminInfo.adminType;
            if (AdminInfo.Password == "admin")
            {
                btnCash.Enabled = true;
                btnWTI.Enabled = true;
                btnCheckGroup.Enabled = true;
                btnRoom.Enabled = true;
                btnCusto.Enabled = true;
                btnBackManager.Enabled = true;
                btnWorker.Enabled = true;
            }
            else if (AdminInfo.Password == "cashmin")
            {
                btnCash.Enabled = true;
                btnWTI.Enabled = false;
                btnCheckGroup.Enabled = false;
                btnRoom.Enabled = false;
                btnCusto.Enabled = false;
                btnBackManager.Enabled = false;
                btnWorker.Enabled = false;
            }
            else if (AdminInfo.Password == "hotelmin")
            {
                btnCash.Enabled = false;
                btnWTI.Enabled = true;
                btnCheckGroup.Enabled = false;
                btnRoom.Enabled = true;
                btnCusto.Enabled = true;
                btnBackManager.Enabled = true;
                btnWorker.Enabled = false;
            }
        }

        private void picSet_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void tsmiBackUpDatabase_Click(object sender, EventArgs e)
        {
            FrmBackupDatabase frm = new FrmBackupDatabase();
            frm.Show();
        }

        private void btnCash_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btnCash_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnWTI_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            pnlRoomPage.Visible = false;
            pnlCheckPage.Visible = false;
            pnlWTI.Visible = false;
            if (pnlCashPage.Visible == true)
            {
                pnlCashPage.Visible = false;
            }
            else if (pnlCashPage.Visible == false)
            {
                pnlCashPage.Visible = true;
            }
            pnlCustoPage.Visible = false;
            pnlWorkerPage.Visible = false;
            pnlBack.Visible = false;
        }

        private void btnWTI_Click(object sender, EventArgs e)
        {
            pnlRoomPage.Visible = false;
            pnlCheckPage.Visible = false;
            if (pnlWTI.Visible == true)
            {
                pnlWTI.Visible = false;
            }
            else if (pnlWTI.Visible == false)
            {
                pnlWTI.Visible = true;
            }
            pnlCashPage.Visible = false;
            pnlCustoPage.Visible = false;
            pnlWorkerPage.Visible = false;
            pnlBack.Visible = false;

        }

        private void btnCheckGroup_Click(object sender, EventArgs e)
        {
            pnlRoomPage.Visible = false;
            if (pnlCheckPage.Visible == true)
            {
                pnlCheckPage.Visible = false;
            }
            else if (pnlCheckPage.Visible == false)
            {
                pnlCheckPage.Visible = true;
            }
            pnlWTI.Visible = false;
            pnlCashPage.Visible = false;
            pnlCustoPage.Visible = false;
            pnlWorkerPage.Visible = false;
            pnlBack.Visible = false;

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (pnlRoomPage.Visible == true)
            {
                pnlRoomPage.Visible = false;
            }
            else if (pnlRoomPage.Visible == false)
            {
                pnlRoomPage.Visible = true;
            }
            pnlBack.Visible = false;
            pnlCheckPage.Visible = false;
            pnlWTI.Visible = false;
            pnlCashPage.Visible = false;
            pnlCustoPage.Visible = false;
            pnlWorkerPage.Visible = false;

        }

        private void btnCusto_Click(object sender, EventArgs e)
        {
            pnlRoomPage.Visible = false;
            pnlCheckPage.Visible = false;
            pnlWTI.Visible = false;
            pnlCashPage.Visible = false;
            pnlBack.Visible = false;
            if (pnlCustoPage.Visible == true)
            {
                pnlCustoPage.Visible = false;
            }
            else if (pnlCustoPage.Visible == false)
            {
                pnlCustoPage.Visible = true;
            }
            pnlWorkerPage.Visible = false;

        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            pnlRoomPage.Visible = false;
            pnlCheckPage.Visible = false;
            pnlWTI.Visible = false;
            pnlCashPage.Visible = false;
            pnlCustoPage.Visible = false;
            pnlBack.Visible = false;
            if (pnlWorkerPage.Visible == true)
            {
                pnlWorkerPage.Visible = false;
            }
            else if (pnlWorkerPage.Visible == false)
            {
                pnlWorkerPage.Visible = true;
            }

        }

        private void llbWTI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLook.Controls.Clear();
            WtiInfo frm1 = new WtiInfo();
            frm1.TopLevel = false;
            pnlLook.Controls.Add(frm1);
            frm1.Show();
            pnlWTI.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlLook_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void FrmBackAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            pnlRoomPage.Visible = false;
            pnlCheckPage.Visible = false;
            pnlWTI.Visible = false;
            pnlCashPage.Visible = false;
            pnlCustoPage.Visible = false;
            pnlWorkerPage.Visible = false;
            pnlBack.Visible = false;
        }



        private void llbUpdateCusto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLook.Controls.Clear();
            FrmCustoManager frm1 = new FrmCustoManager();
            frm1.TopLevel = false;
            pnlLook.Controls.Add(frm1);
            frm1.Show();
            pnlCustoPage.Visible = false;
        }

        private void llbCheckForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLook.Controls.Clear();
            FrmCheckInfo frm1 = new FrmCheckInfo();
            frm1.TopLevel = false;
            pnlLook.Controls.Add(frm1);
            frm1.Show();
            pnlCheckPage.Visible = false;
        }

        private void llbCheckMoney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnBackManager_Click(object sender, EventArgs e)
        {
            pnlRoomPage.Visible = false;
            pnlCheckPage.Visible = false;
            pnlWTI.Visible = false;
            pnlCashPage.Visible = false;
            pnlCustoPage.Visible = false;
            pnlWorkerPage.Visible = false;
            if (pnlBack.Visible == true)
            {
                pnlBack.Visible = false;
            }
            else if (pnlBack.Visible == false)
            {
                pnlBack.Visible = true;
            }
        }

        private void llbSellThing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLook.Controls.Clear();
            FrmSellThingManager frm1 = new FrmSellThingManager();
            frm1.TopLevel = false;
            pnlLook.Controls.Add(frm1);
            frm1.Show();
            pnlBack.Visible = false;
        }

        private void llbCash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                pnlLook.Controls.Clear();
                FrmCash frm1 = new FrmCash();
                frm1.TopLevel = false;
                pnlLook.Controls.Add(frm1);
                frm1.Show();
                pnlCashPage.Visible = false;
            }
            catch
            {
                pnlLook.Controls.Clear();
                FrmCash frm1 = new FrmCash();
                frm1.TopLevel = false;
                pnlLook.Controls.Add(frm1);
                frm1.Show();
                pnlCashPage.Visible = false;
            }
            finally
            {
                pnlLook.Controls.Clear();
                FrmCash frm1 = new FrmCash();
                frm1.TopLevel = false;
                pnlLook.Controls.Add(frm1);
                frm1.Show();
                pnlCashPage.Visible = false;
            }
            
        }

        private void llbBackCash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWorkerLog_Click(object sender, EventArgs e)
        {
            pnlRoomPage.Visible = false;
            pnlCheckPage.Visible = false;
            pnlWTI.Visible = false;
            pnlCashPage.Visible = false;
            pnlCustoPage.Visible = false;
            pnlWorkerPage.Visible = false;
            pnlLook.Controls.Clear();
            FrmOperation frm1 = new FrmOperation();
            frm1.TopLevel = false;
            pnlLook.Controls.Add(frm1);
            frm1.Show();
        }
    }
}
