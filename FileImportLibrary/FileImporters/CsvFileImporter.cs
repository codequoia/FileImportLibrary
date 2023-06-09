namespace FileImportLibrary
{
    public class CsvFileImporter : FileImporterBase
    {
        /// <summary>
        /// Imports a CSV file.
        /// </summary>
        /// <param name="file">The path of the CSV file to import.</param>
        public override void ImportFile(string filePath)
        {
            //Add Logic to import csv file here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines if the importer can handle the given file.
        /// </summary>
        /// <param name="file">The path of the file to check.</param>
        /// <returns>True if the file extension is ".csv"; otherwise, false.</returns>
        public override bool CanImport(string file)
        {
            return file.EndsWith(".csv");
        }
    }
}

