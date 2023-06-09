// See https://aka.ms/new-console-template for more information
using FileImportLibrary;

string filePath = "path/to/your/file.csv";
FileImporterFactory factory = new FileImporterFactory(); //This can be registered as a service and used anywhere via DI
IFileImporter fileImporter = factory.CreateFileImporter(filePath);
fileImporter.ImportFile(filePath);

// Extra Logic for file import
Console.ReadLine();


