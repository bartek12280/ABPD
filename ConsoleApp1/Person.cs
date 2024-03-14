namespace ConsoleApp1;

public class Person
{
    private string name;
    private int age;

    
    public Person(){}
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string getName()
    {
        return this.name;
    }
    public void setName(String newName)
    {
        this.name = newName;
    }

    public int getAge()
    {
        return age;
    }

    public void setAge(int newAge)
    {
        this.age = newAge;
    }

    public void printInfo()
    {
        Console.WriteLine("Age: ",age);
        Console.WriteLine("Name: ",name);
    }
}