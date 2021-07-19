using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhdAutoStoreUtilities.Tests
{
    class TestFileManager
    {
        public const string emptySynqFile = "synq_tus_empty.xlsx";
        public const string emptyASFile = "as_bins_empty.csv";

        public const string simpleSynqFile = "synq_tus_simple.xlsx";
        public const string simpleASFile = "as_bins_simple.csv";

        public const string missing2SynqFile = "synq_tus_missing_2.xlsx";
        public const string missing2ASFile = "as_bins_missing_2.csv";

        public const string missingHeaderSynqFile = "synq_tus_no_header.xlsx";
        public const string missingHeaderASFile = "as_bins_no_header.csv";

        public const string emptyFirstColSynqFile = "synq_tus_empty_first_column.xlsx";
        public const string emptyFirstColASFile = "as_bins_empty_first_column.csv";

        private readonly string testDirectory;

        public TestFileManager()
        {
            testDirectory = System.IO.Directory.GetCurrentDirectory() +
                @"\..\..\TestFiles\";
        }

        public string GetTestFilePath(string fileName)
        {
            return testDirectory + fileName;
        }
    }
}
