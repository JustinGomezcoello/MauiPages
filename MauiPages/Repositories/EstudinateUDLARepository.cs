using MauiPages.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiPages.Repositories
{
    public class EstudinateUDLARepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiante.txt");
        public Estudiante DevuelveInfoEstudainte()
        {
            return new Estudiante()
            {
                Id = 1,
                Nombre = "Justin",
                Carrera = "Ing de Software"

            };

            

        }

        public void GuardarEnArchivo(Estudiante estudiante)
        {
            string json= JsonConvert.SerializeObject(estudiante);
            File.WriteAllText(_fileName, estudiante.Nombre);
        }
        public Estudiante ObtenerInformacionArchivo()
        {
            Estudiante estudiante = new Estudiante();
            if(File.Exists(_fileName))
            {
                string data_archivo = File.ReadAllText(_fileName);
                estudiante = JsonConvert.DeserializeObject<Estudiante>(data_archivo);
            }
            return estudiante;
        }
    }
}
