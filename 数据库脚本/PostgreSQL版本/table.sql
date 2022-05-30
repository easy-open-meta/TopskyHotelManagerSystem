-- ----------------------------
-- Sequence structure for upms_log_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."upms_log_id_seq";
CREATE SEQUENCE "public"."upms_log_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Table structure for admininfo
-- ----------------------------
DROP TABLE IF EXISTS "public"."admininfo";
CREATE TABLE "public"."admininfo" (
  "Id" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "AdminAccount" varchar(15) COLLATE "pg_catalog"."default" NOT NULL,
  "AdminPassword" varchar(200) COLLATE "pg_catalog"."default",
  "AdminType" varchar(15) COLLATE "pg_catalog"."default",
  "AdminName" varchar(50) COLLATE "pg_catalog"."default",
  "IsAdmin" int4,
  "DeleteMk" int4,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_time" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_time" date
)
;
COMMENT ON COLUMN "public"."admininfo"."Id" IS '自增长ID';
COMMENT ON COLUMN "public"."admininfo"."AdminAccount" IS '管理员账号';
COMMENT ON COLUMN "public"."admininfo"."AdminPassword" IS '管理员密码';
COMMENT ON COLUMN "public"."admininfo"."AdminType" IS '管理员类型';
COMMENT ON COLUMN "public"."admininfo"."AdminName" IS '管理员名称';
COMMENT ON COLUMN "public"."admininfo"."IsAdmin" IS '是否为超级管理员';
COMMENT ON COLUMN "public"."admininfo"."DeleteMk" IS '删除标记';
COMMENT ON COLUMN "public"."admininfo"."datains_usr" IS '资料新增人';
COMMENT ON COLUMN "public"."admininfo"."datains_time" IS '资料新增时间';
COMMENT ON COLUMN "public"."admininfo"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."admininfo"."datachg_time" IS '资料更新时间';
COMMENT ON TABLE "public"."admininfo" IS '管理员信息表';

-- ----------------------------
-- Table structure for admintype
-- ----------------------------
DROP TABLE IF EXISTS "public"."admintype";
CREATE TABLE "public"."admintype" (
  "Id" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "type_id" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "type_name" varchar(50) COLLATE "pg_catalog"."default",
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."admintype"."Id" IS '编号';
COMMENT ON COLUMN "public"."admintype"."type_id" IS '管理员类型';
COMMENT ON COLUMN "public"."admintype"."type_name" IS '管理员类型名称';
COMMENT ON COLUMN "public"."admintype"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."admintype"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."admintype"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."admintype"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."admintype"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."admintype" IS '管理员类型表';

-- ----------------------------
-- Table structure for applicationversion
-- ----------------------------
DROP TABLE IF EXISTS "public"."applicationversion";
CREATE TABLE "public"."applicationversion" (
  "base_versionId" int2 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "base_version" varchar(50) COLLATE "pg_catalog"."default" NOT NULL
)
;
COMMENT ON COLUMN "public"."applicationversion"."base_versionId" IS '流水号';
COMMENT ON COLUMN "public"."applicationversion"."base_version" IS '版本号';
COMMENT ON TABLE "public"."applicationversion" IS '应用程序版本控制表';

-- ----------------------------
-- Table structure for backinfo
-- ----------------------------
DROP TABLE IF EXISTS "public"."backinfo";
CREATE TABLE "public"."backinfo" (
  "BackNo" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "BackName" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "BackSource" varchar(18) COLLATE "pg_catalog"."default" NOT NULL,
  "BackCash" numeric(6,2) NOT NULL,
  "BackType" int4 NOT NULL,
  "BackPerson" varchar(8) COLLATE "pg_catalog"."default" NOT NULL,
  "ControlClub" varchar(12) COLLATE "pg_catalog"."default" NOT NULL,
  "BackClub" varchar(12) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."backinfo"."BackNo" IS '物资编号';
COMMENT ON COLUMN "public"."backinfo"."BackName" IS '物资名称';
COMMENT ON COLUMN "public"."backinfo"."BackSource" IS '物资来源';
COMMENT ON COLUMN "public"."backinfo"."BackCash" IS '物资金额';
COMMENT ON COLUMN "public"."backinfo"."BackType" IS '物资类型';
COMMENT ON COLUMN "public"."backinfo"."BackPerson" IS '经办人';
COMMENT ON COLUMN "public"."backinfo"."ControlClub" IS '管理部门';
COMMENT ON COLUMN "public"."backinfo"."BackClub" IS '所属部门';
COMMENT ON COLUMN "public"."backinfo"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."backinfo"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."backinfo"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."backinfo"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."backinfo"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."backinfo" IS '酒店物资表';

-- ----------------------------
-- Table structure for base
-- ----------------------------
DROP TABLE IF EXISTS "public"."base";
CREATE TABLE "public"."base" (
  "url_no" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "url_addr" varchar(255) COLLATE "pg_catalog"."default"
)
;
COMMENT ON COLUMN "public"."base"."url_no" IS 'ID';
COMMENT ON COLUMN "public"."base"."url_addr" IS '地址';
COMMENT ON TABLE "public"."base" IS '程序信息配置表';

-- ----------------------------
-- Table structure for cardcodes
-- ----------------------------
DROP TABLE IF EXISTS "public"."cardcodes";
CREATE TABLE "public"."cardcodes" (
  "id" int8 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "Province" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "City" varchar(255) COLLATE "pg_catalog"."default",
  "District" varchar(255) COLLATE "pg_catalog"."default",
  "bm" varchar(255) COLLATE "pg_catalog"."default"
)
;
COMMENT ON COLUMN "public"."cardcodes"."id" IS '编号';
COMMENT ON COLUMN "public"."cardcodes"."Province" IS '省份';
COMMENT ON COLUMN "public"."cardcodes"."City" IS '城市';
COMMENT ON COLUMN "public"."cardcodes"."District" IS '地区';
COMMENT ON COLUMN "public"."cardcodes"."bm" IS '地区识别码';
COMMENT ON TABLE "public"."cardcodes" IS '身份证地区识别码表';

-- ----------------------------
-- Table structure for cashinfo
-- ----------------------------
DROP TABLE IF EXISTS "public"."cashinfo";
CREATE TABLE "public"."cashinfo" (
  "CashNo" varchar(12) COLLATE "pg_catalog"."default" NOT NULL,
  "CashName" varchar(300) COLLATE "pg_catalog"."default" NOT NULL,
  "CashPrice" numeric(10,2) NOT NULL,
  "CashClub" varchar(800) COLLATE "pg_catalog"."default" NOT NULL,
  "CashTime" timestamp(6) NOT NULL,
  "CashSource" varchar(200) COLLATE "pg_catalog"."default" NOT NULL,
  "CashPerson" varchar(800) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."cashinfo"."CashNo" IS '资产编号';
COMMENT ON COLUMN "public"."cashinfo"."CashName" IS '资产名称';
COMMENT ON COLUMN "public"."cashinfo"."CashPrice" IS '资产总值';
COMMENT ON COLUMN "public"."cashinfo"."CashClub" IS '所属部门';
COMMENT ON COLUMN "public"."cashinfo"."CashTime" IS '入库时间';
COMMENT ON COLUMN "public"."cashinfo"."CashSource" IS '资产来源';
COMMENT ON COLUMN "public"."cashinfo"."CashPerson" IS '资产经办人';
COMMENT ON COLUMN "public"."cashinfo"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."cashinfo"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."cashinfo"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."cashinfo"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."cashinfo"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."cashinfo" IS '酒店资产表';

-- ----------------------------
-- Table structure for checkinfo
-- ----------------------------
DROP TABLE IF EXISTS "public"."checkinfo";
CREATE TABLE "public"."checkinfo" (
  "CheckNo" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "CheckClub" varchar(12) COLLATE "pg_catalog"."default" NOT NULL,
  "CheckProgres" varchar(250) COLLATE "pg_catalog"."default" NOT NULL,
  "CheckCash" varchar(250) COLLATE "pg_catalog"."default" NOT NULL,
  "CheckScore" int4 NOT NULL,
  "CheckPerson" varchar(8) COLLATE "pg_catalog"."default" NOT NULL,
  "CheckAdvice" varchar(45) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."checkinfo"."CheckNo" IS '监管统计编号';
COMMENT ON COLUMN "public"."checkinfo"."CheckClub" IS '受监管部门';
COMMENT ON COLUMN "public"."checkinfo"."CheckProgres" IS '受监管部门总体概述';
COMMENT ON COLUMN "public"."checkinfo"."CheckCash" IS '受监管部门交易情况';
COMMENT ON COLUMN "public"."checkinfo"."CheckScore" IS '受监管部门得分情况';
COMMENT ON COLUMN "public"."checkinfo"."CheckPerson" IS '本次监管负责人';
COMMENT ON COLUMN "public"."checkinfo"."CheckAdvice" IS '监管建议';
COMMENT ON COLUMN "public"."checkinfo"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."checkinfo"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."checkinfo"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."checkinfo"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."checkinfo"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."checkinfo" IS '监管统计表';

-- ----------------------------
-- Table structure for counterrule
-- ----------------------------
DROP TABLE IF EXISTS "public"."counterrule";
CREATE TABLE "public"."counterrule" (
  "rule_id" int4 NOT NULL,
  "rule_name" varchar(50) COLLATE "pg_catalog"."default",
  "rule_desc" varchar(100) COLLATE "pg_catalog"."default",
  "now_id" int4,
  "prefix_name" varchar(20) COLLATE "pg_catalog"."default",
  "custo_format" varchar(50) COLLATE "pg_catalog"."default",
  "number_format" varchar(10) COLLATE "pg_catalog"."default",
  "separating_char" varchar(5) COLLATE "pg_catalog"."default",
  "datains_usrid" varchar(20) COLLATE "pg_catalog"."default",
  "datains_time" timestamp(6),
  "datachg_usrid" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_time" timestamp(6)
)
;
COMMENT ON COLUMN "public"."counterrule"."rule_id" IS '规则编号';
COMMENT ON COLUMN "public"."counterrule"."rule_name" IS '规格名称';
COMMENT ON COLUMN "public"."counterrule"."rule_desc" IS '规则描述';
COMMENT ON COLUMN "public"."counterrule"."now_id" IS '当前ID';
COMMENT ON COLUMN "public"."counterrule"."prefix_name" IS '规则简写';
COMMENT ON COLUMN "public"."counterrule"."custo_format" IS '规则格式';
COMMENT ON COLUMN "public"."counterrule"."number_format" IS '编号前缀';
COMMENT ON COLUMN "public"."counterrule"."separating_char" IS '规则分割符';
COMMENT ON COLUMN "public"."counterrule"."datains_usrid" IS '资料新增人';
COMMENT ON COLUMN "public"."counterrule"."datains_time" IS '资料新增时间';
COMMENT ON COLUMN "public"."counterrule"."datachg_usrid" IS '资料更新人';
COMMENT ON COLUMN "public"."counterrule"."datachg_time" IS '资料更新时间';
COMMENT ON TABLE "public"."counterrule" IS '业务流水号规则表';

-- ----------------------------
-- Table structure for custospend
-- ----------------------------
DROP TABLE IF EXISTS "public"."custospend";
CREATE TABLE "public"."custospend" (
  "SpendId" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "RoomNo" varchar(8) COLLATE "pg_catalog"."default" NOT NULL,
  "CustoNo" varchar(15) COLLATE "pg_catalog"."default" NOT NULL,
  "SpendName" varchar(25) COLLATE "pg_catalog"."default" NOT NULL,
  "SpendAmount" int4 NOT NULL,
  "SpendPrice" numeric(10,2) NOT NULL,
  "SpendMoney" numeric(10,2) NOT NULL,
  "SpendTime" timestamp(6) NOT NULL,
  "MoneyState" varchar(9) COLLATE "pg_catalog"."default",
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."custospend"."SpendId" IS '记录编号';
COMMENT ON COLUMN "public"."custospend"."RoomNo" IS '房间编号';
COMMENT ON COLUMN "public"."custospend"."CustoNo" IS '客户编号';
COMMENT ON COLUMN "public"."custospend"."SpendName" IS '商品名称';
COMMENT ON COLUMN "public"."custospend"."SpendAmount" IS '商品数量';
COMMENT ON COLUMN "public"."custospend"."SpendPrice" IS '商品价格';
COMMENT ON COLUMN "public"."custospend"."SpendMoney" IS '消费总额';
COMMENT ON COLUMN "public"."custospend"."SpendTime" IS '消费时间';
COMMENT ON COLUMN "public"."custospend"."MoneyState" IS '结算状态';
COMMENT ON COLUMN "public"."custospend"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."custospend"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."custospend"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."custospend"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."custospend"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."custospend" IS '商品消费表';

-- ----------------------------
-- Table structure for dept
-- ----------------------------
DROP TABLE IF EXISTS "public"."dept";
CREATE TABLE "public"."dept" (
  "dept_no" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "dept_name" varchar(100) COLLATE "pg_catalog"."default",
  "dept_desc" varchar(255) COLLATE "pg_catalog"."default",
  "dept_date" date,
  "dept_leader" varchar(20) COLLATE "pg_catalog"."default",
  "dept_parent" varchar(50) COLLATE "pg_catalog"."default",
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."dept"."dept_no" IS '部门编号';
COMMENT ON COLUMN "public"."dept"."dept_name" IS '部门名称';
COMMENT ON COLUMN "public"."dept"."dept_desc" IS '部门描述';
COMMENT ON COLUMN "public"."dept"."dept_date" IS '创建时间(部门)';
COMMENT ON COLUMN "public"."dept"."dept_leader" IS '部门主管';
COMMENT ON COLUMN "public"."dept"."dept_parent" IS '上级部门';
COMMENT ON COLUMN "public"."dept"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."dept"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."dept"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."dept"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."dept"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."dept" IS '部门表';

-- ----------------------------
-- Table structure for education
-- ----------------------------
DROP TABLE IF EXISTS "public"."education";
CREATE TABLE "public"."education" (
  "education_no" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "education_name" varchar(100) COLLATE "pg_catalog"."default",
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."education"."education_no" IS '学历编号';
COMMENT ON COLUMN "public"."education"."education_name" IS '学历名称';
COMMENT ON COLUMN "public"."education"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."education"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."education"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."education"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."education"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."education" IS '学历表';

-- ----------------------------
-- Table structure for fonts
-- ----------------------------
DROP TABLE IF EXISTS "public"."fonts";
CREATE TABLE "public"."fonts" (
  "FontsId" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "FontsMess" varchar(250) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."fonts"."FontsId" IS 'ID';
COMMENT ON COLUMN "public"."fonts"."FontsMess" IS '文字信息';
COMMENT ON COLUMN "public"."fonts"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."fonts"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."fonts"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."fonts"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."fonts"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."fonts" IS '主页跑马灯信息表';

-- ----------------------------
-- Table structure for gbtype
-- ----------------------------
DROP TABLE IF EXISTS "public"."gbtype";
CREATE TABLE "public"."gbtype" (
  "GBTypeId" int4 NOT NULL,
  "GBName" varchar(255) COLLATE "pg_catalog"."default",
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."gbtype"."GBTypeId" IS '奖惩类型ID';
COMMENT ON COLUMN "public"."gbtype"."GBName" IS '奖惩类型名称';
COMMENT ON COLUMN "public"."gbtype"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."gbtype"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."gbtype"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."gbtype"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."gbtype"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."gbtype" IS '奖惩类型';

-- ----------------------------
-- Table structure for module
-- ----------------------------
DROP TABLE IF EXISTS "public"."module";
CREATE TABLE "public"."module" (
  "module_id" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "module_name" varchar(200) COLLATE "pg_catalog"."default",
  "module_desc" varchar(255) COLLATE "pg_catalog"."default",
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_time" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_time" date
)
;
COMMENT ON COLUMN "public"."module"."module_id" IS '模块ID';
COMMENT ON COLUMN "public"."module"."module_name" IS '模块名称';
COMMENT ON COLUMN "public"."module"."module_desc" IS '模块描述';
COMMENT ON COLUMN "public"."module"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."module"."datains_usr" IS '资料新增人';
COMMENT ON COLUMN "public"."module"."datains_time" IS '资料新增时间';
COMMENT ON COLUMN "public"."module"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."module"."datachg_time" IS '资料更新时间';
COMMENT ON TABLE "public"."module" IS '系统模块表';

-- ----------------------------
-- Table structure for module_zero
-- ----------------------------
DROP TABLE IF EXISTS "public"."module_zero";
CREATE TABLE "public"."module_zero" (
  "module_id" int4 NOT NULL,
  "admin_account" varchar(15) COLLATE "pg_catalog"."default",
  "module_name" varchar(200) COLLATE "pg_catalog"."default",
  "module_enable" int4
)
;
COMMENT ON COLUMN "public"."module_zero"."module_id" IS '模块ID';
COMMENT ON COLUMN "public"."module_zero"."admin_account" IS '管理员账号';
COMMENT ON COLUMN "public"."module_zero"."module_name" IS '模块名称';
COMMENT ON COLUMN "public"."module_zero"."module_enable" IS '是否开启';
COMMENT ON TABLE "public"."module_zero" IS '系统模块权限表';

-- ----------------------------
-- Table structure for nation
-- ----------------------------
DROP TABLE IF EXISTS "public"."nation";
CREATE TABLE "public"."nation" (
  "nation_no" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "nation_name" varchar(100) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."nation"."nation_no" IS '民族编号';
COMMENT ON COLUMN "public"."nation"."nation_name" IS '民族名称';
COMMENT ON COLUMN "public"."nation"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."nation"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."nation"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."nation"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."nation"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."nation" IS '民族信息表';

-- ----------------------------
-- Table structure for operationlog
-- ----------------------------
DROP TABLE IF EXISTS "public"."operationlog";
CREATE TABLE "public"."operationlog" (
  "OperationId" int8 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "OperationTime" timestamp(0) NOT NULL,
  "LogContent" varchar(8000) COLLATE "pg_catalog"."default" NOT NULL,
  "OperationAccount" varchar(300) COLLATE "pg_catalog"."default" NOT NULL,
  "OperationLevel" int4,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" timestamp(0) DEFAULT NULL::timestamp without time zone,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" timestamp(0) DEFAULT NULL::timestamp without time zone,
  "SoftwareVersion" varchar(10) COLLATE "pg_catalog"."default",
  "login_ip" varchar(10) COLLATE "pg_catalog"."default"
)
;
COMMENT ON COLUMN "public"."operationlog"."OperationId" IS '记录ID';
COMMENT ON COLUMN "public"."operationlog"."OperationTime" IS '记录时间';
COMMENT ON COLUMN "public"."operationlog"."LogContent" IS '日志内容';
COMMENT ON COLUMN "public"."operationlog"."OperationAccount" IS '被记录账户';
COMMENT ON COLUMN "public"."operationlog"."OperationLevel" IS '日志等级';
COMMENT ON COLUMN "public"."operationlog"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."operationlog"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."operationlog"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."operationlog"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."operationlog"."datachg_date" IS '资料更新时间';
COMMENT ON COLUMN "public"."operationlog"."SoftwareVersion" IS '软件版本';
COMMENT ON COLUMN "public"."operationlog"."login_ip" IS '登录IP';
COMMENT ON TABLE "public"."operationlog" IS '系统操作日志表';

-- ----------------------------
-- Table structure for passporttype
-- ----------------------------
DROP TABLE IF EXISTS "public"."passporttype";
CREATE TABLE "public"."passporttype" (
  "PassportId" int4 NOT NULL,
  "PassportName" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."passporttype"."PassportId" IS '证件类型ID';
COMMENT ON COLUMN "public"."passporttype"."PassportName" IS '证件类型名称';
COMMENT ON COLUMN "public"."passporttype"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."passporttype"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."passporttype"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."passporttype"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."passporttype"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."passporttype" IS '证件类型表';

-- ----------------------------
-- Table structure for pdman_db_version
-- ----------------------------
DROP TABLE IF EXISTS "public"."pdman_db_version";
CREATE TABLE "public"."pdman_db_version" (
  "DB_VERSION" varchar(256) COLLATE "pg_catalog"."default",
  "VERSION_DESC" varchar(1024) COLLATE "pg_catalog"."default",
  "CREATED_TIME" varchar(32) COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Table structure for position
-- ----------------------------
DROP TABLE IF EXISTS "public"."position";
CREATE TABLE "public"."position" (
  "position_no" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "position_name" varchar(150) COLLATE "pg_catalog"."default",
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."position"."position_no" IS '职位编号';
COMMENT ON COLUMN "public"."position"."position_name" IS '职位名称';
COMMENT ON COLUMN "public"."position"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."position"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."position"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."position"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."position"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."position" IS '职位表';

-- ----------------------------
-- Table structure for reser
-- ----------------------------
DROP TABLE IF EXISTS "public"."reser";
CREATE TABLE "public"."reser" (
  "ReserId" varchar(16) COLLATE "pg_catalog"."default" NOT NULL,
  "CustoName" varchar(8) COLLATE "pg_catalog"."default",
  "CustoTel" varchar(11) COLLATE "pg_catalog"."default",
  "ReserWay" varchar(10) COLLATE "pg_catalog"."default",
  "ReserRoom" varchar(255) COLLATE "pg_catalog"."default",
  "ReserDate" date,
  "ReserEndDay" date,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."reser"."ReserId" IS '预约ID ';
COMMENT ON COLUMN "public"."reser"."CustoName" IS '客户名字';
COMMENT ON COLUMN "public"."reser"."CustoTel" IS '联系方式';
COMMENT ON COLUMN "public"."reser"."ReserWay" IS '预约方式';
COMMENT ON COLUMN "public"."reser"."ReserRoom" IS '预约房号';
COMMENT ON COLUMN "public"."reser"."ReserDate" IS '预约开始日期';
COMMENT ON COLUMN "public"."reser"."ReserEndDay" IS '预约结束日期';
COMMENT ON COLUMN "public"."reser"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."reser"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."reser"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."reser"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."reser"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."reser" IS '预约表';

-- ----------------------------
-- Table structure for room
-- ----------------------------
DROP TABLE IF EXISTS "public"."room";
CREATE TABLE "public"."room" (
  "RoomNo" varchar(8) COLLATE "pg_catalog"."default" NOT NULL,
  "RoomType" int4 NOT NULL,
  "CustoNo" varchar(15) COLLATE "pg_catalog"."default",
  "CheckTime" timestamp(6),
  "CheckOutTime" timestamp(6),
  "RoomStateId" int4 NOT NULL,
  "RoomMoney" numeric(10,2),
  "RoomPosition" varchar(6) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date,
  "deposit" numeric(10,2)
)
;
COMMENT ON COLUMN "public"."room"."RoomNo" IS '房间编号';
COMMENT ON COLUMN "public"."room"."RoomType" IS '房间类型';
COMMENT ON COLUMN "public"."room"."CustoNo" IS '客户编号';
COMMENT ON COLUMN "public"."room"."CheckTime" IS '入住时间';
COMMENT ON COLUMN "public"."room"."CheckOutTime" IS '退房时间';
COMMENT ON COLUMN "public"."room"."RoomStateId" IS '房间状态';
COMMENT ON COLUMN "public"."room"."RoomMoney" IS '房间单价';
COMMENT ON COLUMN "public"."room"."RoomPosition" IS '房间位置';
COMMENT ON COLUMN "public"."room"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."room"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."room"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."room"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."room"."datachg_date" IS '资料更新时间';
COMMENT ON COLUMN "public"."room"."deposit" IS '房间押金';
COMMENT ON TABLE "public"."room" IS '房间表';

-- ----------------------------
-- Table structure for roomstate
-- ----------------------------
DROP TABLE IF EXISTS "public"."roomstate";
CREATE TABLE "public"."roomstate" (
  "RoomStateId" int4 NOT NULL,
  "RoomState" varchar(8) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."roomstate"."RoomStateId" IS '房间状态ID';
COMMENT ON COLUMN "public"."roomstate"."RoomState" IS '房间状态名称';
COMMENT ON COLUMN "public"."roomstate"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."roomstate"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."roomstate"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."roomstate"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."roomstate"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."roomstate" IS '房间状态表';

-- ----------------------------
-- Table structure for roomtype
-- ----------------------------
DROP TABLE IF EXISTS "public"."roomtype";
CREATE TABLE "public"."roomtype" (
  "RoomType" int4 NOT NULL,
  "RoomName" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."roomtype"."RoomType" IS '房间类型ID';
COMMENT ON COLUMN "public"."roomtype"."RoomName" IS '房间类型名称';
COMMENT ON COLUMN "public"."roomtype"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."roomtype"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."roomtype"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."roomtype"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."roomtype"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."roomtype" IS '房间类型表';

-- ----------------------------
-- Table structure for sellthing
-- ----------------------------
DROP TABLE IF EXISTS "public"."sellthing";
CREATE TABLE "public"."sellthing" (
  "SellNo" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "SellName" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "SellPrice" numeric(10,2) NOT NULL,
  "format" varchar(20) COLLATE "pg_catalog"."default",
  "Stock" int4 NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."sellthing"."SellNo" IS '商品编号';
COMMENT ON COLUMN "public"."sellthing"."SellName" IS '商品名称';
COMMENT ON COLUMN "public"."sellthing"."SellPrice" IS '商品价格';
COMMENT ON COLUMN "public"."sellthing"."format" IS '规格型号';
COMMENT ON COLUMN "public"."sellthing"."Stock" IS '库存数量';
COMMENT ON COLUMN "public"."sellthing"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."sellthing"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."sellthing"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."sellthing"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."sellthing"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."sellthing" IS '商品表';

-- ----------------------------
-- Table structure for sextype
-- ----------------------------
DROP TABLE IF EXISTS "public"."sextype";
CREATE TABLE "public"."sextype" (
  "sexId" int4 NOT NULL,
  "sexName" varchar(15) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."sextype"."sexId" IS '性别ID';
COMMENT ON COLUMN "public"."sextype"."sexName" IS '性别名称';
COMMENT ON COLUMN "public"."sextype"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."sextype"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."sextype"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."sextype"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."sextype"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."sextype" IS '性别类型表';

-- ----------------------------
-- Table structure for uploadinfo
-- ----------------------------
DROP TABLE IF EXISTS "public"."uploadinfo";
CREATE TABLE "public"."uploadinfo" (
  "NoticeNo" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "Noticetheme" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "NoticeType" varchar(100) COLLATE "pg_catalog"."default",
  "NoticeTime" timestamp(6) NOT NULL,
  "NoticeContent" varchar(8000) COLLATE "pg_catalog"."default" NOT NULL,
  "NoticeClub" varchar(25) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."uploadinfo"."NoticeNo" IS '公告编号';
COMMENT ON COLUMN "public"."uploadinfo"."Noticetheme" IS '公告主题';
COMMENT ON COLUMN "public"."uploadinfo"."NoticeType" IS '公告类型';
COMMENT ON COLUMN "public"."uploadinfo"."NoticeTime" IS '发布日期';
COMMENT ON COLUMN "public"."uploadinfo"."NoticeContent" IS '公告正文';
COMMENT ON COLUMN "public"."uploadinfo"."NoticeClub" IS '发文部门';
COMMENT ON COLUMN "public"."uploadinfo"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."uploadinfo"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."uploadinfo"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."uploadinfo"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."uploadinfo"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."uploadinfo" IS '公告表';

-- ----------------------------
-- Table structure for user_log
-- ----------------------------
DROP TABLE IF EXISTS "public"."user_log";
CREATE TABLE "public"."user_log" (
  "id" int4 NOT NULL,
  "user_key" varchar(100) COLLATE "pg_catalog"."default",
  "user_token" varchar(255) COLLATE "pg_catalog"."default",
  "datains_time" timestamp(6)
)
;
COMMENT ON TABLE "public"."user_log" IS '用户登录信息表';

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS "public"."userinfo";
CREATE TABLE "public"."userinfo" (
  "CustoNo" varchar(15) COLLATE "pg_catalog"."default" NOT NULL,
  "CustoName" varchar(15) COLLATE "pg_catalog"."default" NOT NULL,
  "CustoSex" int4 NOT NULL,
  "CustoTel" varchar(600) COLLATE "pg_catalog"."default" NOT NULL,
  "PassportType" int4 NOT NULL,
  "CustoID" varchar(600) COLLATE "pg_catalog"."default" NOT NULL,
  "CustoAdress" varchar(600) COLLATE "pg_catalog"."default",
  "CustoBirth" date NOT NULL,
  "CustoType" int4 NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."userinfo"."CustoNo" IS '用户编号';
COMMENT ON COLUMN "public"."userinfo"."CustoName" IS '用户名称';
COMMENT ON COLUMN "public"."userinfo"."CustoSex" IS '用户性别';
COMMENT ON COLUMN "public"."userinfo"."CustoTel" IS '用户电话';
COMMENT ON COLUMN "public"."userinfo"."PassportType" IS '证照类型';
COMMENT ON COLUMN "public"."userinfo"."CustoID" IS '证件号码';
COMMENT ON COLUMN "public"."userinfo"."CustoAdress" IS '居住地址';
COMMENT ON COLUMN "public"."userinfo"."CustoBirth" IS '出生日期';
COMMENT ON COLUMN "public"."userinfo"."CustoType" IS '客户类型';
COMMENT ON COLUMN "public"."userinfo"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."userinfo"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."userinfo"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."userinfo"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."userinfo"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."userinfo" IS '用户信息表';

-- ----------------------------
-- Table structure for usertype
-- ----------------------------
DROP TABLE IF EXISTS "public"."usertype";
CREATE TABLE "public"."usertype" (
  "UserType" int4 NOT NULL,
  "TypeName" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."usertype"."UserType" IS '客户类型ID';
COMMENT ON COLUMN "public"."usertype"."TypeName" IS '客户类型名称';
COMMENT ON COLUMN "public"."usertype"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."usertype"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."usertype"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."usertype"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."usertype"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."usertype" IS '用户类型表';

-- ----------------------------
-- Table structure for vip_rule
-- ----------------------------
DROP TABLE IF EXISTS "public"."vip_rule";
CREATE TABLE "public"."vip_rule" (
  "id" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "rule_id" varchar(64) COLLATE "pg_catalog"."default" NOT NULL,
  "rule_name" varchar(128) COLLATE "pg_catalog"."default" NOT NULL,
  "rule_value" numeric(32,2) NOT NULL,
  "type_id" int4 NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."vip_rule"."id" IS '索引ID';
COMMENT ON COLUMN "public"."vip_rule"."rule_id" IS '会员规则流水号';
COMMENT ON COLUMN "public"."vip_rule"."rule_name" IS '会员规则名称';
COMMENT ON COLUMN "public"."vip_rule"."rule_value" IS '预设数值';
COMMENT ON COLUMN "public"."vip_rule"."type_id" IS '会员等级';
COMMENT ON COLUMN "public"."vip_rule"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."vip_rule"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."vip_rule"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."vip_rule"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."vip_rule"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."vip_rule" IS '会员等级规则表';

-- ----------------------------
-- Table structure for worker
-- ----------------------------
DROP TABLE IF EXISTS "public"."worker";
CREATE TABLE "public"."worker" (
  "WorkerId" varchar(12) COLLATE "pg_catalog"."default" NOT NULL,
  "WorkerName" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "WorkerBirthday" timestamp(6) NOT NULL,
  "WorkerSex" int4 NOT NULL,
  "WorkerTel" varchar(300) COLLATE "pg_catalog"."default" NOT NULL,
  "WorkerClub" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "WorkerNation" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "WorkerAddress" varchar(600) COLLATE "pg_catalog"."default" NOT NULL,
  "WorkerPosition" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "CardID" varchar(600) COLLATE "pg_catalog"."default" NOT NULL,
  "WorkerPwd" varchar(600) COLLATE "pg_catalog"."default",
  "WorkerTime" timestamp(6) NOT NULL,
  "WorkerFace" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "WorkerEducation" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."worker"."WorkerId" IS '工号';
COMMENT ON COLUMN "public"."worker"."WorkerName" IS '名字';
COMMENT ON COLUMN "public"."worker"."WorkerBirthday" IS '出生日期';
COMMENT ON COLUMN "public"."worker"."WorkerSex" IS '性别';
COMMENT ON COLUMN "public"."worker"."WorkerTel" IS '电话';
COMMENT ON COLUMN "public"."worker"."WorkerClub" IS '部门';
COMMENT ON COLUMN "public"."worker"."WorkerNation" IS '民族';
COMMENT ON COLUMN "public"."worker"."WorkerAddress" IS '居住地址';
COMMENT ON COLUMN "public"."worker"."WorkerPosition" IS '职位';
COMMENT ON COLUMN "public"."worker"."CardID" IS '证件号码';
COMMENT ON COLUMN "public"."worker"."WorkerPwd" IS '系统密码';
COMMENT ON COLUMN "public"."worker"."WorkerTime" IS '入职时间';
COMMENT ON COLUMN "public"."worker"."WorkerFace" IS '面貌';
COMMENT ON COLUMN "public"."worker"."WorkerEducation" IS '学历';
COMMENT ON COLUMN "public"."worker"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."worker"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."worker"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."worker"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."worker"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."worker" IS '员工表';

-- ----------------------------
-- Table structure for workercheck
-- ----------------------------
DROP TABLE IF EXISTS "public"."workercheck";
CREATE TABLE "public"."workercheck" (
  "Id" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "WorkerNo" varchar(20) COLLATE "pg_catalog"."default",
  "CheckTime" timestamp(6),
  "CheckWay" varchar(80) COLLATE "pg_catalog"."default",
  "CheckState" int4,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."workercheck"."Id" IS '自增长ID';
COMMENT ON COLUMN "public"."workercheck"."WorkerNo" IS '工号';
COMMENT ON COLUMN "public"."workercheck"."CheckTime" IS '打卡时间';
COMMENT ON COLUMN "public"."workercheck"."CheckWay" IS '打卡方式';
COMMENT ON COLUMN "public"."workercheck"."CheckState" IS '打卡状态';
COMMENT ON COLUMN "public"."workercheck"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."workercheck"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."workercheck"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."workercheck"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."workercheck"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."workercheck" IS '员工打卡表';

-- ----------------------------
-- Table structure for workergoodbad
-- ----------------------------
DROP TABLE IF EXISTS "public"."workergoodbad";
CREATE TABLE "public"."workergoodbad" (
  "Id" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "WorkNo" varchar(50) COLLATE "pg_catalog"."default",
  "GBInfo" varchar(255) COLLATE "pg_catalog"."default",
  "GBType" int4,
  "GBOperation" varchar(200) COLLATE "pg_catalog"."default",
  "GBTime" timestamp(6),
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."workergoodbad"."Id" IS '自增长ID';
COMMENT ON COLUMN "public"."workergoodbad"."WorkNo" IS '工号';
COMMENT ON COLUMN "public"."workergoodbad"."GBInfo" IS '奖惩信息';
COMMENT ON COLUMN "public"."workergoodbad"."GBType" IS '奖惩类型';
COMMENT ON COLUMN "public"."workergoodbad"."GBOperation" IS '录入人';
COMMENT ON COLUMN "public"."workergoodbad"."GBTime" IS '录入时间';
COMMENT ON COLUMN "public"."workergoodbad"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."workergoodbad"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."workergoodbad"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."workergoodbad"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."workergoodbad"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."workergoodbad" IS '员工奖惩记录表';

-- ----------------------------
-- Table structure for workerhistory
-- ----------------------------
DROP TABLE IF EXISTS "public"."workerhistory";
CREATE TABLE "public"."workerhistory" (
  "Id" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "WorkerId" varchar(12) COLLATE "pg_catalog"."default" NOT NULL,
  "StartDate" timestamp(6) NOT NULL,
  "EndDate" timestamp(6) NOT NULL,
  "Position" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "Company" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."workerhistory"."Id" IS '自增长ID';
COMMENT ON COLUMN "public"."workerhistory"."WorkerId" IS '工号';
COMMENT ON COLUMN "public"."workerhistory"."StartDate" IS '开始时间';
COMMENT ON COLUMN "public"."workerhistory"."EndDate" IS '结束时间';
COMMENT ON COLUMN "public"."workerhistory"."Position" IS '职务';
COMMENT ON COLUMN "public"."workerhistory"."Company" IS '公司';
COMMENT ON COLUMN "public"."workerhistory"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."workerhistory"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."workerhistory"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."workerhistory"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."workerhistory"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."workerhistory" IS '员工履历表';

-- ----------------------------
-- Table structure for workerpic
-- ----------------------------
DROP TABLE IF EXISTS "public"."workerpic";
CREATE TABLE "public"."workerpic" (
  "Id" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "WorkerId" varchar(17) COLLATE "pg_catalog"."default",
  "Pic" varchar(255) COLLATE "pg_catalog"."default"
)
;
COMMENT ON COLUMN "public"."workerpic"."Id" IS '自增长流水号';
COMMENT ON COLUMN "public"."workerpic"."WorkerId" IS '工号';
COMMENT ON COLUMN "public"."workerpic"."Pic" IS '照片路径';

-- ----------------------------
-- Table structure for wtinfo
-- ----------------------------
DROP TABLE IF EXISTS "public"."wtinfo";
CREATE TABLE "public"."wtinfo" (
  "WtiNo" int4 NOT NULL DEFAULT nextval('upms_log_id_seq'::regclass),
  "RoomNo" varchar(8) COLLATE "pg_catalog"."default" NOT NULL,
  "UseDate" timestamp(6) NOT NULL,
  "EndDate" timestamp(6),
  "WaterUse" numeric(6,2) NOT NULL,
  "PowerUse" numeric(6,2) NOT NULL,
  "Record" varchar(8) COLLATE "pg_catalog"."default" NOT NULL,
  "CustoNo" varchar(15) COLLATE "pg_catalog"."default",
  "delete_mk" int4 NOT NULL,
  "datains_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datains_date" date,
  "datachg_usr" varchar(20) COLLATE "pg_catalog"."default",
  "datachg_date" date
)
;
COMMENT ON COLUMN "public"."wtinfo"."WtiNo" IS '记录编号';
COMMENT ON COLUMN "public"."wtinfo"."RoomNo" IS '房间编号';
COMMENT ON COLUMN "public"."wtinfo"."UseDate" IS '开始时间';
COMMENT ON COLUMN "public"."wtinfo"."EndDate" IS '结束时间';
COMMENT ON COLUMN "public"."wtinfo"."WaterUse" IS '用水情况';
COMMENT ON COLUMN "public"."wtinfo"."PowerUse" IS '用电情况';
COMMENT ON COLUMN "public"."wtinfo"."Record" IS '记录人';
COMMENT ON COLUMN "public"."wtinfo"."CustoNo" IS '客户编号';
COMMENT ON COLUMN "public"."wtinfo"."delete_mk" IS '删除标记';
COMMENT ON COLUMN "public"."wtinfo"."datains_usr" IS '资料创建人';
COMMENT ON COLUMN "public"."wtinfo"."datains_date" IS '资料创建时间';
COMMENT ON COLUMN "public"."wtinfo"."datachg_usr" IS '资料更新人';
COMMENT ON COLUMN "public"."wtinfo"."datachg_date" IS '资料更新时间';
COMMENT ON TABLE "public"."wtinfo" IS '水电费信息表';

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
SELECT setval('"public"."upms_log_id_seq"', 55, true);

-- ----------------------------
-- Primary Key structure for table admininfo
-- ----------------------------
ALTER TABLE "public"."admininfo" ADD CONSTRAINT "admininfo_pkey" PRIMARY KEY ("Id", "AdminAccount");

-- ----------------------------
-- Primary Key structure for table admintype
-- ----------------------------
ALTER TABLE "public"."admintype" ADD CONSTRAINT "admintype_pkey" PRIMARY KEY ("Id");

-- ----------------------------
-- Primary Key structure for table applicationversion
-- ----------------------------
ALTER TABLE "public"."applicationversion" ADD CONSTRAINT "applicationversion_pkey" PRIMARY KEY ("base_versionId");

-- ----------------------------
-- Primary Key structure for table backinfo
-- ----------------------------
ALTER TABLE "public"."backinfo" ADD CONSTRAINT "backinfo_pkey" PRIMARY KEY ("BackNo");

-- ----------------------------
-- Primary Key structure for table base
-- ----------------------------
ALTER TABLE "public"."base" ADD CONSTRAINT "base_pkey" PRIMARY KEY ("url_no");

-- ----------------------------
-- Primary Key structure for table cardcodes
-- ----------------------------
ALTER TABLE "public"."cardcodes" ADD CONSTRAINT "cardcodes_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table cashinfo
-- ----------------------------
ALTER TABLE "public"."cashinfo" ADD CONSTRAINT "cashinfo_pkey" PRIMARY KEY ("CashNo");

-- ----------------------------
-- Primary Key structure for table checkinfo
-- ----------------------------
ALTER TABLE "public"."checkinfo" ADD CONSTRAINT "checkinfo_pkey" PRIMARY KEY ("CheckNo");

-- ----------------------------
-- Primary Key structure for table counterrule
-- ----------------------------
ALTER TABLE "public"."counterrule" ADD CONSTRAINT "counterrule_pkey" PRIMARY KEY ("rule_id");

-- ----------------------------
-- Primary Key structure for table custospend
-- ----------------------------
ALTER TABLE "public"."custospend" ADD CONSTRAINT "custospend_pkey" PRIMARY KEY ("SpendId");

-- ----------------------------
-- Primary Key structure for table dept
-- ----------------------------
ALTER TABLE "public"."dept" ADD CONSTRAINT "dept_pkey" PRIMARY KEY ("dept_no");

-- ----------------------------
-- Primary Key structure for table education
-- ----------------------------
ALTER TABLE "public"."education" ADD CONSTRAINT "education_pkey" PRIMARY KEY ("education_no");

-- ----------------------------
-- Primary Key structure for table fonts
-- ----------------------------
ALTER TABLE "public"."fonts" ADD CONSTRAINT "fonts_pkey" PRIMARY KEY ("FontsId");

-- ----------------------------
-- Primary Key structure for table gbtype
-- ----------------------------
ALTER TABLE "public"."gbtype" ADD CONSTRAINT "gbtype_pkey" PRIMARY KEY ("GBTypeId");

-- ----------------------------
-- Primary Key structure for table module
-- ----------------------------
ALTER TABLE "public"."module" ADD CONSTRAINT "module_pkey" PRIMARY KEY ("module_id");

-- ----------------------------
-- Primary Key structure for table module_zero
-- ----------------------------
ALTER TABLE "public"."module_zero" ADD CONSTRAINT "module_zero_pkey" PRIMARY KEY ("module_id");

-- ----------------------------
-- Primary Key structure for table nation
-- ----------------------------
ALTER TABLE "public"."nation" ADD CONSTRAINT "nation_pkey" PRIMARY KEY ("nation_no", "nation_name");

-- ----------------------------
-- Primary Key structure for table operationlog
-- ----------------------------
ALTER TABLE "public"."operationlog" ADD CONSTRAINT "operationlog_pkey" PRIMARY KEY ("OperationId");

-- ----------------------------
-- Primary Key structure for table passporttype
-- ----------------------------
ALTER TABLE "public"."passporttype" ADD CONSTRAINT "passporttype_pkey" PRIMARY KEY ("PassportId");

-- ----------------------------
-- Primary Key structure for table position
-- ----------------------------
ALTER TABLE "public"."position" ADD CONSTRAINT "position_pkey" PRIMARY KEY ("position_no");

-- ----------------------------
-- Primary Key structure for table reser
-- ----------------------------
ALTER TABLE "public"."reser" ADD CONSTRAINT "reser_pkey" PRIMARY KEY ("ReserId");

-- ----------------------------
-- Primary Key structure for table room
-- ----------------------------
ALTER TABLE "public"."room" ADD CONSTRAINT "room_pkey" PRIMARY KEY ("RoomNo");

-- ----------------------------
-- Primary Key structure for table roomstate
-- ----------------------------
ALTER TABLE "public"."roomstate" ADD CONSTRAINT "roomstate_pkey" PRIMARY KEY ("RoomStateId");

-- ----------------------------
-- Primary Key structure for table roomtype
-- ----------------------------
ALTER TABLE "public"."roomtype" ADD CONSTRAINT "roomtype_pkey" PRIMARY KEY ("RoomType");

-- ----------------------------
-- Primary Key structure for table sellthing
-- ----------------------------
ALTER TABLE "public"."sellthing" ADD CONSTRAINT "sellthing_pkey" PRIMARY KEY ("SellNo");

-- ----------------------------
-- Primary Key structure for table sextype
-- ----------------------------
ALTER TABLE "public"."sextype" ADD CONSTRAINT "sextype_pkey" PRIMARY KEY ("sexId");

-- ----------------------------
-- Primary Key structure for table uploadinfo
-- ----------------------------
ALTER TABLE "public"."uploadinfo" ADD CONSTRAINT "uploadinfo_pkey" PRIMARY KEY ("NoticeNo");

-- ----------------------------
-- Primary Key structure for table user_log
-- ----------------------------
ALTER TABLE "public"."user_log" ADD CONSTRAINT "user_log_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table userinfo
-- ----------------------------
ALTER TABLE "public"."userinfo" ADD CONSTRAINT "userinfo_pkey" PRIMARY KEY ("CustoNo");

-- ----------------------------
-- Primary Key structure for table usertype
-- ----------------------------
ALTER TABLE "public"."usertype" ADD CONSTRAINT "usertype_pkey" PRIMARY KEY ("UserType");

-- ----------------------------
-- Primary Key structure for table vip_rule
-- ----------------------------
ALTER TABLE "public"."vip_rule" ADD CONSTRAINT "vip_rule_pkey" PRIMARY KEY ("id", "rule_id");

-- ----------------------------
-- Primary Key structure for table worker
-- ----------------------------
ALTER TABLE "public"."worker" ADD CONSTRAINT "worker_pkey" PRIMARY KEY ("WorkerId");

-- ----------------------------
-- Primary Key structure for table workercheck
-- ----------------------------
ALTER TABLE "public"."workercheck" ADD CONSTRAINT "workercheck_pkey" PRIMARY KEY ("Id");

-- ----------------------------
-- Primary Key structure for table workergoodbad
-- ----------------------------
ALTER TABLE "public"."workergoodbad" ADD CONSTRAINT "workergoodbad_pkey" PRIMARY KEY ("Id");

-- ----------------------------
-- Primary Key structure for table workerhistory
-- ----------------------------
ALTER TABLE "public"."workerhistory" ADD CONSTRAINT "workerhistory_pkey" PRIMARY KEY ("Id");

-- ----------------------------
-- Primary Key structure for table workerpic
-- ----------------------------
ALTER TABLE "public"."workerpic" ADD CONSTRAINT "workerpic_pkey" PRIMARY KEY ("Id");

-- ----------------------------
-- Primary Key structure for table wtinfo
-- ----------------------------
ALTER TABLE "public"."wtinfo" ADD CONSTRAINT "wtinfo_pkey" PRIMARY KEY ("WtiNo");
