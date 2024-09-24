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

        // public async Task<List<Claim>> GetUserClaimsAsync(Users user, IEnumerable<string> userRoles)
        // {

        //     var authClaims = new List<Claim>
        //         {
        //             new Claim(ClaimTypes.Name, user.UserName),
        //             new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //         };
        //     foreach (var userRole in userRoles)
        //         authClaims.Add(new Claim(ClaimTypes.Role, userRole));
        //     foreach (var Userclaim in await _userManager.GetClaimsAsync(user))
        //         authClaims.Add(Userclaim);
        //     return authClaims;
        // }

        protected /*async*/ void btntest_Click(object sender, EventArgs e)
        {

            int[] TrustedAdminPersonIds = { 276573, 411746, 276521, 987429, 276557 };
            int[] TrustedAdminUserIds = { 1, 190784, 190800, 335842, 362794, 373531, 339291 };

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


        //         public async Task<SecurityResult<UserModel>> Login(LoginModel model, CancellationToken cancellationToken = default, bool isDevelopment = false)
        //         {
        //             var ip = string.IsNullOrEmpty(model.IP) ? new Utils().getClientIPAddress(_httpContextAccessor.HttpContext.Request) : model.IP;
        //             int failLoginCount = GetFailLoginCount(ip);
        //             if (failLoginCount >= 5)
        //             {
        //                 await AddLog(GetCurrentMethod(), null, cancellationToken: cancellationToken, model);
        //                 return SecurityResult<UserModel>.Fail("خطا - " + UserISlockMessage);
        //             }
        //             logModel.UserName = model.Username ?? string.Empty;
        //             var userValidation = await GetValidUser(model);
        //             if (userValidation.IsSuccessful)
        //             {
        //                 UpdateFailLoginRequestCache(ip, true);

        //                 if (!userValidation.Data.IsActive)
        //                 {
        //                     await AddLog(GetCurrentMethod(), null, cancellationToken: cancellationToken, model);

        //                     return SecurityResult<UserModel>.Fail("کاربر غیر فعال می باشد.");
        //                 }
        //                 ///TODO: MAleki Check BuyerAgent Active & Person Active

        //                 if (!string.IsNullOrEmpty(model.OtpCode) && !isDevelopment)
        //                 {
        // #if !DEBUG
        //                     var verifyOtpCodeResult = await userManager.VerifyChangePhoneNumberTokenAsync(userValidation.Data, model.OtpCode, userValidation.Data.PhoneNumber);
        //                     if (!verifyOtpCodeResult)
        //                     {
        //                         await AddLog(GetCurrentMethod(), null, cancellationToken: cancellationToken, model);
        //                         return SecurityResult<UserModel>.Fail("کد یک بار مصرف صحیح وارد نشده است .");
        //                     }
        // #endif
        //                 }

        //                 var userRoles = await GetUserRoles(userValidation.Data);
        //                 var authClaims = await _userClaimService.GetUserClaimsAsync(userValidation.Data, userRoles);
        //                 var token = GenerateToken(authClaims);
        //                 var userViewRoles = await GetUserViewRoles(userRoles);
        //                 var UserModel = userValidation.Data.ToUserModel(new JwtSecurityTokenHandler().WriteToken(token), userViewRoles);
        //                 UserModel.IsPassExpired = userRoles.Contains(UserRoles.ChangePass);
        //                 var claims = (await userManager.GetClaimsAsync(userValidation.Data)).ToList();
        //                 UserModel.Claims = claims.ToDictionary(x => x.Type.ToString(), x => x.Value.ToString());
        //                 await AddLog(GetCurrentMethod(), UserModel, cancellationToken: cancellationToken, model);
        //                 return SecurityResult<UserModel>.Ok(_configuration.Expires, SuccessMessage, UserModel);
        //             }
        //             await AddLog(GetCurrentMethod(), null, cancellationToken: cancellationToken, model);
        //             UpdateFailLoginRequestCache(ip);
        //             return SecurityResult<UserModel>.Fail(userValidation.Message);
        //         }


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

            var a = "{\"Id\":339291,\"FirstName\":\"\u06A9\u0627\u0631\u0628\u0631 \u062A\u0633\u062A\u06CC\",\"Token\":\"eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiay5zaGFmYWF0IiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiIzMzkyOTEiLCJqdGkiOiI1NWE3YTY0Ny00MDliLTRmNzUtODllNS1jMTdlMWUyZTk3ZjAiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsIlJlZmVyZW5jZVR5cGVJZCI6IjE0NjAiLCJVc2VyUm9sZXMiOiJBZG1pbiIsIlBlcnNvbklkIjoiNDM4OTI2IiwiZXhwIjoxNzI3MTc2NDA5LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjYxOTU1IiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo0MjAwIn0.zt - YKJwn_3GhGkn0 - Eqyqqtqa7cwVcm1w9GgG9LViW3dAwtkNi7zkbgOmIlKraZYsYSW8Nw3xWcSL74qKH - QNw\",\"LastName\":\"\u062A\u0633\u062A\",\"Email\":\"\",\"UserName\":\"k.shafaat\",\"PhoneNumber\":null,\"OtpCode\":null,\"IsPassExpired\":false,\"UserViewroles\":[\"BranchView\"],\"Claims\":{\"ReferenceTypeId\":\"1460\",\"UserRoles\":\"Admin\",\"PersonId\":\"438926\"}}";
            var b = "{\"UnitID\":10000,\"UnitCode\":10000,\"UnitType\":1,\"DigitCode\":0,\"UnitName\":\"\\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"ParentUnitType\":0,\"ParentUnitCode\":0,\"ParentUnitID\":0,\"ParentUnit\":{\"UnitID\":0,\"UnitCode\":0,\"UnitType\":0,\"DigitCode\":0,\"UnitName\":\"\\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"FormatedText\":\"0 - \\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"FormatedTextWithDigit\":\"00 - \\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"FormatedName\":\"\\u0646\\u0627\\u0645\\u0634\\u062E\\u0635\",\"ParentUnitID\":0,\"MergeDate\":null,\"MergeToUnitID\":0,\"IsVirtual\":false,\"UnitStatus\":2,\"UnitFlag\":0,\"OpenningDate\":null,\"AccountingCode\":null,\"UnitDegree\":null},\"MergeDate\":null,\"MergeToUnitID\":10000,\"IsVirtual\":false,\"UnitStatus\":1,\"Flag\":0,\"UnitStatusName\":\"\\u0641\\u0639\\u0627\\u0644\",\"FormatedText\":\"10000 - \\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"FormatedTextWithDigit\":\"100000 - \\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"FormatedName\":\"\\u06A9\\u0644 \\u0628\\u0627\\u0646\\u06A9\",\"ClearName\":\"\",\"OpenningDate\":null,\"AccountingCode\":null,\"UnitDegreeId\":null,\"BankId\":1}";

            UserModel userModel = Newtonsoft.Json.JsonConvert.DeserializeObject<UnitInfo>(a);
            UnitInfo unit = Newtonsoft.Json.JsonConvert.DeserializeObject<UnitInfo>(b);
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



// ,
//   "JWT": {
//     "ValidAudience": "http://localhost:4200",
//     "ValidIssuer": "http://localhost:61955",
//     "Secret": "3916cd41ae1636dbd953a2f44a93a7df03eadu2107cd94febb6044c3ee7c0f3dabf715d62be8ccbfe1e71216eeckeb5d357838789ab20f9fe7907453c8a991513dde447c77fb1b4s14355a77e4827510a422038c7b92b938b9a21beb1eef0z6775892e372e1f56d9a76e9e1a66263aa06976c7fa59e0acf5ac8b7d3d2306e7120f1c5262e9a03e279590953c68dc4357d62da84ec02e9b05b719e20c458f445488f7d374e811789f1ef308d7012c7fecdfe15a28b7af9ebke1460f74c596936ee6913bdbab6d243f197fd0e0ca0af2bced7ded91c55b864793789014913d19cf8e3e27a8c614d75580d4f440164710e5e350726b8aa7b9cfb79b05e7512dfa074a690d8073452bae64d56e57b578e58e287560e5430846b7c941d9dba44a22c893146d64a2d8db758682ff5d1ac1129717b8e22d437ec7e6eb714622fcccd89c18038be691e505f540369cb3ff25e1f03f237ed25a21058c01a0519a2c1f6625b957c15818dce9dd905cb7feb9641c1ddf23c2c5f2b9ef4d3b42c426166d4d87e8b15c72147e4bbfb362c83b00691944e86992f9864e25e4dbd142812386ae147bad6411f0921bbb75edb05ef25741e115e2b5ea5b0a02617d074b5f41b5be4f20cpbaf491ea0265f62fe0025db996f7c1719c75df9c980e967b3645t0ei61a03df663433be241220607b594b44b2a52c8a92671bu79b0cb3227e5e00e8cc8e4",
//     "ExpiresMinutes": "60"
//   }