using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public object TextBox1 { get; private set; }
        public object TextBox2 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = null;
            //using (sqlConnection = new SqlConnection())
            //{
            //    sqlConnection.Open();
            //    SqlCommand cmd = new SqlCommand("name", sqlConnection);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //}

            String connection = "Data Source=DAMINI\\SQLEXPRESS;Initial Catalog=FullStack;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn=new SqlConnection(connection);
            conn.Open();
            int empID;
            string empname;

            SqlCommand cmd = conn.CreateCommand(Insert into FullStackEmpdetails (empID,empName,dateOfJoining,depID,salary,workingplace,Contacts) values(10,nirav,12-2-2022,20,287087,vadodara,9897979898),conn);
            cmd.ExecuteNonQuery();
            conn.Close();




            }
        }
}