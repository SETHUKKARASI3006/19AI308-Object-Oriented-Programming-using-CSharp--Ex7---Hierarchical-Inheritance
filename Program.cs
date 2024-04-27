using System;
public class Inheritance
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.Display(4);
        Scooter scooty = new Scooter();
        scooty.Display(2);
    }
}
public class Vehicle
{
    public void tyre(int t)
    {
        Console.WriteLine("It have " + t + " tubeless tyre");
    }
}
public class Scooter : Vehicle
{
    public void Display(int x)
    {
        int tyres = x;
        Console.WriteLine("It is the Scooter class");
        base.tyre(tyres);
    }
}
public class Car : Vehicle
{
    public void Display(int x)
    {
        int tyres = x;
        Console.WriteLine("It is the Car class");
        base.tyre(tyres);
    }
}