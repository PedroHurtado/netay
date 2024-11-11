using Aves;
using Curso;
using service;
using util;
// See https://aka.ms/new-console-template for more information


List<int> list = [1,2,3,4,5,6,7,8,8,9,10];
var evens = list.Where(v=>v%2==0);

var events1 = list.Filter(v=>v%2==0);

events1.ToList();   //bloquante
events1.ToArray();  //bloqueante

foreach (var ev in events1){ //iterando elemento a elemento
    Console.WriteLine(ev);
}
int b = 5;
Console.WriteLine(b.Between(1,10)); // true

/*
  2,4,6,8,8,10
*/

List<Func<int,int,int>> operations = [
    (a,b)=>a+b,  //una lambda crea una instancia de un delegado
    (a,b)=>a*b,
    (a,b)=>a-b,
    (a,b)=>a/b,
];

//Clousures

/*
 function sum(a){
    return (b)=>a+b
 }
*/
Func<int,Func<int,int>> sum=(a)=>(b)=>a+b;

var result = sum(5);
Console.WriteLine(result(100));
Console.WriteLine(result(30));







foreach (var operation in operations)
{
    Console.WriteLine(operation(2,2));
}

PrintUtil.PrintDate(DateTime.Now,Console.WriteLine);

var repository = new Repository();
var service =new Service(repository);
var controller = new Controller(service);
controller.Add();


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

//public delegate int Operation(int a, int b);


public static class ExtensionsInt{
    public static bool Between(this int value, int a, int b){
        return (value >= a && value <= b);
    }
}

public static class ExtensionIEnumerable{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate) {
        foreach (var item in source) {
            if(predicate(item)){
                yield return item;  
            }
        }
    }
}