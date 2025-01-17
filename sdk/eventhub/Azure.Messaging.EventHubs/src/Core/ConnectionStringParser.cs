﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Messaging.EventHubs.Metadata;

namespace Azure.Messaging.EventHubs.Core
{
    /// <summary>
    ///   Allows for parsing Event Hubs connection strings.
    /// </summary>
    ///
    internal class ConnectionStringParser
    {
        /// <summary>The character used to separate a token and its value in the connection string.</summary>
        protected const char TokenValueSeparator = '=';

        /// <summary>The character used to mark the beginning of a new token/value pair in the connection string.</summary>
        protected const char TokenValuePairDelimiter = ';';

        /// <summary>The formatted protocol used by an Event Hubs endpoint. </summary>
        protected const string EventHubsEndpointScheme = "sb://";

        /// <summary>The token that identifies the endpoint address for the Event Hubs namespace.</summary>
        protected const string EndpointToken = "Endpoint";

        /// <summary>The token that identifies the path to a specific Event Hub under the namespace.</summary>
        protected const string EventHubPathToken = "EntityPath";

        /// <summary>The token that identifies the name of a shared access key.</summary>
        protected const string SharedAccessKeyNameToken = "SharedAccessKeyName";

        /// <summary>The token that identifies the value of a shared access key.</summary>
        protected const string SharedAccessKeyValueToken = "SharedAccessKey";

        /// <summary>
        ///   Parses the specified Event Hubs connection string into its component properties.
        /// </summary>
        ///
        /// <param name="connectionString">The connection string to parse.</param>
        ///
        /// <returns>The component properties parsed from the connection string.</returns>
        ///
        /// <seealso cref="ConnectionStringProperties" />
        ///
        public static ConnectionStringProperties Parse(string connectionString)
        {
            Guard.ArgumentNotNullOrEmpty(nameof(connectionString), connectionString);

            int tokenPositionModifier = (connectionString[0] == TokenValuePairDelimiter) ? 0 : 1;
            int lastPosition = 0;
            int currentPosition = 0;
            int valueStart;

            string slice;
            string token;
            string value;

            var parsedValues =
            (
                EndpointToken : default(UriBuilder),
                EventHubPathToken : default(string),
                SharedAccessKeyNameToken : default(string),
                SharedAccessKeyValueToken : default(string)
            );

            while (currentPosition != -1)
            {
                // Slice the string into the next token/value pair.

                currentPosition = connectionString.IndexOf(TokenValuePairDelimiter, lastPosition + 1);

                if (currentPosition >= 0)
                {
                    slice = connectionString.Substring(lastPosition, (currentPosition - lastPosition));
                }
                else
                {
                    slice = connectionString.Substring(lastPosition);
                }

                // Break the token and value apart, if this is a legal pair.

                valueStart = slice.IndexOf(TokenValueSeparator);

                if (valueStart >= 0)
                {
                    token = slice.Substring((1 - tokenPositionModifier), (valueStart - 1 + tokenPositionModifier));
                    value = slice.Substring(valueStart + 1);

                    // Guard against leading and trailing spaces, only trimming if there is a need.

                    if ((!String.IsNullOrEmpty(token)) && (Char.IsWhiteSpace(token[0])) || Char.IsWhiteSpace(token[token.Length - 1]))
                    {
                       token = token.Trim();
                    }

                    if ((!String.IsNullOrEmpty(value)) && (Char.IsWhiteSpace(value[0]) || Char.IsWhiteSpace(value[value.Length - 1])))
                    {
                       value = value.Trim();
                    }

                    // If there was no value for a key, then consider the connection string to
                    // be malformed.

                    if (String.IsNullOrEmpty(value))
                    {
                        throw new FormatException(Resources.InvalidConnectionString);
                    }

                    // Compare the token against the known connection string properties and capture the
                    // pair if they are a known attribute.

                    if (String.Compare(EndpointToken, token, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        parsedValues.EndpointToken = new UriBuilder(value);
                        parsedValues.EndpointToken.Scheme = EventHubsEndpointScheme;
                    }
                    else if (String.Compare(EventHubPathToken, token, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        parsedValues.EventHubPathToken = value;
                    }
                    else if (String.Compare(SharedAccessKeyNameToken, token, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        parsedValues.SharedAccessKeyNameToken = value;
                    }
                    else if (String.Compare(SharedAccessKeyValueToken, token, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        parsedValues.SharedAccessKeyValueToken = value;
                    }
                }
                else if ((slice.Length != 1) || (slice[0] != TokenValuePairDelimiter))
                {
                    // This wasn't a legal pair it is not simply a trailing delmieter; consider
                    // the connection string to be malformed.

                    throw new FormatException(Resources.InvalidConnectionString);
                }

                tokenPositionModifier = 0;
                lastPosition = currentPosition;
            }

            return new ConnectionStringProperties
            (
                parsedValues.EndpointToken?.Uri,
                parsedValues.EventHubPathToken,
                parsedValues.SharedAccessKeyNameToken,
                parsedValues.SharedAccessKeyValueToken
            );
        }
    }
}
