using System.Runtime.CompilerServices;

namespace Personal;

public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador    
    }

public class Empleado {
    private String Nombre;
    private String Apellido;
    private DateTime FechaNacimiento;
    private Char EstadoCivil; //*Casado = c; soltero = s;
    private DateTime FechaIngreso;
    private Double SueldoBasico;
    private Cargos Cargo;

    public Empleado(string nombre, string apellido,DateTime fechaNac,char eCivil,DateTime fechaI, double sueldoB, Cargos cargo){
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNac;
        this.estadoCivil = eCivil;
        this.fechaIngreso = fechaI;
        this.sueldoBasico = sueldoB;
        this.cargo = cargo;
    }

    public string nombre { get => Nombre; set => Nombre = value; }
    public string apellido { get => Apellido; set => Apellido = value; }
    public DateTime fechaNacimiento { get => FechaNacimiento; set => FechaNacimiento = value; }
    public char estadoCivil { get => EstadoCivil; set => EstadoCivil = value; }
    public DateTime fechaIngreso { get => FechaIngreso; set => FechaIngreso = value; }
    public double sueldoBasico { get => SueldoBasico; set => SueldoBasico = value; }
    internal Cargos cargo { get => Cargo; set => Cargo = value; }


    public int Antiguedad(){
        return DateTime.Now.Year - FechaIngreso.Year;
    }
    public int Edad(){
        return DateTime.Now.Year - FechaNacimiento.Year;
    }
    public int AniosParaJubilacion(){
        return 65 - Edad();
    }
    public Double Adicional(){
        Double adicional = 0;
        int antiguedad = this.Antiguedad();
        if ( antiguedad <= 20)
        {
            adicional += (Double)antiguedad/100 * this.SueldoBasico;
        }else
        {
            adicional += 0.25 * this.SueldoBasico;
        }
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional += adicional/2;
        }
        if (this.EstadoCivil == 'c')
        {
            adicional += 150000;
        }
        return adicional;
    }
    public double Salario(){
        return this.SueldoBasico + this.Adicional();
    }
    public void MostrarDatos(){
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Apellido: {apellido}");
        Console.WriteLine($"fecha de nacimiento: {fechaNacimiento.ToString("dd/mm/yyyy")}");
        Console.WriteLine($"Estado civil: {estadoCivil}");
        Console.WriteLine($"fecha de ingreso: {fechaIngreso.ToString("dd/mm/yyyy")}");
        Console.WriteLine($"Sueldo Basico : {sueldoBasico}");
        Console.WriteLine($"Salario : {this.Salario()}");
        Console.WriteLine($"Cargo : {cargo}");
        Console.WriteLine($"Antiguedad : {this.Antiguedad()}");
        Console.WriteLine($"Años : {this.Edad()}");
        Console.WriteLine($"Años para la jubilacion : {this.AniosParaJubilacion()}");
    }
}