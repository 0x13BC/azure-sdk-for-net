// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Open Database Connectivity (ODBC) linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Odbc")]
    [Rest.Serialization.JsonTransformation]
    public partial class OdbcLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the OdbcLinkedService class.
        /// </summary>
        public OdbcLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OdbcLinkedService class.
        /// </summary>
        /// <param name="connectionString">The non-access credential portion of
        /// the connection string as well as an optional encrypted
        /// credential.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="authenticationType">Type of authentication used to
        /// connect to the ODBC data store. Possible values are: Anonymous and
        /// Basic. Type: string (or Expression with resultType string).</param>
        /// <param name="credential">The access credential portion of the
        /// connection string specified in driver-specific property-value
        /// format.</param>
        /// <param name="userName">User name for Basic authentication. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="password">Password for Basic authentication.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public OdbcLinkedService(SecretBase connectionString, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object authenticationType = default(object), SecretBase credential = default(SecretBase), object userName = default(object), SecretBase password = default(SecretBase), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            ConnectionString = connectionString;
            AuthenticationType = authenticationType;
            Credential = credential;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the non-access credential portion of the connection
        /// string as well as an optional encrypted credential.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public SecretBase ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets type of authentication used to connect to the ODBC
        /// data store. Possible values are: Anonymous and Basic. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public object AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the access credential portion of the connection string
        /// specified in driver-specific property-value format.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.credential")]
        public SecretBase Credential { get; set; }

        /// <summary>
        /// Gets or sets user name for Basic authentication. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets password for Basic authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
        }
    }
}
