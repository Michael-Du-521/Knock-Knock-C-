namespace StreamTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\filestream_test.data";
            FileStream fileStream = null;
            //注意 fileStream 对象的声明代码 要放在try语句之前
            try
            {
                if (!File.Exists(filePath))
                {
                    FileInfo myFile = new FileInfo(filePath);
                    fileStream = myFile.OpenWrite();
                    byte[] data = { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109 };
                    fileStream.Write(data, 0, data.Length);
                    Console.WriteLine("Data have already been written");
                }
                else
                {
                    // estabish the stream revalent to the file
                    fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    byte[] data = new byte[fileStream.Length];
                    fileStream.Read(data, 0, data.Length);
                    Console.WriteLine("Read data:");
                    foreach (byte datum in data)
                    {
                        Console.Write(datum);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
               
            }
            finally
            //关闭流操作 应放在 finally 块中， 以确保无论操作成功还是操作失败，流都被及时释放。
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            
        }
    }
}