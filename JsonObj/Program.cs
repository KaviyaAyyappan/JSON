using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace JsonObj
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = @"{""Name"":""Deva"",""Class"":10,""RollNo"":5489625,""Subjects"":[""Math"",""Science""]}";

            var Students = new JavaScriptSerializer().Deserialize<Student>(students);

           // string name = Students.Name;
           
            
                Console.WriteLine(Students.Name+" " + Students.Class+" " + Students.RollNo +" "+ Students.Subjects[0]);
                Console.ReadLine();
            
            

            
        }
    }
}
