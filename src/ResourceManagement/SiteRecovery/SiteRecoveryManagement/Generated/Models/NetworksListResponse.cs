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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The response model for the list of Networks.
    /// </summary>
    public partial class NetworksListResponse : OperationCommonResponse
    {
        private IList<Network> _networksList;
        
        /// <summary>
        /// Optional. List of networks.
        /// </summary>
        public IList<Network> NetworksList
        {
            get { return this._networksList; }
            set { this._networksList = value; }
        }
        
        private string _nextLink;
        
        /// <summary>
        /// Optional. Next link.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworksListResponse class.
        /// </summary>
        public NetworksListResponse()
        {
            this.NetworksList = new LazyList<Network>();
        }
    }
}