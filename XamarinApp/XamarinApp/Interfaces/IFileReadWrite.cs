using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Humantiz.Interfaces
{
   public interface IFileReadWrite
    {
        Task<bool> WriteToFile(String Text);
        Task<string> ReadFromFile();

    }
}
