namespace PPmedJonny
{
    public class Person
    {
        //Navn, alder, hårDesc, Hva vi holder på med, oh hobbyer
        string name { get; set; }
        int age { get; set; }
        string hair { get; set; }
        string[] hobby { get; set; }

        public Person(string _name, int _age, string _hair, string[] _hobby)
        {
            name = _name;
            age = _age;
            hair = _hair;
            hobby = _hobby;
        }

        public void printInfo()
        {
            Console.WriteLine($"Hei, mitt navn er {name}, jeg er {age} år gammel, har {hair} hår");
            foreach (var felt in hobby)
            {
                Console.WriteLine(felt);
            }
            Console.WriteLine();
        }
    }
}