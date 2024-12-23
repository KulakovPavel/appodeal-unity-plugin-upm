// ReSharper Disable CheckNamespace

using System;

namespace AppodealStack.Monetization.Common
{
    internal class InAppPurchaseValidationProxyListener : IInAppPurchaseValidationProxyListener
    {
        public IInAppPurchaseValidationListener Listener { get; set; }

        public event EventHandler<InAppPurchaseEventArgs> OnValidationSucceeded;
        public event EventHandler<InAppPurchaseEventArgs> OnValidationFailed;

        public void OnInAppPurchaseValidationSucceeded(string json)
        {
            Listener?.OnInAppPurchaseValidationSucceeded(json);
            OnValidationSucceeded?.Invoke(this, new InAppPurchaseEventArgs(json));
        }

        public void OnInAppPurchaseValidationFailed(string json)
        {
            Listener?.OnInAppPurchaseValidationFailed(json);
            OnValidationFailed?.Invoke(this, new InAppPurchaseEventArgs(json));
        }
    }
}
