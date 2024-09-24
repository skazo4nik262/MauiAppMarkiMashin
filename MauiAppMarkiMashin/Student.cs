using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppMarkiMashin
{
    internal class Student
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateOnly BirthDay { get; set; }
        public bool IsBoy { get; set; }
        public string Address { get; set; }
    }
}
