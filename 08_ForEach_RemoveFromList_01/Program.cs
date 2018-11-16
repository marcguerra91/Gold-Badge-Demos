using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ForEach_RemoveFromList_01
{
    class Program
    {
        static void Main(string[] args)
        {
            InstructorRepository intructorRepo = new InstructorRepository();
            List<string> intructors = instructorRepo.GetIntructors();

            var one = "Josh";
            var two = "Paul";
            var three = "Ransford";
            var four = "Kenn";

            foreach(string s in intructors)
            {
                Console.WriteLine(s);
            }
             
            Console.ReadLine();
        }
    }
}
