namespace ConsoleApp1; // .NET 6.0

/// <summary> Description in the BASE class. (TargetFramework = net6.0) </summary>
public class MyBaseClass
{
    /// <summary> Description in the BASE class. </summary>
    public virtual void MyMethod() { }
    
    /// <inheritdoc/>
    public override string ToString() => "";
}

/// <inheritdoc/>
public class MyChildClass : MyBaseClass
{
    /// <inheritdoc/>
    public override void MyMethod() { }
}
