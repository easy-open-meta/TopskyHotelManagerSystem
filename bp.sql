USE [TSHotelDB]
GO
/****** Object:  Table [dbo].[SELLTHING]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SELLTHING](
	[SellNo] [varchar](10) NOT NULL,
	[SellName] [varchar](20) NOT NULL,
	[SellPrice] [decimal](10, 2) NOT NULL,
	[format] [varchar](20) NULL,
	[Stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SellNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROOMTYPE]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ROOMTYPE](
	[RoomType] [int] NOT NULL,
	[RoomName] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROOMSTATE]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ROOMSTATE](
	[RoomStateId] [int] NOT NULL,
	[RoomState] [varchar](8) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RESER]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RESER](
	[ReserId] [varchar](16) NOT NULL,
	[CustoName] [varchar](8) NOT NULL,
	[CustoTel] [varchar](11) NOT NULL,
	[ReserWay] [varchar](10) NOT NULL,
	[ReserRoom] [int] NOT NULL,
	[ReserCash] [decimal](5, 2) NULL,
	[ReserDate] [datetime] NOT NULL,
	[ReserPerson] [int] NOT NULL,
	[ReserRemark] [varchar](255) NULL,
 CONSTRAINT [PK__RESER__78A3145F2CF2ADDF] PRIMARY KEY CLUSTERED 
(
	[ReserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PASSPORTTYPE]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PASSPORTTYPE](
	[PassportId] [int] NOT NULL,
	[PassportName] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OperationLog]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OperationLog](
	[OperationTime] [datetime] NOT NULL,
	[OperationLog] [varchar](100) NOT NULL,
	[OperationAccount] [varchar](30) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONEYINFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONEYINFO](
	[MoneyNo] [varchar](10) NOT NULL,
	[MoneyType] [int] NOT NULL,
	[MoneyIn] [decimal](10, 2) NOT NULL,
	[MoneyOut] [decimal](10, 2) NOT NULL,
	[MoneyCheck] [varchar](8) NOT NULL,
	[MoneyPerson] [varchar](8) NOT NULL,
	[Remarks] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MoneyNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fonts]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fonts](
	[FontsId] [int] IDENTITY(1,1) NOT NULL,
	[FontsMess] [varchar](250) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOSPEND]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOSPEND](
	[RoomNo] [varchar](8) NOT NULL,
	[CustoNo] [varchar](15) NOT NULL,
	[SpendName] [varchar](25) NOT NULL,
	[SpendAmount] [int] NOT NULL,
	[SpendPrice] [decimal](10, 2) NOT NULL,
	[SpendMoney] [decimal](10, 2) NOT NULL,
	[SpendTime] [datetime] NOT NULL,
	[MoneyState] [varchar](9) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHECKINFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHECKINFO](
	[CheckNo] [varchar](10) NOT NULL,
	[CheckClub] [varchar](12) NOT NULL,
	[CheckProgres] [varchar](250) NOT NULL,
	[CheckCash] [varchar](250) NOT NULL,
	[CheckScore] [int] NOT NULL,
	[CheckPerson] [varchar](8) NOT NULL,
	[CheckAdvice] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CheckNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CASHINFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CASHINFO](
	[CashNo] [varchar](12) NOT NULL,
	[CashName] [varchar](30) NOT NULL,
	[CashPrice] [varchar](4) NOT NULL,
	[CashClub] [varchar](8) NOT NULL,
	[CashTime] [datetime] NOT NULL,
	[CashSource] [varchar](20) NOT NULL,
	[CashPerson] [varchar](8) NOT NULL,
 CONSTRAINT [PK__CASHINFO__6B80D1413552E9B6] PRIMARY KEY CLUSTERED 
(
	[CashNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CARDINFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CARDINFO](
	[CardID] [varchar](11) NOT NULL,
	[CardName] [varchar](20) NOT NULL,
	[CustoNo] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BACKINFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BACKINFO](
	[BackNo] [varchar](20) NOT NULL,
	[BackName] [varchar](20) NOT NULL,
	[BackSource] [varchar](18) NOT NULL,
	[BackCash] [decimal](6, 2) NOT NULL,
	[BackType] [int] NOT NULL,
	[BackPerson] [varchar](8) NOT NULL,
	[ControlClub] [varchar](12) NOT NULL,
	[BackClub] [varchar](12) NOT NULL,
 CONSTRAINT [PK__BACKINFO__5E59BC880B5CAFEA] PRIMARY KEY CLUSTERED 
(
	[BackNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ADMININFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADMININFO](
	[AdminPassword] [varchar](12) NOT NULL,
	[AdminType] [varchar](15) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WORKERINFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WORKERINFO](
	[WorkerId] [varchar](12) NOT NULL,
	[WorkerName] [varchar](50) NOT NULL,
	[WorkerBirthday] [datetime] NOT NULL,
	[WorkerSex] [varchar](4) NOT NULL,
	[WorkerTel] [varchar](11) NOT NULL,
	[WorkerClub] [varchar](8) NOT NULL,
	[WorkerAddress] [varchar](45) NOT NULL,
	[WorkerPosition] [varchar](8) NOT NULL,
	[CardID] [varchar](18) NOT NULL,
	[WorkerPwd] [varchar](10) NOT NULL,
	[WorkerTime] [datetime] NOT NULL,
	[WorkerFace] [varchar](4) NULL,
 CONSTRAINT [PK__WORKERIN__077F569D2610A626] PRIMARY KEY CLUSTERED 
(
	[WorkerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USERTYPE]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERTYPE](
	[UserType] [int] NOT NULL,
	[TypeName] [varchar](10) NOT NULL,
UNIQUE NONCLUSTERED 
(
	[TypeName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USERINFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERINFO](
	[CustoNo] [varchar](15) NOT NULL,
	[CustoName] [varchar](15) NOT NULL,
	[CustoSex] [varchar](4) NOT NULL,
	[CustoTel] [varchar](11) NOT NULL,
	[PassportType] [int] NOT NULL,
	[CustoID] [varchar](19) NOT NULL,
	[CustoAdress] [varchar](30) NULL,
	[CustoBirth] [datetime] NOT NULL,
	[CustoType] [int] NOT NULL,
 CONSTRAINT [PK__UESRINFO__7FA8BFA507C12930] PRIMARY KEY CLUSTERED 
(
	[CustoNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UPLOADINFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UPLOADINFO](
	[NoticeNo] [varchar](8) NOT NULL,
	[Noticetheme] [varchar](15) NOT NULL,
	[NoticeTime] [datetime] NOT NULL,
	[NoticeContent] [varchar](800) NOT NULL,
	[NoticeClub] [varchar](25) NOT NULL,
	[NoticePerson] [varchar](20) NOT NULL,
 CONSTRAINT [PK__UPLOADIN__CE83E30A318258D2] PRIMARY KEY CLUSTERED 
(
	[NoticeNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPENDTYPE]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPENDTYPE](
	[SpendType] [int] NOT NULL,
	[TypeName] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPEND]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPEND](
	[CustoNo] [varchar](15) NOT NULL,
	[SpendDate] [datetime] NOT NULL,
	[SpendMoney] [decimal](6, 2) NOT NULL,
	[SpendType] [int] NOT NULL,
	[SpendMess] [varchar](255) NOT NULL,
	[Lender] [varchar](12) NULL,
	[Reamrks] [varchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROOM]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ROOM](
	[RoomNo] [varchar](8) NOT NULL,
	[RoomType] [int] NOT NULL,
	[CustoNo] [varchar](15) NULL,
	[CheckTime] [datetime] NULL,
	[CheckOutTime] [datetime] NULL,
	[RoomStateId] [int] NOT NULL,
	[RoomMoney] [decimal](10, 2) NULL,
	[PersonNum] [varchar](3) NULL,
	[RoomPosition] [varchar](6) NOT NULL,
 CONSTRAINT [PK__ROOM__328651AA395884C4] PRIMARY KEY CLUSTERED 
(
	[RoomNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WTINFO]    Script Date: 10/17/2019 19:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WTINFO](
	[RoomNo] [varchar](8) NOT NULL,
	[UseDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[WaterUse] [decimal](6, 2) NOT NULL,
	[PowerUse] [decimal](6, 2) NOT NULL,
	[Record] [varchar](8) NOT NULL,
	[CustoNo] [varchar](15) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_CUSTOSPEND_MoneyState]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[CUSTOSPEND] ADD  CONSTRAINT [DF_CUSTOSPEND_MoneyState]  DEFAULT ('未结算') FOR [MoneyState]
GO
/****** Object:  Default [DF_ROOM_RoomType]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[ROOM] ADD  CONSTRAINT [DF_ROOM_RoomType]  DEFAULT ((1)) FOR [RoomType]
GO
/****** Object:  Default [DF_ROOM_CheckTime]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[ROOM] ADD  CONSTRAINT [DF_ROOM_CheckTime]  DEFAULT (getdate()) FOR [CheckTime]
GO
/****** Object:  Default [DF_ROOM_RoomStateId]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[ROOM] ADD  CONSTRAINT [DF_ROOM_RoomStateId]  DEFAULT ((0)) FOR [RoomStateId]
GO
/****** Object:  Default [DF_ROOM_RoomMoney]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[ROOM] ADD  CONSTRAINT [DF_ROOM_RoomMoney]  DEFAULT ((300.00)) FOR [RoomMoney]
GO
/****** Object:  Default [DF_ROOMSTATE_RoomStateId]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[ROOMSTATE] ADD  CONSTRAINT [DF_ROOMSTATE_RoomStateId]  DEFAULT ((0)) FOR [RoomStateId]
GO
/****** Object:  Default [DF_SPEND_Lender]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[SPEND] ADD  CONSTRAINT [DF_SPEND_Lender]  DEFAULT ('admin') FOR [Lender]
GO
/****** Object:  Check [CK_CUSTOSPEND_MoneyState]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[CUSTOSPEND]  WITH CHECK ADD  CONSTRAINT [CK_CUSTOSPEND_MoneyState] CHECK  (([MoneyState]='已结算' OR [MoneyState]='未结算'))
GO
ALTER TABLE [dbo].[CUSTOSPEND] CHECK CONSTRAINT [CK_CUSTOSPEND_MoneyState]
GO
/****** Object:  Check [CK__UESRINFO__CustoI__0A9D95DB]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[USERINFO]  WITH CHECK ADD  CONSTRAINT [CK__UESRINFO__CustoI__0A9D95DB] CHECK  ((datalength([CustoID])<=(19)))
GO
ALTER TABLE [dbo].[USERINFO] CHECK CONSTRAINT [CK__UESRINFO__CustoI__0A9D95DB]
GO
/****** Object:  Check [CK__UESRINFO__CustoS__09A971A2]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[USERINFO]  WITH CHECK ADD  CONSTRAINT [CK__UESRINFO__CustoS__09A971A2] CHECK  (([CustoSex]='男' OR [CustoSex]='女'))
GO
ALTER TABLE [dbo].[USERINFO] CHECK CONSTRAINT [CK__UESRINFO__CustoS__09A971A2]
GO
/****** Object:  Check [CK_USERINFO_CustoType]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[USERINFO]  WITH CHECK ADD  CONSTRAINT [CK_USERINFO_CustoType] CHECK  (([CustoType]=(0) OR [CustoType]=(1) OR [CustoType]=(2) OR [CustoType]=(3)))
GO
ALTER TABLE [dbo].[USERINFO] CHECK CONSTRAINT [CK_USERINFO_CustoType]
GO
/****** Object:  Check [CK__WORKERINF__Worke__27F8EE98]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[WORKERINFO]  WITH CHECK ADD  CONSTRAINT [CK__WORKERINF__Worke__27F8EE98] CHECK  (([WorkerSex]='男' OR [WorkerSex]='女'))
GO
ALTER TABLE [dbo].[WORKERINFO] CHECK CONSTRAINT [CK__WORKERINF__Worke__27F8EE98]
GO
/****** Object:  Check [CK__WORKERINF__Worke__28ED12D1]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[WORKERINFO]  WITH CHECK ADD  CONSTRAINT [CK__WORKERINF__Worke__28ED12D1] CHECK  ((datalength([CardID])<=(19)))
GO
ALTER TABLE [dbo].[WORKERINFO] CHECK CONSTRAINT [CK__WORKERINF__Worke__28ED12D1]
GO
/****** Object:  ForeignKey [FK__ROOM__CustoNo__3B40CD36]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[ROOM]  WITH NOCHECK ADD  CONSTRAINT [FK__ROOM__CustoNo__3B40CD36] FOREIGN KEY([CustoNo])
REFERENCES [dbo].[USERINFO] ([CustoNo])
GO
ALTER TABLE [dbo].[ROOM] NOCHECK CONSTRAINT [FK__ROOM__CustoNo__3B40CD36]
GO
/****** Object:  ForeignKey [FK__SPEND__CustoNo__00DF2177]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[SPEND]  WITH CHECK ADD  CONSTRAINT [FK__SPEND__CustoNo__00DF2177] FOREIGN KEY([CustoNo])
REFERENCES [dbo].[USERINFO] ([CustoNo])
GO
ALTER TABLE [dbo].[SPEND] CHECK CONSTRAINT [FK__SPEND__CustoNo__00DF2177]
GO
/****** Object:  ForeignKey [FK__WTINFO__CustoNo__0880433F]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[WTINFO]  WITH CHECK ADD  CONSTRAINT [FK__WTINFO__CustoNo__0880433F] FOREIGN KEY([CustoNo])
REFERENCES [dbo].[USERINFO] ([CustoNo])
GO
ALTER TABLE [dbo].[WTINFO] CHECK CONSTRAINT [FK__WTINFO__CustoNo__0880433F]
GO
/****** Object:  ForeignKey [FK__WTINFO__RoomNo__078C1F06]    Script Date: 10/17/2019 19:12:36 ******/
ALTER TABLE [dbo].[WTINFO]  WITH CHECK ADD  CONSTRAINT [FK__WTINFO__RoomNo__078C1F06] FOREIGN KEY([RoomNo])
REFERENCES [dbo].[ROOM] ([RoomNo])
GO
ALTER TABLE [dbo].[WTINFO] CHECK CONSTRAINT [FK__WTINFO__RoomNo__078C1F06]
GO
