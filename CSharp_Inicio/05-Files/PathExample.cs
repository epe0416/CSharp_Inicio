partial class Program
{
    static void PathExample()
    {
        var filePath = ".\\05-Files\\ejemplo.txt";
        var fileName = Path.GetFileName(filePath);
        WriteLine($"Nombre del archivo: {fileName}");
        var fileExtension = Path.GetExtension(filePath);
        WriteLine($"Extensión del archivo: {fileExtension}");
        var directoryName = Path.GetDirectoryName(filePath);
        WriteLine($"Nombre del Directorio: {directoryName}");
        var combinedPath = Path.Combine("C:","User","Documents","Ejemplo.txt");
        WriteLine($"Ruta combinanda: {combinedPath}");
        var fullFilePath = Path.GetFullPath(filePath);
        WriteLine($"Ruta completa del archivo: {fullFilePath}");

    }
}