using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImportLibrary
{
    /// <summary>
    /// Base abstract class for file importers.
    /// </summary>
    public abstract class FileImporterBase : IFileImporter
    {
        /// <summary>
        /// Imports the specified file.
        /// </summary>
        /// <param name="file">The file to import.</param>
        public abstract void ImportFile(string file);

        /// <summary>
        /// Determines if the importer can handle the specified file.
        /// </summary>
        /// <param name="file">The file to check.</param>
        /// <returns>True if the importer can handle the file; otherwise, false.</returns>
        public abstract bool CanImport(string file);
    }
}
