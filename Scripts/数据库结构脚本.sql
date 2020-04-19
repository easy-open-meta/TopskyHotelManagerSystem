-- ----------------------------
-- Table structure for ADMININFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ADMININFO]') AND type IN ('U'))
	DROP TABLE [dbo].[ADMININFO]
GO

CREATE TABLE [dbo].[ADMININFO] (
  [AdminPassword] varchar(12) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [AdminType] varchar(15) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [AdminName] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[ADMININFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for BACKINFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BACKINFO]') AND type IN ('U'))
	DROP TABLE [dbo].[BACKINFO]
GO

CREATE TABLE [dbo].[BACKINFO] (
  [BackNo] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [BackName] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [BackSource] varchar(18) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [BackCash] decimal(6,2)  NOT NULL,
  [BackType] int  NOT NULL,
  [BackPerson] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ControlClub] varchar(12) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [BackClub] varchar(12) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[BACKINFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for baseversion
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[baseversion]') AND type IN ('U'))
	DROP TABLE [dbo].[baseversion]
GO

CREATE TABLE [dbo].[baseversion] (
  [base_version] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[baseversion] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for CARDCODES
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CARDCODES]') AND type IN ('U'))
	DROP TABLE [dbo].[CARDCODES]
GO

CREATE TABLE [dbo].[CARDCODES] (
  [id] bigint  NULL,
  [Province] nvarchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [City] nvarchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [District] nvarchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [bm] nvarchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[CARDCODES] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for CARDINFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CARDINFO]') AND type IN ('U'))
	DROP TABLE [dbo].[CARDINFO]
GO

CREATE TABLE [dbo].[CARDINFO] (
  [CardID] varchar(11) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CardName] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CustoNo] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[CARDINFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for CASHINFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CASHINFO]') AND type IN ('U'))
	DROP TABLE [dbo].[CASHINFO]
GO

CREATE TABLE [dbo].[CASHINFO] (
  [CashNo] varchar(12) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CashName] varchar(300) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CashPrice] varchar(400) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CashClub] varchar(800) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CashTime] datetime  NOT NULL,
  [CashSource] varchar(200) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CashPerson] varchar(800) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[CASHINFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for CHECKINFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CHECKINFO]') AND type IN ('U'))
	DROP TABLE [dbo].[CHECKINFO]
GO

CREATE TABLE [dbo].[CHECKINFO] (
  [CheckNo] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CheckClub] varchar(12) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CheckProgres] varchar(250) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CheckCash] varchar(250) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CheckScore] int  NOT NULL,
  [CheckPerson] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CheckAdvice] varchar(45) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[CHECKINFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for CUSTOSPEND
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CUSTOSPEND]') AND type IN ('U'))
	DROP TABLE [dbo].[CUSTOSPEND]
GO

CREATE TABLE [dbo].[CUSTOSPEND] (
  [RoomNo] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CustoNo] varchar(15) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [SpendName] varchar(25) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [SpendAmount] int  NOT NULL,
  [SpendPrice] decimal(10,2)  NOT NULL,
  [SpendMoney] decimal(10,2)  NOT NULL,
  [SpendTime] datetime  NOT NULL,
  [MoneyState] varchar(9) COLLATE Chinese_PRC_CI_AS DEFAULT ('未结算') NOT NULL
)
GO

ALTER TABLE [dbo].[CUSTOSPEND] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Fonts
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Fonts]') AND type IN ('U'))
	DROP TABLE [dbo].[Fonts]
GO

CREATE TABLE [dbo].[Fonts] (
  [FontsId] int  IDENTITY(1,1) NOT NULL,
  [FontsMess] varchar(250) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Fonts] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for MONEYINFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[MONEYINFO]') AND type IN ('U'))
	DROP TABLE [dbo].[MONEYINFO]
GO

CREATE TABLE [dbo].[MONEYINFO] (
  [MoneyNo] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [MoneyType] int  NOT NULL,
  [MoneyIn] decimal(10,2)  NOT NULL,
  [MoneyOut] decimal(10,2)  NOT NULL,
  [MoneyCheck] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [MoneyPerson] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Remarks] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[MONEYINFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for OperationLog
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[OperationLog]') AND type IN ('U'))
	DROP TABLE [dbo].[OperationLog]
GO

CREATE TABLE [dbo].[OperationLog] (
  [OperationTime] datetime  NOT NULL,
  [OperationLog] varchar(8000) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [OperationAccount] varchar(300) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[OperationLog] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for PASSPORTTYPE
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PASSPORTTYPE]') AND type IN ('U'))
	DROP TABLE [dbo].[PASSPORTTYPE]
GO

CREATE TABLE [dbo].[PASSPORTTYPE] (
  [PassportId] int  NOT NULL,
  [PassportName] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[PASSPORTTYPE] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for RESER
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RESER]') AND type IN ('U'))
	DROP TABLE [dbo].[RESER]
GO

CREATE TABLE [dbo].[RESER] (
  [ReserId] varchar(16) COLLATE Chinese_PRC_CI_AS  NULL,
  [CustoName] varchar(8) COLLATE Chinese_PRC_CI_AS  NULL,
  [CustoTel] varchar(11) COLLATE Chinese_PRC_CI_AS  NULL,
  [ReserWay] varchar(10) COLLATE Chinese_PRC_CI_AS  NULL,
  [ReserRoom] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [ReserDate] date  NULL,
  [ReserEndDate] date  NULL,
  [ReserRemark] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[RESER] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ROOM
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ROOM]') AND type IN ('U'))
	DROP TABLE [dbo].[ROOM]
GO

CREATE TABLE [dbo].[ROOM] (
  [RoomNo] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [RoomType] int DEFAULT ((1)) NOT NULL,
  [CustoNo] varchar(15) COLLATE Chinese_PRC_CI_AS  NULL,
  [CheckTime] datetime  NULL,
  [CheckOutTime] datetime  NULL,
  [RoomStateId] int DEFAULT ((0)) NOT NULL,
  [RoomMoney] decimal(10,2) DEFAULT ((300.00)) NULL,
  [PersonNum] varchar(3) COLLATE Chinese_PRC_CI_AS  NULL,
  [RoomPosition] varchar(6) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[ROOM] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ROOMSTATE
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ROOMSTATE]') AND type IN ('U'))
	DROP TABLE [dbo].[ROOMSTATE]
GO

CREATE TABLE [dbo].[ROOMSTATE] (
  [RoomStateId] int DEFAULT ((0)) NOT NULL,
  [RoomState] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[ROOMSTATE] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ROOMTYPE
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ROOMTYPE]') AND type IN ('U'))
	DROP TABLE [dbo].[ROOMTYPE]
GO

CREATE TABLE [dbo].[ROOMTYPE] (
  [RoomType] int  NOT NULL,
  [RoomName] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[ROOMTYPE] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for SELLTHING
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SELLTHING]') AND type IN ('U'))
	DROP TABLE [dbo].[SELLTHING]
GO

CREATE TABLE [dbo].[SELLTHING] (
  [SellNo] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [SellName] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [SellPrice] decimal(10,2)  NOT NULL,
  [format] varchar(20) COLLATE Chinese_PRC_CI_AS  NULL,
  [Stock] int  NOT NULL
)
GO

ALTER TABLE [dbo].[SELLTHING] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for SPEND
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SPEND]') AND type IN ('U'))
	DROP TABLE [dbo].[SPEND]
GO

CREATE TABLE [dbo].[SPEND] (
  [CustoNo] varchar(15) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [SpendDate] datetime  NOT NULL,
  [SpendMoney] decimal(6,2)  NOT NULL,
  [SpendType] int  NOT NULL,
  [SpendMess] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Lender] varchar(12) COLLATE Chinese_PRC_CI_AS DEFAULT ('admin') NULL,
  [Reamrks] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[SPEND] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for SPENDTYPE
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SPENDTYPE]') AND type IN ('U'))
	DROP TABLE [dbo].[SPENDTYPE]
GO

CREATE TABLE [dbo].[SPENDTYPE] (
  [SpendType] int  NOT NULL,
  [TypeName] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[SPENDTYPE] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for UPLOADINFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UPLOADINFO]') AND type IN ('U'))
	DROP TABLE [dbo].[UPLOADINFO]
GO

CREATE TABLE [dbo].[UPLOADINFO] (
  [NoticeNo] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Noticetheme] varchar(15) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [NoticeTime] datetime  NOT NULL,
  [NoticeContent] varchar(800) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [NoticeClub] varchar(25) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [NoticePerson] varchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[UPLOADINFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for USERINFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[USERINFO]') AND type IN ('U'))
	DROP TABLE [dbo].[USERINFO]
GO

CREATE TABLE [dbo].[USERINFO] (
  [CustoNo] varchar(15) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CustoName] varchar(15) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CustoSex] varchar(4) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CustoTel] varchar(11) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [PassportType] int  NOT NULL,
  [CustoID] varchar(19) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CustoAdress] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [CustoBirth] datetime  NOT NULL,
  [CustoType] int  NOT NULL
)
GO

ALTER TABLE [dbo].[USERINFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for USERTYPE
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[USERTYPE]') AND type IN ('U'))
	DROP TABLE [dbo].[USERTYPE]
GO

CREATE TABLE [dbo].[USERTYPE] (
  [UserType] int  NOT NULL,
  [TypeName] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[USERTYPE] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for WORKERHISTORY
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[WORKERHISTORY]') AND type IN ('U'))
	DROP TABLE [dbo].[WORKERHISTORY]
GO

CREATE TABLE [dbo].[WORKERHISTORY] (
  [WorkerId] varchar(12) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [StartDate] datetime  NOT NULL,
  [EndDate] datetime  NOT NULL,
  [Position] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Company] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[WORKERHISTORY] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for WORKERINFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[WORKERINFO]') AND type IN ('U'))
	DROP TABLE [dbo].[WORKERINFO]
GO

CREATE TABLE [dbo].[WORKERINFO] (
  [WorkerId] varchar(12) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WorkerName] varchar(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WorkerBirthday] datetime  NOT NULL,
  [WorkerSex] varchar(4) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WorkerTel] varchar(11) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WorkerClub] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WorkerAddress] varchar(45) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WorkerPosition] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CardID] varchar(18) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WorkerPwd] varchar(10) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WorkerTime] datetime  NOT NULL,
  [WorkerFace] varchar(4) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WorkerEducation] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[WORKERINFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for WTINFO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[WTINFO]') AND type IN ('U'))
	DROP TABLE [dbo].[WTINFO]
GO

CREATE TABLE [dbo].[WTINFO] (
  [RoomNo] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [UseDate] datetime  NOT NULL,
  [EndDate] datetime  NULL,
  [WaterUse] decimal(6,2)  NOT NULL,
  [PowerUse] decimal(6,2)  NOT NULL,
  [Record] varchar(8) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CustoNo] varchar(15) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[WTINFO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Primary Key structure for table BACKINFO
-- ----------------------------
ALTER TABLE [dbo].[BACKINFO] ADD CONSTRAINT [PK__BACKINFO__5E59BC880B5CAFEA] PRIMARY KEY CLUSTERED ([BackNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table CASHINFO
-- ----------------------------
ALTER TABLE [dbo].[CASHINFO] ADD CONSTRAINT [PK__CASHINFO__6B80D1413552E9B6] PRIMARY KEY CLUSTERED ([CashNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table CHECKINFO
-- ----------------------------
ALTER TABLE [dbo].[CHECKINFO] ADD CONSTRAINT [PK__CHECKINF__86812FD516CE6296] PRIMARY KEY CLUSTERED ([CheckNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Checks structure for table CUSTOSPEND
-- ----------------------------
ALTER TABLE [dbo].[CUSTOSPEND] ADD CONSTRAINT [CK_CUSTOSPEND_MoneyState] CHECK ([MoneyState]='已结算' OR [MoneyState]='未结算')
GO


-- ----------------------------
-- Primary Key structure for table MONEYINFO
-- ----------------------------
ALTER TABLE [dbo].[MONEYINFO] ADD CONSTRAINT [PK__MONEYINF__C5FC882D12FDD1B2] PRIMARY KEY CLUSTERED ([MoneyNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ROOM
-- ----------------------------
ALTER TABLE [dbo].[ROOM] ADD CONSTRAINT [PK__ROOM__328651AA395884C4] PRIMARY KEY CLUSTERED ([RoomNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table SELLTHING
-- ----------------------------
ALTER TABLE [dbo].[SELLTHING] ADD CONSTRAINT [PK__SELLTHIN__B3509E74731B1205] PRIMARY KEY CLUSTERED ([SellNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table UPLOADINFO
-- ----------------------------
ALTER TABLE [dbo].[UPLOADINFO] ADD CONSTRAINT [PK__UPLOADIN__CE83E30A318258D2] PRIMARY KEY CLUSTERED ([NoticeNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Checks structure for table USERINFO
-- ----------------------------
ALTER TABLE [dbo].[USERINFO] ADD CONSTRAINT [CK__UESRINFO__CustoS__09A971A2] CHECK ([CustoSex]='男' OR [CustoSex]='女')
GO

ALTER TABLE [dbo].[USERINFO] ADD CONSTRAINT [CK__UESRINFO__CustoI__0A9D95DB] CHECK (datalength([CustoID])<=(19))
GO

ALTER TABLE [dbo].[USERINFO] ADD CONSTRAINT [CK_USERINFO_CustoType] CHECK ([CustoType]=(0) OR [CustoType]=(1) OR [CustoType]=(2) OR [CustoType]=(3))
GO


-- ----------------------------
-- Primary Key structure for table USERINFO
-- ----------------------------
ALTER TABLE [dbo].[USERINFO] ADD CONSTRAINT [PK__UESRINFO__7FA8BFA507C12930] PRIMARY KEY CLUSTERED ([CustoNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table USERTYPE
-- ----------------------------
ALTER TABLE [dbo].[USERTYPE] ADD CONSTRAINT [UQ__USERTYPE__D4E7DFA80D7A0286] UNIQUE NONCLUSTERED ([TypeName] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Checks structure for table WORKERINFO
-- ----------------------------
ALTER TABLE [dbo].[WORKERINFO] ADD CONSTRAINT [CK__WORKERINF__Worke__27F8EE98] CHECK ([WorkerSex]='男' OR [WorkerSex]='女')
GO

ALTER TABLE [dbo].[WORKERINFO] ADD CONSTRAINT [CK__WORKERINF__Worke__28ED12D1] CHECK (datalength([CardID])<=(19))
GO


-- ----------------------------
-- Primary Key structure for table WORKERINFO
-- ----------------------------
ALTER TABLE [dbo].[WORKERINFO] ADD CONSTRAINT [PK__WORKERIN__077F569D2610A626] PRIMARY KEY CLUSTERED ([WorkerId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table SPEND
-- ----------------------------
ALTER TABLE [dbo].[SPEND] ADD CONSTRAINT [FK__SPEND__CustoNo__00DF2177] FOREIGN KEY ([CustoNo]) REFERENCES [dbo].[USERINFO] ([CustoNo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table WTINFO
-- ----------------------------
ALTER TABLE [dbo].[WTINFO] ADD CONSTRAINT [FK__WTINFO__RoomNo__078C1F06] FOREIGN KEY ([RoomNo]) REFERENCES [dbo].[ROOM] ([RoomNo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[WTINFO] ADD CONSTRAINT [FK__WTINFO__CustoNo__0880433F] FOREIGN KEY ([CustoNo]) REFERENCES [dbo].[USERINFO] ([CustoNo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

