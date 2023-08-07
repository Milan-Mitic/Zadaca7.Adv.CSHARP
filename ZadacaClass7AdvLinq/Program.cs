namespace ZadacaClass7AdvLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Select numbers from range

            List<int> numbers = new List<int>() { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };

            var selectNumbersFromRange = numbers.Where(num => num > 40 && num < 70);

            Console.WriteLine("Numbers greater than 40 and less than 70:");
            foreach (var num in selectNumbersFromRange)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("...............................");

            // 2. Minimum length to uppercase

            List<string> animals = new List<string>() { "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion", "sheep", "tiger", "wolf" };

            var filteredAnimals = animals.Where(name => name.Length >= 6)
                                         .Select(name => name.ToUpper());

            Console.WriteLine("List the animals 6 char least and transform to uppercase:");
            foreach (var name in filteredAnimals)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("...............................");


            // 3. Select word with condition

            var startWithHAndEndWithE = animals.Where(animal => animal.StartsWith("h") && animal.EndsWith("e"));


            Console.WriteLine("Animals name starts with H and ends with E:");
            foreach (var animal in startWithHAndEndWithE)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("...............................");


            // 4. Top 5 numbers in descend order 

            var topFiveNumbers = numbers.OrderByDescending(number => number)
                                         .Take(5);

            Console.WriteLine("Top 5 numbers in descending order:");
            foreach (var number in topFiveNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("...............................");


            // 5. Numbers that square is greather than 7000

            var result = numbers.Select(x => new { Number = x, Square = x * x })
                                 .Where(x => x.Square > 7000);

            Console.WriteLine("Numbers that square greather than 7000:");
            foreach (var item in result)
            {
                Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
            }

            Console.WriteLine("...............................");


            // 6. Replace substring

            var modifiedAnimals = animals.Select(animal => animal.Replace("an", "*"));

            Console.WriteLine("Modified Animal Name:");
            foreach (var modifiedAnimal in modifiedAnimals)
            {
                Console.WriteLine(modifiedAnimal);
            }

            Console.WriteLine("...............................");

            // 7.Last word containing letter

            Console.WriteLine("Last word containing letter E:");
            var sortedAnimalsWithE = animals
                               .OrderBy(animal => animal)
                               .Where(animals => animals.Contains('e'))
                               .ToList();

            if (sortedAnimalsWithE.Count > 0)
            {
                string lastNameWithE = sortedAnimalsWithE.Last();
                Console.WriteLine(lastNameWithE);
            }
            else
            {
                Console.WriteLine("No animal name contains the letter 'e'. ");
            }

            Console.WriteLine("...............................");


            // 8. Shuffle an sorted array

            Console.WriteLine("Shuffle an sorted array:");
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var shuffled = input.OrderBy(i => Guid.NewGuid()).ToArray();

            Console.WriteLine(string.Join(" ", shuffled));
        }
    }
}