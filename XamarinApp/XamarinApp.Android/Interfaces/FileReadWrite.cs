using System;
using System.IO;
using System.Threading.Tasks;
using Humantiz.Droid;
using Humantiz.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(FileReadWrite))]
namespace Humantiz.Droid
{
     public class FileReadWrite : IFileReadWrite
    {
        public async Task<string> ReadFromFile()
        {
            string result = string.Empty;
            TextReader reader = null;

            try
            {
                var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                var filePath = Path.Combine(documentsPath, "Login.json");

                reader = new StreamReader(filePath);

                if (File.Exists(filePath))
                    result = await reader.ReadToEndAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return result;
        }

        public Task<string> ReadFromFile(string Text)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> WriteToFile(string text)
        {
            bool result = true;
            TextWriter writer = null;
            try
            {
                var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                var filePath = Path.Combine(documentsPath, "Login.json");

                writer = new StreamWriter(filePath);
                await writer.WriteAsync(text);

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return result;
        }
    }
}
