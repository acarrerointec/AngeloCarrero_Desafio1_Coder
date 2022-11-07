/* Desafio 1 / Primero pasos
 * @Autor: Angelo Carrero 
 * @mail: acmleonardy@gmail.com
 * @twitter: @anjerokata
 * @version: 1 
 * @Descripcion: Creacion de la clase Venta. 
 * Con los atributos id, comentarios
 */


using System;

public class Venta 
{
	public int id { get; set; }
	public string comentarios { get; set; }

	public Venta() // Constructor por defecto 
	{
		id = 0;
		comentarios = "";
	}
	public Venta (int id, string comentarios) // Contructor por parametros
    {
		this.id = id;
		this.comentarios = comentarios;

    }
}
