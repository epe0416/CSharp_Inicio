partial class Program
{
    static void WriteFileExample()
    {
        var filePath = "F:\\Dev\\Cursos\\DevTalles\\CSharp\\CSharp_Inicio\\CSharp_Inicio\\05-Files\\EjemploEscritura.txt";
        var content = "Primera Linea";
        var streamWrite = new StreamWriter(filePath, append: true);
        streamWrite.WriteLine(content);
        streamWrite.WriteLine($"La hora Actual es: " + DateTime.Now.ToString("HH:mm:ss"));
        streamWrite.Dispose();
        WriteLine("Archivo creado exitosamente");

    }
}