using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppData
{
    public partial class ToDoList
    {
        public override string ToString()
        {
            return $"{dateTime.ToString("ddd/MM/yyyy HH:mm")}\t\t{task} ";
        }
    }
}
