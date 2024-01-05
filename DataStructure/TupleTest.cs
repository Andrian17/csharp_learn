using Learning1.DataStructure;

class TupleTest {
    public Tuple<string> MyTuple1 = new Tuple<string>("Andrian");
    public Tuple<string, string, int, string> MyTuple2 
        = new Tuple<string, string, int, string>("Andrian", "Cimen", 22, "Bima");

    public Tuple<int, int, int, int, int, int, int, Tuple<int>>MyTuple3 = new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1,2,3,4,5,6,7, new Tuple<int>(8)); 

    public void printTuple() {
        var tuple1 = Tuple.Create(1, 2, 3, 4, Tuple.Create("Andrian", "Cimen", 22));
        System.Console.WriteLine(tuple1.Item1);
        System.Console.WriteLine(tuple1.Item2);
        System.Console.WriteLine(tuple1.Item4);
        System.Console.WriteLine(tuple1.Item5.Item1);
        System.Console.WriteLine(tuple1.Item5.Item2);
        System.Console.WriteLine(tuple1.Item5.Item3);
        System.Console.WriteLine(tuple1.Equals(MyTuple3.Item1));
        System.Console.WriteLine(tuple1.Item5.Item1.Equals(MyTuple2.Item1));
    }
}