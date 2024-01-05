
using Learning1.OOPTest;

public interface IPerson {
    void introduction();
    string fullName();
}

public class PersonInterface : IPerson {

    private string firstName;
    private string lastName;

    private int age;
    public PersonInterface(string firstName, string lastName, int age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    public void introduction () {
        Console.WriteLine("My name is {0}, im {1} years old.", this.fullName(), this.age);
    }

    public string fullName () {
        return string.Format("My name is {0} {1}", this.firstName, this.lastName);
    }
}