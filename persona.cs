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
        int edad=DateTime.Now.Year-FechaNacimiento.Year;
        if(DateTime.Now.DayOfYear<FechaNacimiento.DayOfYear) edad--;
        return edad;

    }
    public bool PuedeVotar(int edad)
    {
        bool votar;
        if (edad>=16){
            votar=true;
        }else{
            votar =false;
        }
        return votar;
    }


}