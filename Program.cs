namespace GERAS;
class Program
{
    static void Main(string[] args)
    {
        bool MostrarMenu=true;
        while(MostrarMenu){
            MostrarMenu=MostrarMenu();
        }
    }
    public static bool menu(){
        Console.Clear();
        Console.WriteLine("seleccione una opcion:");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("2.- Eliminar Automovil");
        Console.WriteLine("3.- Buscar Automovil");
        Console.WriteLine("4.- Listar todos");
        Console.WriteLine("5.- Salir");
        Console.Write("Opcion: ");
        switch (Console.ReadLine())
        {
           
            case "1":
            Console.WriteLine("Seleccionaste 1");
            Console.ReadLine();
            return true;
             
            case "2":
            Console.WriteLine("Seleccionaste 1");
            Console.ReadLine();
            return true;
            
            case "3":
            Console.WriteLine("Seleccionaste 1");
            Console.ReadLine();
            return true;
            
            case "4":
            Console.WriteLine("Seleccionaste 1");
            Console.ReadLine();
            return true;
            
            case "5":
            return false;
            default:
            true;
        }
        return true;

    }
}
