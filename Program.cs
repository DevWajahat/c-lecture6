using System.Drawing;

namespace c__lecture_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
          Cow cowobj  = new Cow();
            cowobj.name = "cow";
            cowobj.legs = 4;
            cowobj.eye = 2;
            cowobj.Color = "brown";
            
            cowobj.details();
            Console.WriteLine("It has " + cowobj.legs + " legs " + " and " + cowobj.eye + " eyes");

            dog dobj = new dog();
            dobj.name = "dog";
            dobj.legs = 4;
            dobj.eye = 2;
            dobj.Color = "black";

            dobj.details();
            Console.WriteLine("It has " + dobj.legs + " legs " + " and " + dobj.eye + " eyes");
        }
    }

    public class Animal
    {
        public string name;
        public string Color;
        public int eye;
        public int legs;

    }
    public class Cow : Animal
    {
        public void details()
        {
            Console.WriteLine("The name of animal is "+name+" and its color is " + Color);
        }


    }
    public class dog : Animal { 
    public void details()
        {
            Console.WriteLine("The name of animal is " + name + " and its color is " + Color);
        }
    }
}