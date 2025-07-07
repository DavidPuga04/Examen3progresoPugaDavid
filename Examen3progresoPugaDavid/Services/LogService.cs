using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3progresoPugaDavid.Services
{
    class LogService
    {
        private static string logFilepath = Path.Combine(FileSystem.AppDataDirectory, "log_Puga.txt");
    

    public static async Task AppendLogAsync(string NombreProducto)
        {
            string log = $"Se incluyó el registro [{NombreProducto}] en la base de datos el {DateTime.Now: yyyy-MM-dd HH:mm:ss}\n";
            await File.AppendAllLinesAsync(logFilepath, new[] { log });
        }
        public static async Task<List<string>> LeerLogsAsync()
        {
            if (File.Exists(logFilepath))
                return (await File.ReadAllLinesAsync(logFilepath)).ToList();
            else
                return new List<string>();
        }
    }
}

