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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ProductDetail :  IEquatable<ProductDetail>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetail" /> class.
        /// </summary>
        /// <param name="Id">Identificador do produto.</param>
        /// <param name="OriginalId">Identificador do produto no parceiro.</param>
        /// <param name="Name">Nome do produto.</param>
        /// <param name="Description">Descrição do produto.</param>
        /// <param name="Sections">Categorização.</param>
        /// <param name="Skus">SKUs.</param>
        /// <param name="Features">Características.</param>
        /// <param name="Vendor">Vendor.</param>
        public ProductDetail(string Id = default(string), string OriginalId = default(string), string Name = default(string), string Description = default(string), List<Sections> Sections = default(List<Sections>), List<ProductSKUDetail> Skus = default(List<ProductSKUDetail>), List<Features> Features = default(List<Features>), ProductDetailVendor Vendor = default(ProductDetailVendor))
        {
            this.Id = Id;
            this.OriginalId = OriginalId;
            this.Name = Name;
            this.Description = Description;
            this.Sections = Sections;
            this.Skus = Skus;
            this.Features = Features;
            this.Vendor = Vendor;
            
        }

        /// <summary>
        /// Identificador do produto
        /// </summary>
        /// <value>Identificador do produto</value>
        [DataMember(Name="id")]
        public string Id { get; set; }
        /// <summary>
        /// Identificador do produto no parceiro
        /// </summary>
        /// <value>Identificador do produto no parceiro</value>
        [DataMember(Name="originalId")]
        public string OriginalId { get; set; }
        /// <summary>
        /// Nome do produto
        /// </summary>
        /// <value>Nome do produto</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Descrição do produto
        /// </summary>
        /// <value>Descrição do produto</value>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// Categorização
        /// </summary>
        /// <value>Categorização</value>
        [DataMember(Name="sections")]
        public List<Sections> Sections { get; set; }
        /// <summary>
        /// SKUs
        /// </summary>
        /// <value>SKUs</value>
        [DataMember(Name="skus")]
        public List<ProductSKUDetail> Skus { get; set; }
        /// <summary>
        /// Características
        /// </summary>
        /// <value>Características</value>
        [DataMember(Name="features")]
        public List<Features> Features { get; set; }
        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="vendor")]
        public ProductDetailVendor Vendor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OriginalId: ").Append(OriginalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
            sb.Append("  Skus: ").Append(Skus).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((ProductDetail)obj);
        }

        /// <summary>
        /// Returns true if ProductDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductDetail other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.OriginalId == other.OriginalId ||
                    this.OriginalId != null &&
                    this.OriginalId.Equals(other.OriginalId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Sections == other.Sections ||
                    this.Sections != null &&
                    this.Sections.SequenceEqual(other.Sections)
                ) && 
                (
                    this.Skus == other.Skus ||
                    this.Skus != null &&
                    this.Skus.SequenceEqual(other.Skus)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(other.Features)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.OriginalId != null)
                    hash = hash * 59 + this.OriginalId.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.Sections != null)
                    hash = hash * 59 + this.Sections.GetHashCode();
                    if (this.Skus != null)
                    hash = hash * 59 + this.Skus.GetHashCode();
                    if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();
                    if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ProductDetail left, ProductDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductDetail left, ProductDetail right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
