using System.Reflection;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom(@"D:\C#\Reflection\MyAssembly1\bin\Debug\MyAssembly1.dll");

            Type t = asm.GetType("MyAssembly.MyClass");

            Console.WriteLine("Properties:");
            foreach (PropertyInfo prop in t.GetProperties())
            {
                Console.WriteLine($"{prop.PropertyType} {prop.Name} ");
            }

            Console.WriteLine(new String('*', 10));


            Console.WriteLine("Metods:");
             foreach (MethodInfo member in t.GetMethods()
            .Where(m => !m.Name.StartsWith("get_") && !m.Name.StartsWith("set_"))) 
                {
                Console.Write($"{member.ReturnType.Name} {member.Name} ");

                ParameterInfo[] parameters = member.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    var param = parameters[i];
                    string modificator = "";
                    if (param.IsIn) modificator = "in";
                    else if (param.IsOut) modificator = "out";

                    Console.Write($" {param.ParameterType.Name} {modificator} {param.Name}");
                    
                }
                Console.WriteLine(" |||||");
            }
        }


    }
}