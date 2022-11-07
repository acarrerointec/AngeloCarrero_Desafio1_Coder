/* Desafio 1 / Primero pasos
 * @Autor: Angelo Carrero 
 * @mail: acmleonardy@gmail.com
 * @twitter: @anjerokata
 * @version: 1 
 * @Descripcion: Creacion de la clase Producto Vendido. 
 * Con los atributos id, id Producto, stock, id Venta.
 */
using System;

public class ProductoVendido
{
	int id { get; set; }
	string idProducto { get; set; }
	int stock { get; set; }
	int idVenta { get; set; }

	public ProductoVendido() // Constructor por defecto
	{
		id = 0;
		idProducto = "";
		stock = 0;
		idVenta = 0;
	}
	public ProductoVendido(int id, string idProducto, int stock, int idVenta) // Construtor por parametros
    {
		this.id = id;
		this.idProducto = idProducto;
		this.stock = stock;
		this.idVenta = idVenta;
    }
}
