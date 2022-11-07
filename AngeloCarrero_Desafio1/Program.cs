/* Desafio 1 / Primero pasos
 * @Autor: Angelo Carrero 
 * @mail: acmleonardy@gmail.com
 * @twitter: @anjerokata
 * @version: 1 
 * @Descripcion: Creacion de la clase usuario. 
 * Con los atributos id, nombre, nombre de usuario, contrasena, correo.
 */
using System;

namespace AngeloCarrero_Desafio1
{
    public class Usuario
    {
       
        private int id { get; set; }
        private string name { get; set; }
        private string surName { get; set; }
        private string userName { get; set; }
        private string password { get; set; }
        private string mail { get; set; }

        
        public Usuario() // Constructor por defecto 
        {
            id = 0;
            name = "";
            surName = "";
            userName = "";
            password = "";
            mail = "";
        }

        public Usuario(int id, string name, string surName, string userName, string password, string mail) // constructor por parametros 
        {
            this.id = id;
            this.name = name;
            this.surName = surName;
            this.userName = userName;
            this.password = password;
            this.mail = mail;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Definicion de clase Usuario");
            Usuario usuario = new Usuario();
            Console.WriteLine(usuario);
        }
    }
}
