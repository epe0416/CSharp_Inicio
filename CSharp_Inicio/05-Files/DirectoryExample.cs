partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "F:\\Dev\\Cursos\\DevTalles\\CSharp\\CSharp_Inicio\\CSharp_Inicio\\05-Files\\";
        Directory.CreateDirectory($"{directoryPath}\\DirEjemplo\\OtherDirEjemplo");
        if (Directory.Exists($"{directoryPath}\\DirEjemplo\\OtherDirEjemplo"))
        {
            WriteLine("El directorio ya existe");
        }
        Directory.Delete($"{directoryPath}\\DirEjemplo\\OtherDirEjemplo");
    }   
}