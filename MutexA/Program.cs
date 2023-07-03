namespace MutexA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread ThreadA = new Thread(delegate ()
            {
                Mutex fileMutex = new Mutex(false, "MutexForTimeRecordFile");
                string fileName = @"D:/TimeRecord.txt";
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        fileMutex.WaitOne();
                        File.AppendAllText(fileName, "ThreadA:" + DateTime.Now + "\r\n");
                    }
                    catch (System.Threading.ThreadInterruptedException)
                    {

                        Console.WriteLine("ThreadA is suspended");
                    }
                    finally
                    {
                        fileMutex.ReleaseMutex();
                    }
                    Thread.Sleep(1000);

                }
            });
            ThreadA.Start();
        }
    }
}