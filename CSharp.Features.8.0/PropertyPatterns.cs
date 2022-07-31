namespace CSharp.Features._8._0
{
    class PropertyPatterns
    {
        public void Run()
        {
            var person = new Person { Name = "Kiril" };
            person.Id = GetId(person);
        }

        public static int GetId(Person person) => person switch
        {
            { Name: "Kiril" } => 1,
            { Name: "Alexander" } => 2,
            _ => 3
        };
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
