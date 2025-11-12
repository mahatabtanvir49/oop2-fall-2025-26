class House
{
    public int BuildYear { get; set; }
    public double Size { get; set; }

    public House(int buildYear, double size)
    {
        this.BuildYear = buildYear;
        this.Size = size;
    }

    private int HowOld()
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - BuildYear;
        return age;
    }

    public bool CanBeSold()
    {
        int age = HowOld();
        if (age > 15)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"House Built In: {BuildYear}");
        Console.WriteLine($"Size: {Size} sq. ft.");
        Console.WriteLine($"Can be sold: {CanBeSold()}");
    }
}

class Program
{
    static void Main()
    {
        House myHouse = new House(2003, 1107);
        myHouse.ShowInfo();
        Console.ReadLine();
    }
}
