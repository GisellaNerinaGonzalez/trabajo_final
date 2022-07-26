// Aspectos a incluir
//Clase usuario; PROPIEDADES: id, apellido,nombreUsuario,Contrasena, mail
namespace Desafio1
{
    
    
     public class Usuario
        {
            private string id;
            private string apellido;
            private string nombreUsuario;
            private string contraseña;
            private string mail; 
            
        }
    //si quiero que el cliente o usuario ponga todos los datos, se le crea una logica con get y set
    
    public class Producto//Clase producto: PROPIEDADES: id,descripcion, costo, precioVenta,stock,id usuario
    {
     private string id;
     private string descripcion;
     private double costo;
     private double precioVenta;
     private int stock;
     private string idusuario;

        
    }
    public class ProductoVendido// PROPIEDADES: id, idProducto, Stock, idVenta
    {
        private string id;
        private string idProducto;
        private int Stock;
        private string idVenta;
    }//hacer publico
    public class Venta // Clase venta: PROPIEDADES: id, comentarios
    {
        private string id;
        private string comentarios;
    }
}

