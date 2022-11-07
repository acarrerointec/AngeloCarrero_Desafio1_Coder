/* Desafio 1 / Primero pasos
 * @Autor: Angelo Carrero 
 * @mail: acmleonardy@gmail.com
 * @twitter: @anjerokata
 * @version: 1 
 * @Descripcion: Creacion de la clase Producto. 
 * Con los atributos id, descripcion, costo, precio venta, sotck, id usuario.
 */
using System;

public class Producto
{
        public int id { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public decimal pV { get; set; }
        public int stock { get; set; }
        public string idUsuario { get; set; }

    public Producto() // Constructor por defecto
    {
        id = 0;
        descripcion = "";
        costo = 0;
        pV = 0;
        stock = 0;
        idUsuario = "";

    }

    public Producto(int id , string descripion, decimal costo, decimal pV, int stock, string idUsuario) // Constructor por parametros
    {
        this.id = id;
        this.descripcion = descripion;
        this.costo = costo;
        this.pV = pV;
        this.stock = stock;
        this.idUsuario = idUsuario;

    }

}
