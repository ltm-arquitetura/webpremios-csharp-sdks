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
    public class EndereoApiController : Controller
    { 

        /// <summary>
        /// Obtém endereço pelo CEP
        /// </summary>
        /// <remarks>Recurso utilizado para buscar endereço pelo CEP</remarks>
        /// <param name="zipCode">CEP</param>
        /// <response code="200">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpGet]
        [Route("/marketplace-api/v1/addresses/{zipCode}")]
        [SwaggerOperation("AddressesZipCodeGet")]
        [SwaggerResponse(200, type: typeof(ZipCodeAddress))]
        public virtual IActionResult AddressesZipCodeGet([FromRoute]string zipCode)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ZipCodeAddress>(exampleJson)
            : default(ZipCodeAddress);
            return new ObjectResult(example);
        }
    }
}
