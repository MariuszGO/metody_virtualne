namespace metody_virtualne
{
    public class Samochod
    {
        public string marka;
        public string model;
        public int rok;
    
    public virtual void wyswietl()
        {
            Console.WriteLine("To jest samochod" + marka + " " + model);
        }
    
    }

    public class Osobowy : Samochod
    {
        public override void wyswietl()
        {
            Console.WriteLine("To jest samochod osobowy: " + marka + " " + model);
        }
    }

    public class Ciezarowka : Samochod
    {
        public override void wyswietl()
        {
            Console.WriteLine("To jest samochod ciężarowy: " + marka + " " + model);
        }
    }

    public class Autobus : Samochod
    {
        public override void wyswietl()
        {
            Console.WriteLine("To jest autobus: " + marka + " " + model);
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
           

            Samochod a1 = new Osobowy();
            Samochod b1 = new Ciezarowka();
            Samochod c1 = new Autobus();


            a1.wyswietl();
            b1.wyswietl();
            c1.wyswietl();


        }
    }
}
