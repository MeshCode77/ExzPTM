using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExzPTM
{
    class DataTrans
    {
        public static string temp { get; set; } // нужен static т.к. доступ к объекту нужен только через класс а не через экземпляр класса
        public static string lastIDempl { get; set; }
    }
}
