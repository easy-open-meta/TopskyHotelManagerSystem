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
    public partial class CtrlOrgChar : UserControl
    {
        public CtrlOrgChar()
        {
            InitializeComponent();
        }
        OrgCharGenerator _CharGen = new OrgCharGenerator();

        private object _RootParentKeyValue;
        public object RootParentKeyValue
        {
            get
            {
                return _RootParentKeyValue;
            }
            set
            {
                if (_RootParentKeyValue != value)
                {
                    _RootParentKeyValue = value;
                }
            }
        }
        private string _KeyFileName;
        public string KeyFileName
        {
            get
            {
                return _KeyFileName;
            }
            set
            {
                if (_KeyFileName != value)
                {
                    _KeyFileName = value;
                }
            }
        }
        private string _ParentKeyFileName;
        public string ParentKeyFileName
        {
            get
            {
                return _ParentKeyFileName;
            }
            set
            {
                if (_ParentKeyFileName != value)
                {
                    _ParentKeyFileName = value;
                }
            }
        }
        private DataTable _DataSource;
        public DataTable DataSource
        {
            get
            {
                return _DataSource;
            }
            set
            {
                if (_DataSource != value)
                {
                    _DataSource = value;
                }
            }
        }


        public void ShowChar()
        {
            try
            {
                this.panel1.SuspendLayout();
                OrgCharDataSource ds = new OrgCharDataSource(this.KeyFileName,
                    ParentKeyFileName,
                    _RootParentKeyValue,
                    DataSource,
                    typeof(SH_OrgCharControlBuilder),
                    this.panel1);
                _CharGen.GeneratorControlChar(ds);
                this.panel1.Invalidate();
            }
            finally
            {
                this.panel1.ResumeLayout(false);
            }
        }
    }
}
