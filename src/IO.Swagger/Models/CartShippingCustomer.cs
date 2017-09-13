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
    public partial class CartShippingCustomer :  IEquatable<CartShippingCustomer>
    {
                /// <summary>
        /// Gênero
        /// </summary>
        /// <value>Gênero</value>
        public enum GenderTypeEnum
        {
            
            /// <summary>
            /// Enum MALEEnum for "MALE"
            /// </summary>
            [EnumMember(Value = "MALE")]
            MALEEnum,
            
            /// <summary>
            /// Enum FEMALEEnum for "FEMALE"
            /// </summary>
            [EnumMember(Value = "FEMALE")]
            FEMALEEnum,
            
            /// <summary>
            /// Enum UNINFORMEDEnum for "UNINFORMED"
            /// </summary>
            [EnumMember(Value = "UNINFORMED")]
            UNINFORMEDEnum
        }
                /// <summary>
        /// Tipo de pessoa
        /// </summary>
        /// <value>Tipo de pessoa</value>
        public enum PersonTypeEnum
        {
            
            /// <summary>
            /// Enum INDIVIDUALEnum for "INDIVIDUAL"
            /// </summary>
            [EnumMember(Value = "INDIVIDUAL")]
            INDIVIDUALEnum,
            
            /// <summary>
            /// Enum COMPANYEnum for "COMPANY"
            /// </summary>
            [EnumMember(Value = "COMPANY")]
            COMPANYEnum
        }
        /// <summary>
        /// Gênero
        /// </summary>
        /// <value>Gênero</value>
        [DataMember(Name="genderType")]
        public GenderTypeEnum? GenderType { get; set; }
        /// <summary>
        /// Tipo de pessoa
        /// </summary>
        /// <value>Tipo de pessoa</value>
        [DataMember(Name="personType")]
        public PersonTypeEnum? PersonType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartShippingCustomer" /> class.
        /// </summary>
        /// <param name="Name">Nome do cliente.</param>
        /// <param name="DocumentNumber">Documento ex: CPF, CNPJ.</param>
        /// <param name="Email">E-mail.</param>
        /// <param name="BirthDate">Data de nascimento.</param>
        /// <param name="GenderType">Gênero.</param>
        /// <param name="PersonType">Tipo de pessoa.</param>
        /// <param name="Phones">Telefones.</param>
        public CartShippingCustomer(string Name = default(string), string DocumentNumber = default(string), string Email = default(string), DateTime? BirthDate = default(DateTime?), GenderTypeEnum? GenderType = default(GenderTypeEnum?), PersonTypeEnum? PersonType = default(PersonTypeEnum?), List<Phone> Phones = default(List<Phone>))
        {
            this.Name = Name;
            this.DocumentNumber = DocumentNumber;
            this.Email = Email;
            this.BirthDate = BirthDate;
            this.GenderType = GenderType;
            this.PersonType = PersonType;
            this.Phones = Phones;
            
        }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        /// <value>Nome do cliente</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Documento ex: CPF, CNPJ
        /// </summary>
        /// <value>Documento ex: CPF, CNPJ</value>
        [DataMember(Name="documentNumber")]
        public string DocumentNumber { get; set; }
        /// <summary>
        /// E-mail
        /// </summary>
        /// <value>E-mail</value>
        [DataMember(Name="email")]
        public string Email { get; set; }
        /// <summary>
        /// Data de nascimento
        /// </summary>
        /// <value>Data de nascimento</value>
        [DataMember(Name="birthDate")]
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// Telefones
        /// </summary>
        /// <value>Telefones</value>
        [DataMember(Name="phones")]
        public List<Phone> Phones { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartShippingCustomer {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  GenderType: ").Append(GenderType).Append("\n");
            sb.Append("  PersonType: ").Append(PersonType).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
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
            return Equals((CartShippingCustomer)obj);
        }

        /// <summary>
        /// Returns true if CartShippingCustomer instances are equal
        /// </summary>
        /// <param name="other">Instance of CartShippingCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartShippingCustomer other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.DocumentNumber == other.DocumentNumber ||
                    this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(other.DocumentNumber)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.BirthDate == other.BirthDate ||
                    this.BirthDate != null &&
                    this.BirthDate.Equals(other.BirthDate)
                ) && 
                (
                    this.GenderType == other.GenderType ||
                    this.GenderType != null &&
                    this.GenderType.Equals(other.GenderType)
                ) && 
                (
                    this.PersonType == other.PersonType ||
                    this.PersonType != null &&
                    this.PersonType.Equals(other.PersonType)
                ) && 
                (
                    this.Phones == other.Phones ||
                    this.Phones != null &&
                    this.Phones.SequenceEqual(other.Phones)
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
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.DocumentNumber != null)
                    hash = hash * 59 + this.DocumentNumber.GetHashCode();
                    if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                    if (this.BirthDate != null)
                    hash = hash * 59 + this.BirthDate.GetHashCode();
                    if (this.GenderType != null)
                    hash = hash * 59 + this.GenderType.GetHashCode();
                    if (this.PersonType != null)
                    hash = hash * 59 + this.PersonType.GetHashCode();
                    if (this.Phones != null)
                    hash = hash * 59 + this.Phones.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CartShippingCustomer left, CartShippingCustomer right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CartShippingCustomer left, CartShippingCustomer right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
