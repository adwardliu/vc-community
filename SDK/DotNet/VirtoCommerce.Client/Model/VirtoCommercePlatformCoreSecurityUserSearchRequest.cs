using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace VirtoCommerce.Client.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class VirtoCommercePlatformCoreSecurityUserSearchRequest : IEquatable<VirtoCommercePlatformCoreSecurityUserSearchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtoCommercePlatformCoreSecurityUserSearchRequest" /> class.
        /// </summary>
        public VirtoCommercePlatformCoreSecurityUserSearchRequest()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets AccountTypes
        /// </summary>
        [DataMember(Name="accountTypes", EmitDefaultValue=false)]
        public List<string> AccountTypes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Keyword
        /// </summary>
        [DataMember(Name="keyword", EmitDefaultValue=false)]
        public string Keyword { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SkipCount
        /// </summary>
        [DataMember(Name="skipCount", EmitDefaultValue=false)]
        public int? SkipCount { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TakeCount
        /// </summary>
        [DataMember(Name="takeCount", EmitDefaultValue=false)]
        public int? TakeCount { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtoCommercePlatformCoreSecurityUserSearchRequest {\n");
            sb.Append("  AccountTypes: ").Append(AccountTypes).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
            sb.Append("  SkipCount: ").Append(SkipCount).Append("\n");
            sb.Append("  TakeCount: ").Append(TakeCount).Append("\n");
            
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VirtoCommercePlatformCoreSecurityUserSearchRequest);
        }

        /// <summary>
        /// Returns true if VirtoCommercePlatformCoreSecurityUserSearchRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of VirtoCommercePlatformCoreSecurityUserSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtoCommercePlatformCoreSecurityUserSearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountTypes == other.AccountTypes ||
                    this.AccountTypes != null &&
                    this.AccountTypes.SequenceEqual(other.AccountTypes)
                ) && 
                (
                    this.Keyword == other.Keyword ||
                    this.Keyword != null &&
                    this.Keyword.Equals(other.Keyword)
                ) && 
                (
                    this.SkipCount == other.SkipCount ||
                    this.SkipCount != null &&
                    this.SkipCount.Equals(other.SkipCount)
                ) && 
                (
                    this.TakeCount == other.TakeCount ||
                    this.TakeCount != null &&
                    this.TakeCount.Equals(other.TakeCount)
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
                
                if (this.AccountTypes != null)
                    hash = hash * 57 + this.AccountTypes.GetHashCode();
                
                if (this.Keyword != null)
                    hash = hash * 57 + this.Keyword.GetHashCode();
                
                if (this.SkipCount != null)
                    hash = hash * 57 + this.SkipCount.GetHashCode();
                
                if (this.TakeCount != null)
                    hash = hash * 57 + this.TakeCount.GetHashCode();
                
                return hash;
            }
        }

    }


}
