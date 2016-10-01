using EstudioCapra.Backend;
using EstudioCapra.Entity;
using EstudioCapra.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.IO;

namespace EstudioCapra.WebApp.Controllers
{
    public class ObjetoMultimediaController : BaseController
    {
        private readonly string IMGTYPE = "IMG";

        private readonly string DEFAULTLOCATION = "F://";

        private readonly string DEFAULTSERVER = "LOCAL";

        public ObjetoMultimediaController(IUnitOfWork unitOfWork)
        {
            base._UnitOfWork = unitOfWork;
        }

        public PartialViewResult Create()
        {
            return this.PartialView();
        }

        [HttpPost]
        public ActionResult Create(ObjetoMultimediaModel model)
        {
            bool flag = model.Archivo.Length > 0L;
            if (flag)
            {
                ObjetoMultimedia objMultimedia = new ObjetoMultimedia
                {
                    EtapaId = new int?(model.EtapaId),
                    DatosComprimidos = this.ConvertToBytes(model.Archivo),
                    Nombre = model.Nombre,
                    Servidor = this.DEFAULTSERVER,
                    Directorio = this.DEFAULTLOCATION,
                    Tipo = this.IMGTYPE
                };
                base._UnitOfWork.ObjetoMultimediaRepository.Add(objMultimedia);
                base._UnitOfWork.Save();
            }

            return this.RedirectToAction("Details", new RouteValueDictionary(new
            {
                controller = "Service",
                action = "Details",
                idContrato = model.ContratoId
            }));
        }

        public FileContentResult GetImage(int Id)
        {
            byte[] image = base._UnitOfWork.ObjetoMultimediaRepository.Get(Id).DatosComprimidos;
            return new FileContentResult(image, "image/jpg");
        }

        private byte[] ConvertToBytes(IFormFile image)
        {
            BinaryReader reader = new BinaryReader(image.OpenReadStream());
            return reader.ReadBytes((int)image.Length);
        }
    }
}
