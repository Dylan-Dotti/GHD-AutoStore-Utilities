using GhdAutoStoreUtilities.Exceptions;
using System.Linq;
using Xunit;

namespace GhdAutoStoreUtilities.Tests
{
    public class DataReaderTests
    {
        private readonly TestFileManager fileManager;

        public DataReaderTests()
        {
            fileManager = new TestFileManager();
        }

        [Theory]
        [InlineData(TestFileManager.emptySynqFile, new string[] { })]
        [InlineData(TestFileManager.simpleSynqFile, new string[] { "10001", "10002", "10003", "10004", "10005" })]
        [InlineData(TestFileManager.missing2SynqFile, new string[] { "10001", "10003", "10005" })]
        [InlineData(TestFileManager.emptyFirstColSynqFile, new string[] { "10001", "10002", "10003" })]
        public void TestGetTUIDs(string fileName, string[] expected)
        {
            string testFilePath = fileManager.GetTestFilePath(fileName);
            var reader = new SynqDataReader(new ExcelReader(testFilePath));
            string[] actual = reader.GetTUIDs();
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(TestFileManager.emptyASFile, new string[] { })]
        [InlineData(TestFileManager.simpleASFile, new string[] { "10001", "10002", "10003", "10004", "10005" })]
        [InlineData(TestFileManager.missing2ASFile, new string[] { "10001", "10003", "10005" })]
        [InlineData(TestFileManager.emptyFirstColASFile, new string[] { "10001", "10002", "10003" })]
        public void TestGetBinIDs(string fileName, string[] expected)
        {
            string testFilePath = fileManager.GetTestFilePath(fileName);
            var reader = new AutoStoreDataReader(new SeparatedValueReader(testFilePath, '\t'));
            AutoStoreBin[] actual = reader.GetBins(sortByID: true);
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i].ID);
            }
        }

        [Theory]
        [InlineData(TestFileManager.emptyASFile, new string[] { })]
        [InlineData(TestFileManager.simpleASFile, new string[] { "10001 GRID", "10002 GRID", "10003 PREPARED", "10004 GRID", "10005 GRID" })]
        [InlineData(TestFileManager.missing2ASFile, new string[] { "10001 GRID", "10003 PREPARED", "10005 GRID" })]
        public void TestGetBinModes(string fileName, string[] expected)
        {
            string testFilePath = fileManager.GetTestFilePath(fileName);
            AutoStoreBin[] expectedBinModes = expected
                .Select(s => s.Split(' ')).Select(s => new AutoStoreBin(s[0], s[1]))
                .ToArray();
            var reader = new AutoStoreDataReader(new SeparatedValueReader(testFilePath, '\t'));
            AutoStoreBin[] actual = reader.GetBins();
            Assert.Equal(expectedBinModes.Length, actual.Length);
            for (int i = 0; i < expectedBinModes.Length; i++)
            {
                Assert.Equal(expectedBinModes[i].ID, actual[i].ID);
                Assert.Equal(expectedBinModes[i].Mode, actual[i].Mode);
            }
        }

        [Fact]
        public void TestTUHeaderNotFoundException()
        {
            Assert.Throws<SynqHeaderNotFoundException>(() =>
            {
                var reader = new SynqDataReader(
                    new ExcelReader(fileManager.GetTestFilePath(
                            TestFileManager.missingHeaderSynqFile)));
                reader.GetTUIDs();
            });
        }

        [Fact]
        public void TestBinHeaderNotFoundException()
        {
            Assert.Throws<AutoStoreHeaderNotFoundException>(() =>
            {
                var reader = new AutoStoreDataReader(
                    new SeparatedValueReader(fileManager.GetTestFilePath(
                        TestFileManager.missingHeaderASFile), '\t'));
                reader.GetBinIDs();
            });
        }
    }
}
