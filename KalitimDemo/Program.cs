namespace KalitimDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Memeli insan = new Insan()
            {
                Adi = "Ali",
                
            };
            Console.WriteLine(insan.Yuru());

            Memeli kopek = new Kopek()
            {
                Adi = "Uzay"
            };
            Kopek k = (Kopek)kopek;
            Console.WriteLine(k.Yuru() + k.Havla());

            Memeli kedi = new Kedi()
            {
                Adi = "Gaspi"
            };
            Console.WriteLine(kedi.Yuru());
            
            //Console.WriteLine(k.Yuru() + k.Havla());


        }
    }
    abstract class Memeli // base
    {
        public string Adi { get; set; }

        abstract public string Yuru();
        
        
    }
    class Insan : Memeli 
    {
        public override string Yuru()
        {
            return Adi + " İnsan 2 ayakla yürür";
        }
    }
    class Kopek : Memeli
    {


        public override string Yuru()
        {
            return Adi + " Köpek 4 ayakla yürür";
        }
        public string Havla()
        {
            return " Havlar";
        }
        
    }
    class Kedi : Memeli
    {
        public override string Yuru()
        {
            return Adi + " Kedi 4 ayakla yürür";
        }
    }


}