partial class Program
{
    static void FileExample()
    {
        var filePath = "F:\\Dev\\Cursos\\DevTalles\\CSharp\\CSharp_Inicio\\CSharp_Inicio\\05-Files\\ejemplo.txt";
        var content = File.ReadAllText("F:\\Dev\\Cursos\\DevTalles\\CSharp\\CSharp_Inicio\\CSharp_Inicio\\05-Files\\ejemplo.txt");
        //WriteLine(content);
        var lines = File.ReadAllLines(filePath);
        foreach(var line in lines)
        {
            WriteLine(line);
        }
        WriteLine(lines[1]);
        File.Copy(filePath, "F:\\Dev\\Cursos\\DevTalles\\CSharp\\CSharp_Inicio\\CSharp_Inicio\\05-Files\\ejemploCopia.txt", overwrite: true);
        File.Delete("F:\\Dev\\Cursos\\DevTalles\\CSharp\\CSharp_Inicio\\CSharp_Inicio\\05-Files\\ejemploCopia.txt");
    }
}