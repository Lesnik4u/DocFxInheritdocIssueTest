using MyClassLibrary;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        MyBaseClass baseClass = new MyChildClass();
        baseClass.MyMethod();
        baseClass.ToString();

        MyLibBaseClass libBaseClass = new MyLibChildClass();

        libBaseClass.MyMethod();
        libBaseClass.ToString();
    }
}