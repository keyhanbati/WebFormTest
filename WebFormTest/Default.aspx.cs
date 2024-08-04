using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebGrease.Css.Ast.Selectors;
using static System.Net.Mime.MediaTypeNames;

namespace WebFormTest
{
    public partial class _Default : Page
    {

        public List<string> MyList { get; set; } = new List<string>();

        protected async void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.SetCurrentUserID(1024);

            MyList = new List<string>
            {
                "FirstItem"
            };

            gvEmployee.DataSource = new[] {
                new { EmpID = 1 ,EmpName="abc" ,EmpAge=25} ,
                new { EmpID = 2 ,EmpName="def" ,EmpAge=30} ,
                new { EmpID = 3 ,EmpName="ghi" ,EmpAge=19} ,
            };
            await Task.Run(() => { gvEmployee.DataBind(); });
            await Task.Run(() => { AddItemToList(); });
            MyList.Add("LastItem");
            lst.DataSource = MyList;
            lst.DataBind();
        }

        private void AddItemToList()
        {
            Thread.Sleep(1000);
            MyList.Add("Async Item");
        }

        protected async void gvEmployee_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            await Task.Run(() =>
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    int age = Convert.ToInt32(((HyperLink)e.Row.Cells[2].Controls[0]).Text.ToString());
                    if (age >= 25 && age < 30)
                    {
                        e.Row.BackColor = Color.GreenYellow;
                    }
                    if (age == 30)
                    {
                        e.Row.BackColor = Color.LightBlue;
                    }
                }
            });
        }

        protected /*async*/ void btntest_Click(object sender, EventArgs e)
        {
            //List<DbSpModel> retVal =Task.Run(async () => {return await FetchFromSp(); }).GetAwaiter().GetResult();
            FetchFromSp().
                ContinueWith(t => 
                {
                    List<DbSpModel> retVal = t.Result;
                    GridView1.DataSource = retVal;
                    GridView1.DataBind();
                },
                TaskContinuationOptions.OnlyOnFaulted);
            //List<DbSpModel> retVal = /*await*/ FetchFromSp().Result;
        }

        private async Task<List<DbSpModel>> FetchFromSp()
        {
            var retList = new List<DbSpModel>();
            using (var cnn = new SqlConnection(@"Data Source=(LOCALDB)\MSSQLLOCALDB;Initial Catalog=Test;Integrated Security=True"))
            {
                await cnn.OpenAsync();
                using (var cmd = new SqlCommand("dbo.sp_Test", cnn) { CommandType = System.Data.CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@Id", 1);
                    var reader = await cmd.ExecuteReaderAsync();
                    if (reader.HasRows)
                        while (await reader.ReadAsync())
                            retList.Add((DbSpModel)reader);
                }
                cnn.Close();
            }
            var us = new UserContext();
            var usr = us.GetCurrentUserId();
            return retList;
        }
    }

    internal class DbSpModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public static implicit operator DbSpModel(SqlDataReader row)
        {
            return new DbSpModel()
            {
                Id = Convert.ToInt32(row["ID"]),
                Comment = Convert.ToString(row["comment"])
            };
        }
    }
}