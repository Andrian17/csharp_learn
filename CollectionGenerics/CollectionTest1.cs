
namespace Learning1.CollectionGenerics;

using System.Collections.ObjectModel;
using Learning1.CollectionGenerics;

public class CollectionTest1
{
    public void MyCollectionTest() {
        Collection<string> students = new();
        students.Add("Andrian"); 
        students.Add("Cimen"); 
        students.Add("Ali");

        foreach (var item in students)
        {
            System.Console.WriteLine(item);
        }
        students.Remove("Andrian");
        
        System.Console.WriteLine(students.IndexOf("Cimen"));

        foreach (var item in students)
        {
            System.Console.WriteLine(item);
        }
    }
}