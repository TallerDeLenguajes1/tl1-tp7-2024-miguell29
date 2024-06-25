using Personal;
internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("jose", "lopez", new DateTime(1998, 8, 14), 'C', new DateTime(2015, 7, 18), 550000, Cargos.Especialista);
        Empleado empleado2 = new Empleado("juan", "nuñes", new DateTime(1985, 10, 15), 'C', new DateTime(2009, 5, 20), 650000, Cargos.Ingeniero);
        Empleado empleado3 = new Empleado("lucas", "Santillan", new DateTime(2000, 2, 18), 'S', new DateTime(2018, 3, 12), 400000, Cargos.Administrativo);

        Empleado[] empleados={empleado1, empleado2, empleado3};

        Console.Clear();
        Console.WriteLine("Monto total de Salarios: " +(empleado1.Salario()+empleado2.Salario()+empleado3.Salario()));

        Empleado empleadoAjubilarse = empleado1;

        foreach (Empleado empleado in empleados)
        {
            if(empleado.AniosParaJubilacion() < empleadoAjubilarse.AniosParaJubilacion())
            {
                empleadoAjubilarse=empleado;
            }
        }

        Console.WriteLine("---- Datos del empleado Más próximo a jubilarse ----");
        empleadoAjubilarse.MostrarDatos();
    }

}