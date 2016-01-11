// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics.Contracts;

namespace System.Resources
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    [System.Runtime.InteropServices.ComVisible(true)]
    public sealed class SatelliteContractVersionAttribute : Attribute
    {
        private String _version;

        public SatelliteContractVersionAttribute(String version)
        {
            if (version == null)
                throw new ArgumentNullException("version");
            Contract.EndContractBlock();
            _version = version;
        }

        public String Version
        {
            get { return _version; }
        }
    }
}
