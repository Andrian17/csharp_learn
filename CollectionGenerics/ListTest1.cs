namespace Learning1.CollectionGenerics;

class ListTest1
{
    public List<int> listClass = new();
    public void printList() {
        List<string> students = new List<string>();
        students.Add("Andrian");
        students.Add("Cimen");
        students.Add("Ali");
        students.Add("Hadi");
        students.Add("Liana");
        students.Add("Nadine");

        students.Sort();
        students.RemoveAt(students.Count - 1);

        foreach (var item in students)
        {
            System.Console.WriteLine(item);
        }
    }
}