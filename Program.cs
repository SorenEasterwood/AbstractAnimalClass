using System.Net.Security;

namespace AbstractAnimalClass
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Program
    {
        class BlobFish : Animal
        {
            public int Age { get; set; }
            public override string Name { get; set; }
            public string Gender { get; set; }
            public BlobFish()
            {
                Age = 0;
                Name = string.Empty;
                Gender = string.Empty;
            }
            public BlobFish(int age, string name, string gender)
            {
                Age = age;
                Name = name;
                Gender = gender;
            }
            public override string Describe()
            {
                return $"Age: {Age}, Name: {Name}, Gender: {Gender}";
            }
        }
        static void Main(string[] args)
        {
            BlobFish bobby = new BlobFish();
            bobby.Age = 10;
            bobby.Name = "Bobby";
            bobby.Gender = "Male";

            BlobFish becky = new BlobFish(8, "Becky", "Female");
            
            Console.WriteLine(bobby.Describe());
            Console.WriteLine();
            Console.WriteLine(becky.Describe());
            Console.ReadLine();
        }
    }
}
