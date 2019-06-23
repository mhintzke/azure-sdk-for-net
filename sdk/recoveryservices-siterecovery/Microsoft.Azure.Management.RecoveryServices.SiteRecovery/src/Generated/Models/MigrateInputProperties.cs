// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Migrate input properties.
    /// </summary>
    public partial class MigrateInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the MigrateInputProperties class.
        /// </summary>
        public MigrateInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrateInputProperties class.
        /// </summary>
        /// <param name="providerSpecificDetails">The provider specific
        /// details.</param>
        public MigrateInputProperties(MigrateProviderSpecificInput providerSpecificDetails)
        {
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provider specific details.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public MigrateProviderSpecificInput ProviderSpecificDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProviderSpecificDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProviderSpecificDetails");
            }
        }
    }
}