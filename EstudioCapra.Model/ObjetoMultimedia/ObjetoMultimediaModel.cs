using Microsoft.AspNetCore.Http;
using System;

namespace EstudioCapra.Models
{
    public class ObjetoMultimediaModel
    {
        public int ObjetoMultimediaId
        {
            get;
            set;
        }

        public int EtapaId
        {
            get;
            set;
        }

        public string Servidor
        {
            get;
            set;
        }

        public string Directorio
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public string Tipo
        {
            get;
            set;
        }

        public IFormFile Archivo
        {
            get;
            set;
        }

        public int ContratoId
        {
            get;
            set;
        }
    }
}
