<h1 align="center"><img src="https://foruda.gitee.com/avatar/1677165732744604624/7158691_java-and-net_1677165732.png!avatar100" alt="Organization Logo.png" /></h1>
<h1 align="center">TopskyHotelManagerSystem</h1>
<p align="center">
	<a href='https://gitee.com/java-and-net/TopskyHotelManagerSystem/stargazers'><img src='https://gitee.com/java-and-net/TopskyHotelManagerSystem/badge/star.svg?theme=white' alt='star'></img></a>
        <a href='https://gitee.com/java-and-net/TopskyHotelManagerSystem/members'><img src='https://gitee.com/java-and-net/TopskyHotelManagerSystem/badge/fork.svg?theme=white' alt='fork'></img></a>
        <a href='https://img.shields.io/badge/license-MIT-000000.svg'><img src="https://img.shields.io/badge/license-MIT-000000.svg" alt=""></img></a>
        <a href='https://img.shields.io/badge/language-C#-red.svg'><img src="https://img.shields.io/badge/language-CSharp-red.svg" alt=""></img></a>
</p>
<div align="center">
	<p>中文文档 | <a href="./README.en.md">English Document</a></p>
</div>



#  :exclamation: 重要说明：

 **注意：目前master分支随v2.x版本变动而变动，v2.x版本与v1.x版本变动极大，因此想要v1.x版本的可移步至v1.x分支地址** ： https://gitee.com/java-and-net/TopskyHotelManagerSystem/tree/v1.x/ 

 **即日起，程序版本号规范将固定为x.x.x.x，第一位为当前程序版本，第二位为当前程序框架版本，第三位为功能大变更版本，第四位为日常修复版本，例如：基于.NET 8框架的2.0版本，对应的版本号是2.8.0.0，往后的.NET 9将会是2.9.0.0，并以此类推**

#  :pray: 引用的开源项目：

1. ##### Fody——将所有dll打包成exe应用程序。[Fody,MIT开源协议](https://github.com/Fody/Fody)      

2. ##### SQLSugar，国内最受欢迎ORM框架[SQLSugar。 [Apache-2.0开源协议](https://gitee.com/dotnetchina/SqlSugar) 

3. ##### SunnyUI——SunnyUI.Net, 基于 C# .Net WinForm 开源控件库、工具类库、扩展类库、多页面开发框架。[SunnyUI.Net,GPL3.0开源协议](https://gitee.com/yhuse/SunnyUI)

4. ##### RestSharp——Simple REST and HTTP API Client for .NET。[RestSharp,Apache-2.0开源协议](https://github.com/restsharp/RestSharp)

5. ##### AntdUI——👚 基于 Ant Design 设计语言的 Winform 界面库。[AntdUI,Apache-2.0开源协议](https://gitee.com/antdui/AntdUI)

#  :exclamation: 本项目说明：

1、在对本项目进行二次开发时，请遵循 MIT 开源协议。所有引用的其他开源项目均采用其各自的开源协议。使用这些开源项目时，请务必在项目介绍中添加相应的声明，并按照各自的开源协议进行开源等操作。

2、有bug欢迎提出issue！或进行评论

3、本系统UI框架主要基于Sunny.UI和AntdUI进行创建，在此特别声明！

4、关于数据库脚本问题，请先移步至数据库脚本文件夹下，选择Mysql版本或PostgreSQL版本任意文件夹下载Data和Table两个文件，再数据库中先执行Table.sql，再执行Data.sql!

5、针对MySQL和PostgreSQL数据库的说明：

		5.1、本地数据库若为MySQL，请拉取[MySQL专用分支](https://gitee.com/java-and-net/topsky-hotel-manager-system-web-api/tree/MySQL_Version/)。
	
		5.2、本地数据库若为PostgreSQL，则无需进行任何改动，只需要在Common层对HttpHelper里的pgsqlString常量数据库连接字符串进行配置。

#  :thought_balloon: 开发目的：

在现如今发展迅速的酒店行业，随着酒店的日常工作增加，已经很难用人工去进行处理，一些繁琐的数据也可能会因为人工的失误而造成酒店的一些损失，因此很需要一款可以协助酒店进行内部管理的管理软件。

#  :mag_right: 系统开发环境：

操作系统：Windows 11(x64)

开发工具：Microsoft Visual Studio 2022(系统最新版本)

数据库：PostgreSql16(强烈推荐！)

数据库管理工具：Dbgate

开发语言：C#语言、T-SQL语言

开发平台：.Net

开发框架：.Net 8

开发技术：.NET 8 WinForm

#  :open_file_folder: 系统结构：
```tree
EOM.Client.TopSkyHotelManagerSystem
├─ .git
├─ .gitignore
├─ EOM.Client.TopSkyHotelManagerSystem.sln
├─ FodyWeavers.xml
├─ LICENSE
├─ README.md
├─ EOM.TSHotelManager.Common
├─ EOM.TSHotelManager.Common.Core
├─ EOM.TSHotelManager.FormUI
│    ├─ .gitignore
│    ├─ App.config
│    ├─ AppFunction
│    ├─ AppInterface
│    ├─ AppMain
│    ├─ AppUserControls
│    ├─ FodyWeavers.xml
│    ├─ FodyWeavers.xsd
│    ├─ Logo
│    ├─ Program.cs
│    ├─ Properties
│    ├─ Resources
├─ SYS.Library
├─ 数据库脚本
├─ 项目效果图
└─ 项目相关文档
```

#  :chart_with_upwards_trend: 系统数据库关系图(由PDMAN软件生成) :loudspeaker: 
[数据库关系图](https://oscode.top/project/tshotel/db_design.html)

#  :books: 系统功能模块汇总：

| 功能汇总       |              |              |               |              |              |              |
| -------------- | ------------ | ------------ | ------------- | ------------ | ------------ | ------------ |
| (前台)客房管理 | 预约房间     | 入住房间     | 结算退房      | 转换房间     | 查看用户信息 | 修改房间状态 |
| (前台)用户管理 | 用户信息展示 | 搜索用户信息 | 添加客户      |              |              |              |
| (前台)商品消费 | 商品列表     | 搜索商品信息 | 商品消费      | 消费信息     |              |              |
| (前台)扩展功能 | 无           |              |               |              |              |              |
| (后台)基础信息 | 职位类型维护 | 民族类型维护 | 学历类型维护  | 部门信息维护 |              |              |
| (后台)财务信息 | 员工工资账单 | 内部财务账单 | 酒店盈利情况  |              |              |              |
| (后台)水电管理 | 水电信息     |              |               |              |              |              |
| (后台)监管统计 | 监管部门情况 |              |               |              |              |              |
| (后台)客房管理 | 房态图一览   | 新增客房     |               |              |              |              |
| (后台)客户管理 | 客户信息管理 | 顾客消费账单 |               |              |              |              |
| 功能汇总(续)   |              |              |               |              |              |              |
| (后台)人事管理 | 员工管理     | 公告日志     | 上传公告日志  |              |              |              |
| (后台)物资管理 | 商品管理     | 仓库物资     |               |              |              |              |
| 员工操作日志   |              |              |               |              |              |              |
| 系统管理       | 添加管理员   | 权限分配     | 启/禁用管理员 |              |              |              |


#  :family: 项目作者：

**原创团队：Jackson、Benjamin、Bin、Jonathan**

**后期维护团队：易开元(Easy Open Meta)**

#  :computer: 项目运行部署：

**下载并安装.NET 8及以上SDK版本。**
**下载并安装Microsoft Visual Studio Professional 2022及以上版本，并通过下载Zip包解压，打开.sln后缀格式文件运行。**

#  :inbox_tray: 数据库运行部署(本地)：

**作者及开发团队强烈建议使用PostgreSQL数据库，安装PostgreSQL数据库并开启服务，通过可视化管理工具对数据库进行建立，可通过打开执行数据库脚本文件夹内的.sql后缀格式文件进行快速建立数据表和导入数据，执行步骤(以PostgreSQL数据库为例)：**

**1、通过可视化管理工具链接PostgreSQL数据库，随后新建名为‘tshoteldb’数据库。**

**2、通过可视化管理工具打开：数据库脚本\PostgreSQL版本文件\db_file.sql进行数据表建立和数据导入。**

[![java-and-net/TopskyHotelManagerSystem](https://gitee.com/java-and-net/TopskyHotelManagerSystem/widgets/widget_card.svg?colors=4183c4,ffffff,ffffff,e3e9ed,666666,9b9b9b)](https://gitee.com/java-and-net/TopskyHotelManagerSystem)