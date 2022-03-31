using System;

namespace homework_enum
{
    class Program
    {
        enum Currecy {Usd=1, Eur ,Try }
        static void Main(string[] args)
        {
            #region task 1 enum
            //bool control = true;
            //while (control)
            //{

            //    Console.WriteLine("Bir valyuta secin");
            //    Console.WriteLine("1: Usd");
            //    Console.WriteLine("2: Eur");
            //    Console.WriteLine("3: Try");
            //    Console.WriteLine("0: Quit");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("nece manati deyishmek isdiyirsiz ?");
            //    double Azn = Convert.ToInt32(Console.ReadLine());
            //    switch (num)
            //    {

            //        case (int)Currecy.Usd:



            //            Console.WriteLine($"Dollar: {Exchange(Currecy.Usd, Azn)}");

            //            break;
            //        case (int)Currecy.Eur:


            //            Console.WriteLine($"Yevro: {Exchange(Currecy.Eur, Azn)}");
            //            break;
            //        case (int)Currecy.Try:


            //            Console.WriteLine($"Lire: {Exchange(Currecy.Try, Azn)}");
            //            break;


            //    }
            //    if (num == 0)
            //    {
            //        control = false;
            //    }

            //}





            //double Exchange(Currecy enum1, double azn)
            //{
            //    if (enum1 == Currecy.Usd)
            //    {
            //        azn = azn * 0.59;
            //        return azn;
            //    }
            //    else if (enum1 == Currecy.Eur)
            //    {
            //        azn = azn * 0.5371;
            //        return azn;
            //    }
            //    else if (enum1 == Currecy.Try)
            //    {
            //        azn = azn * 8.726;
            //        return azn;
            //    }


            //    return azn;
            //}


            #endregion
            Console.WriteLine("cevirmek istediyin selsini yazin");
            Console.Write("Selsi: "); double Num = Convert.ToDouble(Console.ReadLine());
            Celsius celsius = new Celsius(Num);
            Kelvin kelvin = celsius;
            Console.WriteLine($"Kelvin: {kelvin.Degree}");

        }



    }
}
