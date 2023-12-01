using System;

class Program
{
    public static void Main(string[] args)
    {
        PhoneBuilder builder = new PhoneBuilder();
        Phone phone = builder
            .setos("Android")
            .setProcessor("Snapdragon")
            .setScreenSize(6.2)
            .setBattery(4000)
            .setCamera(12)
            .getPhone();

        Console.WriteLine(phone);
    }
}

public class Phone
{
    private string os;
    private string processor;
    private double screenSize;
    private int battery;
    private int camera;

    public Phone(string os, string processor, double screenSize, int battery, int camera)
    {
        this.os = os;
        this.processor = processor;
        this.screenSize = screenSize;
        this.battery = battery;
        this.camera = camera;
    }

    public override string ToString()
    {
        return $"Phone Details: OS={os}, Processor={processor}, ScreenSize={screenSize}, Battery={battery}, Camera={camera}";
    }
}

public class PhoneBuilder
{
    private string os;
    private string processor;
    private double screenSize;
    private int battery;
    private int camera;

    public PhoneBuilder setos(string os)
    {
        this.os = os;
        return this;
    }

    public PhoneBuilder setProcessor(string processor)
    {
        this.processor = processor;
        return this;
    }

    public PhoneBuilder setScreenSize(double screenSize)
    {
        this.screenSize = screenSize;
        return this;
    }

    public PhoneBuilder setBattery(int battery)
    {
        this.battery = battery;
        return this;
    }

    public PhoneBuilder setCamera(int camera)
    {
        this.camera = camera;
        return this;
    }

    public Phone getPhone()
    {
        return new Phone(os, processor, screenSize, battery, camera);
    }
}
