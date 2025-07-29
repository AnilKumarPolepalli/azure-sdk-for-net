namespace Azure.Analytics.Purview.UnifiedCatalog
{
    public partial class UnifiedCatalogClient
    {
        protected UnifiedCatalogClient() { }
        public UnifiedCatalogClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Purview.UnifiedCatalog.UnifiedCatalogClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class UnifiedCatalogClientOptions : Azure.Core.ClientOptions
    {
        public UnifiedCatalogClientOptions(Azure.Analytics.Purview.UnifiedCatalog.Generated.UnifiedCatalogClientOptions.ServiceVersion version = Azure.Analytics.Purview.UnifiedCatalog.Generated.UnifiedCatalogClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}