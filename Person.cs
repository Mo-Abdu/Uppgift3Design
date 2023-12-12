using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift3Grafik
{
    
    public class Person
    {
        List<Person> persons = new List<Person>();
        


        public string Name { get; set; }
        public string Living { get; set; }
        public string School { get; set; }
        public string Job { get; set; }

        public Person(string name, string living, string school, string job)
        {
            Name = name;
            Living = living;
            School = school;
            Job = job;
        }

        public string GetCSV()
        {
            return Name + "," + Living + "," + School + "," + Job + ",";
        }

        public override string ToString()
        {
            return "Name: " + Name + " , Living: " + Living + ",  School: " + School + ", Job: " + Job + " ";
        }




    }
}
