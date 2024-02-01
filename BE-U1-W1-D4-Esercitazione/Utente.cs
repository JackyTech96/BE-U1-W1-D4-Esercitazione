using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D4_Esercitazione
{
    public static class Utente
    {
        private static string _username;
        private static string _password;
        private static bool _isLoggedIn;
        private static List<string> _logins;

        static Utente()
        {
           _logins = new List<string>();
        }

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public static bool IsLoggedIn
        {
            get { return _isLoggedIn; }
        }

        public static void Login(string username, string password, string confermaPassword)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Inserisci una username valida.");
                return;
            }

            if (password == confermaPassword)
            {
                _username = username;
                _password = password;
                _isLoggedIn = true;
                _logins.Add($"Login effettuato il {DateTime.Now}");
                Console.WriteLine("Login effettuato con successo!");
            }
            else
            {
                Console.WriteLine("Le password non coincidono. Riprova.");
            }
        }

        public static void Logout()
        {
            if (_isLoggedIn)
            {
                _isLoggedIn = false;
                Console.WriteLine("Logout avvenuto con successo");
            }
            else
            {
                Console.WriteLine("Utente non loggato.");
            }
        }

        public static void VerificaOraDataLogin()
        {
            if(_isLoggedIn)
            {
                Console.WriteLine("Ultimo login effettuato il " + _logins[_logins.Count - 1]);
            }
            else
            {
                Console.WriteLine("Nessun utente autenticato. Impossibile verificare l'ora e la data del login.");
            }
        }

        public static void ListaAccessi()
        {

        }
    }
}
