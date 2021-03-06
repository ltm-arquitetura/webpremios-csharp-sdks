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
    public partial class ShippingRates :  IEquatable<ShippingRates>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingRates" /> class.
        /// </summary>
        /// <param name="Total">Valor total do frete para todos os produtos do carrinho.</param>
        /// <param name="Vendors">Vendors.</param>
        public ShippingRates(decimal? Total = default(decimal?), List<VendorRate> Vendors = default(List<VendorRate>))
        {
            this.Total = Total;
            this.Vendors = Vendors;
            
        }

        /// <summary>
        /// Valor total do frete para todos os produtos do carrinho
        /// </summary>
        /// <value>Valor total do frete para todos os produtos do carrinho</value>
        [DataMember(Name="total")]
        public decimal? Total { get; set; }
        /// <summary>
        /// Gets or Sets Vendors
        /// </summary>
        [DataMember(Name="vendors")]
        public List<VendorRate> Vendors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingRates {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Vendors: ").Append(Vendors).Append("\n");
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
            return Equals((ShippingRates)obj);
        }

        /// <summary>
        /// Returns true if ShippingRates instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingRates other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.Vendors == other.Vendors ||
                    this.Vendors != null &&
                    this.Vendors.SequenceEqual(other.Vendors)
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
                    if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                    if (this.Vendors != null)
                    hash = hash * 59 + this.Vendors.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ShippingRates left, ShippingRates right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ShippingRates left, ShippingRates right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
