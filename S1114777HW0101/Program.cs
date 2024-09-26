using System;
class Program
{   
    static void Main()
    {
        Tool.ShowNumOfObj();
        Animal animal1 = new Animal();
        animal1.Say();
        Tool.ShowNumOfObj();
        Animal animal2 = new Animal();
        animal2.Name = "dog";
        animal2.Count = 2;
        animal2.Call = "Woo~";
        animal2.Say();
        Tool.ShowNumOfObj();
        Cat cat = new Cat();
        cat.Count = 3;
        cat.Say();
        Tool.ShowNumOfObj();
        cat.EatFish();
        Tool.Sleep(cat.Name);
    }
}
