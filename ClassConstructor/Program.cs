using System.Drawing;
using System.Threading.Channels;
using System.Xml.Linq;

namespace ClassConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin");
            string surname = Console.ReadLine();
            Console.WriteLine("Grupunusu daxil edin");
            string group = (Console.ReadLine());
            Console.WriteLine("topladiginiz bali daxil edin");
            int point = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mezun olmusunuz:True or False ");
            string IsGraduated = Console.ReadLine();

            Student student = new Student( name, surname, group, point,IsGraduated)
            {
                
                
                // name="sahin",
                // surname="Melikov",
                //group="jkhsknj",
                //point=45,
                //IsGraduated="True"
            };

            if (student.IsGraduated=="True")
            {
                Console.WriteLine("{");
                Console.WriteLine($"Name:{student.name}");
                Console.WriteLine($"Surname:{student.surname}");
                Console.WriteLine($"group:{student.group}");
                Console.WriteLine($"point:{student.point}");
                Console.WriteLine($"IsGraduated:{student.IsGraduated}");
                Console.WriteLine("}");
                if (student.point > 80)
                {
                    Console.WriteLine($"{student.name} {student.surname} Siz Novbeti imtahana gire Bilersiniz");
                }
                else
                {
                    Console.WriteLine($"{student.name} {student.surname} Siz  Novbeti imtahana Gire Bilmezsiniz");
                }
            }
            else
            {
                Console.WriteLine("{");
                Console.WriteLine($"Name:{student.name}");
                Console.WriteLine($"Surname:{student.surname}");
                Console.WriteLine($"group:{student.group}");
                Console.WriteLine($"point:{student.point}");
                Console.WriteLine($"IsGraduated:{student.IsGraduated}");
                Console.WriteLine("}");
                Console.WriteLine($"{student.name} {student.surname} - Bu telebe artiq mezun olub");

            }


          
        }
    }
}