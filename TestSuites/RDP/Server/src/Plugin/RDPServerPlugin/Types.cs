// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Protocols.TestTools.StackSdk.RemoteDesktop.Rdpbcgr;
using System.Collections.Generic;

namespace Microsoft.Protocols.TestManager.RDPServerPlugin
{
    public enum TriggerMethod
    {
        Powershell,
        Manual,
        Managed,
    }
    /// <summary>
    /// The detection information
    /// </summary>
    public class DetectionInfo
    {
        // Parameters for Detecting
        public string SUTName;
        public string DomainName;
        public string UserName;
        public string Port;

        // Detect Result
        public TS_UD_SC_CORE_version_Values Version;

        public bool? IsSupportAutoReconnect;
        public bool? IsSupportFastPathInput;

        public bool IsSupportRDPEDYC = false;
        public bool IsSupportRDPEMT = false;
        public bool IsSupportRDPELE = false;
    }
}
