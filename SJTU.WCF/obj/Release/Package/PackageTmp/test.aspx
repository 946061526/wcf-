<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="SJTU.WCF.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script language="javascript" src="jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            var jsonMsg = { "isbn1": "9787806266892" };
         
            var message = JSON.stringify(jsonMsg)
            $.ajax({
                type: "POST",
                url: "/Book/Patch/9787806266892",
                contentType: "application/json",
                data:message,
                dataType: "text",
                processData: false,
                success: function (json) { document.write(json) },
                error: function (error) {
                    alert("调用出错" + error.responseText);
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
