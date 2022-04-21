// ReSharper Disable CheckNamespace
namespace AppodealStack.Monetization.Common
{
    /// <summary>
    /// <para>
    /// Interface containing method signatures of the <see langword="AppStoreInAppPurchaseBuilder"/> class.
    /// </para>
    /// See <see href=""/> for more details.
    /// </summary>
    public interface IAppStoreInAppPurchaseBuilder : IInAppPurchaseBaseBuilder
    {
        void WithProductId(string productId);
        void WithTransactionId(string transactionId);
        IAppStoreInAppPurchase Build();
    }
}
