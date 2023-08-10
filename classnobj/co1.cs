using System;

public class Car
{
    private int speed;
    private bool isMoving;

    public Car()
    {
        speed = 0;
        isMoving = false;
    }

    public void Start()
    {
        if (!isMoving)
        {
            isMoving = true;
            Console.WriteLine("Car has started moving.");
        }
    }

    public void Accelerate(int amount)
    {
        if (isMoving)
        {
            speed += amount;
            Console.WriteLine("Car is now moving at {0} km/h.", speed);
        }
    }

    public void Brake()
    {
        if (isMoving && speed > 0)
        {
            speed = Math.Max(0, speed - 10);
            Console.WriteLine("Car has slowed down to {0} km/h.", speed);
        }
    }

    public void Stop()
    {
        if (isMoving)
        {
            isMoving = false;
            speed = 0;
            Console.WriteLine("Car has stopped moving.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Car car = new Car();
        car.Start();
        car.Accelerate(50);
        car.Brake();
        car.Accelerate(30);
        car.Brake();
        car.Brake();
        car.Brake();
        car.Brake();
        car.Brake();
        car.Stop();
        car.Accelerate(30);
        Console.ReadLine();
    }
}