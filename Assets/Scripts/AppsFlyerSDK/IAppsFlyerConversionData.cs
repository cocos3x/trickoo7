using UnityEngine;

namespace AppsFlyerSDK
{
    public interface IAppsFlyerConversionData
    {
        // Methods
        public abstract void onConversionDataSuccess(string conversionData); // 0
        public abstract void onConversionDataFail(string error); // 0
        public abstract void onAppOpenAttribution(string attributionData); // 0
        public abstract void onAppOpenAttributionFailure(string error); // 0
    
    }

}
