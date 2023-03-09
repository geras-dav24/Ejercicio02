namespace Ejercicio02;
class Concesionararia
{
public  Lista < Automovil > listaAutomoviles ;
     Automóviles  públicos ; 

    public  int  "lim" ;
    public  int  "num" ;

    public  Concesionararia( string  ID , string  marca , int  km , int  precio ){
        listaAtumoviles  =  new  Lista < Automóvil >. vacío ();
        autos.ID  = ID ;
        autos.marca  =  marca ;
        autos.km  =  km ;
        autos.precio  =  precio;
    }

    public  void  agregarAuto ( Automovil  auto ){
        autos.Añadir ( automático );
        numeroAutomoviles  +=  1 ;
    }
    public  void  mostrarAuto ( Automovil  autoBuscado ){
        foreach ( Artículo Automovil  en autoBuscado ){  
            consola.WriteLine ( elemento.ToString ());
        }
    }
    public  void  eliminarAuto ( Automovil  autoBuscado ){
        autos.Quitar ( autoBuscado );
        limiteAutomoviles  +=  1 ;
    }
    public  void  mostrarAutos (){
        foreach ( Elemento Automovil  en listaAtumoviles ){  
            consola.WriteLine ( elemento.ToString ());
        }
    }
    public  void  vaciarConcesionario (){
        listaAtumoviles  =  new  Lista < Automovil >();
    }
}