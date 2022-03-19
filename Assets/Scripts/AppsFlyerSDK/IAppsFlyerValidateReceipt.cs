using UnityEngine;

namespace AppsFlyerSDK
{
    public interface IAppsFlyerValidateReceipt
    {
        // Methods
        public abstract void didFinishValidateReceipt(string result); // 0
        public abstract void didFinishValidateReceiptWithError(string error); // 0
    
    }

}
