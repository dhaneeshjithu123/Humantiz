using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humantiz.View
{

    public class MainMasterPageMenuItem
    {
        public MainMasterPageMenuItem()
        {
           // TargetType = typeof(MainMasterPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Menuimage { get; set; }

        public Type TargetType { get; set; }
        public string PageName { get; set; }

    }
}