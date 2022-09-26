bool keepGoing = true;
do
{
    Console.WriteLine("Welcome to the GC Room Detail Generator");

    Console.WriteLine("\nEnter the length of your room.");

    decimal length = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Enter the width if your room.");

    decimal width = Convert.ToDecimal(Console.ReadLine());

    //using later for surface area and volume
    Console.WriteLine("Enter the height if your room.");

    decimal height = Convert.ToDecimal(Console.ReadLine());
    decimal area = length * width;
    decimal perimeter = (length + width) * 2;

    Console.WriteLine($"\nThe area of the room is {area}.");
    Console.WriteLine($"The perimeter of the room is {perimeter}.");

    if (area is <= 250)
    {
        Console.WriteLine("\nThis is a small-sized room.");
    }
    else if (area is >= 251 && area is <= 649)
    {
        Console.WriteLine("\nThis is a medium-sized room.");
    }
    else
    {
        Console.WriteLine("\nThis is a large-sized room.");
    }

    decimal volume = (length * height * width);
    decimal surfaceArea = (2 * length * width) + (2 * length * height) + (2 * width * height);

    Console.WriteLine($"\nThe volume of the room is {volume} and the surface area of the room is {surfaceArea}.");

    Console.WriteLine("\nWould you like to measure another room? Y/N.");
    string newRoom = Console.ReadLine().ToLower();

    if (newRoom == "n" || newRoom == "no")
    {
        Console.WriteLine("Goodbye");
        keepGoing = false;
    }
}
while (keepGoing);