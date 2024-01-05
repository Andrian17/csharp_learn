namespace Learning1.DataStructure;
struct Person
{
    public string name;
    public string gender;
    public int age;
    public string address;

    public void describeMe() {
        Console.WriteLine("My name is {0}, im {1} years old, im {2} from {3}", name, age, gender, address);
    }
}

public class PersonDetail
{
    public string name;
    public string gender;
    public int age;
    public string address;
    public PersonDetail (string name, int age, string gender, string address) {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.address = address;

    }

    public void printPerson () {
        Person andrian;
        andrian.name = this.name;
        andrian.age = this.age;
        andrian.gender = this.gender;
        andrian.address = this.address;
        andrian.describeMe();
        // Console.WriteLine("Nama saya " + andrian.name + " umur: " + andrian.age);
    }
}