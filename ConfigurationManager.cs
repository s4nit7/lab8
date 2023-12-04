using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private string loggingMode;
        private string databaseConnection;

        private ConfigurationManager()
        {

            loggingMode = "DefaultLogging";
            databaseConnection = "DefaultConnection";
        }

        public string LoggingMode
        {
            get { return loggingMode; }
            set
            {
                loggingMode = value;
                Console.WriteLine("Logging mode set to: " + value);
            }
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }

        public string DatabaseConnection
        {
            get { return databaseConnection; }
            set
            {
                databaseConnection = value;
                Console.WriteLine("Database connection set to: " + value);
            }
        }
    }
}
