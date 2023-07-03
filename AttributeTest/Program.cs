namespace AttributeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf = new Wolf();
            wolf.DrawMyself();
            Attribute myAttribute = Attribute.GetCustomAttribute(typeof(Wolf), typeof(AnimalInfoAttribute));
            AnimalInfoAttribute wolfAttribute = myAttribute as AnimalInfoAttribute;
            if(wolfAttribute == null)
            {
                Console.WriteLine("Attribute not found");
            }
            else
            {
                Console.WriteLine(wolfAttribute.Name +":") ;
                Console.WriteLine(wolfAttribute.Phylum);
                Console.WriteLine(wolfAttribute.Classis);
                Console.WriteLine(wolfAttribute.Familia);
            }

        }
    }
}