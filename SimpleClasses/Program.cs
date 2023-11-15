 namespace SimpleClasses;

class Program
{
    static void Main(string[] args)
    {

       // instantiate the class
        Car myCar = new Car();

        // setting the property
        myCar.Make = "OldsMobile";
        myCar.Model = "corolla";
        myCar.Year = 2009;
        myCar.Color = "blue";

        // getting the property
        Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

        Console.WriteLine("{0:C}" , myCar.DetermineMarketValue());

       // decimal value = DetermineMarketValue(myCar);
       // Console.WriteLine("{0:C}", value);
    }

    private static decimal DetermineMarketValue(Car car)
    {
        decimal carValue = 100.0M;
        return carValue;
    }
}

 class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }


    public decimal DetermineMarketValue()
    {
        decimal carValue;

        if (Year > 1990)
        {
            carValue = 1000;
        }
        else
        {
            carValue = 2000;
        }

        return carValue;
    }


}

