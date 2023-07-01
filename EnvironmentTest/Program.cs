namespace EnvironmentTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Processors' Number " + Environment.ProcessorCount);
            Console.WriteLine("Operator System Version "+Environment.OSVersion);
            Console.WriteLine("Common Language Runtime Version "+Environment.Version);
            Console.WriteLine("Machine Name "+Environment.MachineName);
            Console.ReadKey();
            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine("MyDocuments Path:"+myDocuments);
        }
    }
}