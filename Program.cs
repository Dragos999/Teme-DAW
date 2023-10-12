using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Materie matematica=new Materie("Matematica","3 ore");
            Materie informatica = new Materie("Informatica", "2 ore");
            Materie istorie = new Materie("Istorie", "1 ora");
            Materie fizica = new Materie("Fizica", "2 ore");

            List<Materie> materii = new List<Materie>();
            List<Student> studenti = new List<Student>();

            materii.Add(fizica);
            materii.Add(informatica);
            studenti.Add(new Student("Nedelcu", "Dragos", materii));
            materii.Clear();

            materii.Add(matematica);
            materii.Add(fizica);
            materii.Add(informatica);
            materii.Add(istorie);
            studenti.Add(new Student("Popescu", "Ion", materii));
            materii.Clear();

            materii.Add(matematica);
            materii.Add(istorie);
            studenti.Add(new Student("Protopopescu", "Protoion", materii));
            materii.Clear();


            foreach (Student s in studenti)
            {
                s.Afisare();
                Console.Write("--------------------------------------\n");
            }
            Console.ReadKey();
        }

        class Materie
        {
            private string titlu, durata;

            public Materie()
            {
                titlu = "";
                durata = "";
            }
            public Materie(string titlu1,string durata1)
            {
                titlu = titlu1;
                durata = durata1;
            }

            public void Afisare()
            {
                Console.Write(titlu + " (durata: " + durata + ")");
            }
        }
        class Student
        {
            private string nume,prenume;
            private List<Materie> materii;
            public Student()
            {
                nume = "";
                prenume = "";
                materii = null;
            }
            public Student(string nume1,string prenume1,List<Materie>materii1)
            {
                nume = nume1;
                prenume = prenume1;
                materii = new List<Materie>();
                foreach (Materie x in materii1)
                    materii.Add(x);
            }
            
            public void Afisare()
            {
                Console.Write("Studentul " + nume + " " + prenume + " are urmatoarele materii:\n");
                foreach(Materie x in materii)
                {
                    x.Afisare();
                    Console.Write("\n");

                }
            }
        }

        
    }
}
