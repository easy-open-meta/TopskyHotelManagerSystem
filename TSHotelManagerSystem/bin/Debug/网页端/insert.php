<html> 
<head> 
<title>表格显示数据表记录</title> 
</head> 
<body> 
   <h2>表格显示数据表记录</h2>
   <hr> 
   <script language="JavaScript"> 
    var objdbConn = new ActiveXObject("ADODB.Connection"); 
    var strdsn = "Driver={SQL Server};SERVER=DESKTOP-0M6ANDJ;UID=sa;PWD=sa;DATABASE=TSHotelDB"; 
    objdbConn.Open(strdsn); 
    var objrs = objdbConn.Execute("Select * from Room;"); 
   
    var fdCount = objrs.Fields.Count - 1; 
    if (!objrs.EOF){ 
     document.write("<table border=1><tr>"); 
     for (var i=0; i <= fdCount; i++) 
      document.write("<td><b>" + objrs.Fields(i).Name + "</b></td>"); 
     document.write("</tr>"); 
     while (!objrs.EOF){ 
      document.write("<tr>"); 
      for (i=0; i <= fdCount; i++) 
       document.write("<td valign='top'>" + objrs.Fields(i).Value + "</td>"); 
      document.write("</tr>"); 
      objrs.moveNext(); // 移到下一个记录点
     } 
   
     document.write("</table>"); 
    } 
    else 
     document.write("数据库内没有记录!<br>"); 
    objrs.Close(); // 关闭记录集和 
    objdbConn.Close(); // 关闭数据库链接
   </script> 
</body> 
</html> 