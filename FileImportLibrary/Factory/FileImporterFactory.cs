using System.Reflection;

namespace FileImportLibrary
{
    public class FileImporterFactory
    {
        private readonly List<Type> importerTypes;

        /// <summary>
        /// Initializes a new instance of the FileImporterFactory class.
        /// </summary>
        public FileImporterFactory()
        {
            importerTypes = new List<Type>();

            // Discover supported file extensions that can be imported at runtime
            var assembly = Assembly.GetExecutingAssembly();
            importerTypes.AddRange(assembly.GetTypes()
                .Where(t => !t.IsAbstract && t.BaseType != null && t.BaseType.IsGenericType && t.BaseType.GetGenericTypeDefinition() == typeof(FileImporterBase)));
        }


        /// <summary>
        /// Creates a file importer based on the file extension.
        /// </summary>
        /// <param name="filePath">The path of the file to import.</param>
        /// <returns>The file importer for the specified file extension.</returns>
        /// <exception cref="ArgumentException">Thrown when the file extension is not supported.</exception>
        public IFileImporter CreateFileImporter(string filePath)
        {
            string fileExtension = Path.GetExtension(filePath).ToLower();
            var importerType = importerTypes.FirstOrDefault(t =>
            {
                var fileImporter = Activator.CreateInstance(t) as IFileImporter;
                return fileImporter != null && fileImporter.CanImport(filePath);
            });

            if (importerType == null)
            {
                throw new ArgumentException("Unsupported file extension: " + fileExtension);
            }

            var fileImporter = Activator.CreateInstance(importerType) as IFileImporter;

            if (fileImporter == null)
            {
                throw new Exception("Failed to create file importer.");
            }

            return fileImporter;
        }
    }
}
