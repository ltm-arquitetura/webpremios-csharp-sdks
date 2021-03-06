/*
 * Marketplace
 *
 * API Cloud Loyalty LTM - Webpremios
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class SKUApiController : Controller
    { 

        /// <summary>
        /// Recurso utilizado para retornar informações de preço e disponibilidade de um determinado SKU
        /// </summary>
        /// <remarks>Obtém a disponibilidade e preço pelo Id</remarks>
        /// <param name="id">Identificador do SKU</param>
        /// <param name="vendorId">Identificador do vendor</param>
        /// <param name="originalId">Identificador do SKU no vendor</param>
        /// <response code="200">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpGet]
        [Route("/marketplace-api/v1/skus/{id}/availability")]
        [SwaggerOperation("SkusIdAvailabilityGet")]
        [SwaggerResponse(200, type: typeof(Availability))]
        public virtual IActionResult SkusIdAvailabilityGet([FromRoute]string id, [FromQuery]string vendorId, [FromQuery]string originalId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Availability>(exampleJson)
            : default(Availability);
            return new ObjectResult(example);
        }
    }
}
