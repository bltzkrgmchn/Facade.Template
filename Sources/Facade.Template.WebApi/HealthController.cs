using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

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
        public IActionResult Get()
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