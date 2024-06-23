namespace EspacioCalculadora;
/*
Cree la clase Calculadora que permita encadenar
operaciones sobre un mismo resultado guardado en un campo llamado dato, utilizando
los siguientes métodos.
● void Sumar(double termino)
● void Restar(double termino)
● void Multiplicar(double termino)
● void Dividir(double termino)
● void Limpiar()
*/
public class Calculadora
{
    private Double dato = 0;
    public Double Resultado { get => dato; }

    public void Sumar(double termino){
        dato += termino;
    }
    public void Restar(double termino){
        dato -= termino;
    }
    public void Multiplicar(double termino){
        dato *= termino;
    }
    public void Dividir(double termino){
        if(termino != 0){
            dato /= termino;
        }else
        {
            Console.WriteLine("ERROR - No se puede dividir por cero");
        }
    }
    public void Limpiar(){
        dato = 0;
    }
}