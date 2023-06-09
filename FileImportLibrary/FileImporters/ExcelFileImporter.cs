using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImportLibrary
{
    public class ExcelFileImporter : FileImporterBase
    {
        /// <summary>
        /// Imports an Excel file.
        /// </summary>
        /// <param name="file">The path of the Excel file to import.</param>
        public override void ImportFile(string file)
        {
            //Write logic to import file here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines if the importer can handle the given file.
        /// </summary>
        /// <param name="file">The path of the file to check.</param>
        /// <returns>True if the file extension is ".xls" or ".xlsx"; otherwise, false.</returns>
        public override bool CanImport(string file)
        {
            string extension = Path.GetExtension(file);
            return extension == ".xls" || extension == ".xlsx";
        }

        
    }
}
