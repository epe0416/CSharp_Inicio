partial class Program
{
    public static void Inheritance()
    {
        HogwarsStudent student = new HogwarsStudent() { Name = "Harry Potter", House = "Gryffindor" };
        HogwarsProfessor professor = new HogwarsProfessor() { Name = "Severus Snape", Subject = "Pociones" };

        student.Greet();
        student.ShowHouse();
        professor.Greet();
        professor.MySubject();
    }
}
class Character
{
    public string? Name { get; set; }
    public virtual void Greet()
    {
        WriteLine($"Hola, soy {Name}");
    }
}

class HogwarsStudent : Character
{
    public string? House { get; set; }
    public override void Greet()
    {

        WriteLine($"Hola, soy {Name} y soy Estudiante");
        
    }
    public void ShowHouse()
    {
        WriteLine($"Pertenezco a la casa {House} en Howgarts");
    }
}
class HogwarsProfessor : Character
{
    public string? Subject { get; set; }
    public override void Greet()
    {
        WriteLine($"Hola, soy{Name} y soy profesor");
    }
    public void MySubject()
    {
        WriteLine($"Enseño {Subject} en Howgarts");
    }
}