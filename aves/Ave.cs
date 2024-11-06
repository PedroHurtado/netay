namespace Aves
{
    public abstract class Ave(int peso)
    {
        public int Peso { get; init; } = peso;
    }
    public abstract class AveVoladora(int peso, int velocidad) : Ave(peso)
    {
        public int Velocidad { get; init; } = velocidad;
    }

    public abstract class AveNoVoladora(int peso) : Ave(peso){


    }

    public class Pinguino(int peso) : AveNoVoladora(peso)
    {
    }
    public class Aguila(int peso, int velocidad): AveVoladora(peso,velocidad){
        
    }

    public class Paloma(int peso, int velocidad): AveVoladora(peso,velocidad){
        
    }


    /*
        la noción de que las “entidades de software … 
        deben estar abiertas para su extensión, 
        pero cerradas para su modificación”.
    */
    public class Printer{
        public static void PrintAve(Ave ave){
            Console.WriteLine(ave);
        }
        public static void PrintAveVoladora(AveVoladora ave){
            Console.WriteLine(ave);
        }

        public static void PrintAveNoVoladora(AveNoVoladora ave){
            Console.WriteLine(ave);
        }
    }
}
