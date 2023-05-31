// See https://aka.ms/new-console-template for more information
using Git_Introduction;

Console.WriteLine("Hello, World!");

Console.WriteLine();

void Create(TestClass test)
{
    
    test.ClassMethod();
}

var clas = new TestClass();

Create(clas);

Console.ReadLine();


