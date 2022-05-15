using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPS3
{
    public class Student
    {
        public string FIO {get;}
        public string Phone {get;}
        public string Address {get;}
        public Dictionary<string, int> Grades { get; set; }=new Dictionary<string, int>();
        public Student(string fio,string phone, string address)
        {
            FIO= fio;
            Phone= phone;
            Address= address;
        }
           
    }
}
