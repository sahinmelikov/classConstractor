using System.Drawing;
using System.Threading.Channels;
using System.Xml.Linq;
using System.Text;
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
            string group = Console.ReadLine();
            Console.WriteLine("topladiginiz bali daxil edin");
            int point = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mezun olmusunuz:True or False ");
            string IsGraduated = Console.ReadLine();
            //string name = "sahin";
            //string surname = "melikov";
            //string group = "ab201";
            //int point = 34;
            //string IsGraduated = "True";

            Student student = new Student( name, surname, group, point,IsGraduated)
            {
       

             };
          




            if (student.IsGraduated=="True")
            {
                student.Showinfo();
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
                student.Showinfo();
                Console.WriteLine($"{student.name} {student.surname} - Bu telebe artiq mezun olub");

            }

            Student student1 = new Student(name,surname,group,point,IsGraduated)
            {
                name = "Sahin",
                surname = "melikov",
                group = "ab201",
                point = 46,
                IsGraduated = "True",


            };
            Student student2 = new Student(name, surname, group, point, IsGraduated)
            {
                name = "Murad",
                surname = "Shikmatov",
                group = "ab201",
                point = 96,
                IsGraduated = "True",


            };

            string ReverseWithBuilder(string name)
            {

                StringBuilder student1=new StringBuilder();

                name = "Sahin";
                surname = "melikov";
                group = "ab201";
                point = 46;
                IsGraduated = "True";
                for (int i = 1; i< name.Length; i++)
                {
                    student1.Append(student1[i]);
                }
                return student1.ToString();

            }
            student1.Showinfo();
            student2.Showinfo();







        }
    }
}