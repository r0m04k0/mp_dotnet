using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
    {
        public
            string Name { get; set; }
            string Gender { get; set; }
            string HairColor { get; set; }
            int Age { get; set; }
            float Weight { get; set; }
            float Height { get; set; }

        public Student(string name, string gender, string hairColor, int age, float weight, float height)
        {
            Name = name;
            Gender = gender;
            HairColor = hairColor;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public string Hybreed(Student student1, Student student2)
        {
            string NewName = "";
            for (int i = 0; i < student2.Name.Length; i += 1)
            {
                NewName += student2.Name.Substring(i, 1) + student1.Name.Substring(i, 1);
            }

            string NewGender;
                
            if (student1.Gender == "male" && student2.Gender == "male") { NewGender = "male"; }
            else if (student1.Gender == "female" && student2.Gender == "female") { NewGender = "female"; }
            else { NewGender = "transgender"; }
            
            string NewColor = "";
            for (int i = 0; i < student2.HairColor.Length; i += 2)
            {
                NewColor += student2.HairColor.Substring(i, 1) + student1.HairColor.Substring(i, 1);
            }

            int NewAge = (student1.Age + student2.Age)/2;

            float NewWeight = student1.Weight + student2.Weight;

            float NewHeight = student1.Height + student2.Height;

            return (NewName + "\n" + NewGender + "\n" + NewColor + "\n" + NewAge + "\n" + NewWeight + "\n" + NewHeight);
                
        }
    }

    

}
