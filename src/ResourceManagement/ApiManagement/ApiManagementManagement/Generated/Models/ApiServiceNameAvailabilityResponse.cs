// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement.Models;

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    /// <summary>
    /// Response of the CheckNameAvailability operation.
    /// </summary>
    public partial class ApiServiceNameAvailabilityResponse : AzureOperationResponse
    {
        private string _message;
        
        /// <summary>
        /// Optional. Gets or sets the message, which provides the resource
        /// naming requirements in case the reason is Invalid.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private bool _nameAvailable;
        
        /// <summary>
        /// Optional. Gets or sets true if the name is available and can be
        /// used to create new Api Management service. Otherwise false.
        /// </summary>
        public bool NameAvailable
        {
            get { return this._nameAvailable; }
            set { this._nameAvailable = value; }
        }
        
        private NameAvailabilityReason _reason;
        
        /// <summary>
        /// Optional. Gets or sets the reason when isAvailable is false.
        /// </summary>
        public NameAvailabilityReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ApiServiceNameAvailabilityResponse class.
        /// </summary>
        public ApiServiceNameAvailabilityResponse()
        {
        }
    }
}
