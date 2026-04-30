partial class Program
{
    static void AbstracClassExamples()
    {
        HomeAppliance myWasher = new WhashingMachine { Brand = "LG" };
        HomeAppliance myMicrowave = new Microwave { Brand = "Samsung" };
        myWasher.ShowBrand();
        myWasher.TurnOn();
    }
}
public abstract class HomeAppliance
{
    public string? Brand { get; set; }
    public abstract void TurnOn();
    public void ShowBrand()
    {
        WriteLine($"La marca del electrodoméstico es {Brand}");
    }
}

class WhashingMachine : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("La lavadora a iniciado el ciclo de lavado");
    }
}
class Microwave : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("El microondas esta calentando la comida.");
    }
}