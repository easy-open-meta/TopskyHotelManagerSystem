/*
 * MIT License
 *Copyright (c) 2021 易开元(EOM)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */

using AntdUI;
using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using EOM.TSHotelManager.FormUI.AppUserControls;
using EOM.TSHotelManager.FormUI.Properties;
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmRoomManager : Form
    {
        

        public delegate void ReLoadRoomList(string typeName);

        public delegate void ReadRoomInfo();

        public delegate void RefreshRoomCount();

        //定义委托类型的变量
        public static ReadRoomInfo ReadInfo;
        public static ReLoadRoomList Reload;
        public static RefreshRoomCount _RefreshRoomCount;
        public FrmRoomManager()
        {
            InitializeComponent();
            ReadInfo = LoadRoomInfo;
            Reload = LoadData;
            _RefreshRoomCount = LoadRoomTypesAndStates;
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        List<Room> romsty = null;
        ucRoom room = null;
        string EmptyCount;
        string OccupiedCount;
        string UnderRepairCount;
        string ReservedCount;
        string DirtyCount;
        #region 房间加载事件方法
        private void FrmRoomManager_Load(object sender, EventArgs e)
        {
            LoadRoomInfo();
            LoadRoomTypesAndStates();
            LoadRoomTypes();
            LoadData();
        }
        #endregion

        private void LoadRoomTypesAndStates()
        {
            try
            {
                EmptyCount = "0";
                OccupiedCount = "0";
                DirtyCount = "0";
                UnderRepairCount =  "0";
                ReservedCount = "0";

                var requests = new Dictionary<string, (string? json, Dictionary<string, string>? parameters)>
                {
                    { "Room/SelectCanUseRoomAllByRoomState", (null, null) },
                    { "Room/SelectNotUseRoomAllByRoomState", (null, null) },
                    { "Room/SelectNotClearRoomAllByRoomState", (null, null) },
                    { "Room/SelectFixingRoomAllByRoomState", (null, null) },
                    { "Room/SelectReseredRoomAllByRoomState", (null, null) }
                };

                var results = HttpHelper.RaiseRequests(requests);

                if (results["Room/SelectCanUseRoomAllByRoomState"].statusCode != 200)
                {
                    throw new Exception("SelectCanUseRoomAllByRoomState+接口服务异常");
                }
                EmptyCount = results["Room/SelectCanUseRoomAllByRoomState"].message!;

                if (results["Room/SelectNotUseRoomAllByRoomState"].statusCode != 200)
                {
                    throw new Exception("SelectNotUseRoomAllByRoomState+接口服务异常");
                }
                OccupiedCount = results["Room/SelectNotUseRoomAllByRoomState"].message!;

                if (results["Room/SelectNotClearRoomAllByRoomState"].statusCode != 200)
                {
                    throw new Exception("SelectNotClearRoomAllByRoomState+接口服务异常");
                }
                DirtyCount = results["Room/SelectNotClearRoomAllByRoomState"].message!;

                if (results["Room/SelectFixingRoomAllByRoomState"].statusCode != 200)
                {
                    throw new Exception("SelectFixingRoomAllByRoomState+接口服务异常");
                }
                UnderRepairCount = results["Room/SelectFixingRoomAllByRoomState"].message!;

                if (results["Room/SelectReseredRoomAllByRoomState"].statusCode != 200)
                {
                    throw new Exception("SelectReseredRoomAllByRoomState+接口服务异常");
                }
                ReservedCount = results["Room/SelectReseredRoomAllByRoomState"].message!;

                LoadRoomState();
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"接口服务异常，请提交Issue或尝试更新版本！: {ex.Message}");
            }
        }

        private void LoadRoomState()
        {
            muRoomState.Items.Clear();

            var stateList = RoomStateConstant.GetAll().ToList();
            MenuItem? menuItem = null;
            if (!stateList.IsNullOrEmpty())
            {
                foreach (var item in stateList)
                {
                    menuItem = new MenuItem
                    {
                        Text = item.Description + GetRoomCountText(item.Code),
                        Tag = item.Code
                    };

                    var roomState = RoomStateConstant.GetConstantByCode(item.Code);
                    if (roomState != null)
                    {
                        menuItem.Icon = GetRoomCountIcon(roomState.Code);
                    }

                    muRoomState.Items.Add(menuItem);
                }
            }
        }

        private string GetRoomCountText(string code)
        {
            return code switch
            {
                var c when c == RoomStateConstant.Empty.Code => $"({EmptyCount})",
                var c when c == RoomStateConstant.Occupied.Code => $"({OccupiedCount})",
                var c when c == RoomStateConstant.UnderRepair.Code => $"({UnderRepairCount})",
                var c when c == RoomStateConstant.Dirty.Code => $"({DirtyCount})",
                var c when c == RoomStateConstant.Reserved.Code => $"({ReservedCount})",
                _ => string.Empty
            };
        }

        private Bitmap? GetRoomCountIcon(string code)
        {
            return code switch
            {
                var c when c == RoomStateConstant.Empty.Code => Resources.可住状态,
                var c when c == RoomStateConstant.Occupied.Code => Resources.已住状态,
                var c when c == RoomStateConstant.UnderRepair.Code => Resources.维修状态,
                var c when c == RoomStateConstant.Dirty.Code => Resources.脏房状态,
                var c when c == RoomStateConstant.Reserved.Code => Resources.预约状态,
                _ => null
            };
        }

        private void LoadRoomTypes()
        {
            try
            {
                var dic = new Dictionary<string, string> { { "isDelete", "0" } };
                var result = HttpHelper.Request("RoomType/SelectRoomTypesAll", null, dic);
                if (result.statusCode != 200)
                {
                    throw new Exception("SelectRoomTypesAll+接口服务异常");
                }

                var listRoomTypes = HttpHelper.JsonToList<RoomType>(result.message!);

                if (listRoomTypes == null)
                {
                    UIMessageBox.ShowError("Room types list is null");
                    return;
                }

                flpRoomTypes.Clear();

                AddRoomTypeButton("全部房间", "btnAll", btnAll_Click);
                foreach (var type in listRoomTypes)
                {
                    AddRoomTypeButton(type.RoomName, Convert.ToString(type.Roomtype), btnRoomType_Click);
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"接口服务异常，请提交Issue或尝试更新版本！: {ex.Message}");
            }
        }

        private void AddRoomTypeButton(string text, string name, EventHandler clickEvent)
        {
            var ucRoomType = new ucRoomType();
            ucRoomType.btnRoomType.Text = text;
            ucRoomType.btnRoomType.Name = name;
            ucRoomType.btnRoomType.Click += clickEvent;
            flpRoomTypes.Controls.Add(ucRoomType);
        }

        private void btnRoomType_Click(object? sender, EventArgs e)
        {
            if (sender is UIButton button)
            {
                string buttonName = button.Text;
                LoadData(buttonName);
            }
        }

        private void btnAll_Click(object? sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadRoomInfo()
        {
            lblRoomNo.Text = ucRoom.co_RoomNo;
            lblCustoName.Text = ucRoom.co_CustoName;
            lblRoomPosition.Text = ucRoom.co_RoomPosition;
            lblCheckTime.Text = ucRoom.co_CheckTime == null ? "" : Convert.ToDateTime(ucRoom.co_CheckTime).ToString("yyyy-MM-dd");
            lblRoomState.Text = ucRoom.co_RoomState;
        }

        private void LoadData(string typeName = "")
        {
            flpRoom.Controls.Clear();
            if (string.IsNullOrEmpty(typeName))
            {
                result = HttpHelper.Request("Room/SelectRoomAll");
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectRoomAll+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                romsty = HttpHelper.JsonToList<Room>(result.message!)!;
            }
            else
            {
                dic = new Dictionary<string, string>()
                {
                    { "TypeName",typeName}
                };
                result = HttpHelper.Request("Room/SelectRoomByTypeName", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectRoomByTypeName+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                romsty = HttpHelper.JsonToList<Room>(result.message!)!;
            }
            for (int i = 0; i < romsty.Count; i++)
            {
                room = new ucRoom();
                room.btnRoom.Text = string.Format("{0}\n\n{1}\n\n{2}", romsty[i].RoomName, romsty[i].RoomNo, romsty[i].CustoName ?? "      ");
                room.lblMark = string.Empty;
                room.romRoomInfo = romsty[i];
                room.romCustoInfo = new Custo { CustoNo = romsty[i].CustoNo, CustoName = romsty[i].CustoName };
                flpRoom.Controls.Add(room);
            }
            lblRoomNo.Text = "";
            lblRoomPosition.Text = "";
            lblRoomState.Text = "";
            lblCustoName.Text = "";
            lblCheckTime.Text = "";
            LoadRoomInfo();
        }

        private void LoadRoomByState(int stateid)
        {
            flpRoom.Controls.Clear();
            dic = new Dictionary<string, string>()
            {
                { "stateid",stateid.ToString()}
            };
            result = HttpHelper.Request("Room/SelectRoomByRoomState", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            romsty = HttpHelper.JsonToList<Room>(result.message!)!;
            for (int i = 0; i < romsty.Count; i++)
            {
                room = new ucRoom();
                room.btnRoom.Text = string.Format("{0}\n\n{1}\n\n{2}", romsty[i].RoomName, romsty[i].RoomNo, romsty[i].CustoName);
                room.lblMark = string.Empty;
                room.romRoomInfo = romsty[i];
                room.romCustoInfo = new Custo { CustoNo = romsty[i].CustoNo, CustoName = romsty[i].CustoName };
                flpRoom.Controls.Add(room);
            }
            lblRoomNo.Text = "";
            lblRoomPosition.Text = "";
            lblRoomState.Text = "";
            lblCustoName.Text = "";
            lblCheckTime.Text = "";
        }

        private void muRoomState_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            flpRoom.Controls.Clear();

            var roomState = RoomStateConstant.GetConstantByCode(e.Value.Tag as string);

            if (roomState != null)
            {
                switch (roomState.Code)
                {
                    case var code when code == RoomStateConstant.Empty.Code:
                        LoadRoomByState(0);
                        break;
                    case var code when code == RoomStateConstant.Occupied.Code:
                        LoadRoomByState(1);
                        break;
                    case var code when code == RoomStateConstant.UnderRepair.Code:
                        LoadRoomByState(2);
                        break;
                    case var code when code == RoomStateConstant.Dirty.Code:
                        LoadRoomByState(3);
                        break;
                    case var code when code == RoomStateConstant.Reserved.Code:
                        LoadRoomByState(4);
                        break;
                }
            }
        }
    }
}