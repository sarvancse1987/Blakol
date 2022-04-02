using Blakol_SalesTax;

public class Program
{
    public static void Main()
    {
        var input1 = new[]
       {
            "1 book at 12.49",
            "1 music CD at 14.99",
            "1 chocolate bar at 0.85"
        };

        var input2 = new[]
        {
            "1 imported box of chocolates at 10.00",
            "1 imported bottle of perfume at 47.50"
        };

        var input3 = new[]
        {
            "1 imported bottle of perfume at 27.99",
            "1 bottle of perfume at 18.99",
            "1 packet of headache pills at 9.75",
            "1 box of imported chocolates at 11.25"
        };


        Blakol_Input.ProcessInput(input1);
        Console.WriteLine("--------------------------------------------------");

        Blakol_Input.ProcessInput(input2);
        Console.WriteLine("--------------------------------------------------");

        Blakol_Input.ProcessInput(input3);
        Console.WriteLine("--------------------------------------------------");
    }
}