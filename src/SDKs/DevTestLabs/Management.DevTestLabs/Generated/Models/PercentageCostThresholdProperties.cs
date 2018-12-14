// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a percentage cost threshold.
    /// </summary>
    public partial class PercentageCostThresholdProperties
    {
        /// <summary>
        /// Initializes a new instance of the PercentageCostThresholdProperties
        /// class.
        /// </summary>
        public PercentageCostThresholdProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PercentageCostThresholdProperties
        /// class.
        /// </summary>
        /// <param name="thresholdValue">The cost threshold value.</param>
        public PercentageCostThresholdProperties(double? thresholdValue = default(double?))
        {
            ThresholdValue = thresholdValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the cost threshold value.
        /// </summary>
        [JsonProperty(PropertyName = "thresholdValue")]
        public double? ThresholdValue { get; set; }

    }
}