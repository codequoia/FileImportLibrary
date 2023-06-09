namespace FileImportLibrary
{
    public interface IFileImporter
    {
        /// <summary>
        /// Imports the specified file.
        /// </summary>
        /// <param name="file">The file to import.</param>
        void ImportFile(string file);

        /// <summary>
        /// Determines if the importer can handle the specified file.
        /// </summary>
        /// <param name="file">The file to check.</param>
        /// <returns>True if the importer can handle the file; otherwise, false.</returns>
        bool CanImport(string file);
    }
}
 