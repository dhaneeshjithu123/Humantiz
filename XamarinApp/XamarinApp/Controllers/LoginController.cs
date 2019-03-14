using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Humantiz.Model;
using Humantiz.AppConstants;
using Humantiz.Interfaces;

namespace Humantiz.Controllers
{
    public class LoginController
    {

        public async Task<bool> CheckLoginDetails(string userName, string password, bool rememberMe)
        {
            string url = Constants.LoginUrl;
            LoginUserDetail loginRec = new LoginUserDetail();
            loginRec.username = userName;
            loginRec.password = password;

            //return await UserLoginAPICall(url, loginRec, rememberMe);
            // return true;
            IFileReadWrite fileReadWrite = Xamarin.Forms.DependencyService.Get<IFileReadWrite>();
            string serialized = JsonConvert.SerializeObject(loginRec);
            bool x = await fileReadWrite.WriteToFile(serialized);
            return true;

        }


        public async Task<bool> UserLoginAPICall(string url, LoginUserDetail loginRec, bool rememberMe)
        {
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                var json = JsonConvert.SerializeObject(loginRec);

                using (var client = new HttpClient())
                {
                    response = new HttpResponseMessage();
                    client.DefaultRequestHeaders.Add("X-Whirlpool-Client-ID", Constants.LoginAPIKey);
                    client.Timeout = TimeSpan.FromSeconds(Constants.LoginServerTimeout);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    response = await client.PostAsync(url, content);

                }
                if (response.IsSuccessStatusCode)
                {
                    var JsonObj = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<LoginUserDetail>(JsonObj);
                    if (obj != null)
                    {
                        //if (obj.valid && !string.IsNullOrEmpty(obj.session))
                        //{
                        //Insert Token Details to Table
                        //loginRec.session = obj.session;
                        //loginRec.password = string.Empty;
                        ////insert usertable
                        //AppLogin loginData = new AppLogin();
                        //loginData.AppLoginName = loginRec.username;

                        //loginData.AppLoginName = EncryptDecryptWithPCLCrypto.EncryptAes(loginRec.username);
                        //loginData.TokenId = EncryptDecryptWithPCLCrypto.EncryptAes(loginRec.session);
                        //loginData.LastLoggedDate = DateTime.Now;
                        //string date = AppFactory.Resolve<IPlatformService>().GetGlobalDate();

                        //// update the login results, date and current region
                        //if (rememberMe)
                        //{
                        //    await AppFactory.GetDb().InsertPreference(Constants.LOGIN_SCREEN, Constants.TRUE);
                        //}
                        //await AppFactory.GetDb().InsertPreference(Constants.LOGIN_DATE, date.ToString());
                        //// refresh the user preferences
                        //AppFactory.InitFlags();

                        //loginData.Remarks = "Success";
                        //await AppFactory.GetDb().DeleteLoginUserDetail();
                        //await AppFactory.GetDb().InsertLoginUserDetail(loginData);

                        ////Retrieve and set App login user details
                        //var currentUser = await AppFactory.GetDb().GetLoginUserDetailsAsync();
                        //if (currentUser != null)
                        //{
                        //    if (currentUser.Count > 0)
                        //    {
                        //        AppState.UserName = EncryptDecryptWithPCLCrypto.DecryptAes(currentUser[0].AppLoginName);
                        //        AppState.UserSession = EncryptDecryptWithPCLCrypto.DecryptAes(currentUser[0].TokenId);
                        //        AppState.AppLoginId = currentUser[0].AppLoginId;
                        //    }
                        //}
                        return true;
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}

