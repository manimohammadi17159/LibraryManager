namespace ConsoleApp1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ali";
            Console.WriteLine(person.Name);
            person.ChangeName("Mani");
            Console.WriteLine(person.Name);
        }
        static void ChangeName(this Person person, string name)
        {
            person.Name = name;


        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}