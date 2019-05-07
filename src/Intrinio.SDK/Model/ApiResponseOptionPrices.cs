

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
using SwaggerDateConverter = Intrinio.SDK.Client.SwaggerDateConverter;

namespace Intrinio.SDK.Model
{
    /// <summary>
    /// ApiResponseOptionPrices
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionPrices :  IEquatable<ApiResponseOptionPrices>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionPrices" /> class.
        /// </summary>
        /// <param name="Prices">A list of option prices in descending order by date.</param>
        /// <param name="Option">Option.</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public ApiResponseOptionPrices(List<OptionPrice> Prices = default(List<OptionPrice>), Option Option = default(Option), string NextPage = default(string))
        {
            this.Prices = Prices;
            this.Option = Option;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// A list of option prices in descending order by date
        /// </summary>
        /// <value>A list of option prices in descending order by date</value>
        [DataMember(Name="prices", EmitDefaultValue=false)]
        public List<OptionPrice> Prices { get; set; }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name="option", EmitDefaultValue=false)]
        public Option Option { get; set; }

        /// <summary>
        /// The token required to request the next page of the data
        /// </summary>
        /// <value>The token required to request the next page of the data</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionPrices {\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
            return this.Equals(input as ApiResponseOptionPrices);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionPrices instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionPrices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionPrices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prices == input.Prices ||
                    this.Prices != null &&
                    this.Prices.SequenceEqual(input.Prices)
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
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
                if (this.Prices != null)
                    hashCode = hashCode * 59 + this.Prices.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
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