using Aves;
using Curso;
// See https://aka.ms/new-console-template for more information


/*
    Principio de sustitución de Liskov 
    la noción de que los “objetos de un programa 
    deberían ser reemplazables por instancias 
    de sus subtipos 
    sin alterar el correcto funcionamiento del programa”
*/
Ave ave = new Pinguino(5);
AveVoladora aveVoladora = new Aguila(10,100);
AveNoVoladora noVoladora= new Pinguino(5);
Ave ave1 = new Aguila(10,100);


Printer.PrintAve(new Aguila(10,100));
Printer.PrintAve(new Pinguino(5));
Printer.PrintAveVoladora(new Aguila(10,100));
Printer.PrintAveNoVoladora(new Pinguino(5));

Foo foo= new(1, "Pedro") ;
Foo foo1= new(1,"Pedro Hurtado"); 
Console.WriteLine(foo1.Equals(foo));
Console.WriteLine(foo1==foo);

var person = new Person("Pedro", "Hurtado");
var person1 = new Person("Pedro", "Hurtado");
Console.WriteLine(person==person1);

//Sugar Sintax
var foo2= new Foo(2,"Pedro Hurtado Candel");

Console.WriteLine(foo1.Name);
Console.WriteLine(foo.Name);


public readonly record struct Person(string FirstName, string LastName);



