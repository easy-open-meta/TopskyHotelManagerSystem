SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admininfo
-- ----------------------------
DROP TABLE IF EXISTS `admininfo`;
CREATE TABLE `admininfo`  (
  `Id` int(11) NOT NULL COMMENT '自增长ID',
  `AdminAccount` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '管理员账号',
  `AdminPassword` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '管理员密码',
  `AdminType` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '管理员类型',
  `AdminName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '管理员名称',
  `IsAdmin` int(11) NULL DEFAULT NULL COMMENT '是否为超级管理员',
  `DeleteMk` int(11) NULL DEFAULT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料新增人',
  `datains_time` date NULL DEFAULT NULL COMMENT '资料新增时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_time` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`Id`, `AdminAccount`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '管理员信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for admintype
-- ----------------------------
DROP TABLE IF EXISTS `admintype`;
CREATE TABLE `admintype`  (
  `Id` int(11) NOT NULL COMMENT '编号',
  `type_id` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '管理员类型',
  `type_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '管理员类型名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '管理员类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for applicationversion
-- ----------------------------
DROP TABLE IF EXISTS `applicationversion`;
CREATE TABLE `applicationversion`  (
  `base_versionId` smallint(6) NOT NULL COMMENT '流水号',
  `base_version` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '版本号',
  PRIMARY KEY (`base_versionId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '应用程序版本控制表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for backinfo
-- ----------------------------
DROP TABLE IF EXISTS `backinfo`;
CREATE TABLE `backinfo`  (
  `BackNo` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '物资编号',
  `BackName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '物资名称',
  `BackSource` varchar(18) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '物资来源',
  `BackCash` decimal(6, 2) NOT NULL COMMENT '物资金额',
  `BackType` int(11) NOT NULL COMMENT '物资类型',
  `BackPerson` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '经办人',
  `ControlClub` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '管理部门',
  `BackClub` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '所属部门',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`BackNo`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '酒店物资表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for base
-- ----------------------------
DROP TABLE IF EXISTS `base`;
CREATE TABLE `base`  (
  `url_no` int(11) NOT NULL COMMENT 'ID',
  `url_addr` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '地址',
  PRIMARY KEY (`url_no`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '程序信息配置表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for cardcodes
-- ----------------------------
DROP TABLE IF EXISTS `cardcodes`;
CREATE TABLE `cardcodes`  (
  `id` bigint(20) NOT NULL COMMENT '编号',
  `Province` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '省份',
  `City` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '城市',
  `District` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '地区',
  `bm` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '地区识别码',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '身份证地区识别码表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for cashinfo
-- ----------------------------
DROP TABLE IF EXISTS `cashinfo`;
CREATE TABLE `cashinfo`  (
  `CashNo` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '资产编号',
  `CashName` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '资产名称',
  `CashPrice` decimal(10, 2) NOT NULL COMMENT '资产总值',
  `CashClub` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '所属部门',
  `CashTime` datetime NOT NULL COMMENT '入库时间',
  `CashSource` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '资产来源',
  `CashPerson` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '资产经办人',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`CashNo`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '酒店资产表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for checkinfo
-- ----------------------------
DROP TABLE IF EXISTS `checkinfo`;
CREATE TABLE `checkinfo`  (
  `CheckNo` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '监管统计编号',
  `CheckClub` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '受监管部门',
  `CheckProgres` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '受监管部门总体概述',
  `CheckCash` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '受监管部门交易情况',
  `CheckScore` int(11) NOT NULL COMMENT '受监管部门得分情况',
  `CheckPerson` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '本次监管负责人',
  `CheckAdvice` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '监管建议',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`CheckNo`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '监管统计表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for counterrule
-- ----------------------------
DROP TABLE IF EXISTS `counterrule`;
CREATE TABLE `counterrule`  (
  `rule_id` int(11) NOT NULL COMMENT '规则编号',
  `rule_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规格名称',
  `rule_desc` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规则描述',
  `now_id` int(11) NULL DEFAULT NULL COMMENT '当前ID',
  `prefix_name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规则简写',
  `custo_format` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规则格式',
  `number_format` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '编号前缀',
  `separating_char` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规则分割符',
  `datains_usrid` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料新增人',
  `datains_time` datetime NULL DEFAULT NULL COMMENT '资料新增时间',
  `datachg_usrid` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_time` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`rule_id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '业务流水号规则表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for custospend
-- ----------------------------
DROP TABLE IF EXISTS `custospend`;
CREATE TABLE `custospend`  (
  `SpendId` int(11) NOT NULL COMMENT '记录编号',
  `RoomNo` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间编号',
  `CustoNo` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '客户编号',
  `SpendName` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '商品名称',
  `SpendAmount` int(11) NOT NULL COMMENT '商品数量',
  `SpendPrice` decimal(10, 2) NOT NULL COMMENT '商品价格',
  `SpendMoney` decimal(10, 2) NOT NULL COMMENT '消费总额',
  `SpendTime` datetime NOT NULL COMMENT '消费时间',
  `MoneyState` varchar(9) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '结算状态',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`SpendId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '商品消费表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for dept
-- ----------------------------
DROP TABLE IF EXISTS `dept`;
CREATE TABLE `dept`  (
  `dept_no` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '部门编号',
  `dept_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '部门名称',
  `dept_desc` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '部门描述',
  `dept_date` date NULL DEFAULT NULL COMMENT '创建时间(部门)',
  `dept_leader` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '部门主管',
  `dept_parent` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '上级部门',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`dept_no`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '部门表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for education
-- ----------------------------
DROP TABLE IF EXISTS `education`;
CREATE TABLE `education`  (
  `education_no` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学历编号',
  `education_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '学历名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`education_no`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '学历表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for fonts
-- ----------------------------
DROP TABLE IF EXISTS `fonts`;
CREATE TABLE `fonts`  (
  `FontsId` int(11) NOT NULL COMMENT 'ID',
  `FontsMess` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '文字信息',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`FontsId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '主页跑马灯信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for gbtype
-- ----------------------------
DROP TABLE IF EXISTS `gbtype`;
CREATE TABLE `gbtype`  (
  `GBTypeId` int(11) NOT NULL COMMENT '奖惩类型ID',
  `GBName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '奖惩类型名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`GBTypeId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '奖惩类型' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for module
-- ----------------------------
DROP TABLE IF EXISTS `module`;
CREATE TABLE `module`  (
  `module_id` int(11) NOT NULL COMMENT '模块ID',
  `module_name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '模块名称',
  `module_desc` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '模块描述',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料新增人',
  `datains_time` date NULL DEFAULT NULL COMMENT '资料新增时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_time` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`module_id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '系统模块表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for module_zero
-- ----------------------------
DROP TABLE IF EXISTS `module_zero`;
CREATE TABLE `module_zero`  (
  `module_id` int(11) NOT NULL COMMENT '模块ID',
  `admin_account` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '管理员账号',
  `module_name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '模块名称',
  `module_enable` int(11) NULL DEFAULT NULL COMMENT '是否开启',
  PRIMARY KEY (`module_id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '系统模块权限表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for nation
-- ----------------------------
DROP TABLE IF EXISTS `nation`;
CREATE TABLE `nation`  (
  `nation_no` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '民族编号',
  `nation_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '民族名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`nation_no`, `nation_name`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '民族信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for operationlog
-- ----------------------------
DROP TABLE IF EXISTS `operationlog`;
CREATE TABLE `operationlog`  (
  `OperationId` bigint(20) NOT NULL COMMENT '记录ID',
  `OperationTime` datetime NOT NULL COMMENT '记录时间',
  `LogContent` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '日志内容',
  `OperationAccount` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '被记录账户',
  `OperationLevel` int(11) NULL DEFAULT NULL COMMENT '日志等级',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  `SoftwareVersion` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '软件版本',
  `login_ip` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '登录IP',
  PRIMARY KEY (`OperationId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '系统操作日志表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for passporttype
-- ----------------------------
DROP TABLE IF EXISTS `passporttype`;
CREATE TABLE `passporttype`  (
  `PassportId` int(11) NOT NULL COMMENT '证件类型ID',
  `PassportName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '证件类型名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`PassportId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '证件类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for pdman_db_version
-- ----------------------------
DROP TABLE IF EXISTS `pdman_db_version`;
CREATE TABLE `pdman_db_version`  (
  `DB_VERSION` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL,
  `VERSION_DESC` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL,
  `CREATED_TIME` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for position
-- ----------------------------
DROP TABLE IF EXISTS `position`;
CREATE TABLE `position`  (
  `position_no` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '职位编号',
  `position_name` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '职位名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`position_no`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '职位表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for reser
-- ----------------------------
DROP TABLE IF EXISTS `reser`;
CREATE TABLE `reser`  (
  `ReserId` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '预约ID ',
  `CustoName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '客户名字',
  `CustoTel` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL COMMENT '联系方式',
  `ReserWay` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL COMMENT '预约方式',
  `ReserRoom` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL COMMENT '预约房号',
  `ReserDate` date NULL DEFAULT NULL COMMENT '预约开始日期',
  `ReserEndDay` date NULL DEFAULT NULL COMMENT '预约结束日期',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`ReserId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '预约表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for room
-- ----------------------------
DROP TABLE IF EXISTS `room`;
CREATE TABLE `room`  (
  `RoomNo` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间编号',
  `RoomType` int(11) NOT NULL COMMENT '房间类型',
  `CustoNo` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '客户编号',
  `CheckTime` datetime NULL DEFAULT NULL COMMENT '入住时间',
  `CheckOutTime` datetime NULL DEFAULT NULL COMMENT '退房时间',
  `RoomStateId` int(11) NOT NULL COMMENT '房间状态',
  `RoomMoney` decimal(10, 2) NULL DEFAULT NULL COMMENT '房间单价',
  `RoomPosition` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间位置',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  `deposit` decimal(10, 2) NULL DEFAULT NULL COMMENT '房间押金',
  PRIMARY KEY (`RoomNo`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '房间表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for roomstate
-- ----------------------------
DROP TABLE IF EXISTS `roomstate`;
CREATE TABLE `roomstate`  (
  `RoomStateId` int(11) NOT NULL COMMENT '房间状态ID',
  `RoomState` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间状态名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`RoomStateId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '房间状态表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for roomtype
-- ----------------------------
DROP TABLE IF EXISTS `roomtype`;
CREATE TABLE `roomtype`  (
  `RoomType` int(11) NOT NULL COMMENT '房间类型ID',
  `RoomName` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间类型名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`RoomType`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '房间类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sellthing
-- ----------------------------
DROP TABLE IF EXISTS `sellthing`;
CREATE TABLE `sellthing`  (
  `SellNo` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '商品编号',
  `SellName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '商品名称',
  `SellPrice` decimal(10, 2) NOT NULL COMMENT '商品价格',
  `format` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规格型号',
  `Stock` decimal(16, 2) NOT NULL COMMENT '库存数量',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`SellNo`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '商品表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sextype
-- ----------------------------
DROP TABLE IF EXISTS `sextype`;
CREATE TABLE `sextype`  (
  `sexId` int(11) NOT NULL COMMENT '性别ID',
  `sexName` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '性别名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`sexId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '性别类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for uploadinfo
-- ----------------------------
DROP TABLE IF EXISTS `uploadinfo`;
CREATE TABLE `uploadinfo`  (
  `NoticeNo` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '公告编号',
  `Noticetheme` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '公告主题',
  `NoticeType` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '公告类型',
  `NoticeTime` datetime NOT NULL COMMENT '发布日期',
  `NoticeContent` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '公告正文',
  `NoticeClub` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '发文部门',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`NoticeNo`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '公告表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for user_log
-- ----------------------------
DROP TABLE IF EXISTS `user_log`;
CREATE TABLE `user_log`  (
  `id` int(11) NOT NULL,
  `user_key` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `user_token` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `datains_time` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '用户登录信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS `userinfo`;
CREATE TABLE `userinfo`  (
  `CustoNo` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '用户编号',
  `CustoName` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '用户名称',
  `CustoSex` int(11) NOT NULL COMMENT '用户性别',
  `CustoTel` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '用户电话',
  `PassportType` int(11) NOT NULL COMMENT '证照类型',
  `CustoID` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '证件号码',
  `CustoAdress` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL COMMENT '居住地址',
  `CustoBirth` date NOT NULL COMMENT '出生日期',
  `CustoType` int(11) NOT NULL COMMENT '客户类型',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`CustoNo`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '用户信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for usertype
-- ----------------------------
DROP TABLE IF EXISTS `usertype`;
CREATE TABLE `usertype`  (
  `UserType` int(11) NOT NULL COMMENT '客户类型ID',
  `TypeName` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '客户类型名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`UserType`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '用户类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for vip_rule
-- ----------------------------
DROP TABLE IF EXISTS `vip_rule`;
CREATE TABLE `vip_rule`  (
  `id` int(11) NOT NULL COMMENT '索引ID',
  `rule_id` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '会员规则流水号',
  `rule_name` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '会员规则名称',
  `rule_value` decimal(32, 2) NOT NULL COMMENT '预设数值',
  `type_id` int(11) NOT NULL COMMENT '会员等级',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `rule_id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '会员等级规则表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for worker
-- ----------------------------
DROP TABLE IF EXISTS `worker`;
CREATE TABLE `worker`  (
  `WorkerId` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '工号',
  `WorkerName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '名字',
  `WorkerBirthday` datetime NOT NULL COMMENT '出生日期',
  `WorkerSex` int(11) NOT NULL COMMENT '性别',
  `WorkerTel` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '电话',
  `WorkerClub` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '部门',
  `WorkerNation` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '民族',
  `WorkerAddress` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '居住地址',
  `WorkerPosition` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '职位',
  `CardID` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '证件号码',
  `WorkerPwd` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL COMMENT '系统密码',
  `WorkerTime` datetime NOT NULL COMMENT '入职时间',
  `WorkerFace` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '面貌',
  `WorkerEducation` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学历',
  `delete_mk` int(11) NULL DEFAULT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`WorkerId`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '员工表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for workercheck
-- ----------------------------
DROP TABLE IF EXISTS `workercheck`;
CREATE TABLE `workercheck`  (
  `Id` int(11) NOT NULL COMMENT '自增长ID',
  `WorkerNo` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '工号',
  `CheckTime` datetime NULL DEFAULT NULL COMMENT '打卡时间',
  `CheckWay` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '打卡方式',
  `CheckState` int(11) NULL DEFAULT NULL COMMENT '打卡状态',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '员工打卡表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for workergoodbad
-- ----------------------------
DROP TABLE IF EXISTS `workergoodbad`;
CREATE TABLE `workergoodbad`  (
  `Id` int(11) NOT NULL COMMENT '自增长ID',
  `WorkNo` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '工号',
  `GBInfo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '奖惩信息',
  `GBType` int(11) NULL DEFAULT NULL COMMENT '奖惩类型',
  `GBOperation` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '录入人',
  `GBTime` datetime NULL DEFAULT NULL COMMENT '录入时间',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '员工奖惩记录表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for workerhistory
-- ----------------------------
DROP TABLE IF EXISTS `workerhistory`;
CREATE TABLE `workerhistory`  (
  `Id` int(11) NOT NULL COMMENT '自增长ID',
  `WorkerId` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '工号',
  `StartDate` datetime NOT NULL COMMENT '开始时间',
  `EndDate` datetime NOT NULL COMMENT '结束时间',
  `Position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '职务',
  `Company` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '公司',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '员工履历表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for workerpic
-- ----------------------------
DROP TABLE IF EXISTS `workerpic`;
CREATE TABLE `workerpic`  (
  `Id` int(11) NOT NULL COMMENT '自增长流水号',
  `WorkerId` varchar(17) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '工号',
  `Pic` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '照片路径',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for wtinfo
-- ----------------------------
DROP TABLE IF EXISTS `wtinfo`;
CREATE TABLE `wtinfo`  (
  `WtiNo` smallint(6) NOT NULL COMMENT '记录编号',
  `RoomNo` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间编号',
  `UseDate` datetime NOT NULL COMMENT '开始时间',
  `EndDate` datetime NULL DEFAULT NULL COMMENT '结束时间',
  `WaterUse` decimal(6, 2) NOT NULL COMMENT '用水情况',
  `PowerUse` decimal(6, 2) NOT NULL COMMENT '用电情况',
  `Record` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '记录人',
  `CustoNo` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '客户编号',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`WtiNo`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '水电费信息表' ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
