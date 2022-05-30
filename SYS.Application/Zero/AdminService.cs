/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

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
using jvncorelib_fr.Encryptor;
using SYS.Common;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SYS.Application
{
    /// <summary>
    /// 管理员数据访问层
    /// </summary>
    public class AdminService:Repository<Admin>, IAdminService
    {
        EncryptLib encryptLib = new EncryptLib();

        #region 根据超管密码查询员工类型和权限
        /// <summary>
        /// 根据超管密码查询员工类型和权限
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public Admin SelectMangerByPass(Admin admin)
        {
            Admin admins = new Admin();
            admins = base.GetSingle(a => a.AdminAccount == admin.AdminAccount && a.AdminPassword == admin.AdminPassword);
            //admin.AdminPassword = admin.AdminPassword.Contains(":") ? encrypt.DeEncryptStr(admin.AdminPassword) : admin.AdminPassword;
            return admins;
        }
        #endregion

        #region 根据超管账号查询对应的密码
        /// <summary>
        /// 根据超管账号查询对应的密码
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public Admin SelectAdminPwdByAccount(string account)
        {
            Admin admin = new Admin();
            admin = base.GetSingle(a => a.AdminAccount == account);
            //admin.AdminPassword = admin.AdminPassword.Contains(":") ? encrypt.DeEncryptStr(admin.AdminPassword) : admin.AdminPassword;
            return admin;
        }
        #endregion

        /// <summary>
        /// 获取所有管理员列表
        /// </summary>
        /// <returns></returns>
        public List<Admin> GetAllAdminList()
        {
            var listAdmins = base.GetList();
            var listAdminType = base.Change<AdminType>().GetList(a => a.delete_mk != 1);
            listAdmins.ForEach(admins =>
            {
                var isAdminType = admins.IsAdmin == 1 ? "是" : "否";
                admins.IsAdminNm = isAdminType;

                var adminType = listAdminType.FirstOrDefault(a => a.type_id.Equals(admins.AdminType));
                admins.TypeName = adminType == null ? "" : adminType.type_name;

                var adminDelete = admins.DeleteMk == 1 ? "是" : "否";
                admins.DeleteNm = adminDelete;

            });

            return listAdmins;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool UpdateNewPwdByOldPwd(Admin admin)
        {
            //admin.AdminPassword = encrypt.EncryptStr(admin.AdminPassword);
            return base.Update(a => new Admin()
            {
                AdminPassword = admin.AdminPassword,
                datachg_usr = AdminInfo.Account,
                datachg_time = DateTime.Now
            },a => a.AdminAccount == admin.AdminAccount);
        }

        /// <summary>
        /// 获取管理员列表(已启用)
        /// </summary>
        /// <returns></returns>
        public List<Admin> GetAllAdmin()
        {
            var listAdmin = base.GetList(a => a.DeleteMk != 1);
            var listAdminType = base.Change<AdminType>().GetList(a => a.delete_mk != 1);
            listAdmin.ForEach(admin =>
            {
                var isAdminType = admin.IsAdmin == 1 ? "是" : "否";
                admin.IsAdminNm = isAdminType;

                var adminType = listAdminType.FirstOrDefault(a => a.type_id.Equals(admin.AdminType));
                admin.TypeName = adminType == null ? "" : adminType.type_name;
            });
            return listAdmin;
        }

        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool AddAdmin(Admin admin)
        {
            //admin.AdminPassword = encrypt.EncryptStr(admin.AdminPassword);
            bool result = base.Insert(admin);
            return result;
        }

        /// <summary>
        /// 获取管理员信息
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public Admin GetAdminInfoByAdminAccount(Admin admin)
        {
            var adminInfo = base.GetSingle(a => a.AdminAccount.Equals(admin.AdminAccount));
            if (adminInfo != null)
            {
                var adminType = base.Change<AdminType>().GetSingle(a => a.type_id.Equals(adminInfo.AdminType));
                adminInfo.TypeName = adminType.type_name;
            }
            return adminInfo;
        }

        /// <summary>
        /// 获取所有管理员类型
        /// </summary>
        /// <returns></returns>
        public List<AdminType> GetAllAdminTypes()
        {
            var listAdminTypes = base.Change<AdminType>().GetList(a => a.delete_mk != 1);
            return listAdminTypes;
        }

        /// <summary>
        /// 更新管理员账户
        /// </summary>
        /// <param name="admins"></param>
        /// <returns></returns>
        public bool UpdAccount(Admin admins)
        {
            admins.DeleteMk = admins.DeleteMk == 0 ? 1 : 0;
            return base.Update(a => new Admin()
            {
                DeleteMk = admins.DeleteMk
            },a => a.Id == admins.Id);
        }


    }
}
