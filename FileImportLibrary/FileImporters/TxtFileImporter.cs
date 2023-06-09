namespace FileImportLibrary
{
    public class TxtFileImporter : FileImporterBase
    {
        /// <summary>
        /// Imports a TXT file.
        /// </summary>
        /// <param name="file">The path of the TXT file to import.</param>
        public override void ImportFile(string file)
        {
            //Logic to Import File Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines if the importer can handle the given file.
        /// </summary>
        /// <param name="file">The path of the file to check.</param>
        /// <returns>True if the file extension is ".txt"; otherwise, false.</returns>
        public override bool CanImport(string file)
        {
            return file.EndsWith(".txt");
        }

        
    }
}

