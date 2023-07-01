using System.Runtime.CompilerServices;

namespace StreamTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamWriter streamWriter = null;
            StreamReader streamReader = null;
            string filePath = @"D:\test_text.txt";
            try
            {
                if (!File.Exists(filePath))
                {
                    FileInfo myFile = new FileInfo(filePath);
                    streamWriter = myFile.CreateText();
                    string text = @"The good artist copy, the great artist steal.";
                    streamWriter.Write(text);
                    Console.WriteLine("The data have already been written in");
               
                }
                else
                {
                    streamReader = new StreamReader(filePath);
                    string text = streamReader.ReadToEnd();
                    Console.WriteLine("Read text:\n"+text);
                }

            }
            catch (Exception)
            {

                throw;
            }finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
                if (streamReader != null)
                {
                    streamReader.Close();
                }

                FileInfo myFile = new FileInfo(filePath);
                streamWriter = myFile.AppendText();
                streamWriter.Write("can you hear me!!!!");
                if (streamWriter != null) {
                    streamWriter.Close();
                }
                if (streamReader != null)
                {
                    streamReader.Close();
                }

            }
        }
    }
}