using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Humantiz.Interfaces;
using Humantiz.Model;

namespace Humantiz.AppConstants
{
    public class FileService
    {
        IFileReadWrite fileReadWrite;

        public FileService()
        {
            fileReadWrite = Xamarin.Forms.DependencyService.Get<IFileReadWrite>();
        }

        public async Task<bool> WriteToJsonFile(LoginUserDetail param)
        {
            bool result = true;

            try
            {
                string serialized = JsonConvert.SerializeObject(param);
                await fileReadWrite.WriteToFile(serialized);
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public async Task<LoginUserDetail> ReadFromJsonFile()
        {
            LoginUserDetail deserialized = new LoginUserDetail();

            try
            {
                deserialized = JsonConvert.DeserializeObject<LoginUserDetail>(await fileReadWrite.ReadFromFile());

                if (deserialized == null)
                    deserialized = new LoginUserDetail();
            }
            catch (Exception ex)
            {
                deserialized = new LoginUserDetail();
            }

            return deserialized;
        }
    }
}