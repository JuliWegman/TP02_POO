using System.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        List <Persona> listaPersonas=new List<Persona>();
        List <int> edades = new List<int>();
        int eleccion=Menu();
        while(eleccion!=5){
        switch (eleccion){
            case 1:
            AgregarPersona(listaPersonas);
            break;
            case 2:
            ObtenerEstadisticas(listaPersonas);
            break;
            case 3:
            BuscarPersona(listaPersonas);
            break;
            case 4:
            ModificarMail(listaPersonas);
            break;
        }
        Console.ReadKey();
        Console.Clear();
        eleccion=Menu();
        }
    }

    static void ModificarMail(List<Persona> lista)
    {
        int dni=IngresarInt("Ingresar dni de la persona que quieras buscar");

        bool existe=false;
        foreach(Persona a in lista)
        {
            if (a.DNI==dni)
            {
                existe=true;
                a.Email=IngresarString("Ingresar el mail nuevo");
                break;
            } 
        }
        if(!existe) Console.WriteLine("No se encuentra el DNI");


    }
    static void BuscarPersona(List<Persona> lista)
    {
        int dni=IngresarInt("Ingresar dni de la persona que quieras buscar"); 
        bool existe=false;
        foreach(Persona a in lista)
        {
            if (a.DNI==dni)
            {
                existe=true;
                int edad=a.ObtenerEdad();
                Console.WriteLine(a.Nombre+" "+a.Apellido+" tiene "+edad+" años");
                Console.WriteLine(a.PuedeVotar(edad)?"Puede votar":"No puede votar");
                Console.WriteLine("Su mail es "+a.Email);
                break;
            } 
        }
        if(!existe) Console.WriteLine("No se encuentra el DNI");
    }

    static void ObtenerEstadisticas(List<Persona> lista)
    {
        int cantVotantes=0, sumaEdad=0, promedioEdad,edad;
        foreach(Persona a in lista)
        {
            edad=a.ObtenerEdad();
            sumaEdad+=edad;
            if(a.PuedeVotar(edad)) cantVotantes++ ;
        }
        promedioEdad=sumaEdad/lista.Count();
        Console.WriteLine(" Estadísticas del censo: \n Cantidad de personas: "+lista.Count()+"\n Cantidad de personas habilitadas para votar: "+cantVotantes+" Promedio de edad: "+ promedioEdad);

    }

    static void AgregarPersona(List<Persona> lista)
    {
        int dni=IngresarInt("Ingresar DNI");
        string apellido=IngresarString("Ingresar apellido de la persona");
        string nombre=IngresarString("Ingresar nombre de la persona");
        DateTime fechaNacimiento=ingresarNacimiento();
        string email=IngresarString("Ingresar email de la persona");
        lista.Add(new Persona(dni,apellido,nombre,fechaNacimiento,email));
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