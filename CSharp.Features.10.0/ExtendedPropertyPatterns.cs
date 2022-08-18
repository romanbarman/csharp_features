namespace CSharp.Features._10._0
{
    class ExtendedPropertyPatterns
    {
        public void Run()
        {
            object person = new Person { Name = "Test", Date = DateTime.Now };

            if (person is Person { Date: { Day: 5 } })
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
