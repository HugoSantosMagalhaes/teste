using System;
using System.Linq;

class MainClass
{


    public static void Main(string[] args)
    {

        int r = 4, p = 0;

        Console.WriteLine("total de dados d3: {0}, e um d{1}:", r/3, r%3 );

        //double fatr = 1;
        //while (r != 1)
        //{
        //    fatr *= r;
        //    r--;
        //}
        //Console.WriteLine( fatr);

        double seila = 1;

        for (int i = 0; i < r; i++)
        {
            seila *= 3;
        }
        
        Console.WriteLine(seila);
        Console.WriteLine((3 / seila)*100);
        /*
        * 1 1 1 1
        * 1 1 2
        * 1 3
        * 2 2
        * 
        * 3 1
        * 2 1 1
        * 1 2 1
        * 2 2
        * 1 1 1 1
        * 1 1 1 1
        * 1 1 1 1
       
        */














    }



    


}