## 基础核心类库jvncorelib(适用全平台)

### 一、安装部署

#### 		 1、打开管理Nu-get包命令行，输入如下代码：

```C#
Install-Package jvncorelib -Version 1.0.1.7
```

####     	2、安装完成后，在需要用到的地方写上如下代码：

```C#
using jvncorelib;  //.Net Core3.1+/.Net 5引用,默认加载所有类库，按需引入请查看“引用参照表”
using jvncorelib_fr;  //.Net Framework 4.6+引用,默认加载所有类库，按需引入请查看“引用参照表”

static void Main(string[] args)
{
  #region 加/解密
  EncryptLib encryptLib= new EncryptLib();
  var str = "需要加密的字符串！";
  //获得加密后的字符串
  var encryptedStr = encryptLib.Encryption(str);
  Console.WriteLine(encryptedStr);
  //解密加密后的字符串
  var deEncryptStr = encryptLib.Decryption(encryptedStr);
  //对比密文
  var str1 = "需要加密的字符串！";
  var encryptedSt1r = encryptLib.Encryption(str1);
  var result = encryptLib.Compare(encryptedStr,encryptedSt1r);
  Console.WriteLine(deEncryptStr);
  #endregion
  
  #region 流水号生成
  UniqueCode uniqueCode= new UniqueCode();
  //生成不带业务前缀的普通流水号
  List<string> result = uniqueCode.GetListNewId(10);
  //生成带业务前缀的业务流水号(多条)
  result = uniqueCode.GetListNewId("JVN",10);
  //生成带业务前缀的业务流水号(单条)
  string _result = uniqueCode.GetNewId("JVN");
  Console.WriteLine(string.Join("\n",result));
  Console.WriteLine(result);
  #endregion
      
  #region 实体扩展类库
  var value = string.Empty;
  var result = value.IsNullOrEmpty() ? false : true;
  #endregion
      
  #region 时间类库
  var result = "2021-5-6 12:00:59";
  var newResult = TimeExtend.StringFormat(result);
  var result = DateTime.Now;
  var newResult = TimeExtend.DateTimeFormat(result,TimeType);  
  Console.WriteLine(newResult);
  var result1 = TimeExtend.GetFirstAndLastDate(DateClass.Month,new DateTime(2021,4,15));
  Console.WriteLine(result1.StartDate + "-" + result1.EndDate);
  var listDateTime = TimeExtend.GetDateRange(startDate,endDate,RangeType.Month);
  #endregion
      
  #region GUID扩展类库
  var result = new List<string>();
  for (int i = 0; i < 2000; i++)
  {
     result.Add(new GuidExtend().GetGUID(Word.UpperCase,true));
     result.Add(new GuidExtend().GetGUID(Word.LowCase,"AA-"));
  }    
  Console.WriteLine(string.Join("\n",result));
  #endregion
}

#region Http请求工具类
RequestUtil util = new RequestUtil();
Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
keyValuePairs.Add("id", "1");
var checkInfo = new CheckInfo
{
    WorkerNo = "WK010",
    CheckTime = DateTime.Now.ToLocalTime(),
    CheckWay = "系统界面2333333333333333",
    CheckState = 0
};
var finalJSON = util.ObjectToJson(checkInfo);
var result = util.DoGet("http://localhost:33610/api/Base/Base", keyValuePairs);
var postResult = util.DoPost("http://localhost:36101/api/WorkerCheck/AddCheckInfo", finalJSON);
Console.WriteLine(string.Join("\n",result));
#endregion
```

### 二、引用参照表(仅针对1.0.1.1之后版本)

|    类库名称    | 命名空间(.Net Core 3.1+/.Net 5) |   命名空间(.Net Framework 4.6+)   |
| :------------: | :-----------------------------: | :-------------------------------: |
| 流水号生成类库 |    using jvncorelib.CodeLib;    |   using jvncorelib_fr.CodeLib;    |
|  信息加密类库  | using jvncorelib. EncryptorLib; | using jvncorelib_fr.EncryptorLib; |
|  实体扩展类库  |  using jvncorelib. EntityLib;   |  using jvncorelib_fr.EntityLib;   |
|    时间类库    |   using jvncorelib. TimeLib;    |   using jvncorelib_fr.TimeLib;    |
|  GUID扩展类库  |   using jvncorelib. GuidLib;    |   using jvncorelib_fr.GuidLib;    |
| Http请求工具类 |    using jvncorelib.HttpLib;    |   using jvncorelib_fr.HttpLib;    |

### 三、历史版本参照表(倒序)

|    包名    | 版本号  |                      更新日志                      |                   命令行                    |
| :--------: | :-----: | :------------------------------------------------: | :-----------------------------------------: |
| jvncorelib | 1.0.1.7 | 加密类库新增加密级别枚举，新增“增强”加密级别的加密 | Install-Package jvncorelib -Version 1.0.1.7 |
| jvncorelib | 1.0.1.6 |              加密类库新增密文对比方法              | Install-Package jvncorelib -Version 1.0.1.6 |
| jvncorelib | 1.0.1.5 |       新增Http请求工具类；时间类库优化扩展；       | Install-Package jvncorelib -Version 1.0.1.5 |
| jvncorelib | 1.0.1.4 |   新增实体扩展类库、时间类库；新增GUID扩展类库；   | Install-Package jvncorelib -Version 1.0.1.4 |
| jvncorelib | 1.0.1.2 |                  类库支持按需引入                  | Install-Package jvncorelib -Version 1.0.1.2 |
| jvncorelib | 1.0.1.1 |         整合加密类库；完善优化流水号类库;          | Install-Package jvncorelib -Version 1.0.1.1 |
| jvncorelib | 1.0.0.1 |            初始化项目；新增流水号类库；            | Install-Package jvncorelib -Version 1.0.0.1 |
| jvncorelib |  1.0.0  |                    初始化项目；                    |  Install-Package jvncorelib -Version 1.0.0  |



### 四、说明：

### 1、如有任何疑问，请点击右侧链接【[Contact owners](https://www.nuget.org/packages/jvncorelib/1.0.1.7/ContactOwners)】联系作者！

### 2、想查看更详细的更新内容，请浏览[CHANGELOG.md](https://gitee.com/java-and-net/encrypt-tools/blob/master/CHANGELOG.md)！

