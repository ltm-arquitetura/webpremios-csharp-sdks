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
    public partial class Product :  IEquatable<Product>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="Id">Identificador do produto.</param>
        /// <param name="OriginalId">Identificador do produto no parceiro.</param>
        /// <param name="Name">Nome do produto.</param>
        /// <param name="ImageUrl">Imagem do produto.</param>
        /// <param name="Vendor">Vendor.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Brand">Brand.</param>
        public Product(string Id = default(string), string OriginalId = default(string), string Name = default(string), string ImageUrl = default(string), ProductVendor Vendor = default(ProductVendor), ProductCategory Category = default(ProductCategory), ProductBrand Brand = default(ProductBrand))
        {
            this.Id = Id;
            this.OriginalId = OriginalId;
            this.Name = Name;
            this.ImageUrl = ImageUrl;
            this.Vendor = Vendor;
            this.Category = Category;
            this.Brand = Brand;
            
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
        /// Imagem do produto
        /// </summary>
        /// <value>Imagem do produto</value>
        [DataMember(Name="imageUrl")]
        public string ImageUrl { get; set; }
        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="vendor")]
        public ProductVendor Vendor { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category")]
        public ProductCategory Category { get; set; }
        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand")]
        public ProductBrand Brand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OriginalId: ").Append(OriginalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            return Equals((Product)obj);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="other">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product other)
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
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Brand == other.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(other.Brand)
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
                    if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                    if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                    if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                    if (this.Brand != null)
                    hash = hash * 59 + this.Brand.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Product left, Product right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Product left, Product right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
