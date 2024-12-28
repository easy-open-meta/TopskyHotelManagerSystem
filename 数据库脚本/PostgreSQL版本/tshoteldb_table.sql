DROP TABLE IF EXISTS "public"."admintype";
DROP TABLE IF EXISTS "public"."cashinfo";
DROP TABLE IF EXISTS "public"."customer";
DROP TABLE IF EXISTS "public"."education";
DROP TABLE IF EXISTS "public"."fonts";
DROP TABLE IF EXISTS "public"."member_info";
DROP TABLE IF EXISTS "public"."nation";
DROP TABLE IF EXISTS "public"."passporttype";
DROP TABLE IF EXISTS "public"."room";
DROP TABLE IF EXISTS "public"."roomtype";
DROP TABLE IF EXISTS "public"."sellthing";
DROP TABLE IF EXISTS "public"."sextype";
DROP TABLE IF EXISTS "public"."usertype";
DROP TABLE IF EXISTS "public"."workercheck";
DROP TABLE IF EXISTS "public"."workerpic";
DROP TABLE IF EXISTS "public"."admininfo";
DROP TABLE IF EXISTS "public"."applicationversion";
DROP TABLE IF EXISTS "public"."base";
DROP TABLE IF EXISTS "public"."cardcodes";
DROP TABLE IF EXISTS "public"."checkinfo";
DROP TABLE IF EXISTS "public"."counterrule";
DROP TABLE IF EXISTS "public"."custospend";
DROP TABLE IF EXISTS "public"."dept";
DROP TABLE IF EXISTS "public"."module";
DROP TABLE IF EXISTS "public"."module_zero";
DROP TABLE IF EXISTS "public"."nav_bar";
DROP TABLE IF EXISTS "public"."operationlog";
DROP TABLE IF EXISTS "public"."position";
DROP TABLE IF EXISTS "public"."reser";
DROP TABLE IF EXISTS "public"."roomstate";
DROP TABLE IF EXISTS "public"."gbtype";
DROP TABLE IF EXISTS "public"."uploadinfo";
DROP TABLE IF EXISTS "public"."vip_rule";
DROP TABLE IF EXISTS "public"."worker";
DROP TABLE IF EXISTS "public"."workergoodbad";
DROP TABLE IF EXISTS "public"."workerhistory";
DROP TABLE IF EXISTS "public"."wtinfo";
CREATE TABLE "public"."admintype" ( 
  "Id" SERIAL,
  "type_id" VARCHAR NOT NULL,
  "type_name" VARCHAR NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "admintype_pkey" PRIMARY KEY ("Id")
);
CREATE TABLE "public"."cashinfo" ( 
  "CashNo" VARCHAR NOT NULL,
  "CashName" VARCHAR NOT NULL,
  "CashPrice" NUMERIC NOT NULL,
  "CashClub" VARCHAR NOT NULL,
  "CashTime" TIMESTAMP NOT NULL,
  "CashSource" VARCHAR NOT NULL,
  "CashPerson" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "cashinfo_pkey" PRIMARY KEY ("CashNo")
);
CREATE TABLE "public"."customer" ( 
  "custo_no" VARCHAR NOT NULL DEFAULT ''::character varying ,
  "custo_name" VARCHAR NULL,
  "custo_sex" SMALLINT NULL DEFAULT 0 ,
  "custo_tel" VARCHAR NOT NULL,
  "passport_type" SMALLINT NOT NULL DEFAULT 0 ,
  "passport_id" VARCHAR NOT NULL,
  "custo_address" VARCHAR NULL,
  "custo_birth" DATE NULL,
  "custo_type" SMALLINT NOT NULL DEFAULT 0 ,
  "delete_mk" SMALLINT NOT NULL DEFAULT 0 ,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "customer_pkey" PRIMARY KEY ("custo_no")
);
CREATE TABLE "public"."education" ( 
  "education_no" VARCHAR NOT NULL,
  "education_name" VARCHAR NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "education_pkey" PRIMARY KEY ("education_no")
);
CREATE TABLE "public"."fonts" ( 
  "FontsId" SERIAL,
  "FontsMess" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "fonts_pkey" PRIMARY KEY ("FontsId")
);
CREATE TABLE "public"."member_info" ( 
  "member_id" VARCHAR NOT NULL,
  "member_name" VARCHAR NOT NULL,
  "member_nick_name" VARCHAR NULL,
  "member_qq_number" VARCHAR NOT NULL,
  "member_sex" VARCHAR NULL,
  "member_qq_age" VARCHAR NULL,
  "member_join_date" VARCHAR NOT NULL,
  "member_level_score" VARCHAR NOT NULL,
  "created_by" VARCHAR NULL,
  "created_time" TIMESTAMP NULL,
  "updated_by" VARCHAR NULL,
  "updated_time" TIMESTAMP NULL,
  CONSTRAINT "member_info_pkey" PRIMARY KEY ("member_id")
);
CREATE TABLE "public"."nation" ( 
  "nation_no" VARCHAR NOT NULL,
  "nation_name" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "nation_pkey" PRIMARY KEY ("nation_no", "nation_name")
);
CREATE TABLE "public"."passporttype" ( 
  "PassportId" INTEGER NOT NULL,
  "PassportName" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "passporttype_pkey" PRIMARY KEY ("PassportId")
);
CREATE TABLE "public"."room" ( 
  "room_no" VARCHAR NOT NULL,
  "room_type" SMALLINT NOT NULL DEFAULT 0 ,
  "custo_no" VARCHAR NULL,
  "check_in_time" DATE NULL,
  "check_out_time" DATE NULL,
  "room_state_id" SMALLINT NOT NULL DEFAULT 0 ,
  "room_rent" NUMERIC NOT NULL DEFAULT 0 ,
  "room_deposit" NUMERIC NULL DEFAULT 0 ,
  "room_position" VARCHAR NOT NULL DEFAULT 0 ,
  "delete_mk" SMALLINT NOT NULL DEFAULT 0 ,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "room_pkey" PRIMARY KEY ("room_no")
);
CREATE TABLE "public"."roomtype" ( 
  "RoomType" INTEGER NOT NULL,
  "RoomName" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL DEFAULT 0 ,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  "room_rent" NUMERIC NOT NULL DEFAULT 0 ,
  "room_deposit" NUMERIC NOT NULL DEFAULT 0 ,
  CONSTRAINT "roomtype_pkey" PRIMARY KEY ("RoomType")
);
CREATE TABLE "public"."sellthing" ( 
  "SellNo" VARCHAR NOT NULL,
  "SellName" VARCHAR NOT NULL,
  "SellPrice" NUMERIC NOT NULL,
  "format" VARCHAR NULL,
  "Stock" NUMERIC NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "sellthing_pkey" PRIMARY KEY ("SellNo")
);
CREATE TABLE "public"."sextype" ( 
  "sexId" INTEGER NOT NULL,
  "sexName" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "sextype_pkey" PRIMARY KEY ("sexId")
);
CREATE TABLE "public"."usertype" ( 
  "UserType" INTEGER NOT NULL,
  "TypeName" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "usertype_pkey" PRIMARY KEY ("UserType")
);
CREATE TABLE "public"."workercheck" ( 
  "Id" SERIAL,
  "WorkerNo" VARCHAR NULL,
  "CheckTime" TIMESTAMP NULL,
  "CheckWay" VARCHAR NULL,
  "CheckState" INTEGER NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "workercheck_pkey" PRIMARY KEY ("Id")
);
CREATE TABLE "public"."workerpic" ( 
  "Id" SERIAL,
  "WorkerId" VARCHAR NULL,
  "Pic" VARCHAR NULL,
  CONSTRAINT "workerpic_pkey" PRIMARY KEY ("Id")
);
CREATE TABLE "public"."admininfo" ( 
  "Id" SERIAL,
  "AdminAccount" VARCHAR NOT NULL,
  "AdminPassword" VARCHAR NULL,
  "AdminType" VARCHAR NULL,
  "AdminName" VARCHAR NULL,
  "IsAdmin" INTEGER NULL,
  "DeleteMk" INTEGER NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "admininfo_pkey" PRIMARY KEY ("Id", "AdminAccount")
);
CREATE TABLE "public"."applicationversion" ( 
  "base_versionId" SERIAL,
  "base_version" VARCHAR NOT NULL,
  CONSTRAINT "applicationversion_pkey" PRIMARY KEY ("base_versionId")
);
CREATE TABLE "public"."base" ( 
  "url_no" SERIAL,
  "url_addr" VARCHAR NULL,
  CONSTRAINT "base_pkey" PRIMARY KEY ("url_no")
);
CREATE TABLE "public"."cardcodes" ( 
  "id" SERIAL,
  "Province" VARCHAR NOT NULL,
  "City" VARCHAR NULL,
  "District" VARCHAR NULL,
  "bm" VARCHAR NULL,
  CONSTRAINT "cardcodes_pkey" PRIMARY KEY ("id")
);
CREATE TABLE "public"."checkinfo" ( 
  "CheckNo" VARCHAR NOT NULL,
  "CheckClub" VARCHAR NOT NULL,
  "CheckProgres" VARCHAR NOT NULL,
  "CheckCash" VARCHAR NOT NULL,
  "CheckScore" INTEGER NOT NULL,
  "CheckPerson" VARCHAR NOT NULL,
  "CheckAdvice" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "checkinfo_pkey" PRIMARY KEY ("CheckNo")
);
CREATE TABLE "public"."counterrule" ( 
  "rule_id" INTEGER NOT NULL,
  "rule_name" VARCHAR NULL,
  "rule_desc" VARCHAR NULL,
  "now_id" INTEGER NULL,
  "prefix_name" VARCHAR NULL,
  "custo_format" VARCHAR NULL,
  "number_format" VARCHAR NULL,
  "separating_char" VARCHAR NULL,
  "datains_usrid" VARCHAR NULL,
  "datains_time" TIMESTAMP NULL,
  "datachg_usrid" VARCHAR NULL,
  "datachg_time" TIMESTAMP NULL,
  CONSTRAINT "counterrule_pkey" PRIMARY KEY ("rule_id")
);
CREATE TABLE "public"."custospend" ( 
  "SpendId" SERIAL,
  "RoomNo" VARCHAR NOT NULL,
  "CustoNo" VARCHAR NOT NULL,
  "SpendName" VARCHAR NOT NULL,
  "SpendAmount" INTEGER NOT NULL,
  "SpendPrice" NUMERIC NOT NULL,
  "SpendMoney" NUMERIC NOT NULL,
  "SpendTime" TIMESTAMP NOT NULL,
  "MoneyState" VARCHAR NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "custospend_pkey" PRIMARY KEY ("SpendId")
);
CREATE TABLE "public"."dept" ( 
  "dept_no" VARCHAR NOT NULL,
  "dept_name" VARCHAR NULL,
  "dept_desc" VARCHAR NULL,
  "dept_date" DATE NULL,
  "dept_leader" VARCHAR NULL,
  "dept_parent" VARCHAR NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "dept_pkey" PRIMARY KEY ("dept_no")
);
CREATE TABLE "public"."module" ( 
  "module_id" SERIAL,
  "module_name" VARCHAR NULL,
  "module_desc" VARCHAR NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "module_pkey" PRIMARY KEY ("module_id")
);
CREATE TABLE "public"."module_zero" ( 
  "module_id" SERIAL,
  "admin_account" VARCHAR NULL,
  "module_name" VARCHAR NULL,
  "module_enable" INTEGER NULL,
  CONSTRAINT "module_zero_pkey" PRIMARY KEY ("module_id")
);
CREATE TABLE "public"."nav_bar" ( 
  "nav_id" SERIAL,
  "nav_name" VARCHAR NOT NULL,
  "nav_or" INTEGER NULL DEFAULT 0 ,
  "nav_pic" VARCHAR NULL,
  "nav_event" VARCHAR NULL,
  "delete_mk" INTEGER NOT NULL DEFAULT 0 ,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  "margin_left" SMALLINT NULL,
  CONSTRAINT "nav_bar_pkey" PRIMARY KEY ("nav_id")
);
CREATE TABLE "public"."operationlog" ( 
  "OperationId" SERIAL,
  "OperationTime" TIMESTAMP NOT NULL,
  "LogContent" VARCHAR NOT NULL,
  "OperationAccount" VARCHAR NOT NULL,
  "OperationLevel" INTEGER NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" TIMESTAMP NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" TIMESTAMP NULL,
  "SoftwareVersion" VARCHAR NULL,
  "login_ip" VARCHAR NULL,
  CONSTRAINT "operationlog_pkey" PRIMARY KEY ("OperationId")
);
CREATE TABLE "public"."position" ( 
  "position_no" VARCHAR NOT NULL,
  "position_name" VARCHAR NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "position_pkey" PRIMARY KEY ("position_no")
);
CREATE TABLE "public"."reser" ( 
  "ReserId" VARCHAR NOT NULL,
  "CustoName" VARCHAR NULL,
  "CustoTel" VARCHAR NULL,
  "ReserWay" VARCHAR NULL,
  "ReserRoom" VARCHAR NULL,
  "ReserDate" DATE NULL,
  "ReserEndDay" DATE NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "reser_pkey" PRIMARY KEY ("ReserId")
);
CREATE TABLE "public"."roomstate" ( 
  "RoomStateId" INTEGER NOT NULL,
  "RoomState" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "roomstate_pkey" PRIMARY KEY ("RoomStateId")
);
CREATE TABLE "public"."gbtype" ( 
  "GBTypeId" INTEGER NOT NULL,
  "GBName" VARCHAR NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "gbtype_pkey" PRIMARY KEY ("GBTypeId")
);
CREATE TABLE "public"."uploadinfo" ( 
  "NoticeNo" VARCHAR NOT NULL,
  "Noticetheme" VARCHAR NOT NULL,
  "NoticeType" VARCHAR NULL,
  "NoticeTime" TIMESTAMP NOT NULL,
  "NoticeContent" VARCHAR NOT NULL,
  "NoticeClub" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "uploadinfo_pkey" PRIMARY KEY ("NoticeNo")
);
CREATE TABLE "public"."vip_rule" ( 
  "id" SERIAL,
  "rule_id" VARCHAR NOT NULL,
  "rule_name" VARCHAR NOT NULL,
  "rule_value" NUMERIC NOT NULL,
  "type_id" INTEGER NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "vip_rule_pkey" PRIMARY KEY ("id", "rule_id")
);
CREATE TABLE "public"."worker" ( 
  "WorkerId" VARCHAR NOT NULL,
  "WorkerName" VARCHAR NOT NULL,
  "WorkerBirthday" TIMESTAMP NOT NULL,
  "WorkerSex" INTEGER NOT NULL,
  "WorkerTel" VARCHAR NOT NULL,
  "WorkerClub" VARCHAR NOT NULL,
  "WorkerNation" VARCHAR NOT NULL,
  "WorkerAddress" VARCHAR NOT NULL,
  "WorkerPosition" VARCHAR NOT NULL,
  "CardID" VARCHAR NOT NULL,
  "WorkerPwd" VARCHAR NULL,
  "WorkerTime" TIMESTAMP NOT NULL,
  "WorkerFace" VARCHAR NOT NULL,
  "WorkerEducation" VARCHAR NOT NULL,
  "delete_mk" INTEGER NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "worker_pkey" PRIMARY KEY ("WorkerId")
);
CREATE TABLE "public"."workergoodbad" ( 
  "Id" SERIAL,
  "WorkNo" VARCHAR NULL,
  "GBInfo" VARCHAR NULL,
  "GBType" INTEGER NULL,
  "GBOperation" VARCHAR NULL,
  "GBTime" TIMESTAMP NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "workergoodbad_pkey" PRIMARY KEY ("Id")
);
CREATE TABLE "public"."workerhistory" ( 
  "Id" SERIAL,
  "WorkerId" VARCHAR NOT NULL,
  "StartDate" TIMESTAMP NOT NULL,
  "EndDate" TIMESTAMP NOT NULL,
  "Position" VARCHAR NOT NULL,
  "Company" VARCHAR NOT NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  CONSTRAINT "workerhistory_pkey" PRIMARY KEY ("Id")
);
CREATE TABLE "public"."wtinfo" ( 
  "RoomNo" VARCHAR NOT NULL,
  "UseDate" TIMESTAMP NOT NULL,
  "EndDate" TIMESTAMP NULL,
  "WaterUse" NUMERIC NOT NULL,
  "PowerUse" NUMERIC NOT NULL,
  "Record" VARCHAR NOT NULL,
  "CustoNo" VARCHAR NULL,
  "delete_mk" INTEGER NOT NULL,
  "datains_usr" VARCHAR NULL,
  "datains_date" DATE NULL,
  "datachg_usr" VARCHAR NULL,
  "datachg_date" DATE NULL,
  "WtiNo" SERIAL,
  CONSTRAINT "wtinfo_pkey" PRIMARY KEY ("WtiNo")
);
