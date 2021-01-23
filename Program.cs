using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypesHW
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new Class();

            List<Student> studs = list.GetAllStudentName();

            list.Add(new Student { Number = 1, Name = "Cansu", LastName="Koyuncu", Score=60, Age=25});
            list.Add(new Student { Number = 2, Name = "Anıl", LastName = "Şen", Score = 90, Age=23 });
            list.Add(new Student { Number = 3, Name = "Cenk", LastName = "Cemaloğlu", Score = 50, Age=24});
            list.Add(new Student { Number = 4, Name = "Ebru", LastName = "Belim", Score = 100, Age=23});
            list.Add(new Student { Number = 5, Name = "Melek", LastName = "Aydın", Score = 80, Age=23});
            list.Add(new Student { Number = 6, Name = "Semih", LastName = "Erdem", Score = 100, Age = 18 });


            foreach (var item in studs)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            list.Add(new Student { Number = 1, Name = "Cansu", LastName = "Koyuncu" });

            foreach (var item in studs)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Öğrenci numarasına göre öğrenci: ");
            var student = list.GetStudentByNumber(3);
            Console.WriteLine($"{student.Number} numaralı {student.Name} {student.LastName} isimli öğrenci sınıfta mevcut.");

            Console.WriteLine();

            Console.WriteLine("Öğrenci ismine göre öğrenciler: ");
            var findNames = list.GetStudentByName("Anıl");
            findNames.ForEach(st => Console.WriteLine($"{st.Name} {st.LastName} isimli öğrenci sınıfta mevcut."));

            Console.WriteLine();
            Console.WriteLine("Öğrenci yaşına göre öğrenciler: ");
            var findNamesByAge = list.GetStudentByAge(23);
            findNamesByAge.ForEach(st => Console.WriteLine($"{st.Age} yaşında {st.Name} {st.LastName} isimli öğrenci sınıfta mevcut."));

            Console.WriteLine();

            Console.WriteLine("Öğrencinin aldığı puanlara göre öğrenciler: ");
            var findNamesByScore = list.GetStudentByScore(100);
            findNamesByScore.ForEach(st => Console.WriteLine($"{st.Score} puanı almış {st.Name} {st.LastName} isimli öğrenci sınıfta mevcut."));

            Console.WriteLine();
            list.Remove(5);

            foreach (var item in studs)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}
