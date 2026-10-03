class Vehicle
{
    public string Brand;
    public int Years;
    public Vehicle(string brand, int years)
    {
        Brand = brand;
        Years = years;
    }
    public void Start()
    {
        Console.WriteLine("the Vehicle is starting");
    }
}
class Car : Vehicle
{
    public int Numperofdoor;
    public Car(string brand, int years, int numperofdoor) : base(brand, years)
    {
        Numperofdoor = numperofdoor;
    }

}
class Bus : Vehicle
{
    public int Capacity;
    public Bus(string brand, int years, int capacity) : base(brand, years)
    {
        Capacity = capacity;
    }
}
class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(string brand, int year, bool hasSidecar)
        : base(brand, year)
    {
        HasSidecar = hasSidecar;
    }
}
class programe
{
    static void Main()
    {
        Car c1 = new Car("toyota", 2026, 4);
        Bus b1 = new Bus("costar", 2026, 30);
        Motorcycle m1 = new Motorcycle("copra", 2026, true);
        c1.Start();
        b1.Start();
        m1.Start();
    }
}
