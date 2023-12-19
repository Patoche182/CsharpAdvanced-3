using System;

namespace CsharpAdvanced_3
{
    internal class Program
    {
        public static int age;
        delegate void AgeDelegate(int age);


        public  void Jeune(int age)
        {
            Console.WriteLine("{0} ans, tu es jeune !", age);
        }

        public  void MoinsJeune(int age)
        {
            Console.WriteLine("{0} ans, ah...tu es un peu moins jeune !", age);
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Random random = new Random();
            age = random.Next(0, 100);

            AgeDelegate ageDel;
            ageDel = age < 50                                   // Condition
                ? ageDel = new AgeDelegate(p.Jeune)             // si Condition Vrai ==> ?
                : ageDel = new AgeDelegate(p.MoinsJeune);       // sinon ==> :

            //if (age < 50)
            //{
            //    ageDel = new AgeDelegate(p.Jeune);
            //}
            //else
            //{
            //    ageDel = new AgeDelegate(p.MoinsJeune);
            //}


            ageDel(age);
        }
    }

}