using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel05
{
    public class Student :EventArgs
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateIs { get; set; }
        public string Name { get; set; }
        public decimal Marks { get; set; }
    }
}
