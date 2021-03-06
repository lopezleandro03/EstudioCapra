﻿using System;
using System.Collections.Generic;

namespace EstudioCapra.Models
{
    public class EtapaModel
    {
        public int IdEtapa
        {
            get;
            set;
        }

        public string NombreEtapa
        {
            get;
            set;
        }

        public string DescripcionEtapa
        {
            get;
            set;
        }

        public DateTime FechaInicioEtapa
        {
            get;
            set;
        }

        public DateTime? FechaFinEtapa
        {
            get;
            set;
        }

        public List<TareaModel> ListaTareas
        {
            get;
            set;
        }

        public List<int> ListaIdObjetoMultimedia
        {
            get;
            set;
        }

        public string Estado
        {
            get;
            set;
        }
    }
}
