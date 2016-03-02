// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Contains the data disk images information.
    /// </summary>
    public partial class DataDiskImage
    {
        /// <summary>
        /// Initializes a new instance of the DataDiskImage class.
        /// </summary>
        public DataDiskImage() { }

        /// <summary>
        /// Initializes a new instance of the DataDiskImage class.
        /// </summary>
        public DataDiskImage(int? lun = default(int?))
        {
            Lun = lun;
        }

        /// <summary>
        /// Gets the LUN number for a data disk.This value is used to identify
        /// data disk image inside the VMImage therefore it must be unique
        /// for each data disk.The allowed character for the value is digit.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int? Lun { get; private set; }

    }
}
