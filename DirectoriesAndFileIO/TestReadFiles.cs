using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DirectoriesAndFileIO
{
    [TestClass]
    public class TestReadFiles
    {
        string testDir = "";
        string fileA = "";
        string fileAContents = "";
        string fileB = "";
        string fileBContents = "";
        string subDir = "";
        string subDirFile = "";
        string subDirFileContents = "";

        [TestInitialize]
        public void Initialize()
        {
            // Create a test-directory with known files and directories
            testDir = "testDir";
            fileA = Path.Combine(testDir, "a.txt");
            fileB = Path.Combine(testDir, "b.txt");
            
            subDir = Path.Combine(testDir, "subDir");
            subDirFile = Path.Combine(subDir, subDirFile);
            fileAContents = "This is a.txt.";
            fileBContents = "This is b.txt.\nwith a newline";
            subDirFileContents = "This is a file in a sub-directory.";

            Directory.CreateDirectory(testDir);
            File.WriteAllText(fileA, fileAContents);
            File.WriteAllText(fileB, fileBContents);
            Directory.CreateDirectory(subDir);
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (Directory.Exists(testDir))
            {
                Directory.Delete(testDir, recursive: true);
            }
        }

        [TestMethod]
        public void TestFileReadAllText()
        {
            string txt = File.ReadAllText(fileA);
            Assert.AreEqual(fileAContents, txt);

            string txtb = File.ReadAllText(fileB);
            Assert.AreEqual(fileBContents, txtb);
        }

        [TestMethod]
        public void TestReadAllLines()
        {
            string[] lines = File.ReadAllLines(fileA);

            Assert.AreEqual(1, lines.Length);
            Assert.AreEqual(fileAContents, lines[0]);

            string[] linesB = File.ReadAllLines(fileB);
            string line = linesB[0] + "\n" + linesB[1];
            Assert.AreEqual(2, linesB.Length);
            Assert.AreEqual(fileBContents, line);
        }
        [TestMethod]
        public void TestFileOpenText()
        {
            StreamReader str = File.OpenText(fileA);

            string txt = str.ReadToEnd();
            Assert.AreEqual(txt, fileAContents);

            str.Close();
            
        }



[TestMethod]
        public void TestStreamReader()
        {
            StreamReader s = new StreamReader(fileA);

            string txt = s.ReadToEnd();
            Assert.AreEqual(fileAContents, txt);

            s.Close();
        }

        [TestMethod]
        public void TestFileStream()
        {
            byte[] data = new byte[20]; // we choose 20 bytes because that's more than enough for what we choose as fileAContents, all bytes will be initialized to 0

            FileStream stream = File.OpenRead(fileA);
            int r = stream.Read(data, 0, 20); // we read 20 bytes or less if the stream is finished

            string txt = "";
            foreach(byte b in data)
            {
                if(b != 0) // the last bytes of the array will still be 0
                {
                    txt += (char)b;
                }
            }

            Assert.AreEqual(fileAContents.Length, r);
            Assert.AreEqual(fileAContents, txt);

            stream.Close();
        }

    }
}
