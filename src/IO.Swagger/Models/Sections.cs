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
    public partial class Sections :  IEquatable<Sections>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Sections" /> class.
        /// </summary>
        /// <param name="Id">Identificador da categorização.</param>
        /// <param name="SectionType">Tipo da categorização.</param>
        /// <param name="Name">Nome da categorização.</param>
        /// <param name="Slug">URL amigável da categorização.</param>
        public Sections(string Id = default(string), string SectionType = default(string), string Name = default(string), string Slug = default(string))
        {
            this.Id = Id;
            this.SectionType = SectionType;
            this.Name = Name;
            this.Slug = Slug;
            
        }

        /// <summary>
        /// Identificador da categorização
        /// </summary>
        /// <value>Identificador da categorização</value>
        [DataMember(Name="id")]
        public string Id { get; set; }
        /// <summary>
        /// Tipo da categorização
        /// </summary>
        /// <value>Tipo da categorização</value>
        [DataMember(Name="sectionType")]
        public string SectionType { get; set; }
        /// <summary>
        /// Nome da categorização
        /// </summary>
        /// <value>Nome da categorização</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// URL amigável da categorização
        /// </summary>
        /// <value>URL amigável da categorização</value>
        [DataMember(Name="slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sections {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SectionType: ").Append(SectionType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
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
            return Equals((Sections)obj);
        }

        /// <summary>
        /// Returns true if Sections instances are equal
        /// </summary>
        /// <param name="other">Instance of Sections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sections other)
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
                    this.SectionType == other.SectionType ||
                    this.SectionType != null &&
                    this.SectionType.Equals(other.SectionType)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Slug == other.Slug ||
                    this.Slug != null &&
                    this.Slug.Equals(other.Slug)
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
                    if (this.SectionType != null)
                    hash = hash * 59 + this.SectionType.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Slug != null)
                    hash = hash * 59 + this.Slug.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Sections left, Sections right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Sections left, Sections right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}