// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Analytics.Purview.UnifiedCatalog.Tests
{
    public class UnifiedCatalogClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("UnifiedCatalog_ENDPOINT");

        // Add other client paramters here as above.
    }
}
