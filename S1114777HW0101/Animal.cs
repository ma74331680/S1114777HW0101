using System;
class Animal
{
    protected string _name;
    protected string _call;
    protected int _count;
    public static int _objCreateTimes;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Call
    {
        get { return _call; }
        set { _call = value; }
    }

    public int Count
    {
        get { return _count; }
        set { _count = value; }
    }

    public Animal()
    {
        _name = "animal";
        _call = "null";
        _count = 0;
        _objCreateTimes++;
    }

    public void Say()
    {
        Console.WriteLine($"{_count} {_name} say {_call}");
    }
}

class Cat : Animal
{
    public string Name
    {
        get { return _name; }
    }
    public string Call
    {
        get { return _call; }
    }
    public void EatFish()
    {
        Console.WriteLine("The cat just ate a fish");
    }

    public Cat()
    {
        _name = "cat";
        _call = "meow~";
        _count = 0;
        _objCreateTimes++;
    }
}
  
class Tool
{
    public static void Sleep(string name)
    {
        Console.WriteLine($"The {name} is sleeping now");
    }

    public static void ShowNumOfObj()
    {
        Console.WriteLine($"We have {Animal._objCreateTimes} objects");
    }
}