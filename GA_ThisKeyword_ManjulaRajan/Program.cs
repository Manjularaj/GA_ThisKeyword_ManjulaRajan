namespace GA_ThisKeyword_ManjulaRajan
{

    //Manjula Rajan
    //Date;3/14/2024
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alice", 25);
            person1.Display(); // Outputs: Name: Alice, Age: 25

            Person person2 = new Person("Bob");
            person2.Display(); // Outputs: Name: Bob, Age: 0
            person2.SetAge(30);
            person2.Display(); // Outputs: Name: Bob, Age: 30
        }
    }
}