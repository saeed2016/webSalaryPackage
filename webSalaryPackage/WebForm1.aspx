<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webSalaryPackage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">



    <script>
        // This function allows only one checkbox  to be checked
        function selectOnlyThis(id) {
            var myCheckbox = document.getElementsByName("checkbox");
            Array.prototype.forEach.call(myCheckbox, function (el) {
                el.checked = false;
            });
            id.checked = true;
        }
        function validateform1() {

            var name = document.getElementById('name').value;
            var work_type = document.getElementById('work_type').value;
            var salary = document.getElementById('salary').value;
            var hours = document.getElementById('hours').value;
            var education_type = document.getElementById('education_type').value;
            var coporate_check = document.getElementById("coporate");
            var hospital_check = document.getElementById("hospital");
            var pbi_check = document.getElementById("pbi");
            if (!coporate_check.checked || !hospital_check.checked || !pbi_check.checked) {
                alert("select company")

            }

            if (name == "") {
                alert("name is required");
            }
            if (salary == "") {
                alert(" salary is required ");
            }
            // To calculate salary package for part time employee in coporate company work hours needed.
            if (coporate_check.checked == true && work_type == "part-time" && hours == "") {
                alert(" work hours is required ");
            }


        }

    </script>


    <title></title>

    
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <label>Coporate</label>
            <input type="checkbox" id ="coporate" name="checkbox" value="1" onclick="selectOnlyThis(this)"/>
            <label>Hospital</label>
            <input type="checkbox" id ="hospital" name="checkbox" value="2" onclick="selectOnlyThis(this)"/> 
            <label>PBI</label>
            <input type="checkbox" id ="pbi" name="checkbox" value="3" onclick="selectOnlyThis(this)"/><br />
            <br />
            <label>Name:</label>
            <input type="text" id="name" name="name"/><br />
            <asp:Label ID="lblName" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <label>WorkType:</label>
            <select id="work_type" name ="work_type">
                <option value="full-time">full-time</option>
                <option value="part-time">part-time</option>
                <option value="casual">casual</option>
            </select><br />
            <br />
            <label>Salary:</label>
            <input type="number" id="salary" name="salary"  onkeypress="return event.charCode>=48 && event.charCode<=57"
                /><br />
            <br />
            <label>Hours:</label>
            <input type="number" id="hours" name="hours" onkeypress ="return event.charCode>=48 && event.charCode<=57
                "/><br />
            <br />
            <label>EducationType:</label>
            <select id ="education_type" name="education_type">
                <option value="non-educated">non-educated</option>
                <option value="bachelor-degree">bachelor-degree</option>
                <option value="postgraduate">postgraduat</option>
                <option value="docorate">docorate</option>
            </select><br />
            <br />
            
           <input type="button" value="calculate" onclick="validateform1()" />
        </div>
    </form>
</body>
</html>
