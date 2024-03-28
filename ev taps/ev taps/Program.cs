using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ev_taps
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
          
            Students student1 = new Students("Eli","Eliyev");
            student1.GroupNumber = "q123";
            Students.AddStudent(student1);
            Console.WriteLine(student1.No + "." + student1.Name + "," + student1.Surname);

            Students student2 = new Students("Veli", "Veliyev");
            student2.GroupNumber = "w45";
            Students.AddStudent(student2);
            Console.WriteLine(student2.No + "." + student2.Name + "," + student2.Surname);

            Students student3 = new Students("Aynur", "Eliyeva");
            student3.GroupNumber = "r678";
            Students.AddStudent(student3);
            Console.WriteLine(student3.No + "." + student3.Name + "," + student3.Surname);

            Students student4 = new Students("Lala", "Mammadova");
            student4.GroupNumber = "t890";
            Students.AddStudent(student4);
            Console.WriteLine(student4.No + "." + student4.Name + "," + student4.Surname);


            while (true)
            {
                Console.WriteLine("1. Search");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. Edit");
                Console.WriteLine("\n Which operation do you want to select?");
                int menyu = Convert.ToInt32(Console.ReadLine());

                switch (menyu)
                {
                    case 1:
                       
                        Students.Search();

                        break;

                    case 2:
                       Students.RemoveStudent();

                        break;

                    case 3:
                        Students.Edit();
                        break;

                    default:

                        Console.WriteLine("Nomre tapilmadi.");
                        break;
                       
                }
            }
        }
    }
}
