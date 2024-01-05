using Learning1.OOPTest;
using System.IO;
using System;
using Learning1.DataStructure;
using System.Collections;
using Learning1.CollectionGenerics;

class Program
{
    enum Level
    {
        Low, Medium, High
    }

    static void Main(String[] args)
    {
        Cat cat = new Cat();
        cat.Name = "Beni";
        cat.voice();
        cat.animalSound();
        Console.WriteLine(cat.Name);
        cat.sleep();
        Console.WriteLine(cat.testName("Beni"));

        Level lvl = Level.Medium;
        switch (lvl)
        {
            case Level.Low:
                Console.WriteLine($"Level is {lvl}");
                break;
            case Level.Medium:
                Console.WriteLine($"Level is {lvl}");
                break;
            case Level.High:
                Console.WriteLine($"Level us {lvl}");
                break;
            default:
                Console.WriteLine("Level undefined");
                break;
        }

        try {
            string loremIpsum = "lorem ipsum dolor si amet.";
            File.WriteAllText("lorem_ipsum.txt", loremIpsum);

            string resultLoremIpsum = File.ReadAllText("lorem_ipsum.txt");
            Console.WriteLine(resultLoremIpsum);
        } catch(Exception e){
            Console.WriteLine(e.Message);
        }

        PersonDetail person = new("Andrian", 22, "Male", "Mataram");
        person.printPerson();

        PersonInterface personInterface = new("Andrian", "Cimen", 22);
        Console.WriteLine(personInterface.fullName());
        personInterface.introduction();

        ArrayTest listStudents = new ArrayTest();
        foreach (var item in listStudents.students)
        {
            Console.WriteLine("Hy: {0}", item);
        }

        // listStudents.classOfStudents[3] = 4;
        foreach (var item in listStudents.classOfStudents)
        {
            Console.WriteLine("Class : {0}", item);
        }

        string [] animals = {"Leon", "Tiger", "Eagle"};
        // animals[4] = "Messi";
        foreach (var animal in animals)
        {
            Console.WriteLine("Name animal : {0}", animal);
        }

        string [] [] frameworkIt = new string [3][];
        frameworkIt[0] = new string[] {"PHP", "Laravel", "Codeigniter"};
        frameworkIt[1] = new string[] {"Python", "Flask", "Django"};
        frameworkIt[2] = new string[] {"Dotnet", "Csharp", "VB"};

        for (int i = 0; i <= frameworkIt.Length - 1; i++)
        {
            for (int j = 0; j <= frameworkIt[i].Length - 1; j++)
            {
                Console.WriteLine("Tools : {0}", frameworkIt[i][j]);
            }
        }

        // Console.WriteLine(animals);
        IList<string> myList = Array.AsReadOnly(animals);
        // Console.WriteLine(myList);

        foreach (var item in myList)
        {
            // System.Console.WriteLine(item);
        }

        string? resultAnimal = Array.Find(animals, animal => animal == "Leon");
        System.Console.WriteLine("Result: {0}", resultAnimal);
        System.Console.WriteLine("========================================");

        Array.ForEach(animals, (animal) => {
            System.Console.WriteLine(animal);
        });

        Action<string> animalSound = new Action<string>(soundAnimal);
        Array.ForEach(animals, animalSound);

        System.Console.WriteLine("------------------------------------------");
        ArrayListTest arrayList = new();
        arrayList.ArrayListAja();
        arrayList.students?.Remove("Cimen");
        arrayList.students?.Add("Ali");
        arrayList.printArray();
        Console.WriteLine(arrayList.CountArray());

        ArrayList? arrayList1 = (ArrayList?)(arrayList?.students?.Clone());
        System.Console.WriteLine(arrayList1?.Count);

        TupleTest tupleTest = new();
        tupleTest.printTuple();

        MyCollection myCollection = new();
        // Setting values using multiple parameter indexer
        myCollection[0, false] = 5;
        myCollection[1, false] = 10;
        myCollection[2, false] = 15;
        myCollection[3, false] = 20;
 
        // Getting values using multiple parameter indexer
        Console.WriteLine(myCollection[0, false]);  
        Console.WriteLine(myCollection[1, true]);   
 
        // Getting values using string parameter indexer
        Console.WriteLine(myCollection["first"]);   
        Console.WriteLine(myCollection["last"]);    
 
        // Getting values using read-only indexer
        Console.WriteLine(myCollection[2]); 

        System.Console.WriteLine("====================================");
        CollectionTest1 collectionTest1 = new();
        collectionTest1.MyCollectionTest();

        System.Console.WriteLine("================Generic===========");
        GenericsTest1<string> genericsTest1 = new GenericsTest1<string>();
        genericsTest1.Value = "Andrian";
        System.Console.WriteLine(genericsTest1.Value);

        GenericsTest1<int> genericsTest2 = new GenericsTest1<int>();
        System.Console.WriteLine(genericsTest2.Value);
        genericsTest2.Value = 100;
        System.Console.WriteLine(genericsTest2.Value);

        genericMethodDisplay<string>("name", "Andrian");
        genericMethodDisplay<int>("Umur", 22);
        genericMethodDisplay<double>("BB", 52.3);

        System.Console.WriteLine("================List===============");
        ListTest1 listTest1 = new();
        listTest1.printList();
        listTest1.listClass.Add(1);
        listTest1.listClass.Add(2);
        listTest1.listClass.Add(3);
        listTest1.listClass.Add(4);
        listTest1.listClass.Add(5);
        listTest1.listClass.Add(6);
        listTest1.listClass.RemoveAt(0);
        listTest1.listClass.ForEach((myNum) => {
            System.Console.WriteLine(myNum);
        });
    }

    public static void soundAnimal(string animal) {
        if (animal == "Leon")
        {
            System.Console.WriteLine("Rowwww");
        } else
        {
            System.Console.WriteLine("zzzzzzzzzz");
        }
    }

    // Generics method
    public static void genericMethodDisplay<DataType>(string name, DataType dataType) {
        System.Console.WriteLine("{0}: {1}", name, dataType);
    }

    
}
