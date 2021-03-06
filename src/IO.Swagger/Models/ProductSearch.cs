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
    public partial class ProductSearch :  IEquatable<ProductSearch>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSearch" /> class.
        /// </summary>
        /// <param name="Id">Identificador do produto.</param>
        /// <param name="OriginalId">Identificador do produto no parceiro..</param>
        /// <param name="Name">Nome do produto.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Brand">Brand.</param>
        /// <param name="Vendor">Vendor.</param>
        public ProductSearch(string Id = default(string), string OriginalId = default(string), string Name = default(string), ProductCategory Category = default(ProductCategory), ProductBrand Brand = default(ProductBrand), ProductDetailVendor Vendor = default(ProductDetailVendor))
        {
            this.Id = Id;
            this.OriginalId = OriginalId;
            this.Name = Name;
            this.Category = Category;
            this.Brand = Brand;
            this.Vendor = Vendor;
            
        }

        /// <summary>
        /// Identificador do produto
        /// </summary>
        /// <value>Identificador do produto</value>
        [DataMember(Name="id")]
        public string Id { get; set; }
        /// <summary>
        /// Identificador do produto no parceiro.
        /// </summary>
        /// <value>Identificador do produto no parceiro.</value>
        [DataMember(Name="originalId")]
        public string OriginalId { get; set; }
        /// <summary>
        /// Nome do produto
        /// </summary>
        /// <value>Nome do produto</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
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
            sb.Append("class ProductSearch {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OriginalId: ").Append(OriginalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            return Equals((ProductSearch)obj);
        }

        /// <summary>
        /// Returns true if ProductSearch instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductSearch other)
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
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Brand == other.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(other.Brand)
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
                    if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                    if (this.Brand != null)
                    hash = hash * 59 + this.Brand.GetHashCode();
                    if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ProductSearch left, ProductSearch right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductSearch left, ProductSearch right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
