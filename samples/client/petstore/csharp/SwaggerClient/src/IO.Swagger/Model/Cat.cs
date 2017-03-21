/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Cat
    /// </summary>
    [DataContract]
    public partial class Cat : Animal,  IEquatable<Cat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Cat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat" /> class.
        /// </summary>
        /// <param name="ClassName">ClassName (required).</param>
        /// <param name="Color">Color (default to &quot;red&quot;).</param>
        /// <param name="Declawed">Declawed.</param>
        public Cat(string ClassName = default(string), string Color = "red", bool? Declawed = default(bool?))
        {
            // to ensure "ClassName" is required (not null)
            if (ClassName == null)
            {
                throw new InvalidDataException("ClassName is a required property for Cat and cannot be null");
            }
            else
            {
                this.ClassName = ClassName;
            }
            // use default value if no "Color" provided
            if (Color == null)
            {
                this.Color = "red";
            }
            else
            {
                this.Color = Color;
            }
            this.Declawed = Declawed;
        }
        
        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }
        /// <summary>
        /// Gets or Sets Declawed
        /// </summary>
        [DataMember(Name="declawed", EmitDefaultValue=false)]
        public bool? Declawed { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cat {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Declawed: ").Append(Declawed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Cat);
        }

        /// <summary>
        /// Returns true if Cat instances are equal
        /// </summary>
        /// <param name="other">Instance of Cat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cat other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClassName == other.ClassName ||
                    this.ClassName != null &&
                    this.ClassName.Equals(other.ClassName)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Declawed == other.Declawed ||
                    this.Declawed != null &&
                    this.Declawed.Equals(other.Declawed)
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
                if (this.ClassName != null)
                    hash = hash * 59 + this.ClassName.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Declawed != null)
                    hash = hash * 59 + this.Declawed.GetHashCode();
                return hash;
            }
        }

        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
