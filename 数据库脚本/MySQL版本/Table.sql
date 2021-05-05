SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admininfo
-- ----------------------------
DROP TABLE IF EXISTS `admininfo`;
CREATE TABLE `admininfo`  (
  `AdminAccount` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '管理员账号',
  `AdminPassword` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '管理员密码',
  `AdminType` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '管理员类型',
  `AdminName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '管理员名称',
  `IsAdmin` int NOT NULL COMMENT '是否为超级管理员',
  `DeleteMk` int NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料新增人',
  `datains_time` date NULL DEFAULT NULL COMMENT '资料新增时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_time` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`AdminAccount`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for admintype
-- ----------------------------
DROP TABLE IF EXISTS `admintype`;
CREATE TABLE `admintype`  (
  `type_id` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '管理员类型',
  `type_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '管理员类型名称',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`type_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for applicationversion
-- ----------------------------
DROP TABLE IF EXISTS `applicationversion`;
CREATE TABLE `applicationversion`  (
  `base_versionId` int NOT NULL AUTO_INCREMENT COMMENT '流水号',
  `base_version` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '版本号',
  PRIMARY KEY (`base_versionId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for backinfo
-- ----------------------------
DROP TABLE IF EXISTS `backinfo`;
CREATE TABLE `backinfo`  (
  `BackNo` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '物资编号',
  `BackName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '物资名称',
  `BackSource` varchar(18) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '物资来源',
  `BackCash` decimal(6, 2) NOT NULL COMMENT '物资金额',
  `BackType` int NOT NULL COMMENT '物资类型',
  `BackPerson` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '经办人',
  `ControlClub` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '管理部门',
  `BackClub` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '所属部门',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`BackNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for base
-- ----------------------------
DROP TABLE IF EXISTS `base`;
CREATE TABLE `base`  (
  `url_no` int NOT NULL COMMENT 'ID',
  `url_addr` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '地址',
  PRIMARY KEY (`url_no`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for cardcodes
-- ----------------------------
DROP TABLE IF EXISTS `cardcodes`;
CREATE TABLE `cardcodes`  (
  `id` bigint NOT NULL COMMENT '编号',
  `Province` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '省份',
  `City` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '城市',
  `District` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '地区',
  `bm` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '地区识别码',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for cashinfo
-- ----------------------------
DROP TABLE IF EXISTS `cashinfo`;
CREATE TABLE `cashinfo`  (
  `CashNo` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '资产编号',
  `CashName` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '资产名称',
  `CashPrice` decimal(10, 2) NOT NULL COMMENT '资产总值',
  `CashClub` varchar(800) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '所属部门',
  `CashTime` datetime(0) NOT NULL COMMENT '入库时间',
  `CashSource` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '资产来源',
  `CashPerson` varchar(800) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '资产经办人',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`CashNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for checkinfo
-- ----------------------------
DROP TABLE IF EXISTS `checkinfo`;
CREATE TABLE `checkinfo`  (
  `CheckNo` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '监管统计编号',
  `CheckClub` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '受监管部门',
  `CheckProgres` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '受监管部门总体概述',
  `CheckCash` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '受监管部门交易情况',
  `CheckScore` int NOT NULL COMMENT '受监管部门得分情况',
  `CheckPerson` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '本次监管负责人',
  `CheckAdvice` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '监管建议',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`CheckNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for counterrule
-- ----------------------------
DROP TABLE IF EXISTS `counterrule`;
CREATE TABLE `counterrule`  (
  `rule_id` int NOT NULL AUTO_INCREMENT COMMENT '规则编号',
  `rule_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '规格名称',
  `rule_desc` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '规则描述',
  `now_id` int NULL DEFAULT NULL COMMENT '当前ID',
  `prefix_name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '规则简写',
  `custo_format` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '规则格式',
  `number_format` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '编号前缀',
  `separating_char` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '规则分割符',
  `datains_usrid` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料新增人',
  `datains_time` datetime(0) NULL DEFAULT NULL COMMENT '资料新增时间',
  `datachg_usrid` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_time` datetime(0) NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`rule_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for custospend
-- ----------------------------
DROP TABLE IF EXISTS `custospend`;
CREATE TABLE `custospend`  (
  `SpendId` int NOT NULL AUTO_INCREMENT COMMENT '记录编号',
  `RoomNo` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '房间编号',
  `CustoNo` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '客户编号',
  `SpendName` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '商品名称',
  `SpendAmount` int NOT NULL COMMENT '商品数量',
  `SpendPrice` decimal(10, 2) NOT NULL COMMENT '商品价格',
  `SpendMoney` decimal(10, 2) NOT NULL COMMENT '消费总额',
  `SpendTime` datetime(0) NOT NULL COMMENT '消费时间',
  `MoneyState` varchar(9) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '结算状态',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`SpendId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 78 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for dept
-- ----------------------------
DROP TABLE IF EXISTS `dept`;
CREATE TABLE `dept`  (
  `dept_no` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '部门编号',
  `dept_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '部门名称',
  `dept_desc` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '部门描述',
  `dept_date` date NULL DEFAULT NULL COMMENT '创建时间(部门)',
  `dept_leader` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '部门主管',
  `dept_parent` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '上级部门',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`dept_no`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for education
-- ----------------------------
DROP TABLE IF EXISTS `education`;
CREATE TABLE `education`  (
  `education_no` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '学历编号',
  `education_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '学历名称',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`education_no`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for fonts
-- ----------------------------
DROP TABLE IF EXISTS `fonts`;
CREATE TABLE `fonts`  (
  `FontsId` int NOT NULL AUTO_INCREMENT,
  `FontsMess` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`FontsId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for gbtype
-- ----------------------------
DROP TABLE IF EXISTS `gbtype`;
CREATE TABLE `gbtype`  (
  `GBTypeId` int NOT NULL,
  `GBName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`GBTypeId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for module
-- ----------------------------
DROP TABLE IF EXISTS `module`;
CREATE TABLE `module`  (
  `module_id` varchar(30) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '模块流水号',
  `module_name` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '模块名称',
  `module_desc` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '模块描述',
  `module_url` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '模块地址',
  `datains_usr` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '新增数据USR',
  `datains_date` datetime(0) NULL DEFAULT NULL COMMENT '新增数据时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '更新数据USR',
  `datachg_date` datetime(0) NULL DEFAULT NULL COMMENT '更新数据时间',
  PRIMARY KEY (`module_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for moneyinfo
-- ----------------------------
DROP TABLE IF EXISTS `moneyinfo`;
CREATE TABLE `moneyinfo`  (
  `MoneyNo` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `MoneyType` int NOT NULL,
  `MoneyIn` decimal(10, 2) NOT NULL,
  `MoneyOut` decimal(10, 2) NOT NULL,
  `MoneyCheck` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `MoneyPerson` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Remarks` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`MoneyNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for nation
-- ----------------------------
DROP TABLE IF EXISTS `nation`;
CREATE TABLE `nation`  (
  `nation_no` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '民族编号',
  `nation_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '民族名称',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`nation_no`, `nation_name`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for operationlog
-- ----------------------------
DROP TABLE IF EXISTS `operationlog`;
CREATE TABLE `operationlog`  (
  `OperationId` bigint NOT NULL AUTO_INCREMENT,
  `OperationTime` datetime(0) NOT NULL,
  `OperationLog` varchar(8000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `OperationAccount` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`OperationId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for passporttype
-- ----------------------------
DROP TABLE IF EXISTS `passporttype`;
CREATE TABLE `passporttype`  (
  `PassportId` int NOT NULL,
  `PassportName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`PassportId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for position
-- ----------------------------
DROP TABLE IF EXISTS `position`;
CREATE TABLE `position`  (
  `position_no` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '职位编号',
  `position_name` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '职位名称',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`position_no`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for reser
-- ----------------------------
DROP TABLE IF EXISTS `reser`;
CREATE TABLE `reser`  (
  `ReserId` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CustoName` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `CustoTel` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ReserWay` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ReserRoom` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ReserDate` date NULL DEFAULT NULL,
  `ReserEndDay` date NULL DEFAULT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`ReserId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for room
-- ----------------------------
DROP TABLE IF EXISTS `room`;
CREATE TABLE `room`  (
  `RoomNo` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '房间编号',
  `RoomType` int NOT NULL DEFAULT 1 COMMENT '房间类型',
  `CustoNo` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '' COMMENT '客户编号',
  `CheckTime` datetime(0) NULL DEFAULT NULL COMMENT '入住时间',
  `CheckOutTime` datetime(0) NULL DEFAULT NULL COMMENT '退房时间',
  `RoomStateId` int NOT NULL DEFAULT 0 COMMENT '房间状态',
  `RoomMoney` decimal(10, 2) NULL DEFAULT NULL COMMENT '房间单价',
  `RoomPosition` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '房间位置',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`RoomNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for roomstate
-- ----------------------------
DROP TABLE IF EXISTS `roomstate`;
CREATE TABLE `roomstate`  (
  `RoomStateId` int NOT NULL DEFAULT 0,
  `RoomState` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`RoomStateId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for roomtype
-- ----------------------------
DROP TABLE IF EXISTS `roomtype`;
CREATE TABLE `roomtype`  (
  `RoomType` int NOT NULL,
  `RoomName` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`RoomType`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for sellthing
-- ----------------------------
DROP TABLE IF EXISTS `sellthing`;
CREATE TABLE `sellthing`  (
  `SellNo` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '商品编号',
  `SellName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '商品名称',
  `SellPrice` decimal(10, 2) NOT NULL COMMENT '商品价格',
  `format` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '规格型号',
  `Stock` int NOT NULL COMMENT '库存数量',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`SellNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for sextype
-- ----------------------------
DROP TABLE IF EXISTS `sextype`;
CREATE TABLE `sextype`  (
  `sexId` int NOT NULL COMMENT '性别ID',
  `sexName` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '性别名称',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`sexId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for spendtype
-- ----------------------------
DROP TABLE IF EXISTS `spendtype`;
CREATE TABLE `spendtype`  (
  `SpendType` int NOT NULL,
  `TypeName` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`SpendType`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for uploadinfo
-- ----------------------------
DROP TABLE IF EXISTS `uploadinfo`;
CREATE TABLE `uploadinfo`  (
  `NoticeNo` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '公告编号',
  `Noticetheme` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '公告主题',
  `NoticeType` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '公告类型',
  `NoticeTime` datetime(0) NOT NULL COMMENT '发布日期',
  `NoticeContent` varchar(8000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '公告正文',
  `NoticeClub` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '发文部门',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`NoticeNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS `userinfo`;
CREATE TABLE `userinfo`  (
  `CustoNo` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '用户编号',
  `CustoName` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '用户名称',
  `CustoSex` int NOT NULL COMMENT '用户性别',
  `CustoTel` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '用户电话',
  `PassportType` int NOT NULL COMMENT '证照类型',
  `CustoID` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '证件号码',
  `CustoAdress` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '居住地址',
  `CustoBirth` date NOT NULL COMMENT '出生日期',
  `CustoType` int NOT NULL COMMENT '客户类型',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`CustoNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for usertype
-- ----------------------------
DROP TABLE IF EXISTS `usertype`;
CREATE TABLE `usertype`  (
  `UserType` int NOT NULL,
  `TypeName` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`UserType`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for worker
-- ----------------------------
DROP TABLE IF EXISTS `worker`;
CREATE TABLE `worker`  (
  `WorkerId` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '工号',
  `WorkerName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '名字',
  `WorkerBirthday` datetime(0) NOT NULL COMMENT '出生日期',
  `WorkerSex` int NOT NULL COMMENT '性别',
  `WorkerTel` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '电话',
  `WorkerClub` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '部门',
  `WorkerNation` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '民族',
  `WorkerAddress` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '居住地址',
  `WorkerPosition` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '职位',
  `CardID` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '证件号码',
  `WorkerPwd` varchar(600) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '123456' COMMENT '系统密码',
  `WorkerTime` datetime(0) NOT NULL COMMENT '入职时间',
  `WorkerFace` varchar(4) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '面貌',
  `WorkerEducation` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '学历',
  `delete_mk` int UNSIGNED NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`WorkerId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for workercheck
-- ----------------------------
DROP TABLE IF EXISTS `workercheck`;
CREATE TABLE `workercheck`  (
  `Id` int NOT NULL AUTO_INCREMENT,
  `WorkerNo` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `CheckTime` datetime(0) NULL DEFAULT NULL,
  `CheckWay` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `CheckState` int NULL DEFAULT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for workergoodbad
-- ----------------------------
DROP TABLE IF EXISTS `workergoodbad`;
CREATE TABLE `workergoodbad`  (
  `Id` int NOT NULL AUTO_INCREMENT,
  `WorkNo` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `GBInfo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `GBType` int NULL DEFAULT NULL,
  `GBOperation` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `GBTime` datetime(0) NULL DEFAULT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for workerhistory
-- ----------------------------
DROP TABLE IF EXISTS `workerhistory`;
CREATE TABLE `workerhistory`  (
  `Id` int NOT NULL AUTO_INCREMENT,
  `WorkerId` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `StartDate` datetime(0) NOT NULL,
  `EndDate` datetime(0) NOT NULL,
  `Position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Company` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Table structure for wtinfo
-- ----------------------------
DROP TABLE IF EXISTS `wtinfo`;
CREATE TABLE `wtinfo`  (
  `WtiNo` int NOT NULL AUTO_INCREMENT COMMENT '记录编号',
  `RoomNo` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '房间编号',
  `UseDate` datetime(0) NOT NULL COMMENT '开始时间',
  `EndDate` datetime(0) NULL DEFAULT NULL COMMENT '结束时间',
  `WaterUse` decimal(6, 2) NOT NULL COMMENT '用水情况',
  `PowerUse` decimal(6, 2) NOT NULL COMMENT '用电情况',
  `Record` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '记录人',
  `CustoNo` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '客户编号',
  `delete_mk` int NOT NULL DEFAULT 0 COMMENT '删除标记',
  `datains_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` date NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` date NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`WtiNo`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 39 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

SET FOREIGN_KEY_CHECKS = 1;
