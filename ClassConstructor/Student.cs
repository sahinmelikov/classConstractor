
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

        public string name;
        public string surname;
        public string group;
        public int point;
        public string IsGraduated;
    }
   
} 
