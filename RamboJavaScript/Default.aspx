<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RamboJavaScript.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rambo Web Apps</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Assets/JS/custom.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="row">
                <div class="col-md-6">

                    <div class="form-group">
                        <label for="first_name">First Name</label>
                        <input type="text" class="form-control" id="first_name" name="first_name" />
                    </div>
                    <div class="form-group">
                        <label for="last_name">Last Name</label>
                        <input type="text" class="form-control" id="last_name" name="last_name" />
                    </div>
                    
                    <div class="form-group">
                        <label for="last_name">Date</label>
                        <input type="text" class="form-control" id="currentDate" name="last_name" />
                    </div>
                    <p onclick="getFormData()" id="btnSubmit" class="btn btn-default">Submit Inline</p>
                    
                    <p id="btnSubmitClick" class="btn btn-default">Submit on Click</p>
                </div>
                <div class="col-md-6">
                   <p id="user"></p>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
