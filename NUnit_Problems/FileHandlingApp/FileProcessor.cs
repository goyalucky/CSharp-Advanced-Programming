using System.IO;

namespace FileHandlingApp
{
    public class FileProcessor
    {
        // Method to write a file
        public void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }
        // Method to read a file
        public string ReadFromFile(string filename)
        {
            if (!File.Exists(filename))
                throw new IOException("File not found");
            return File.ReadAllText(filename);
        }
    }
}
