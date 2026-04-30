/*
=============
🏆 Ejercicio 
=============
*/

// 1. Crear una clase base "Employee" con las siguientes propiedades protegidas:
//    - Name (string)
//    - Salary (double)
//    - Position (string)
//
// 2. Implementar un constructor en "Employee" que inicialice sus valores.
//
// 3. Agregar un método virtual "CalculateBonus()" que retorne un bono del 5% del salario.
//
// 4. Agregar un método "ShowInfo()" que muestre los detalles del empleado:
//    - Nombre
//    - Cargo
//    - Salario
//    - Bono calculado
//
// 5. Crear dos clases derivadas de "Employee":
//    - "TeamLeader": Su bono es del 10% del salario.
//    - "Developer": Su bono es del 7% del salario.
//
// 6. Instanciar una lista de empleados con al menos los siguientes datos:
//    - Carlos (Team Leader, 5000)
//    - Ana (Developer, 4000)
//    - Laura (Team Leader, 6000)
//    - Luis (Developer, 3500)
//
// 7. Recorrer la lista de empleados y mostrar la información de cada uno con el método "ShowInfo()".


partial class Program
{
    static void ShowEmployeesInformation()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new TeamLeader("Carlos", 5000));
        employees.Add(new Developer("Ana", 4000));
        employees.Add(new TeamLeader("Laura", 6000));
        employees.Add(new Developer("Luis", 3500));
        WriteLine("Lista de empleados: ");
        foreach (var employee in employees) 
        {
            employee.ShowInfo();
        }
    }
}

class Employee
{
    protected string? Name { get; set; }
    protected string? Position { get; set; }
    protected double Salary { get; set; }
    public Employee (string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }
    public virtual double CalculateBonus()
    {
        return Salary * 0.05;
    }
    public void ShowInfo() {
        WriteLine($"Nombre: {Name}, Cargo: {Position}, Salario = {Salary}, Bono calculado = {CalculateBonus():C}");
    }
}

class TeamLeader : Employee
{
    public TeamLeader(string name, double salary) : base(name, salary, "Team Leader") { }
    public override double CalculateBonus()
    {
        return Salary * 0.10;
    }
}

class Developer : Employee
{
    public Developer(string name, double salary) : base(name, salary, "Developer") { }
    public override double CalculateBonus()
    {
        return Salary * 0.07;
    }
}