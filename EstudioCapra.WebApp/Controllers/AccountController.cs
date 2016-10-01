using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using EstudioCapra.Model.Cuenta;
using EstudioCapra.Backend.BLL;
using EstudioCapra.Backend;
using mercadopago;
using System.Collections;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EstudioCapra.WebApp.Controllers
{   
    public class AccountController : BaseController
    {
        private string _mpClient;
        private string _mpSecret;

        public string PAYMENTCURRENCY = "ARS";
        public string PAYMENTTITLE = "EstudioCapra_Cliente_{0}";

        public AccountController(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        // GET: /<controller>/
        public ActionResult Index()
        {
            var user = base.HttpContext.Session.GetString("USER");
            
            var clientId = (from x in _UnitOfWork.ClienteRepository.GetAll()
                            join y in _UnitOfWork.UsuarioRepository.GetAll() on x.UserId equals y.UserId
                            where y.Email == user
                            select x.ClienteId
                   ).ToList().First();

            AccountManager AccMan = new AccountManager(_UnitOfWork, clientId);

            CuentaModel model = new CuentaModel()
            {
                PagoMinimo = Convert.ToInt32(AccMan.GetPagoMinimo()).ToString(),
                Saldo = Convert.ToInt32(AccMan.GetSaldo()).ToString(),
                Total = Convert.ToInt32(AccMan.GetTotalAcum()).ToString(),
                TotalPagosAceptados = Convert.ToInt32(AccMan.GetTotalPagosAceptados()).ToString(),
                TotalPagosPendientes = Convert.ToInt32(AccMan.GetTotalPagosPendientes()).ToString(),
                Pagos = AccMan.Pagos.Select(x => new PagoModel()
                {
                    Estado = x.Estado,
                    FechaDePago = x.FechaDePago,
                    MetodoDePago = x.MetodoPago.Nombre,
                    Monto = x.Monto,
                    Motivo = x.Motivo,
                    PagoId = x.PagoId
                }).ToList()
            };
            
            //Generación de links de pago Mercado Pago
            ViewBag.PagoMinimo = NuevoPago(clientId.ToString(), Convert.ToInt32(AccMan.GetPagoMinimo()));
            ViewBag.PagoTotal = NuevoPago(clientId.ToString(), Convert.ToInt32(AccMan.GetSaldo()));

            return PartialView(model);
        }


        public string NuevoPago(string clienteId, decimal monto)
        {
            try
            {
                _mpClient = "3393902190530423";
                _mpSecret = "JEyz4whYl72bDz8G1MhzD8Z6I7UGM9m2";

                String paymentTitle = string.Format(PAYMENTTITLE, clienteId);

                MP mp = new MP(_mpClient, _mpSecret);
                String preferenceData = "{\"items\":" +
                                            "[{" +
                                                "\"title\":\"" + paymentTitle + "\"," +
                                                "\"quantity\":1," +
                                                "\"currency_id\":\"" + PAYMENTCURRENCY + "\"," +
                                                "\"unit_price\":" + monto + "" +
                                            "}]" +
                                        "}";

                Hashtable preference = mp.createPreference(preferenceData);
                int responseCode = (int)preference["status"];

                if (responseCode == 201)
                {
                    Hashtable response = (Hashtable)preference["response"];
                    String paymentLink = (String)response["sandbox_init_point"];

                    return paymentLink;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
