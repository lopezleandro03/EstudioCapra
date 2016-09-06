using EstudioCapra.Backend.Repository;
using EstudioCapra.Entity;
using System;

namespace EstudioCapra.Backend
{
    public class UnitOfWork : IUnitOfWork
    {
        private ServicioRepository _servicioRepository;

        private ClienteRepository _clienteRepository;

        private ContratoRepository _contratoRepository;

        private TipoServicioRepository _tipoServicioRepository;

        private TareaEmpleadoRepository _tareaEmpleadoRepository;

        private ObjetoMultimediaRepository _objetoMultimediaRepository;

        private TareaRepository _tareaRepository;

        private TipoTareaRepository _tipoTareaRepository;

        private EmpleadoRepository _empleadoRepository;

        private UsuarioRepository _usuarioRepository;

        private UsuarioRolRepository _usuarioRolRepository;

        private RolRepository _rolRepository;

        private ItemMenuRepository _itemMenuRepository;

        private ContratoEmpleadoRepository _contratoEmpleadoRepository;

        private PagoRepository _pagoRepository;

        private bool disposed = false;

        private EstudioCapraEntities _context
        {
            get;
            set;
        }

        public ServicioRepository ServicioRepository
        {
            get
            {
                bool flag = this._servicioRepository == null;
                if (flag)
                {
                    this._servicioRepository = new ServicioRepository(this._context);
                }
                return this._servicioRepository;
            }
        }

        public ClienteRepository ClienteRepository
        {
            get
            {
                bool flag = this._clienteRepository == null;
                if (flag)
                {
                    this._clienteRepository = new ClienteRepository(this._context);
                }
                return this._clienteRepository;
            }
        }

        public ContratoRepository ContratoRepository
        {
            get
            {
                bool flag = this._contratoRepository == null;
                if (flag)
                {
                    this._contratoRepository = new ContratoRepository(this._context);
                }
                return this._contratoRepository;
            }
        }

        public TipoServicioRepository TipoServicioRepository
        {
            get
            {
                bool flag = this._tipoServicioRepository == null;
                if (flag)
                {
                    this._tipoServicioRepository = new TipoServicioRepository(this._context);
                }
                return this._tipoServicioRepository;
            }
        }

        public TareaEmpleadoRepository TareaEmpleadoRepository
        {
            get
            {
                bool flag = this._tareaEmpleadoRepository == null;
                if (flag)
                {
                    this._tareaEmpleadoRepository = new TareaEmpleadoRepository(this._context);
                }
                return this._tareaEmpleadoRepository;
            }
        }

        public ObjetoMultimediaRepository ObjetoMultimediaRepository
        {
            get
            {
                bool flag = this._objetoMultimediaRepository == null;
                if (flag)
                {
                    this._objetoMultimediaRepository = new ObjetoMultimediaRepository(this._context);
                }
                return this._objetoMultimediaRepository;
            }
        }

        public TareaRepository TareaRespository
        {
            get
            {
                bool flag = this._tareaRepository == null;
                if (flag)
                {
                    this._tareaRepository = new TareaRepository(this._context);
                }
                return this._tareaRepository;
            }
        }

        public TipoTareaRepository TipoTareaReposiory
        {
            get
            {
                bool flag = this._tipoTareaRepository == null;
                if (flag)
                {
                    this._tipoTareaRepository = new TipoTareaRepository(this._context);
                }
                return this._tipoTareaRepository;
            }
        }

        public EmpleadoRepository EmpleadoRepository
        {
            get
            {
                bool flag = this._empleadoRepository == null;
                if (flag)
                {
                    this._empleadoRepository = new EmpleadoRepository(this._context);
                }
                return this._empleadoRepository;
            }
        }

        public UsuarioRepository UsuarioRepository
        {
            get
            {
                bool flag = this._usuarioRepository == null;
                if (flag)
                {
                    this._usuarioRepository = new UsuarioRepository(this._context);
                }
                return this._usuarioRepository;
            }
        }

        public UsuarioRolRepository UsuarioRolRepository
        {
            get
            {
                bool flag = this._usuarioRolRepository == null;
                if (flag)
                {
                    this._usuarioRolRepository = new UsuarioRolRepository(this._context);
                }
                return this._usuarioRolRepository;
            }
        }

        public RolRepository RolRepository
        {
            get
            {
                bool flag = this._rolRepository == null;
                if (flag)
                {
                    this._rolRepository = new RolRepository(this._context);
                }
                return this._rolRepository;
            }
        }
        public ItemMenuRepository ItemMenuRepository
        {
            get
            {
                bool flag = this._itemMenuRepository == null;
                if (flag)
                {
                    this._itemMenuRepository = new ItemMenuRepository(this._context);
                }
                return this._itemMenuRepository;
            }
        }

        public ContratoEmpleadoRepository ContratoEmpleadoRepository
        {
            get
            {
                bool flag = this._contratoEmpleadoRepository == null;
                if (flag)
                {
                    this._contratoEmpleadoRepository = new ContratoEmpleadoRepository(this._context);
                }
                return this._contratoEmpleadoRepository;
            }
        }

        public PagoRepository PagoRepository
        {
            get
            {
                bool flag = this._pagoRepository == null;
                if (flag)
                {
                    this._pagoRepository = new PagoRepository(this._context);
                }
                return this._pagoRepository;
            }
        }
        
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save()
        {
            this._context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            bool flag = !this.disposed;
            if (flag)
            {
                if (disposing)
                {
                    this._context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
        }
    }
}
