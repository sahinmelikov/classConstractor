
namespace ClassConstructor
{
    public class Student
    {
       
        public Student(string name,string surname,string group,int poin,string IsGraduated)
        {
           
            this.name = name;
            this.surname= surname;
            this.group= group;
            this.point= poin;
            this.IsGraduated= IsGraduated;
        }
       public void Showinfo()
        {
            Console.WriteLine("{");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Surname:{surname}");
            Console.WriteLine($"group:{group}");
            Console.WriteLine($"point:{point}");
            Console.WriteLine($"IsGraduated:{IsGraduated}");
            Console.WriteLine("}");
           


        }

        public string name;
        public string surname;
        public string group;
        public int point;
        public string IsGraduated;
    }
   
} 
