using System;

//namespace MoneyAndProduct
//{
//    public class Money
//    {
//        private int wholePart;

//        private int fractionalPart;

//        public Money(int wholePart, int fractionalPart)
//        {
//            this.wholePart = wholePart;
//            this.fractionalPart = fractionalPart;
//        }
//        public int GetWholePart()
//        {
//            return wholePart;
//        }

//        public int GetFractionalPart()
//        {
//            return fractionalPart;
//        }

//        public void Display()
//        {
//            Console.WriteLine("{0}.{1}", wholePart, fractionalPart);
//        }

//        public void SetWholePart(int wholePart)
//        {
//            this.wholePart = wholePart;
//        }

//        public void SetFractionalPart(int fractionalPart)
//        {
//            this.fractionalPart = fractionalPart;
//        }
//    }

//    public class Product
//    {
//        private string name;

//        private Money price;

//        public Product(string name, Money price)
//        {
//            this.name = name;
//            this.price = price;
//        }


//        public void ReducePrice(Money amount)
//        {
//            int newWholePart = price.GetWholePart() - amount.GetWholePart();
//            int newFractionalPart = price.GetFractionalPart() - amount.GetFractionalPart();

//            if (newFractionalPart < 0)
//            {
//                newWholePart--;
//                newFractionalPart += 100;
//            }

//            price.SetWholePart(newWholePart);
//            price.SetFractionalPart(newFractionalPart);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Money price = new Money(100, 50);
//            price.Display(); 

//            price.SetWholePart(200);
//            price.SetFractionalPart(25);
//            price.Display(); 

//            Product product = new Product("Phone", price);
//            product.ReducePrice(new Money(50, 0));
//            price.Display(); 
//        }
//    }
//}


//namespace Devices
//{
//    public class Device
//    {
//        private string name;

//        public Device(string name)
//        {
//            this.name = name;
//        }

//        public virtual void Sound()
//        {
//            Console.WriteLine("Beep beep!");
//        }

//        public void Show()
//        {
//            Console.WriteLine("Name: {0}", name);
//        }

//        public virtual void Desc()
//        {
//            Console.WriteLine("This is a device.");
//        }
//    }

//    public class Kettle : Device
//    {
//        public Kettle(string name) : base(name)
//        {
//        }

//        public override void Sound()
//        {
//            Console.WriteLine("Boiling water!");
//        }

//        public override void Desc()
//        {
//            Console.WriteLine("This is a kettle for boiling water.");
//        }
//    }

//    public class Microwave : Device
//    {
//        public Microwave(string name) : base(name)
//        {
//        }

//        public override void Sound()
//        {
//            Console.WriteLine("Heating food!");
//        }

//        public override void Desc()
//        {
//            Console.WriteLine("This is a microwave for heating food.");
//        }
//    }

//    public class Car : Device
//    {
//        public Car(string name) : base(name)
//        {
//        }

//        public override void Sound()
//        {
//            Console.WriteLine("Vroom vroom!");
//        }

//        public override void Desc()
//        {
//            Console.WriteLine("This is a car for transportation.");
//        }
//    }

//    public class Steamship : Device
//    {
//        public Steamship(string name) : base(name)
//        {
//        }

//        public override void Sound()
//        {
//            Console.WriteLine("Chugging along!");
//        }

//        public override void Desc()
//        {
//            Console.WriteLine("This is a steamship for transportation on water.");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Kettle kettle = new Kettle("Kettle");
//            Microwave microwave = new Microwave("Microwave");
//            Car car = new Car("Car");
//            Steamship steamship = new Steamship("Steamship");

//            kettle.Sound();
//            kettle.Show();
//            kettle.Desc();

//            microwave.Sound();
//            microwave.Show();
//            microwave.Desc();

//            car.Sound();
//            car.Show();
//            car.Desc();

//            steamship.Sound();
//            steamship.Show();
//            steamship.Desc();
//        }
//    }
//}


//namespace MusicalInstruments
//{
//    public class MusicalInstrument
//    {
//        private string name;

//        public MusicalInstrument(string name)
//        {
//            this.name = name;
//        }

//        public virtual void Sound()
//        {
//            Console.WriteLine("Playing music!");
//        }

//        public void Show()
//        {
//            Console.WriteLine("Name: {0}", name);
//        }

//        public virtual void Desc()
//        {
//            Console.WriteLine("This is a musical instrument.");
//        }

//        public virtual void History()
//        {
//            Console.WriteLine("This musical instrument has a long and rich history.");
//        }
//    }

//    public class Violin : MusicalInstrument
//    {
//        public Violin(string name) : base(name)
//        {
//        }

//        public override void Sound()
//        {
//            Console.WriteLine("Playing beautiful violin music!");
//        }

//        public override void Desc()
//        {
//            Console.WriteLine("This is a violin, a stringed musical instrument played with a bow.");
//        }

//        public override void History()
//        {
//            Console.WriteLine("The violin was first developed in the 16th century in Italy.");
//        }
//    }

//    public class Trombone : MusicalInstrument
//    {
//        public Trombone(string name) : base(name)
//        {
//        }

//        public override void Sound()
//        {
//            Console.WriteLine("Playing powerful trombone music!");
//        }

//        public override void Desc()
//        {
//            Console.WriteLine("This is a trombone, a brass musical instrument played with a slide.");
//        }

//        public override void History()
//        {
//            Console.WriteLine("The trombone was first developed in the 15th century in Europe.");
//        }
//    }

//    public class Ukulele : MusicalInstrument
//    {
//        public Ukulele(string name) : base(name)
//        {
//        }

//        public override void Sound()
//        {
//            Console.WriteLine("Playing cheerful ukulele music!");
//        }

//        public override void Desc()
//        {
//            Console.WriteLine("This is a ukulele, a small stringed musical instrument played with fingers.");
//        }

//        public override void History()
//        {
//            Console.WriteLine("The ukulele was first developed in the 19th century in Hawaii.");
//        }
//    }

//    public class Cello : MusicalInstrument
//    {
//        public Cello(string name) : base(name)
//        {
//        }

//        public override void Sound()
//        {
//            Console.WriteLine("Playing beautiful cello music!");
//        }

//        public override void Desc()
//        {
//            Console.WriteLine("This is a cello, a large stringed musical instrument played with a bow.");
//        }

//        public override void History()
//        {
//            Console.WriteLine("The cello was first developed in the 16th century in Italy.");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Violin violin = new Violin("Violin");
//            Trombone trombone = new Trombone("Trombone");
//            Ukulele ukulele = new Ukulele("Ukulele");
//            Cello cello = new Cello("Cello");

//            violin.Sound();
//            violin.Show();
//            violin.Desc();
//            violin.History();

//            trombone.Sound();
//            trombone.Show();
//            trombone.Desc();
//            trombone.History();

//            ukulele.Sound();
//            ukulele.Show();
//            ukulele.Desc();
//            ukulele.History();

//            cello.Sound();
//            cello.Show();
//            cello.Desc();
//            cello.History();
//        }
//    }
//}

namespace Workers
{
    public abstract class Worker
    {
        private string name;

        public Worker(string name)
        {
            this.name = name;
        }

        public string getName ()
        {
            return name;
        }
        public abstract void Print();
    }

    public class President : Worker
    {
        public President(string name) : base(name)
        {
        }

        public override void Print()
        {
            Console.WriteLine("Name: {0}", getName());
            Console.WriteLine("Position: President");
            Console.WriteLine("Responsibilities: Leading the company and making strategic decisions.");
        }
    }

    public class Security : Worker
    {
        public Security(string name) : base(name)
        {
        }

        public override void Print()
        {
            Console.WriteLine("Name: {0}", getName());
            Console.WriteLine("Position: Security");
            Console.WriteLine("Responsibilities: Protecting the company and its employees.");
        }
    }

    public class Manager : Worker
    {
        public Manager(string name) : base(name)
        {
        }

        public override void Print()
        {
            Console.WriteLine("Name: {0}", getName());
            Console.WriteLine("Position: Manager");
            Console.WriteLine("Responsibilities: Managing a team and coordinating their work.");
        }
    }

    public class Engineer : Worker
    {
        public Engineer(string name) : base(name)
        {
        }

        public override void Print()
        {
            Console.WriteLine("Name: {0}", getName());
            Console.WriteLine("Position: Engineer");
            Console.WriteLine("Responsibilities: Designing and building technical solutions.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            President president = new President("John Smith");
            Security security = new Security("Jane Doe");
            Manager manager = new Manager("Bob Johnson");
            Engineer engineer = new Engineer("Alice Lee");

            president.Print();
            security.Print();
            manager.Print();
            engineer.Print();
        }
    }
}
