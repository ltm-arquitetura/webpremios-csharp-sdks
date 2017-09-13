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
    public class CarrinhoApiController : Controller
    { 

        /// <summary>
        /// Obtém um carrinho
        /// </summary>
        /// <remarks>Recurso utilizado para recuperar o ultimo carrinho criado do participante</remarks>
        /// <param name="type">Tipo do carrinho</param>
        /// <response code="200">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpGet]
        [Route("/marketplace-api/v1/carts/me")]
        [SwaggerOperation("CartsMeGet")]
        [SwaggerResponse(200, type: typeof(Cart))]
        public virtual IActionResult CartsMeGet([FromQuery]string type)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Cart>(exampleJson)
            : default(Cart);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Adicionar item no carrinho
        /// </summary>
        /// <remarks>Recurso utilizado para adicinar um determinado item no carrinho</remarks>
        /// <param name="type">Tipo do carrinho</param>
        /// <param name="item"></param>
        /// <param name="email">E-mail que será enviado o voucher</param>
        /// <response code="201">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpPost]
        [Route("/marketplace-api/v1/carts/me/items")]
        [SwaggerOperation("CartsMeItemsPost")]
        public virtual void CartsMeItemsPost([FromQuery]string type, [FromBody]RequestAddCartItem item, [FromQuery]string email)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Remove item do carrinho
        /// </summary>
        /// <remarks>Recurso utilizado para remover um determinado item do carrinho</remarks>
        /// <param name="skuId">Identificador do SKU.</param>
        /// <param name="type">Tipo do carrinho</param>
        /// <response code="204">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpDelete]
        [Route("/marketplace-api/v1/carts/me/items/{skuId}")]
        [SwaggerOperation("CartsMeItemsSkuIdDelete")]
        public virtual void CartsMeItemsSkuIdDelete([FromRoute]string skuId, [FromQuery]string type)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Alterar item no carrinho
        /// </summary>
        /// <remarks>Recurso utilizado para alterar um determinado item no carrinho</remarks>
        /// <param name="skuId">Identificador do SKU</param>
        /// <param name="type">Tipo do carrinho</param>
        /// <param name="vendorId">Identificador do parceiro</param>
        /// <param name="item"></param>
        /// <response code="204">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpPut]
        [Route("/marketplace-api/v1/carts/me/items/{skuId}")]
        [SwaggerOperation("CartsMeItemsSkuIdPut")]
        public virtual void CartsMeItemsSkuIdPut([FromRoute]int? skuId, [FromQuery]string type, [FromQuery]string vendorId, [FromBody]RequestUpdCartItem item)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Adiciona dados de entrega no carrinho
        /// </summary>
        /// <remarks>Recurso utilizado para adicinar os dados de entrega do carrinho</remarks>
        /// <param name="type">Tipo do carrinho</param>
        /// <param name="shipping"></param>
        /// <response code="204">Operação realizada com sucesso.</response>
        /// <response code="400">Requisição mal formada.</response>
        /// <response code="401">Requisição requer autenticação.</response>
        /// <response code="403">O acesso ao recurso foi negado.</response>
        /// <response code="404">Recurso não encontrado.</response>
        /// <response code="422">Requisição não processável.</response>
        /// <response code="500">Erro Interno.</response>
        [HttpPut]
        [Route("/marketplace-api/v1/carts/me/shipping")]
        [SwaggerOperation("CartsMeShippingPut")]
        public virtual void CartsMeShippingPut([FromQuery]string type, [FromBody]CartShipping shipping)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Calcula o frete do carrinho para um CEP
        /// </summary>
        /// <remarks>Recurso utilizado para calcular o frete do carrinho baseado em um CEP</remarks>
        /// <param name="zipCode">CEP a ser calculado</param>
        /// <param name="type">Tipo do carrinho</param>
        /// <response code="200">Frete calculado com sucesso</response>
        /// <response code="422">Carrinho inválido para calculo de frete</response>
        [HttpGet]
        [Route("/marketplace-api/v1/carts/me/shipping/rates")]
        [SwaggerOperation("CartsMeShippingRatesGet")]
        [SwaggerResponse(200, type: typeof(ShippingRates))]
        public virtual IActionResult CartsMeShippingRatesGet([FromQuery]string zipCode, [FromQuery]string type)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ShippingRates>(exampleJson)
            : default(ShippingRates);
            return new ObjectResult(example);
        }
    }
}
