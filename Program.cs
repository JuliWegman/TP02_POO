using System.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        List <Persona> listaPersonas=new List<Persona>();
        int eleccion=Menu();
        switch (eleccion){
            case 1:


            break;
            case 2:
            break;
            case 3:
            break;
            case 4:
            break;
        }
    }

    static void AgregarPersona(List<Persona> lista)
    {
        int dni=IngresarInt("Ingresar DNI");
        string apellido=IngresarString("Ingresar apellido de la persona");
        string nombre=IngresarString("Ingresar nombre de la persona");
        DateTime fechaNacimiento=ingresarNacimiento();
        string email=IngresarString("Ingresar email de la persona");

        new Persona(dni,apellido,nombre,fechaNacimiento,email);

        Console.WriteLine(nombre+apellido+" se agregó a la lista");



    }
    static DateTime ingresarNacimiento()
    {
        int año=IngresarInt("Ingresar año de nacimiento");
        int mes=IngresarInt("Ingresar mes de nacimiento (con 0 al principio si es de un digito)");
        int dia=IngresarInt("Ingresar día de nacimiento");


        DateTime nacimiento=new DateTime(año,mes,dia);
        return nacimiento;
    }
    static int IngresarInt(string mensaje)
    {
        Console.WriteLine(mensaje);
        int.TryParse(Console.ReadLine(),out int numero);
        return numero;

    }

    static string IngresarString(string mensaje){
        Console.WriteLine(mensaje);
        string frase= Console.ReadLine();
        return frase;
    }
    
    static int Menu()
    {
    int eleccion;
    Console.WriteLine(" 1- Cargar Nueva Persona \n 2- Obtener Estadísticas del Censo \n 3- Buscar Persona \n 4- Modificar Mail de una Persona \n 5- Salir");
    int.TryParse(Console.ReadLine(),out eleccion);
    return eleccion;
    }

}