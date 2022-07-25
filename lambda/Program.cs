using System;

namespace lambda
{
    class Students
    {
        public string Name { get; set; }    
        public string Family { get; set; }

        public bool BanStatus { get; set; }   

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> lstStudents = new List<Students>{
                new Students{ Name="ali" ,Family="hosseini" , BanStatus=false },
                new Students{ Name="hasan" ,Family="hosseini" , BanStatus=false },
                new Students{ Name="Jack" ,Family="hosseini" , BanStatus=true },
                new Students{ Name="Steven" ,Family="hosseini" , BanStatus=true },
                new Students{ Name="Mathew" ,Family="hosseini" , BanStatus=true },
                new Students{ Name="amir" ,Family="hosseini" , BanStatus=false },

            };

            Console.Write("Enter your name:");
            string? name = Console.ReadLine();

            if (lstStudents.Select(student => student.Name).Contains(name) == false)
            {
                Console.WriteLine("Invalid access..");
                return;
            }

            Console.WriteLine("Welcome " + name);

            IEnumerable<string> BanStudents = from students in lstStudents
                                                where students.Name == name
                                                where students.BanStatus == true
                                                select students.Name;


            List<string> BanStudents2 = lstStudents
            .Where(student => student.Name == name)
            .Where(student => student.BanStatus == true)
            .Select(student => student.Name).ToList();


            List<string> data = BanStudents.ToList();
            if (data.Contains(name))
            {
                Console.WriteLine("You are Banned...");
            }

        }
    }
}

