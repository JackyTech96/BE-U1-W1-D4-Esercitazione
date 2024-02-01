using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D4_Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esci = false;

            while (!esci) 
            {
                Console.WriteLine("==========OPERAZIONI==========");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Logout");
                Console.WriteLine("3. Verifica ora e data di login");
                Console.WriteLine("4. Lista degli accessi");
                Console.WriteLine("5. Esci");

                Console.WriteLine("=========================");

                Console.Write("Opzione: ");
                int opzione =Convert.ToInt16(Console.ReadLine());

                switch(opzione) 
                {
                    case 1:
                        Console.Write("Username: ");
                        string username=Console.ReadLine();

                        Console.Write("Password: ");
                        string password=Console.ReadLine();

                        Console.Write("Conferma password: ");
                        string confermaPassword = Console.ReadLine();

                        Utente.Login(username, password, confermaPassword);
                        break;

                    case 2:
                        Utente.Logout();
                        break;

                    case 3:
                        Utente.VerificaOraDataLogin();
                        break;

                    case 4:
                        break;
                    case 5:
                        esci = true;
                        break;

                    default:
                    break;


                
                }
            }

        }
    }
}
