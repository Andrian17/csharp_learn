
namespace Learning1.DataStructure;
using System.Collections;

public class ArrayListTest {
    public ArrayList? students = new ();
    public void ArrayListAja() {
        students?.Add("Andrian");
        students?.Add("Cimen");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        foreach (var item in students)
        {
            System.Console.WriteLine(item);
        }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }

    public void printArray() {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        foreach (var item in students)
        {
            System.Console.WriteLine(item);
        }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }

    public int CountArray() {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        return students.Count;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}