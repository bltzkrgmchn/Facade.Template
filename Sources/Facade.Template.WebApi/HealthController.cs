using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Facade.Template.WebApi
{
    /// <summary>
    /// Контроллер проверки состояния службы.
    /// </summary>
    [ApiController]
    [Route("/health")]
    public class HealthController : ControllerBase
    {
        /// <summary>
        /// Получить статус службы.
        /// </summary>
        /// <returns>Статус службы.</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return this.Ok();
            }
            catch (Exception)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadGateway);
            }
        }
    }
}