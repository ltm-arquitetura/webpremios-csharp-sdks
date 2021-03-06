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
    public class CompraApiController : Controller
    { 

        /// <summary>
        /// Cria e autoriza uma compra
        /// </summary>
        /// <remarks>Recurso utilizado para criação e autorização de uma compras</remarks>
        /// <param name="purchase"></param>
        /// <response code="201">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpPost]
        [Route("/marketplace-api/v1/purchases/authorize")]
        [SwaggerOperation("PurchasesAuthorizePost")]
        [SwaggerResponse(200, type: typeof(PurchaseAdd))]
        public virtual IActionResult PurchasesAuthorizePost([FromBody]PurchaseAuthorize purchase)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PurchaseAdd>(exampleJson)
            : default(PurchaseAdd);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Confirma uma compra
        /// </summary>
        /// <remarks>Recurso utilizado para confirmação de compra</remarks>
        /// <param name="id">Identificador da compra</param>
        /// <response code="204">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpPost]
        [Route("/marketplace-api/v1/purchases/{id}/confirm")]
        [SwaggerOperation("PurchasesIdConfirmPost")]
        public virtual void PurchasesIdConfirmPost([FromRoute]string id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Obtém um compra
        /// </summary>
        /// <remarks>Recurso utilizado obter uma compra</remarks>
        /// <param name="id">Identificador da compra</param>
        /// <response code="200">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpGet]
        [Route("/marketplace-api/v1/purchases/{id}")]
        [SwaggerOperation("PurchasesIdGet")]
        [SwaggerResponse(200, type: typeof(Purchase))]
        public virtual IActionResult PurchasesIdGet([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Purchase>(exampleJson)
            : default(Purchase);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Obtém compras
        /// </summary>
        /// <remarks>Recurso utilizado obter as compras de um participante</remarks>
        /// <response code="200">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpGet]
        [Route("/marketplace-api/v1/purchases/me")]
        [SwaggerOperation("PurchasesMeGet")]
        [SwaggerResponse(200, type: typeof(List<Purchase>))]
        public virtual IActionResult PurchasesMeGet()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Purchase>>(exampleJson)
            : default(List<Purchase>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Cria uma compra
        /// </summary>
        /// <remarks>Recurso utilizado para criação de uma compra</remarks>
        /// <param name="purchase"></param>
        /// <response code="201">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpPost]
        [Route("/marketplace-api/v1/purchases")]
        [SwaggerOperation("PurchasesPost")]
        [SwaggerResponse(200, type: typeof(PurchaseAdd))]
        public virtual IActionResult PurchasesPost([FromBody]PurchasePost purchase)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PurchaseAdd>(exampleJson)
            : default(PurchaseAdd);
            return new ObjectResult(example);
        }
    }
}
