using MauiPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPages.Repositories
{
    public class EstudinateUDLARepository
    {
        public Estudiante DevuelveInfoEstudainte()
        {
            return new Estudiante()
            {
                Id = 1,
                Nombre = "Justin",
                Carrera = "Ing de Software"

            };
        }
    }
}
