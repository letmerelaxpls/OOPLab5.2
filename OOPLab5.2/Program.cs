using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOPLab5._2
{
    class ClassRoom
    {
        List<Pupil> pupils = new List<Pupil>();
        public ClassRoom(Pupil pupil1)
        {
            pupils.Add(pupil1);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
            pupils.Add(pupil3);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
            pupils.Add(pupil3);
            pupils.Add(pupil4);
        }
        public void PrintClassRoom()
        {
            foreach(var pupil in pupils)
            {
                Console.Write("Pupil`s name: ");
                pupil.Print();
                pupil.Read();
                pupil.Study();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }

     abstract class Pupil
    {
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
        public abstract void Print();

    }

     class ExcelentPupil : Pupil
    {
        public string name;
        public ExcelentPupil(string n) { name = n;}
        public override void Print()
        {
            Console.WriteLine(name);
        }
        public override void Read()
        {
            Console.WriteLine("Reads a lot");
        }
        public override void Study()
        {
            Console.WriteLine("Studies a lot");
        }
        public override void Write()
        {
            Console.WriteLine("Writes a lot");
        }
        public override void Relax()
        {
            Console.WriteLine("Doesn`t relax");
        }



    }

     class GoodPupil : Pupil
    {
        public string name;
        public GoodPupil(string n) { name = n; }
        public override void Print()
        {
            Console.WriteLine(name);
        }
        public override void Read()
        {
            Console.WriteLine("Reads well");
        }
        public override void Study()
        {
            Console.WriteLine("Studies well");
        }
        public override void Write()
        {
            Console.WriteLine("Writes well");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxes sometimes");
        }
    }

    class BadPupil : Pupil
    {
        public string name;
        public BadPupil(string n) { name = n; }
        public override void Print()
        {
            Console.WriteLine(name);
        }
        public override void Read()
        {
            Console.WriteLine("Doesn`t read");
        }
        public override void Study()
        {
            Console.WriteLine("Doesn`t study");
        }
        public override void Write()
        {
            Console.WriteLine("Doesn`t write");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxes a lot");
        }
    }
    static class Questions
    {
       
    }
    internal class Program
    {
        public static void Questionss()
        {
            Console.WriteLine("This pupil is: ");
            Console.WriteLine("1 - Bad");
            Console.WriteLine("2 - Good");
            Console.WriteLine("3 - Excelent");
        }
        public static void cases(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Questionss();
                int whatpupil1 = int.Parse(Console.ReadLine());
                switch (whatpupil1)
                {
                    case 1:
                        Console.WriteLine("Name: ");
                        ClassRoom classroo = new ClassRoom(new BadPupil(Console.ReadLine()));
                        classroo.PrintClassRoom();
                        break;
                    case 2:
                        Console.WriteLine("Name: ");
                        ClassRoom classro = new ClassRoom(new GoodPupil(Console.ReadLine()));
                        classro.PrintClassRoom();
                        break;
                    case 3:
                        Console.WriteLine("Name: ");
                        ClassRoom classr = new ClassRoom(new ExcelentPupil(Console.ReadLine()));
                        classr.PrintClassRoom();
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many pupils? (Max 4)");
            int pupilsamount = int.Parse(Console.ReadLine());
            switch (pupilsamount)
            {
                case 1:
                    cases(1);
                    break;
                case 2:
                    cases(2);
                    break;
                case 3:
                    cases(3);
                    break;
                case 4:
                    cases(4);
                    break;
            }
        }
    }
}