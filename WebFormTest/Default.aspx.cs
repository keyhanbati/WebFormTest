using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormTest.db;
using WebFormTest.Models.Units;
using WebGrease.Css.Ast.Selectors;
using static System.Net.Mime.MediaTypeNames;
using UnitTypes = WebFormTest.Models.Units.UnitTypes;

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

            int[] TrustedAdminPersonIds = { 276573, 411746, 276521, 987429, 276557 };
            int[] TrustedAdminUserIds = { 1,190784, 190800, 335842, 362794, 373531,339291};

            UserModel _userModel = new UserModel()
            {
                Id = 339291,
                LastName = "تست",
                FirstName = "کاربر تستی",
                Claims = new Dictionary<string, string>() { { "ReferenceTypeId", "1460" }, { "UserRoles", "Admin" }, { "PersonId", "438926" } }
            };

            List<string> roles = new List<string>() { "Admin" };
            UnitInfo unit = Newtonsoft.Json.JsonConvert.DeserializeObject<UnitInfo>("{\"UnitID\":10000,\"UnitCode\":10000,\"UnitType\":1,\"DigitCode\":0,\"UnitName\":\"\\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"ParentUnitType\":0,\"ParentUnitCode\":0,\"ParentUnitID\":0,\"ParentUnit\":{\"UnitID\":0,\"UnitCode\":0,\"UnitType\":0,\"DigitCode\":0,\"UnitName\":\"\\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"FormatedText\":\"0 - \\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"FormatedTextWithDigit\":\"00 - \\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"FormatedName\":\"\\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"ParentUnitID\":0,\"MergeDate\":null,\"MergeToUnitID\":0,\"IsVirtual\":false,\"UnitStatus\":2,\"UnitFlag\":0,\"OpenningDate\":null,\"AccountingCode\":null,\"UnitDegree\":null},\"MergeDate\":null,\"MergeToUnitID\":10000,\"IsVirtual\":false,\"UnitStatus\":1,\"Flag\":0,\"UnitStatusName\":\"\\u0641\\u0639\\u0627\\u0644\",\"FormatedText\":\"10000 - \\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"FormatedTextWithDigit\":\"100000 - \\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"FormatedName\":\"\\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"ClearName\":\"\",\"OpenningDate\":null,\"AccountingCode\":null,\"UnitDegreeId\":null,\"BankId\":1}");


            Authenticate(_userModel.Id.ToString(), _userModel.UserName,
                _userModel.FirstName + " " + _userModel.LastName, string.Join(",", roles.ToArray()), unit.UnitType,
                unit.UnitCode);
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



        //public List<string> GetRoles(string token)
        //{
        //    var key = Encoding.ASCII.GetBytes(ConfigurationManager.AppSettings["jwtSecret"]);
        //    var handler = new JwtSecurityTokenHandler();
        //    var validations = new TokenValidationParameters
        //    {
        //        ValidateIssuerSigningKey = true,
        //        IssuerSigningKey = new SymmetricSecurityKey(key),
        //        ValidateIssuer = false,
        //        ValidateAudience = false
        //    };
        //    var claims = handler.ValidateToken(token, validations, out var tokenSecure);
        //    return claims.Claims.Where(c => c.Type == ClaimTypes.Role)
        //        .Select(c => c.Value).ToList();
        //}

        protected virtual void Authenticate(string userId, string username, string userFullName, string roles, UnitTypes unitType, int unitCode)
        {
            UnitInfo unit = Newtonsoft.Json.JsonConvert.DeserializeObject<UnitInfo>("{\"UnitID\":10000,\"UnitCode\":10000,\"UnitType\":1,\"DigitCode\":0,\"UnitName\":\"\\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"ParentUnitType\":0,\"ParentUnitCode\":0,\"ParentUnitID\":0,\"ParentUnit\":{\"UnitID\":0,\"UnitCode\":0,\"UnitType\":0,\"DigitCode\":0,\"UnitName\":\"\\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"FormatedText\":\"0 - \\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"FormatedTextWithDigit\":\"00 - \\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"FormatedName\":\"\\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"ParentUnitID\":0,\"MergeDate\":null,\"MergeToUnitID\":0,\"IsVirtual\":false,\"UnitStatus\":2,\"UnitFlag\":0,\"OpenningDate\":null,\"AccountingCode\":null,\"UnitDegree\":null},\"MergeDate\":null,\"MergeToUnitID\":10000,\"IsVirtual\":false,\"UnitStatus\":1,\"Flag\":0,\"UnitStatusName\":\"\\u0641\\u0639\\u0627\\u0644\",\"FormatedText\":\"10000 - \\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"FormatedTextWithDigit\":\"100000 - \\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"FormatedName\":\"\\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"ClearName\":\"\",\"OpenningDate\":null,\"AccountingCode\":null,\"UnitDegreeId\":null,\"BankId\":1}");
            Authenticate(userId, username, userFullName, roles, unit);
        }

        protected virtual void Authenticate(string userId, string username, string userFullName, string roles, IUnitInfo unit)
        {

            HttpCookie authenticationCookie = BaseAuthenticateHttpModule.GetAuthenticationCookie(Convert.ToInt64(userId), username, userFullName, unit.UnitCode, (int)unit.UnitType, unit.UnitName, roles, isPersist: false);
            base.Response.Cookies.Add(authenticationCookie);

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
    public static class BaseAuthenticateHttpModule
    {
        public static HttpCookie GetAuthenticationCookie(long userId, string username, string fullname, int unitCode, int unitType, string unitName, string userRoles, bool isPersist)
        {
            if (string.IsNullOrWhiteSpace(fullname))
            {
                fullname = "نامشخص";
            }

            string userData = CreatUserData(userId.ToString(), fullname, unitType, unitCode, unitName, userRoles);
            return GetAuthenticationCookie(userId, username, userData, isPersist);
        }

        private static HttpCookie GetAuthenticationCookie(long userId, string username, string userData, bool isPersist)
        {
            double num = FormsAuthentication.Timeout.TotalMinutes;
            if (num == 0.0)
            {
                num = 10.0;
            }

            FormsAuthenticationTicket formsAuthenticationTicket = new FormsAuthenticationTicket(0, username, DateTime.Now, DateTime.Now.AddMinutes(num), isPersist, userData);
            HttpCookie httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(formsAuthenticationTicket));
            if (isPersist)
            {
                httpCookie.Expires = formsAuthenticationTicket.Expiration;
            }

            if (!string.IsNullOrWhiteSpace(FormsAuthentication.CookieDomain))
            {
                httpCookie.Domain = FormsAuthentication.CookieDomain;
            }

            return httpCookie;
        }

        private static string CreatUserData(params object[] userDataElements)
        {
            return string.Join("::", userDataElements);
        }

    }
}

