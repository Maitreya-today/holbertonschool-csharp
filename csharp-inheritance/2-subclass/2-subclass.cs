using System;

public static class Obj
{
    ///<summary> Checks if object is an subclass of basetype </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}