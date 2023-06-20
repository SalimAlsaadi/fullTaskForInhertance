using System.Drawing;

namespace fullTaskForInhertance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Dog Action");
            dog.makeNoice();
            dog.eat();

            Console.WriteLine("*********************************");

            Cat cat = new Cat();
            Console.WriteLine("Cat Acion");
            cat.makeNoice();
            cat.eat();

            Console.WriteLine("********************************************");

            Circle circle = new Circle();
            Console.WriteLine("print the area of Circle " + circle.getArea(0.0, 0.0, 3.0));
            Console.WriteLine("print the Perimeter of circle " + circle.getPerimeter(3, 0, 0));

            Regtangle rectangle = new Regtangle();
            
            Console.WriteLine("print the area of Rectange " + rectangle.getArea(2,3,0));
            Console.WriteLine("print the perimeter of Rectangle " + rectangle.getPerimeter(0, 4, 3));

            Console.WriteLine("*******************************************************************");

            Employee manager = new Manager("salim", " ", "IT", 10);
            manager.calculatePay();

            Employee secretary = new Secretary("ali", " ", "secretary", 25);
            secretary.calculatePay();
        }
    }
}