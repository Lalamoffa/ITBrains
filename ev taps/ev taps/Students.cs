using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ev_taps
{
    internal class Students
    {
        public static List<Students> student = new List<Students>();
        public static int Count;
        public Students(string ad, string soyad) 
        {
            Name = ad;
            Surname = soyad;
            Count++;
            No = Count;
        }


        public string Name { get; set; }
        public string Surname { get; set; }
        public int No { get; set; }
        public string GroupNumber { get; set; }
        
        public static void AddStudent(Students std)
        {
            student.Add(std);
        }

        public static void Search()
        {
            Console.WriteLine("Enter a Name:");
            string name = Console.ReadLine();
            foreach (var item in student)
            {
                if (name == item.Name )
                {
                    Console.WriteLine(item.No + "." + item.Name + ", " + item.Surname );
                    
                }

            }
            Console.WriteLine("Information found.");
        }
        public static void RemoveStudent()
        {
            Console.WriteLine("Enter the number you want to remove:");
            int number = Convert.ToInt32(Console.ReadLine());
            foreach (var item in student)
            {
                if (number == item.No)
                {
                    student.Remove(item);
                    Console.WriteLine(item.No + "." +item.Name + ", " + item.Surname +  ": Silindi");
                    break;

                }
                
            }
          
        }
        

        public static void Edit()
        {
            Console.WriteLine("Enter the number you want to Edit:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            foreach (var item in student)
            {
                if (number1 == item.No)
                {
                    Console.WriteLine("Soyad daxil et.");
                    item.Surname = Console.ReadLine();                    
                    Console.WriteLine("Ad daxil et.");
                    item.Name = Console.ReadLine();
                    Console.WriteLine("Ad deyisdirildi. Deyisdirilen telebenin melumatlari.");
                    Console.WriteLine(item.No + "." + item.Name + ", " + item.Surname);

                    return;
                }
            }
            
        }


       
    }
}
