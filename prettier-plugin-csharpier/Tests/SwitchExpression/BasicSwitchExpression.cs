class ClassName
{
    int MethodName()
    {
        return 1 switch
        {
            1 => 100,
            2 => 200,
            _ => throw new global::System.Exception()
        };
    }
}
