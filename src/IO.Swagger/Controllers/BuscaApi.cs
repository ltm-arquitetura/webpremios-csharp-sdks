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
    public class BuscaApiController : Controller
    { 

        /// <summary>
        /// Obtém produtos
        /// </summary>
        /// <remarks>Recurso utilizado para busca de produtos</remarks>
        /// <param name="sort">Tipo da ordenação</param>
        /// <param name="offset">Número da página</param>
        /// <param name="limit">Número de registros</param>
        /// <param name="term">Termo para busca</param>
        /// <param name="vendorId">Identificador do parceiro</param>
        /// <param name="categoryId">Identificador da categoria</param>
        /// <param name="subcategoryId">Identificador da subcategoria</param>
        /// <param name="brandId">Identificador da marca</param>
        /// <param name="minPrice">Range de preço de, em pontos</param>
        /// <param name="maxPrice">Range de preço até, em pontos</param>
        /// <response code="200">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpGet]
        [Route("/marketplace-api/v1/search")]
        [SwaggerOperation("SearchGet")]
        [SwaggerResponse(200, type: typeof(Search))]
        public virtual IActionResult SearchGet([FromQuery]string sort, [FromQuery]decimal? offset, [FromQuery]decimal? limit, [FromQuery]string term, [FromQuery]string vendorId, [FromQuery]string categoryId, [FromQuery]string subcategoryId, [FromQuery]string brandId, [FromQuery]decimal? minPrice, [FromQuery]decimal? maxPrice)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Search>(exampleJson)
            : default(Search);
            return new ObjectResult(example);
        }
    }
}
