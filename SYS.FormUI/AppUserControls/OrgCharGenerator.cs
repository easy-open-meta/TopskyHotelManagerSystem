using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public delegate void dlgNodeClick(OrgCharNode node);
    public class OrgCharGenerator
    {
        public const int ROOTMAIGINS_TOP = 30;
        public const int NODEMAIGINS_RIGHT = 20;
        public const int NODEMAIGINS_LEFT = 20;
        /// <summary>
        /// 節點的垂直間距
        /// </summary>
        public const int NODE_V_DIS = 50;
        /// <summary>
        /// 節點的水平間距
        /// </summary>
        public const int NODE_H_DIS = 10;
        /// <summary>
        /// 節點寬
        /// </summary>
        public const int NODE_WIDTH = 129;
        /// <summary>
        /// 節點高度
        /// </summary>
        public const int NODE_HEIGHT = 61;
        /// <summary>
        /// 跟節點
        /// </summary>
        public OrgCharNode _RootNode;
        /// <summary>
        /// 層次集合
        /// </summary>
        public List<Level> Levels = new List<Level>();
        /// <summary>
        /// 數據源
        /// </summary>
        public OrgCharDataSource DataSource;
        /// <summary>
        /// 容器的控件
        /// </summary>
        public CtrlOrgChar _OrgCtrl;
        public int Max_X;
        public int Max_Y;
        /// <summary>
        /// 給定某個範圍，計算出每個node的位置Rectangle
        /// </summary>
        /// <param name="RootNode"></param>
        /// <param name="LeftNode_x">最左邊的節點x座標</param>
        /// <param name="LeftNode_y">最左邊的節點y座標</param>
        public void GeneratorControlChar(OrgCharNode RootNode)
        {
            this.Max_X = 0;
            this.Max_Y = 0;
            _RootNode = RootNode;
            this.Levels.Clear();
            AddNodeToLevels(RootNode);
            CalNodeRec(RootNode);
            if (this.DataSource != null && this.DataSource.Container != null)
            {
                this.DataSource.Container.Width = this.Max_X + NODE_WIDTH + NODEMAIGINS_RIGHT;
                this.DataSource.Container.Height = this.Max_Y + NODE_HEIGHT;
            }
        }
        public void GeneratorControlChar(OrgCharDataSource datasource)
        {
            DataSource = datasource;
            DataSource.Container.Paint += new PaintEventHandler(Container_Paint);
            this._RootNode=DataSource.BuildNodeTree();
            GeneratorControlChar(this._RootNode);
        }
        void Container_Paint(object sender, PaintEventArgs e)
        {
            this.DrawParenChildLine(e.Graphics);
        }
        /// <summary>
        /// 把各個leve層次的節點加入到對應的level中
        /// </summary>
        /// <param name="n"></param>
        private void AddNodeToLevels(OrgCharNode n)
        {
            if (n.Level > Levels.Count - 1)
            {
                Level l = new Level(n.Level);
                l.Items.Add(n);
                Levels.Add(l);
            }
            else
            {
                Levels[n.Level].Items.Add(n);
            }
            Levels.Sort(CompareSortLevel); //重新排序列表
        }
        private int CompareSortLevel(Level x, Level y)
        {
            return x.level.CompareTo(y.level);
        }
        /// <summary>
        /// 通過childs來獲取node X座標
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int GetXByChilds(OrgCharNode node)
        {
            if (node.Childs.Count > 0)
            {
                int tmp = 0;
                tmp = node.FirstChildNode.X + ((node.LastChildNode.Right - node.FirstChildNode.X) / 2) - NODE_WIDTH / 2;
                return tmp;
            }
            return -1;
        }
        /// <summary>
        /// 通過父親的前一個節點的子節點來獲取X座標
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int GetXByParentPreviousNode(OrgCharNode node)
        {
            if (node.ParentNode == null) { return -1; }
            OrgCharNode pprvnode = node.ParentNode.PreviousNode;
            if (pprvnode != null)
            {
                if (pprvnode.Childs.Count > 0)
                {
                    return pprvnode.LastChildNode.Right + NODE_H_DIS;
                }
                else
                {
                    return pprvnode.X ;
                }
            }
            else
            {
                if (node.ParentNode != null)
                {
                    return GetXByParentPreviousNode(node.ParentNode);
                }
            }
            return -1;
        }
        /// <summary>
        /// 通過同level的前一個子節點的Right來獲取X座標
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int GetXByLevel(OrgCharNode node)
        {
            OrgCharNode prvnode = this.Levels[node.Level].GetPrviousNode(node);
            if (prvnode != null)
            {
                return prvnode.Right + NODE_H_DIS;
            }
            return -1;
        }

        public void CalNodeRec(OrgCharNode node)
        {
            AddNodeToLevels(node);
            foreach (OrgCharNode n in node.Childs)
            {
                CalNodeRec(n);
            }
            //System.Diagnostics.Debug.WriteLine((node.Tag);

            node.Width = NODE_WIDTH;
            node.Heigth = NODE_HEIGHT;
            int[] sortArr = new int[] {  
                                        GetXByParentPreviousNode(node),
                                        GetXByChilds(node),
                                        GetXByLevel(node),
                                        NODEMAIGINS_RIGHT };
            Array.Sort(sortArr);
            int N_X = sortArr[sortArr.Length - 1]; //取出最大X座標 就是node 的座標
            node.X = N_X;            
            node.Y = (NODE_V_DIS + NODE_HEIGHT) * node.Level + ROOTMAIGINS_TOP;
            if (Max_X < node.X)
            {
                Max_X = node.X;
            }
            if (Max_Y< node.Y)
            {
                Max_Y = node.Y;
            }
        }
        private Pen uPen = new Pen(SystemColors.ControlText, 2);
        private Graphics g;
        /// <summary>
        /// 畫父子之間的線條
        /// </summary>
        public void DrawParenChildLine(Graphics g)
        {
            this.g = g;
            if (this._RootNode != null)
            {
                DrawParenChildLine(this._RootNode);
            }
        }
        private void DrawParenChildLine(OrgCharNode node)
        {
            if (node.Childs.Count > 0)
            {
                foreach (OrgCharNode n in node.Childs)
                {
                    
                    Draw3Dline(
                        node.X + node.Width / 2,
                        node.Botton,
                        node.X + node.Width / 2,
                        node.Botton + NODE_V_DIS / 2);
                    Draw3DEndPoint(node.X + node.Width / 2 , node.Botton,0);
                    Draw3Dline(
                        node.X + node.Width / 2,
                        node.Botton + NODE_V_DIS / 2,
                        n.X + n.Width / 2,
                        n.Y - NODE_V_DIS / 2);
                    Draw3Dline(
                        n.X + n.Width / 2,
                        n.Y - NODE_V_DIS / 2,
                        n.X + n.Width / 2,
                        n.Y);
                    Draw3DEndPoint(n.X + n.Width / 2 , n.Y,1);
                    DrawParenChildLine(n);

                }
            }
        }
        SolidBrush EnpointBrush = new SolidBrush(SystemColors.ControlLightLight);
        private void Draw3DEndPoint(int x, int y ,int upanddown)
        {
            //this.g.FillEllipse(new SolidBrush(SystemColors.ControlDark), new Rectangle(x  , y , 8, 8));

            int h = 5;
            Point p1 = new Point(x, y);
           

            if (upanddown == 0)
            {
                
                Point p2 = new Point(x , y - h);
                Point p3 = new Point(x - h, y - h);
                Point p4 = new Point(x + h, y - h);
                p1.Offset(-1, 4);
                p2.Offset(-1, 4);
                p3.Offset(-1, 4);
                p4.Offset(-1, 4);
                EnpointBrush.Color = ControlPaint.Light(SystemColors.ControlLight, 0.4f);
                this.g.FillPolygon(EnpointBrush, new Point[] { p1, p2, p3 });
                EnpointBrush.Color = ControlPaint.Dark(SystemColors.ControlDark, 0.2f); ;
                this.g.FillPolygon(EnpointBrush, new Point[] { p1, p2, p4 });
            }
            else
            {
                Point p2 = new Point(x , y+h);
                Point p5 = new Point(x - h, y+h);
                Point p6 = new Point(x + h, y+h);
                p1.Offset(-1, -5);
                p2.Offset(-1, -5);
                p5.Offset(-1, -5);
                p6.Offset(-1, -5);
                EnpointBrush.Color = ControlPaint.Light(SystemColors.ControlLight, 0.4f);

                this.g.FillPolygon(EnpointBrush, new Point[] { p1, p2, p5});
                EnpointBrush.Color = ControlPaint.Dark(SystemColors.ControlDark, 0.2f); ;
                this.g.FillPolygon(EnpointBrush, new Point[] { p1, p2, p6 });
            }
        }

        private void Draw3Dline(int x, int y, int x1, int y1)
        {
            if (g != null)
            {
                g.DrawLine(uPen, x, y, x1, y1);
                Draw3DLine(g, new Point(x, y), new Point(x1, y1), BorderStyle3D.RaisedFrame, SystemColors.ControlLight, SystemColors.ControlDark);
            }
        }
        private  enum BorderStyle3D
        {
            Default,
            None,
            Flat,
            Raised,
            RaisedInner,
            RaisedOuter,
            Sunken,
            SunkenInner,
            SunkenOuter,
            Etched,
            Bump,
            RaisedFrame
        }
        private void Draw3DLine(Graphics g, Point x, Point y, BorderStyle3D style, Color baseColor, Color border)
        {
            Color color = ControlPaint.Light(baseColor, 0.4f);
            Color color2 = ControlPaint.LightLight(baseColor);
            Color color3 = ControlPaint.Dark(baseColor, 0.2f);
            Color color4 = ControlPaint.Dark(baseColor, 0.6f);
            Pen pen = new Pen(color);
            switch (style)
            {
                case BorderStyle3D.Default:
                case BorderStyle3D.Flat:
                    pen.Color = (border == Color.Empty) ? baseColor : border;
                    g.DrawLine(pen, x, y);
                    break;
                case BorderStyle3D.Raised:
                    Draw3DLine(g, x, y, BorderStyle3D.RaisedOuter, baseColor, border);
                    x.Offset(-1, -1);
                    y.Offset(-1, -1);
                    Draw3DLine(g, x, y, BorderStyle3D.RaisedInner, baseColor, border);
                    break;
                case BorderStyle3D.RaisedInner:
                    if (x.X == y.Y)
                    {
                        g.DrawLine(pen, x, y);
                    }
                    else
                    {
                        pen.Color = color3;
                        g.DrawLine(pen, x, y);
                    }
                    break;
                case BorderStyle3D.RaisedOuter:
                    if (x.X == y.Y)
                    {
                        pen.Color = color2;
                        g.DrawLine(pen, x, y);
                    }
                    else
                    {
                        pen.Color = color4;
                        g.DrawLine(pen, x, y);
                    }
                    break;

                case BorderStyle3D.Sunken:
                    Draw3DLine(g, x, y, BorderStyle3D.SunkenOuter, baseColor, border);
                    x.Offset(-1, -1);
                    y.Offset(-1, -1);
                    Draw3DLine(g, x, y, BorderStyle3D.SunkenInner, baseColor, border);
                    break;

                case BorderStyle3D.SunkenInner:

                    if (x.X == y.Y)
                    {
                        pen.Color = color4;
                        g.DrawLine(pen, x, y);
                    }
                    else
                    {
                        pen.Color = color;
                        g.DrawLine(pen, x, y);
                    }
                    break;
                case BorderStyle3D.SunkenOuter:
                    if (x.X == y.Y)
                    {
                        pen.Color = color3;
                        g.DrawLine(pen, x, y);
                    }
                    else
                    {
                        pen.Color = color2;
                        g.DrawLine(pen, x, y);
                    }
                    break;

                case BorderStyle3D.Etched:
                    Draw3DLine(g, x, y, BorderStyle3D.SunkenOuter, baseColor, border);
                    x.Offset(-1, -1);
                    y.Offset(-1, -1);

                    Draw3DLine(g, x, y, BorderStyle3D.RaisedInner, baseColor, border);
                    break;

                case BorderStyle3D.Bump:
                    Draw3DLine(g, x, y, BorderStyle3D.RaisedOuter, baseColor, border);
                    x.Offset(-1, -1);
                    y.Offset(-1, -1);

                    Draw3DLine(g, x, y, BorderStyle3D.SunkenInner, baseColor, border);
                    break;
                case BorderStyle3D.RaisedFrame:
                    Draw3DLine(g, x, y, BorderStyle3D.Raised, baseColor, border);
                    x.Offset(-2, -2);
                    y.Offset(-2, -2);
                    Draw3DLine(g, x, y, BorderStyle3D.Sunken, baseColor, border);
                    break;
            }
            pen.Dispose();
        }
        public class Level
        {
            public Level(int l)
            {
                level = l;
            }
            private int GetNodeIndex(OrgCharNode node)
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    if (node.Equals(this.Items[i]))
                    {
                        return i;
                    }
                }
                return -1;
            }
            public int level;

            public List<OrgCharNode> Items = new List<OrgCharNode>();
            /// <summary>
            /// 獲取Level某個節點的前一個節點
            /// </summary>
            /// <param name="node"></param>
            /// <returns></returns>
            public OrgCharNode GetPrviousNode(OrgCharNode node)
            {
                int index = this.GetNodeIndex(node);
                if (index == -1 || index == 0)
                {
                    return null;
                }
                else
                {
                    return this.Items[index - 1];
                }

            }
        }
    }
    public class OrgCharNode
    {
        public OrgCharNode(IOrgCharNodeControl c)
        {
            this.ctrl = c;
        }
        private Rectangle PosRec;
        public int Level = 0;
        public OrgCharNode ParentNode;
        public IOrgCharNodeControl ctrl;
        public List<OrgCharNode> Childs = new List<OrgCharNode>();
        public event dlgNodeClick OnNodeClick;
        public void ControlCallBack(OrgCharNode node)
        {
            if (this.OnNodeClick != null)
            {
                this.OnNodeClick(this);
            }
        }
        public void AddChild(OrgCharNode node)
        {
            node.ParentNode = this;
            node.Level = this.Level + 1;
            this.Childs.Add(node);
           
        }
        public int Index
        {
            get
            {
                if (this.ParentNode != null)
                {
                    return this.ParentNode.Childs.IndexOf(this);
                }
                return -1;
            }
        }
        public OrgCharNode PreviousNode
        {
            get
            {
                if (this.ParentNode != null)
                {
                    if (this.Index == -1 || this.Index == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return this.ParentNode.Childs[this.Index - 1];
                    }
                }

                return null;
            }
        }
        public OrgCharNode FirstChildNode
        {
            get
            {
                if (Childs.Count > 0)
                {
                    return this.Childs[0];
                }
                return null;
            }
        }
        public OrgCharNode LastChildNode
        {
            get
            {
                if (Childs.Count ==0)
                {
                    return null;
                }
                else
                {
                    return this.Childs[this.Childs.Count -1];
                }
               
            }
        }
        public int X
        {
            get
            {
                return PosRec.X;
            }
            set
            {
                PosRec.X = value;
                if (this.ctrl != null)
                {
                    this.ctrl.Node_X = value;
                }
            }
        }
        public int Y
        {
            get
            {
                return PosRec.Y;
            }
            set
            {
                PosRec.Y = value;
                if (this.ctrl != null)
                {
                    this.ctrl.Node_Y = value;
                }
            }
        }
        public int Width
        {
            get
            {
                return PosRec.Width;
            }
            set
            {
                PosRec.Width = value;
                if (this.ctrl != null)
                {
                    this.ctrl.NodeWidth = value;
                }
            }
        }
        public int Heigth
        {
            get
            {
                return PosRec.Height;
            }
            set
            {
                PosRec.Height = value;
                if (this.ctrl != null)
                {
                    this.ctrl.NodeHeight = value;
                }
            }
        }
        public int Right
        {
            get
            {
                return X + Width;
            }
        }
        public int Botton
        {
            get
            {
                return Y + Heigth;
            }
        }
        public object Tag;
    }

    public interface IOrgCharNodeControl
    {
        dlgNodeClick ClickCallBack { get; set; }
        OrgCharNode Node { get; set; }
        int Node_X { get; set; }
        int Node_Y { get; set; }
        int NodeWidth { get; set; }
        int NodeHeight { get; set; }
    }
    public interface IOrgCharControlBuilder
    {
        IOrgCharNodeControl Build(DataRow dr);
    }

    public class OrgCharDataSource
    {
        /// <summary>
        /// 數據源構造函數
        /// </summary>
        /// <param name="k">dt表的主鍵名稱</param>
        /// <param name="pk">dt表的父親鍵名稱</param>
        /// <param name="rootparentvalue">根節點的父節點值</param>
        /// <param name="contrltype">要顯示的節點控件類型 給控件必須 繼承Control 實現IOrgCharNodeControl 接口 必須有無參數的構造函數</param>
        /// <param name="dt">來源數據表</param>
        public OrgCharDataSource(string k, string pk,object rootparentvalue, DataTable dt,Type Buildertype,Control c)
        {
            this.KeyFileName = k;
            this.ParentKeyFileName = pk;
            this.Table = dt;
            this.RootParentvalue = rootparentvalue;
            this.BuilderType = Buildertype;
            this.Container = c;
        }
        public string KeyFileName;
        public string ParentKeyFileName;
        public object RootParentvalue;
        public DataTable Table;
        public Type BuilderType;
        public Control Container;
        public IOrgCharControlBuilder ControlBuilder;
        public OrgCharNode BuildNodeTree()
        {
            DataRow[] drs = Table.Select(string.Format("{0}='{1}'", ParentKeyFileName, 0));
            if (ControlBuilder == null)
            {
                ControlBuilder = (IOrgCharControlBuilder)Activator.CreateInstance(this.BuilderType);
            }

            IOrgCharNodeControl obj = ControlBuilder.Build(drs[0]);
            this.Container.Controls.Add((Control)obj);
            obj.Node_X = -100;
            obj.NodeHeight = OrgCharGenerator.NODE_HEIGHT;
            obj.NodeWidth = OrgCharGenerator.NODE_WIDTH;
            OrgCharNode rootn = new OrgCharNode(obj);
            obj.Node = rootn;
            BuildNodeTree(drs[0], rootn);
            return rootn;
        }
        private void BuildNodeTree(DataRow r, OrgCharNode pn)
        {
            DataRow[] drs = Table.Select(string.Format("{0}='{1}'", ParentKeyFileName, r[KeyFileName]));
            foreach (DataRow d in drs)
            {
                if (ControlBuilder == null)
                {
                    ControlBuilder = (IOrgCharControlBuilder)Activator.CreateInstance(this.BuilderType);
                }
                IOrgCharNodeControl obj = ControlBuilder.Build(d);
                this.Container.Controls.Add((Control)obj);   
             
                obj.Node_X = -100;
                obj.NodeHeight = OrgCharGenerator.NODE_HEIGHT;
                obj.NodeWidth = OrgCharGenerator.NODE_WIDTH;
                OrgCharNode n = new OrgCharNode(obj);
                obj.Node = n;
                pn.AddChild(n);
                BuildNodeTree(d, n);
            }
        }

    }


}
