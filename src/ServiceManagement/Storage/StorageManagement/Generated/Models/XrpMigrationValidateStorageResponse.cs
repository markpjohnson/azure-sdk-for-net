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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Storage.Models;

namespace Microsoft.WindowsAzure.Management.Storage.Models
{
    /// <summary>
    /// The Validate Storage Account Migration operation response.
    /// </summary>
    public partial class XrpMigrationValidateStorageResponse : AzureOperationResponse, IEnumerable<XrpMigrationValidateStorageMessage>
    {
        private IList<XrpMigrationValidateStorageMessage> _validateStorageMessages;
        
        /// <summary>
        /// Optional. Validation messages for the storage account to be
        /// migrated.
        /// </summary>
        public IList<XrpMigrationValidateStorageMessage> ValidateStorageMessages
        {
            get { return this._validateStorageMessages; }
            set { this._validateStorageMessages = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// XrpMigrationValidateStorageResponse class.
        /// </summary>
        public XrpMigrationValidateStorageResponse()
        {
            this.ValidateStorageMessages = new LazyList<XrpMigrationValidateStorageMessage>();
        }
        
        /// <summary>
        /// Gets the sequence of ValidateStorageMessages.
        /// </summary>
        public IEnumerator<XrpMigrationValidateStorageMessage> GetEnumerator()
        {
            return this.ValidateStorageMessages.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of ValidateStorageMessages.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
