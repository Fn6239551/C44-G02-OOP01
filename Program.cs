namespace solv_of_OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region 2.Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //person[] persons = new person[3];
            //persons[0] = new person("Alice", 30);
            //persons[1] = new person("Bob", 25);
            //persons[2] = new person("Charlie", 35);
            //foreach (var p in persons)
            //{
            //    Console.WriteLine($"Name: {p.name}, Age: {p.age}");
            //}
            #endregion

            #region 3.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();
            //bool isValidSeason = Enum.TryParse(input, true, out Season season);
            //if (isValidSeason)
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}
            #endregion

            #region 4.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color :");
            //string colorInput = Console.ReadLine();
            //bool isValidColor = Enum.TryParse(colorInput, true, out Colors color);
            //if(isValidColor)
            //{
            //    Console.WriteLine( "This is a primary color." );
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color entered.");
            //}
            #endregion

            #region 5.Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter X for first point1:");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Y for first point1:");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter X for second point2:");
            //double x2 = Convert.ToDouble(Console.ReadLine());]
            //Console.WriteLine("Enter Y for second point2:");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);
            //double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            //Console.WriteLine($"The distance between the points ({point1.X}, {point1.Y}) and ({point2.X}, {point2.Y}) is {distance}.");
            #endregion

            #region 6.Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //person[] persons = new person[3];
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Enter name for person {i + 1}:");
            //    string name = Console.ReadLine();
            //    Console.WriteLine($"Enter age for person {i + 1}:");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    persons[i] = new person(name, age);
            //}
            //person oldestPerson = persons[0];
            //foreach (var p in persons)
            //{
            //    if (p.age > oldestPerson.age)
            //    {
            //        oldestPerson = p;
            //    }
            //}
            //Console.WriteLine($"The oldest person is {oldestPerson.name} with age {oldestPerson.age}.");

            #endregion
   
        }
    }
}
