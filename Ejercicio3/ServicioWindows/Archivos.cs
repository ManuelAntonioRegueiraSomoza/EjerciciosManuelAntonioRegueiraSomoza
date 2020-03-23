using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ServicioWindows
{
    partial class Archivos : ServiceBase
    {
      
        public Archivos()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            stLapso.Start();
        }

        protected override void OnStop()
        {
            stLapso.Stop();
        }

        private void stLapso_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string nombreArchivo = "test.txt";
            string origen = @"C:\Origen";
            string destino = @"C:\Destino";
            string destinoFichero;
          

            System.IO.Directory.CreateDirectory(destino);


          

            if (System.IO.Directory.Exists(origen))
            {
                EventLog.WriteEntry("Se copienza copia de archivo", EventLogEntryType.Information);
                string[] ficheros = System.IO.Directory.GetFiles(origen);

                foreach (string s in ficheros)
                {
                    nombreArchivo = System.IO.Path.GetFileName(s);
                    destinoFichero = System.IO.Path.Combine(destino, nombreArchivo);
                    System.IO.File.Copy(s, destinoFichero, true);
                }
                EventLog.WriteEntry("Se finaliza proceso de copia", EventLogEntryType.Information);
            }
            else
            {
                EventLog.WriteEntry("No se encuentra archivo", EventLogEntryType.Information);
            }

            

        }
    }
}
