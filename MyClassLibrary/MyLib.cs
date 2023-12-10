namespace MyClassLibrary
{
    /// <summary> Description in the BASE class. (TargetFramework = netstandard2.0) </summary>
    public class MyLibBaseClass
    {
        /// <summary> Description in the BASE class. </summary>
        public virtual void MyMethod() { }

        // inheritdoc FAILURE!
        /// <inheritdoc/>
        public override string ToString() => "";
    }


    /// <inheritdoc/>
    public class MyLibChildClass : MyLibBaseClass
    {
        /// <inheritdoc/>
        public override void MyMethod() { }

    }
}
