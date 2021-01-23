using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypesHW
{
    class Class
    {
        private List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            foreach (var st in students)
            {
                if (st.Number == student.Number)
                {
                    Console.WriteLine("Bu öğrenci numarasına sahip bir öğrenci mevcut! Öğrenci numarasını değiştiriniz!");
                    int number = Convert.ToInt32(Console.ReadLine());
                    student.Number = number;
                }
            }

            foreach (var st in students)
            {

                if (st.Name.ToLower().Equals(student.Name.ToLower()) && st.LastName.ToLower().Equals(student.LastName.ToLower()))
                {
                    Console.WriteLine("Aynı ad soyadı taşıyan öğrenci mevcut. Eklemek istediğinize emin misiniz?(Evet/Hayır)");
                    string cevap = Console.ReadLine();

                    if (cevap.ToLower().Equals("hayır"))
                    {
                        return;
                    }

                    Console.WriteLine("Öğrenci başarıyla eklenmiştir");
                }
            }
            students.Add(student);
        }

        public void Remove(Student student)
        {
            students.Remove(student);

        }
        public void Remove(int _Number)
        {
            var student = students.FirstOrDefault(st => st.Number == _Number);

            students.Remove(student);
        }

        public Student GetStudentByNumber(int _Number)
        {
            return students.FirstOrDefault(p => p.Number == _Number);

        }

        public List<Student> GetStudentByName(string _Name)
        {
            return students.Where(p => p.Name.Contains(_Name)).ToList();
        }

        public List<Student> GetStudentByScore(int _Score)
        {
            return students.Where(p => p.Score.Equals(_Score)).ToList();
        } 


        public List<Student> GetStudentByAge(int _Age)
        {
            return students.Where(x => x.Age == _Age).ToList();
        }

        public List<Student> GetAllStudentName()
        {
            return students;
        }

    }
}
