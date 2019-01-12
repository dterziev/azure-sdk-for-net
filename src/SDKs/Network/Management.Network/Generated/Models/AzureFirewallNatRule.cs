// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a NAT rule.
    /// </summary>
    public partial class AzureFirewallNatRule
    {
        /// <summary>
        /// Initializes a new instance of the AzureFirewallNatRule class.
        /// </summary>
        public AzureFirewallNatRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFirewallNatRule class.
        /// </summary>
        /// <param name="name">Name of the NAT rule.</param>
        /// <param name="description">Description of the rule.</param>
        /// <param name="sourceAddresses">List of source IP addresses for this
        /// rule.</param>
        /// <param name="destinationAddresses">List of destination IP addresses
        /// for this rule.</param>
        /// <param name="destinationPorts">List of destination ports.</param>
        /// <param name="protocols">Array of AzureFirewallNetworkRuleProtocols
        /// applicable to this NAT rule.</param>
        /// <param name="translatedAddress">The translated address for this NAT
        /// rule.</param>
        /// <param name="translatedPort">The translated port for this NAT
        /// rule.</param>
        public AzureFirewallNatRule(string name = default(string), string description = default(string), IList<string> sourceAddresses = default(IList<string>), IList<string> destinationAddresses = default(IList<string>), IList<string> destinationPorts = default(IList<string>), IList<string> protocols = default(IList<string>), string translatedAddress = default(string), string translatedPort = default(string))
        {
            Name = name;
            Description = description;
            SourceAddresses = sourceAddresses;
            DestinationAddresses = destinationAddresses;
            DestinationPorts = destinationPorts;
            Protocols = protocols;
            TranslatedAddress = translatedAddress;
            TranslatedPort = translatedPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets list of source IP addresses for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "sourceAddresses")]
        public IList<string> SourceAddresses { get; set; }

        /// <summary>
        /// Gets or sets list of destination IP addresses for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "destinationAddresses")]
        public IList<string> DestinationAddresses { get; set; }

        /// <summary>
        /// Gets or sets list of destination ports.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPorts")]
        public IList<string> DestinationPorts { get; set; }

        /// <summary>
        /// Gets or sets array of AzureFirewallNetworkRuleProtocols applicable
        /// to this NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "protocols")]
        public IList<string> Protocols { get; set; }

        /// <summary>
        /// Gets or sets the translated address for this NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "translatedAddress")]
        public string TranslatedAddress { get; set; }

        /// <summary>
        /// Gets or sets the translated port for this NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "translatedPort")]
        public string TranslatedPort { get; set; }

    }
}