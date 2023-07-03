namespace TypeTest
{
    using System.Reflection;
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("System.Double");
            Console.WriteLine("TypeName:"+type.Name);
            Console.WriteLine("TypeName:"+type.Namespace);
            Console.WriteLine("TypeName:"+type.Assembly.GetName().Name);
            Console.WriteLine("TypeName:"+type.IsClass);
            Console.WriteLine("TypeName:"+type.IsPrimitive); // IsPrimitive is a property to automatcally call the get method
            MemberInfo[] members = type.GetMembers();
            Console.WriteLine("The Member of the class");
            foreach (MemberInfo member in members)
            {
                Console.WriteLine(":" + member.MemberType + ":" +member.Name);
            }
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            Console.WriteLine("The constructors of this class");
            Console.WriteLine(constructorInfos.Length);
            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
               
                Console.WriteLine(constructorInfo.MemberType + ":" + constructorInfo.Name);
            }


        }
    }
}