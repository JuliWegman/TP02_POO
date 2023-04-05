using System.Linq;
class Persona{
    public int DNI{get; private set;}
    public string Apellido{get; private set;}
    public string Nombre{get; private set;}
    public DateTime FechaNacimiento{get; private set;}
    public string Email{get; set;}


    public Persona(int dni, string apellido, string nombre, DateTime fechaNacimiento, string email)
    {
        DNI=dni;
        Apellido=apellido;
        Nombre=nombre;
        FechaNacimiento=FechaNacimiento;
        Email=email;
    }
    public int ObtenerEdad()
    {

        DateTime hoy=DateTime.Today;

        TimeSpan falta=hoy-FechaNacimiento;
        int EdadDias=(int) falta.TotalDays;
        int x=EdadDias % 365;
        EdadDias-=x;
        int EdadAños=EdadDias/365;
        return EdadAños;
    }


}