using System;

namespace tıp_donusumler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("*****Implicit Conversion ********");

            byte a = 5;
            sbyte b = 30;
            short c = 10 ;

            int d = a+b+c;
            Console.WriteLine("d"+d);
            long h = d ;

            Console.WriteLine("h"+h);
            float i =  h;

            Console.WriteLine("i"+i);

            // Explicit Conversion (bilinçli Dönüşüm) // csharp kendi kendine yapamadıgı donusumler

            Console.WriteLine("*****Explicit Conversion ********");
           /* int x = 4;
            byte y ={byte}x;
            Console.WriteLine("y"+y);*/

           /* int z = 100;
            byte t = {byte}z;
             Console.WriteLine("z"+z);*/

            /*float w =    10.3f;
            byte v = {byte}with;
            Console.WriteLine("v:"+v);*/
            
            //*** To String Methodu ****
            Console.WriteLine("*** To String Methodu ****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+yy);

            string zz = 12.5f.ToString();

            //parse
            Console.WriteLine("Parse Methodu");
            ParseMethod();

        }
        public static void ParseMethod(){
            string metin1 = "10";
            string metin2 ="10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1 :"+rakam1);
            
            Console.WriteLine("double1 :"+double1);


        }
    }
}
