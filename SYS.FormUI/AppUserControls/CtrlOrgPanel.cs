using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class CtrlOrgPanel : UserControl, IOrgCharNodeControl
    {
        public CtrlOrgPanel()
        {
            InitializeComponent();
            this.Click += new EventHandler(NodeButton_Click);
        }
        public CtrlOrgPanel(DataRow dr, string name, string descision, string jobs)
        {
            InitializeComponent();

            this.Click += new EventHandler(NodeButton_Click);
            SourceRow = dr;
            this.labDecision.Text = descision;
            this.labJobs.Text = jobs;
            this.labName.Text = name;
        }

        private DataRow _SourceRow;
        private DataRow SourceRow
        {
            set
            {
                if (_SourceRow != value)
                {
                    _SourceRow = value;
                }
            }
        }

        void NodeButton_Click(object sender, EventArgs e)
        {
            if (this.ClickCallBack != null)
            {
                this.ClickCallBack.Invoke(this.Node);
            }
        }
        public OrgCharNode _Node;
        #region INodeControl 成員
        private dlgNodeClick _ClickCallBack;
        public dlgNodeClick ClickCallBack
        {
            get
            {
                return _ClickCallBack;
            }
            set
            {
                _ClickCallBack = value;
            }
        }
        public OrgCharNode Node
        {
            get { return _Node; }
            set
            {
                this._Node = value;

            }
        }
        public int NodeWidth
        {
            get { return this.Width; }
            set { this.Width = value; }
        }
        public int NodeHeight
        {
            get { return this.Height; }
            set { this.Height = value; }
        }
        public int Node_X
        {
            get { return this.Left; }
            set { this.Left = value; }
        }
        public int Node_Y
        {
            get { return this.Top; }
            set { this.Top = value; }
        }

        #endregion


      
  
    }

    public class SH_OrgCharControlBuilder : IOrgCharControlBuilder
    {
   

        #region IOrgCharControlBuilder 成員

        IOrgCharNodeControl IOrgCharControlBuilder.Build(DataRow dr)
        {
            //CtrlOrgPanel pel = new CtrlOrgPanel(dr,
            //    dr["CD_MEMBER"] == DBNull.Value ? "" : dr["CD_MEMBER"].ToString(),
            //    dr["CD_ROLE"] == DBNull.Value ? "" : dr["CD_ROLE"].ToString(),
            //    dr["CD_JOB"] == DBNull.Value ? "" : dr["CD_JOB"].ToString()
            //    );
            CtrlOrgPanel pel = new CtrlOrgPanel(dr,
                dr["id"] == DBNull.Value ? "" : dr["id"].ToString(),
                dr["id"] == DBNull.Value ? "" : dr["id"].ToString(),
                dr["id"] == DBNull.Value ? "" : dr["id"].ToString()
                );
            return pel;
        }

        #endregion
    }
}
