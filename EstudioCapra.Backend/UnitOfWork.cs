using EstudioCapra.Backend.Repository;
using EstudioCapra.Entity;

namespace EstudioCapra.Backend
{
    public class UnitOfWork : IUnitOfWork
    {
        private EstudioCapraEntities _context { get; set; }
        private ServicioRepository _servicioRepository;
        private ClienteRepository _clienteRepository;
        private ContratoRepository _contratoRepository;
        private TipoServicioRepository _tipoServicioRepository;
        private EtapaServicioRepository _etapaServicioRepository;
        private EtapaTareaRepository _etapaTareaRepository;
        private TareaEmpleadoRepository _tareaEmpleadoRepository;

        public UnitOfWork(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public UnitOfWork()
        {
            try
            {
                this._context = new EstudioCapraEntities();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public ServicioRepository ServicioRepository
        {
            get
            {
                if (this._servicioRepository == null)
                {
                    this._servicioRepository = new ServicioRepository(_context);
                }
                return _servicioRepository;
            }
        }
        public ClienteRepository ClienteRepository
        {
            get
            {

                if (this._clienteRepository == null)
                {
                    this._clienteRepository = new ClienteRepository(_context);
                }
                return _clienteRepository;
            }
        }
        public ContratoRepository ContratoRepository
        {
            get
            {

                if (this._contratoRepository == null)
                {
                    this._contratoRepository = new ContratoRepository(_context);
                }
                return _contratoRepository;
            }
        }
        public TipoServicioRepository TipoServicioRepository
        {
            get
            {

                if (this._tipoServicioRepository == null)
                {
                    this._tipoServicioRepository = new TipoServicioRepository(_context);
                }
                return _tipoServicioRepository;
            }
        }
        public EtapaServicioRepository EtapaServicioRepository
        {
            get
            {

                if (this._etapaServicioRepository == null)
                {
                    this._etapaServicioRepository = new EtapaServicioRepository(_context);
                }
                return _etapaServicioRepository;
            }
        }
        public EtapaTareaRepository EtapaTareaRepository
        {
            get
            {
                if (this._etapaTareaRepository == null)
                {
                    this._etapaTareaRepository = new EtapaTareaRepository(_context);
                }
                return _etapaTareaRepository;
            }

        }
        public TareaEmpleadoRepository TareaEmpleadoRepository
        {
            get
            {
                if (this._tareaEmpleadoRepository == null)
                {
                    this._tareaEmpleadoRepository = new TareaEmpleadoRepository(_context);
                }
                return _tareaEmpleadoRepository;
            }

        }
    }
}
