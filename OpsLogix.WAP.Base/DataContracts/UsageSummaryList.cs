﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpsLogix.WAP.Base.DataContracts
{
    /// <summary>
    /// Represents a usage summary list.
    /// </summary>
    [CollectionDataContract(Namespace = "http://schemas.microsoft.com/windowsazure", Name = "UsageSummaries", ItemName = "UsageSummary")]
    public class UsageSummaryList : List<ServiceUsageSummary>
    {
    }
}
