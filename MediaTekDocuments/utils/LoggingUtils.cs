using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.utils
{
    /// <summary>
    /// Classe auxilliaire pour la gestion des journaux de l'application.
    /// </summary>
    public static class LoggingUtils
    {
        /// <summary>
        /// Chemin vers le fichier de journalisation (Récupéré dans App.config)
        /// </summary>
        private static string logFilePath = ConfigurationManager.ConnectionStrings["log_file_location"].ConnectionString;
        /// <summary>
        /// Méthode chargée d'écrire une chaîne dans le fichier de journalisation
        /// </summary>
        /// <param name="str">Chaîne à écrire dans le fichier</param>
        public static void LogStringToFile(string str)
        {
            try
            {
                DateTime now = DateTime.Now;    
                StreamWriter writer = new StreamWriter(LoggingUtils.logFilePath, true);
                writer.Write("[" + now.ToString("dd/MM/yyyy HH:mm:ss") + "] " + str + "\r\n");
                writer.Flush();
                writer.Close();
            } catch(IOException ex) { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
