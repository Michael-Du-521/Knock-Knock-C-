namespace MutexB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread ThreadB = new Thread(delegate ()
            {
                Mutex fileMutex = new Mutex(false, "MutexForTimeRecordFile");
                string fileName = @"D:/TimeRecord.txt";
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        fileMutex.WaitOne();
                        File.AppendAllText(fileName, "ThreadB:" + DateTime.Now + "\r\n");
                    }
                    catch (System.Threading.ThreadInterruptedException)
                    {

                        Console.WriteLine("ThreadB is suspended");
                    }
                    finally
                    {
                        fileMutex.ReleaseMutex();
                    }
                    Thread.Sleep(1000);

                }
            });
            ThreadB.Start();
         
        }
    }
}