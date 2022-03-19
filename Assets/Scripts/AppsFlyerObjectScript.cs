using UnityEngine;
public class AppsFlyerObjectScript : MonoBehaviour, IAppsFlyerConversionData
{
    // Fields
    public string devKey;
    public string appID;
    public bool isDebug;
    public bool getConversionData;
    
    // Methods
    private void Start()
    {
        AppsFlyerSDK.AppsFlyer.setIsDebug(shouldEnable:  (this.isDebug == true) ? 1 : 0);
        AppsFlyerSDK.AppsFlyer.initSDK(devKey:  this.devKey, appID:  null, gameObject:  (this.getConversionData == false) ? 0 : (this));
        AppsFlyerSDK.AppsFlyer.startSDK();
    }
    private void Update()
    {
    
    }
    public void onConversionDataSuccess(string conversionData)
    {
        AppsFlyerSDK.AppsFlyer.AFLog(methodName:  "didReceiveConversionData", str:  conversionData);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(str:  conversionData);
    }
    public void onConversionDataFail(string error)
    {
        AppsFlyerSDK.AppsFlyer.AFLog(methodName:  "didReceiveConversionDataWithError", str:  error);
    }
    public void onAppOpenAttribution(string attributionData)
    {
        AppsFlyerSDK.AppsFlyer.AFLog(methodName:  "onAppOpenAttribution", str:  attributionData);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(str:  attributionData);
    }
    public void onAppOpenAttributionFailure(string error)
    {
        AppsFlyerSDK.AppsFlyer.AFLog(methodName:  "onAppOpenAttributionFailure", str:  error);
    }
    public AppsFlyerObjectScript()
    {
    
    }

}
