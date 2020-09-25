ALTER TABLE [dbo].[SPEND] DROP CONSTRAINT [FK__SPEND__CustoNo__00DF2177]
GO
ALTER TABLE [dbo].[WTINFO] DROP CONSTRAINT [FK__WTINFO__RoomNo__078C1F06]
GO
ALTER TABLE [dbo].[WTINFO] DROP CONSTRAINT [FK__WTINFO__CustoNo__0880433F]
GO

ALTER TABLE [dbo].[USERTYPE] DROP CONSTRAINT [UQ__USERTYPE__D4E7DFA80D7A0286]
GO

ALTER TABLE [dbo].[CUSTOSPEND] DROP CONSTRAINT [CK_CUSTOSPEND_MoneyState]
GO
ALTER TABLE [dbo].[USERINFO] DROP CONSTRAINT [CK__UESRINFO__CustoS__09A971A2]
GO
ALTER TABLE [dbo].[USERINFO] DROP CONSTRAINT [CK__UESRINFO__CustoI__0A9D95DB]
GO
ALTER TABLE [dbo].[USERINFO] DROP CONSTRAINT [CK_USERINFO_CustoType]
GO
ALTER TABLE [dbo].[WORKERINFO] DROP CONSTRAINT [CK__WORKERINF__Worke__27F8EE98]
GO
ALTER TABLE [dbo].[WORKERINFO] DROP CONSTRAINT [CK__WORKERINF__Worke__28ED12D1]
GO

ALTER TABLE [dbo].[BACKINFO] DROP CONSTRAINT [PK__BACKINFO__5E59BC880B5CAFEA]
GO
ALTER TABLE [dbo].[CASHINFO] DROP CONSTRAINT [PK__CASHINFO__6B80D1413552E9B6]
GO
ALTER TABLE [dbo].[CHECKINFO] DROP CONSTRAINT [PK__CHECKINF__86812FD516CE6296]
GO
ALTER TABLE [dbo].[MONEYINFO] DROP CONSTRAINT [PK__MONEYINF__C5FC882D12FDD1B2]
GO
ALTER TABLE [dbo].[ROOM] DROP CONSTRAINT [PK__ROOM__328651AA395884C4]
GO
ALTER TABLE [dbo].[SELLTHING] DROP CONSTRAINT [PK__SELLTHIN__B3509E74731B1205]
GO
ALTER TABLE [dbo].[UPLOADINFO] DROP CONSTRAINT [PK__UPLOADIN__CE83E30A318258D2]
GO
ALTER TABLE [dbo].[USERINFO] DROP CONSTRAINT [PK__UESRINFO__7FA8BFA507C12930]
GO
ALTER TABLE [dbo].[WORKERINFO] DROP CONSTRAINT [PK__WORKERIN__077F569D2610A626]
GO

DROP TABLE [dbo].[ADMININFO]
GO
DROP TABLE [dbo].[BACKINFO]
GO
DROP TABLE [dbo].[baseversion]
GO
DROP TABLE [dbo].[CARDCODES]
GO
DROP TABLE [dbo].[CARDINFO]
GO
DROP TABLE [dbo].[CASHINFO]
GO
DROP TABLE [dbo].[CHECKINFO]
GO
DROP TABLE [dbo].[CUSTOSPEND]
GO
DROP TABLE [dbo].[Fonts]
GO
DROP TABLE [dbo].[GBType]
GO
DROP TABLE [dbo].[MONEYINFO]
GO
DROP TABLE [dbo].[OperationLog]
GO
DROP TABLE [dbo].[PASSPORTTYPE]
GO
DROP TABLE [dbo].[RESER]
GO
DROP TABLE [dbo].[ROOM]
GO
DROP TABLE [dbo].[ROOMSTATE]
GO
DROP TABLE [dbo].[ROOMTYPE]
GO
DROP TABLE [dbo].[SELLTHING]
GO
DROP TABLE [dbo].[SPEND]
GO
DROP TABLE [dbo].[SPENDTYPE]
GO
DROP TABLE [dbo].[UPLOADINFO]
GO
DROP TABLE [dbo].[USERINFO]
GO
DROP TABLE [dbo].[USERTYPE]
GO
DROP TABLE [dbo].[WORKERCHECK]
GO
DROP TABLE [dbo].[WorkerGoodBad]
GO
DROP TABLE [dbo].[WORKERHISTORY]
GO
DROP TABLE [dbo].[WORKERINFO]
GO
DROP TABLE [dbo].[WTINFO]
GO

CREATE TABLE [dbo].[ADMININFO] (
  [AdminPassword] varchar(12)   NOT NULL,
  [AdminType] varchar(15)   NOT NULL,
  [AdminName] varchar(50)   NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[ADMININFO] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[BACKINFO] (
  [BackNo] varchar(20)   NOT NULL,
  [BackName] varchar(20)   NOT NULL,
  [BackSource] varchar(18)   NOT NULL,
  [BackCash] decimal(6,2)  NOT NULL,
  [BackType] int  NOT NULL,
  [BackPerson] varchar(8)   NOT NULL,
  [ControlClub] varchar(12)   NOT NULL,
  [BackClub] varchar(12)   NOT NULL,
  CONSTRAINT [PK__BACKINFO__5E59BC880B5CAFEA] PRIMARY KEY CLUSTERED ([BackNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[BACKINFO] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[baseversion] (
  [base_version] varchar(50)   NOT NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[baseversion] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[CARDCODES] (
  [id] bigint  NULL,
  [Province] nvarchar(255)   NULL,
  [City] nvarchar(255)   NULL,
  [District] nvarchar(255)   NULL,
  [bm] nvarchar(255)   NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[CARDCODES] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[CARDINFO] (
  [CardID] varchar(11)   NOT NULL,
  [CardName] varchar(20)   NOT NULL,
  [CustoNo] varchar(10)   NOT NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[CARDINFO] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[CASHINFO] (
  [CashNo] varchar(12)   NOT NULL,
  [CashName] varchar(300)   NOT NULL,
  [CashPrice] varchar(400)   NOT NULL,
  [CashClub] varchar(800)   NOT NULL,
  [CashTime] datetime  NOT NULL,
  [CashSource] varchar(200)   NOT NULL,
  [CashPerson] varchar(800)   NOT NULL,
  CONSTRAINT [PK__CASHINFO__6B80D1413552E9B6] PRIMARY KEY CLUSTERED ([CashNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[CASHINFO] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[CHECKINFO] (
  [CheckNo] varchar(10)   NOT NULL,
  [CheckClub] varchar(12)   NOT NULL,
  [CheckProgres] varchar(250)   NOT NULL,
  [CheckCash] varchar(250)   NOT NULL,
  [CheckScore] int  NOT NULL,
  [CheckPerson] varchar(8)   NOT NULL,
  [CheckAdvice] varchar(45)   NOT NULL,
  CONSTRAINT [PK__CHECKINF__86812FD516CE6296] PRIMARY KEY CLUSTERED ([CheckNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHECKINFO] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[CUSTOSPEND] (
  [RoomNo] varchar(8)   NOT NULL,
  [CustoNo] varchar(15)   NOT NULL,
  [SpendName] varchar(25)   NOT NULL,
  [SpendAmount] int  NOT NULL,
  [SpendPrice] decimal(10,2)  NOT NULL,
  [SpendMoney] decimal(10,2)  NOT NULL,
  [SpendTime] datetime  NOT NULL,
  [MoneyState] varchar(9)  DEFAULT ('未结算') NOT NULL,
  CONSTRAINT [CK_CUSTOSPEND_MoneyState] CHECK ([MoneyState]='已结算' OR [MoneyState]='未结算')
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[CUSTOSPEND] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[Fonts] (
  [FontsId] int  IDENTITY(1,1) NOT NULL,
  [FontsMess] varchar(250)   NOT NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[Fonts] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[GBType] (
  [GBType] int  NULL,
  [GBName] varchar(255)   NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[GBType] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[MONEYINFO] (
  [MoneyNo] varchar(10)   NOT NULL,
  [MoneyType] int  NOT NULL,
  [MoneyIn] decimal(10,2)  NOT NULL,
  [MoneyOut] decimal(10,2)  NOT NULL,
  [MoneyCheck] varchar(8)   NOT NULL,
  [MoneyPerson] varchar(8)   NOT NULL,
  [Remarks] varchar(255)   NULL,
  CONSTRAINT [PK__MONEYINF__C5FC882D12FDD1B2] PRIMARY KEY CLUSTERED ([MoneyNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[MONEYINFO] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[OperationLog] (
  [OperationTime] datetime  NOT NULL,
  [OperationLog] varchar(8000)   NOT NULL,
  [OperationAccount] varchar(300)   NOT NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[OperationLog] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[PASSPORTTYPE] (
  [PassportId] int  NOT NULL,
  [PassportName] varchar(20)   NOT NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[PASSPORTTYPE] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[RESER] (
  [ReserId] varchar(16)   NULL,
  [CustoName] varchar(8)   NULL,
  [CustoTel] varchar(11)   NULL,
  [ReserWay] varchar(10)   NULL,
  [ReserRoom] varchar(255)   NULL,
  [ReserDate] date  NULL,
  [ReserEndDate] date  NULL,
  [ReserRemark] varchar(255)   NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[RESER] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[ROOM] (
  [RoomNo] varchar(8)   NOT NULL,
  [RoomType] int DEFAULT ((1)) NOT NULL,
  [CustoNo] varchar(15)   NULL,
  [CheckTime] datetime  NULL,
  [CheckOutTime] datetime  NULL,
  [RoomStateId] int DEFAULT ((0)) NOT NULL,
  [RoomMoney] decimal(10,2) DEFAULT ((300.00)) NULL,
  [PersonNum] varchar(3)   NULL,
  [RoomPosition] varchar(6)   NOT NULL,
  CONSTRAINT [PK__ROOM__328651AA395884C4] PRIMARY KEY CLUSTERED ([RoomNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[ROOM] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[ROOMSTATE] (
  [RoomStateId] int DEFAULT ((0)) NOT NULL,
  [RoomState] varchar(8)   NOT NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[ROOMSTATE] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[ROOMTYPE] (
  [RoomType] int  NOT NULL,
  [RoomName] varchar(10)   NOT NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[ROOMTYPE] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[SELLTHING] (
  [SellNo] varchar(10)   NOT NULL,
  [SellName] varchar(20)   NOT NULL,
  [SellPrice] decimal(10,2)  NOT NULL,
  [format] varchar(20)   NULL,
  [Stock] int  NOT NULL,
  CONSTRAINT [PK__SELLTHIN__B3509E74731B1205] PRIMARY KEY CLUSTERED ([SellNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[SELLTHING] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[SPEND] (
  [CustoNo] varchar(15)   NOT NULL,
  [SpendDate] datetime  NOT NULL,
  [SpendMoney] decimal(6,2)  NOT NULL,
  [SpendType] int  NOT NULL,
  [SpendMess] varchar(255)   NOT NULL,
  [Lender] varchar(12)  DEFAULT ('admin') NULL,
  [Reamrks] varchar(255)   NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[SPEND] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[SPENDTYPE] (
  [SpendType] int  NOT NULL,
  [TypeName] varchar(10)   NOT NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[SPENDTYPE] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[UPLOADINFO] (
  [NoticeNo] varchar(8)   NOT NULL,
  [Noticetheme] varchar(15)   NOT NULL,
  [NoticeTime] datetime  NOT NULL,
  [NoticeContent] varchar(800)   NOT NULL,
  [NoticeClub] varchar(25)   NOT NULL,
  [NoticePerson] varchar(20)   NOT NULL,
  CONSTRAINT [PK__UPLOADIN__CE83E30A318258D2] PRIMARY KEY CLUSTERED ([NoticeNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[UPLOADINFO] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[USERINFO] (
  [CustoNo] varchar(15)   NOT NULL,
  [CustoName] varchar(15)   NOT NULL,
  [CustoSex] varchar(4)   NOT NULL,
  [CustoTel] varchar(11)   NOT NULL,
  [PassportType] int  NOT NULL,
  [CustoID] varchar(19)   NOT NULL,
  [CustoAdress] varchar(30)   NULL,
  [CustoBirth] datetime  NOT NULL,
  [CustoType] int  NOT NULL,
  CONSTRAINT [PK__UESRINFO__7FA8BFA507C12930] PRIMARY KEY CLUSTERED ([CustoNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY],
  CONSTRAINT [CK__UESRINFO__CustoS__09A971A2] CHECK ([CustoSex]='男' OR [CustoSex]='女'),
  CONSTRAINT [CK__UESRINFO__CustoI__0A9D95DB] CHECK (datalength([CustoID])<=(19)),
  CONSTRAINT [CK_USERINFO_CustoType] CHECK ([CustoType]=(0) OR [CustoType]=(1) OR [CustoType]=(2) OR [CustoType]=(3))
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[USERINFO] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[USERTYPE] (
  [UserType] int  NOT NULL,
  [TypeName] varchar(10)   NOT NULL,
  CONSTRAINT [UQ__USERTYPE__D4E7DFA80D7A0286] UNIQUE NONCLUSTERED ([TypeName] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[USERTYPE] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[WORKERCHECK] (
  [WorkerNo] varchar(20)   NULL,
  [CheckTime] datetime  NULL,
  [CheckWay] varchar(80)   NULL,
  [CheckState] int  NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[WORKERCHECK] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[WorkerGoodBad] (
  [WorkNo] varchar(50)   NULL,
  [GBInfo] varchar(255)   NULL,
  [GBType] int  NULL,
  [GBOperation] varchar(200)   NULL,
  [GBTime] datetime  NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[WorkerGoodBad] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[WORKERHISTORY] (
  [WorkerId] varchar(12)   NOT NULL,
  [StartDate] datetime  NOT NULL,
  [EndDate] datetime  NOT NULL,
  [Position] varchar(255)   NOT NULL,
  [Company] varchar(255)   NOT NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[WORKERHISTORY] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[WORKERINFO] (
  [WorkerId] varchar(12)   NOT NULL,
  [WorkerName] varchar(50)   NOT NULL,
  [WorkerBirthday] datetime  NOT NULL,
  [WorkerSex] varchar(4)   NOT NULL,
  [WorkerTel] varchar(11)   NOT NULL,
  [WorkerClub] varchar(8)   NOT NULL,
  [WorkerAddress] varchar(45)   NOT NULL,
  [WorkerPosition] varchar(8)   NOT NULL,
  [CardID] varchar(18)   NOT NULL,
  [WorkerPwd] varchar(10)   NOT NULL,
  [WorkerTime] datetime  NOT NULL,
  [WorkerFace] varchar(4)   NOT NULL,
  [WorkerEducation] varchar(255)   NOT NULL,
  CONSTRAINT [PK__WORKERIN__077F569D2610A626] PRIMARY KEY CLUSTERED ([WorkerId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY],
  CONSTRAINT [CK__WORKERINF__Worke__27F8EE98] CHECK ([WorkerSex]='男' OR [WorkerSex]='女'),
  CONSTRAINT [CK__WORKERINF__Worke__28ED12D1] CHECK (datalength([CardID])<=(19))
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[WORKERINFO] SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE [dbo].[WTINFO] (
  [RoomNo] varchar(8)   NOT NULL,
  [UseDate] datetime  NOT NULL,
  [EndDate] datetime  NULL,
  [WaterUse] decimal(6,2)  NOT NULL,
  [PowerUse] decimal(6,2)  NOT NULL,
  [Record] varchar(8)   NOT NULL,
  [CustoNo] varchar(15)   NULL
)  
ON [PRIMARY]
GO
ALTER TABLE [dbo].[WTINFO] SET (LOCK_ESCALATION = TABLE)
GO

ALTER TABLE [dbo].[SPEND] ADD CONSTRAINT [FK__SPEND__CustoNo__00DF2177] FOREIGN KEY ([CustoNo]) REFERENCES [dbo].[USERINFO] ([CustoNo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[WTINFO] ADD CONSTRAINT [FK__WTINFO__RoomNo__078C1F06] FOREIGN KEY ([RoomNo]) REFERENCES [dbo].[ROOM] ([RoomNo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[WTINFO] ADD CONSTRAINT [FK__WTINFO__CustoNo__0880433F] FOREIGN KEY ([CustoNo]) REFERENCES [dbo].[USERINFO] ([CustoNo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

