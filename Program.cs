using Curso;
// See https://aka.ms/new-console-template for more information

Foo foo= new(1, "Pedro") ;
Foo foo1= new(1,"Pedro Hurtado"); 
Console.WriteLine(foo1.Equals(foo));
Console.WriteLine(foo1==foo);

//Sugar Sintax
var foo2= new Foo(2,"Pedro Hurtado Candel");

Console.WriteLine(foo1.Name);
Console.WriteLine(foo.Name);



