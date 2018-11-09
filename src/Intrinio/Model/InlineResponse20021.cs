

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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// InlineResponse20021
    /// </summary>
    [DataContract]
    public partial class InlineResponse20021 :  IEquatable<InlineResponse20021>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20021" /> class.
        /// </summary>
        /// <param name="Indices">Indices.</param>
        public InlineResponse20021(List<StockMarketIndexSummary> Indices = default(List<StockMarketIndexSummary>))
        {
            this.Indices = Indices;
        }
        
        /// <summary>
        /// Gets or Sets Indices
        /// </summary>
        [DataMember(Name="indices", EmitDefaultValue=false)]
        public List<StockMarketIndexSummary> Indices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20021 {\n");
            sb.Append("  Indices: ").Append(Indices).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse20021);
        }

        /// <summary>
        /// Returns true if InlineResponse20021 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20021 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20021 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Indices == input.Indices ||
                    this.Indices != null &&
                    this.Indices.SequenceEqual(input.Indices)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Indices != null)
                    hashCode = hashCode * 59 + this.Indices.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}