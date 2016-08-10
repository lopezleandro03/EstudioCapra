using EstudioCapra.Backend.Repository;
using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCapra.Backend
{
    public interface IUnitOfWork
    { 
        ServicioRepository ServicioRepository { get; }
        ClienteRepository ClienteRepository { get; }
        ContratoRepository ContratoRepository { get; }
        TipoServicioRepository TipoServicioRepository { get; }
        EtapaServicioRepository EtapaServicioRepository { get;  }
        EtapaTareaRepository EtapaTareaRepository { get; }
        TareaEmpleadoRepository TareaEmpleadoRepository { get;  }

        void Save();
        void Dispose();

    }
}
