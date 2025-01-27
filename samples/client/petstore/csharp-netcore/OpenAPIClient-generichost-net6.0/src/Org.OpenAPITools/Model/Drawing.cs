// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */



using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Drawing
    /// </summary>
    public partial class Drawing : Dictionary<String, Fruit>, IEquatable<Drawing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drawing" /> class.
        /// </summary>
        /// <param name="mainShape">mainShape</param>
        /// <param name="shapeOrNull">shapeOrNull</param>
        /// <param name="nullableShape">nullableShape</param>
        /// <param name="shapes">shapes</param>
        public Drawing(Shape mainShape = default, ShapeOrNull shapeOrNull = default, NullableShape nullableShape = default, List<Shape> shapes = default) : base()
        {
            MainShape = mainShape;
            ShapeOrNull = shapeOrNull;
            NullableShape = nullableShape;
            Shapes = shapes;
        }

        /// <summary>
        /// Gets or Sets MainShape
        /// </summary>
        [JsonPropertyName("mainShape")]
        public Shape MainShape { get; set; }

        /// <summary>
        /// Gets or Sets ShapeOrNull
        /// </summary>
        [JsonPropertyName("shapeOrNull")]
        public ShapeOrNull ShapeOrNull { get; set; }

        /// <summary>
        /// Gets or Sets NullableShape
        /// </summary>
        [JsonPropertyName("nullableShape")]
        public NullableShape NullableShape { get; set; }

        /// <summary>
        /// Gets or Sets Shapes
        /// </summary>
        [JsonPropertyName("shapes")]
        public List<Shape> Shapes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Drawing {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  MainShape: ").Append(MainShape).Append("\n");
            sb.Append("  ShapeOrNull: ").Append(ShapeOrNull).Append("\n");
            sb.Append("  NullableShape: ").Append(NullableShape).Append("\n");
            sb.Append("  Shapes: ").Append(Shapes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Drawing).AreEqual;
        }

        /// <summary>
        /// Returns true if Drawing instances are equal
        /// </summary>
        /// <param name="input">Instance of Drawing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Drawing input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.MainShape != null)
                {
                    hashCode = (hashCode * 59) + this.MainShape.GetHashCode();
                }
                if (this.ShapeOrNull != null)
                {
                    hashCode = (hashCode * 59) + this.ShapeOrNull.GetHashCode();
                }
                if (this.NullableShape != null)
                {
                    hashCode = (hashCode * 59) + this.NullableShape.GetHashCode();
                }
                if (this.Shapes != null)
                {
                    hashCode = (hashCode * 59) + this.Shapes.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
