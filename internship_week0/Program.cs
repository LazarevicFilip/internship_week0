// See https://aka.ms/new-console-template for more information
using internship_week0;
using internship_week0.Domain;

Console.WriteLine("Hello, World!");

//polimorfizam
var dog = new Dog("Dog 1",20,"black");
var cat = new Cat("Cat 1",5,"White");
Test(dog);
Test(cat);

static void Test(ICommunication communication)
{
    communication.Communicate();
}


int x = 2;
//passing copy of the variable
static void PassingValue(int x)
{
    x = 6;
    Console.WriteLine(x);
}
PassingValue(x);
Console.WriteLine(x);


//passing ref to the var
static void PassingRef(Dog dog)
{
    dog.Weight = 10;
    Console.WriteLine(dog.Weight);
}
PassingRef(dog);
Console.WriteLine(dog.Weight);

var s = new CollectionExercise();
//s.StackTest();


var sd = new AlgorithamExercise();
sd.SortArray(new int[] { 2, 3, 2, 5, 6, 4, 4, 9 }).ToList().ForEach(x => Console.Write(x));
