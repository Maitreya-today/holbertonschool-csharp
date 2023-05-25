using System;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();
        
        Console.WriteLine($"{typeInfo.Name} Properties:");
        
        foreach (PropertyInfo prop in typeInfo.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }
        
        Console.WriteLine($"{typeInfo.Name} Methods:");
        
        foreach (MethodInfo method in typeInfo.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}