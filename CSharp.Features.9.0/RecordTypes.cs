namespace CSharp.Features._9._0
{
    class RecordTypes
    {
        public void Run()
        {
            //Positional syntax for property definition
            {
                Person1 person = new("Nancy", "Davolio");
                Console.WriteLine(person); // output: Person { FirstName = Nancy, LastName = Davolio }
            }

            //Value equality
            {
                var phoneNumbers = new string[2];
                Person person1 = new("Nancy", "Davolio") { PhoneNumbers = phoneNumbers };
                Person person2 = new("Nancy", "Davolio") { PhoneNumbers = phoneNumbers };
                Console.WriteLine(person1 == person2); // output: True

                person1.PhoneNumbers[0] = "555-1234";
                Console.WriteLine(person1 == person2); // output: True

                Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
            }

            //Nondestructive mutation
            {
                Person person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
                Console.WriteLine(person1); // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

                Person person2 = person1 with { FirstName = "John" };
                Console.WriteLine(person2); // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
                Console.WriteLine(person1 == person2); // output: False

                person2 = person1 with { PhoneNumbers = new string[1] };
                Console.WriteLine(person2); // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
                Console.WriteLine(person1 == person2); // output: False

                person2 = person1 with { };
                Console.WriteLine(person1 == person2); // output: True
            }

            //Inheritance
            {
                Person4 teacher = new Teacher("Nancy", "Davolio", 3);
                Console.WriteLine(teacher); // output: Teacher { FirstName = Nancy, LastName = Davolio, Grade = 3 }
            }

            //Inheritance
            {
                Person4 teacher = new Teacher("Nancy", "Davolio", 3);
                Person4 student = new Student("Nancy", "Davolio", 3);
                Console.WriteLine(teacher == student); // output: False

                Student student2 = new Student("Nancy", "Davolio", 3);
                Console.WriteLine(student2 == student); // output: True
            }
        }
    }

    public record Person(string FirstName, string LastName)
    {
        public string[]? PhoneNumbers { get; init; }
    };

    public record Person1(string FirstName, string LastName);

    public record Person2
    {
        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default!;
    };

    public record Person3
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    };

    public abstract record Person4(string FirstName, string LastName);
    public record Teacher(string FirstName, string LastName, int Grade)
    : Person4(FirstName, LastName);
    public record Student(string FirstName, string LastName, int Grade)
    : Person4(FirstName, LastName);
}
