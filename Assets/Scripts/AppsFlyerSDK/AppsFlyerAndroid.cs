using UnityEngine;

namespace AppsFlyerSDK
{
    public class AppsFlyerAndroid
    {
        // Fields
        private static UnityEngine.AndroidJavaClass appsFlyerAndroid;
        
        // Methods
        public static void initSDK(string devkey, UnityEngine.MonoBehaviour gameObject)
        {
            var val_4;
            object val_5;
            val_4 = null;
            val_4 = null;
            object[] val_1 = new object[2];
            val_1[0] = devkey;
            val_5 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  gameObject)) != false)
            {
                    val_5 = gameObject.name;
            }
            
            val_1[1] = val_5;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "initSDK", args:  val_1);
        }
        public static void startSDK()
        {
            null = null;
            AppsFlyerSDK.AppsFlyerAndroid.startSDK(shouldCallback:  false, callBackObjectName:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void startSDK(bool shouldCallback, string callBackObjectName)
        {
            var val_3;
            int val_4;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[2];
            val_4 = val_2.Length;
            val_2[0] = shouldCallback;
            if(callBackObjectName != null)
            {
                    val_4 = val_2.Length;
            }
            
            val_2[1] = callBackObjectName;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "startTracking", args:  val_2);
        }
        public static void stopSDK(bool isSDKStopped)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = isSDKStopped;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "stopTracking", args:  val_2);
        }
        public static string getSdkVersion()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic<System.String>(methodName:  "getSdkVersion", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void updateServerUninstallToken(string token)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = token;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "updateServerUninstallToken", args:  val_1);
        }
        public static void setIsDebug(bool shouldEnable)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = shouldEnable;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setIsDebug", args:  val_2);
        }
        public static void setImeiData(string aImei)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = aImei;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setImeiData", args:  val_1);
        }
        public static void setAndroidIdData(string aAndroidId)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = aAndroidId;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setAndroidIdData", args:  val_1);
        }
        public static void setCustomerUserId(string id)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = id;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setCustomerUserId", args:  val_1);
        }
        public static void waitForCustomerUserId(bool wait)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = wait;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "waitForCustomerUserId", args:  val_2);
        }
        public static void setCustomerIdAndStartSDK(string id)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = id;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setCustomerIdAndTrack", args:  val_1);
        }
        public static string getOutOfStore()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic<System.String>(methodName:  "getOutOfStore", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void setOutOfStore(string sourceName)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = sourceName;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setOutOfStore", args:  val_1);
        }
        public static void setAppInviteOneLinkID(string oneLinkId)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = oneLinkId;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setAppInviteOneLinkID", args:  val_1);
        }
        public static void setAdditionalData(System.Collections.Generic.Dictionary<string, string> customData)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = AppsFlyerSDK.AppsFlyerAndroid.convertDictionaryToJavaMap(dictionary:  customData);
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setAdditionalData", args:  val_1);
        }
        public static void setUserEmails(string[] emails)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = emails;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setUserEmails", args:  val_1);
        }
        public static void setPhoneNumber(string phoneNumber)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = phoneNumber;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setPhoneNumber", args:  val_1);
        }
        public static void setUserEmails(AppsFlyerSDK.EmailCryptType cryptMethod, string[] emails)
        {
            var val_3;
            int val_4;
            val_3 = null;
            val_3 = null;
            object[] val_1 = new object[2];
            val_4 = val_1.Length;
            val_1[0] = AppsFlyerSDK.AppsFlyerAndroid.getEmailType(cryptType:  cryptMethod);
            if(emails != null)
            {
                    val_4 = val_1.Length;
            }
            
            val_1[1] = emails;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setUserEmails", args:  val_1);
        }
        public static void setCollectAndroidID(bool isCollect)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = isCollect;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setCollectAndroidID", args:  val_2);
        }
        public static void setCollectIMEI(bool isCollect)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = isCollect;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setCollectIMEI", args:  val_2);
        }
        public static void setResolveDeepLinkURLs(string[] urls)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = urls;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setResolveDeepLinkURLs", args:  val_1);
        }
        public static void setOneLinkCustomDomain(string[] domains)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = domains;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setOneLinkCustomDomain", args:  val_1);
        }
        public static void setIsUpdate(bool isUpdate)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = isUpdate;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setIsUpdate", args:  val_2);
        }
        public static void setCurrencyCode(string currencyCode)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = currencyCode;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setCurrencyCode", args:  val_1);
        }
        public static void recordLocation(double latitude, double longitude)
        {
            null = null;
            object[] val_1 = new object[2];
            val_1[0] = latitude;
            val_1[1] = longitude;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "trackLocation", args:  val_1);
        }
        public static void sendEvent(string eventName, System.Collections.Generic.Dictionary<string, string> eventValues)
        {
            null = null;
            AppsFlyerSDK.AppsFlyerAndroid.sendEvent(eventName:  eventName, eventValues:  eventValues, shouldCallback:  false, callBackObjectName:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void sendEvent(string eventName, System.Collections.Generic.Dictionary<string, string> eventValues, bool shouldCallback, string callBackObjectName)
        {
            var val_4;
            int val_5;
            val_4 = null;
            val_4 = null;
            object[] val_1 = new object[4];
            val_1[0] = eventName;
            val_1[1] = AppsFlyerSDK.AppsFlyerAndroid.convertDictionaryToJavaMap(dictionary:  eventValues);
            val_5 = val_1.Length;
            val_1[2] = shouldCallback;
            if(callBackObjectName != null)
            {
                    val_5 = val_1.Length;
            }
            
            val_1[3] = callBackObjectName;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "trackEvent", args:  val_1);
        }
        public static void anonymizeUser(bool isDisabled)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = isDisabled;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setDeviceTrackingDisabled", args:  val_2);
        }
        public static void enableFacebookDeferredApplinks(bool isEnabled)
        {
            var val_3;
            if(((0 & 2) != 0) && (113115136 == 0))
            {
                    val_3 = null;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = isEnabled;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "enableFacebookDeferredApplinks", args:  val_2);
        }
        public static void setConsumeAFDeepLinks(bool doConsume)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = doConsume;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setConsumeAFDeepLinks", args:  val_2);
        }
        public static void setPreinstallAttribution(string mediaSource, string campaign, string siteId)
        {
            var val_2;
            int val_3;
            val_2 = null;
            val_2 = null;
            object[] val_1 = new object[3];
            val_3 = val_1.Length;
            val_1[0] = mediaSource;
            if(campaign != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[1] = campaign;
            if(siteId != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[2] = siteId;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setPreinstallAttribution", args:  val_1);
        }
        public static bool isPreInstalledApp()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic<System.Boolean>(methodName:  "isPreInstalledApp", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static string getAttributionId()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic<System.String>(methodName:  "getAttributionId", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static string getAppsFlyerId()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic<System.String>(methodName:  "getAppsFlyerId", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void validateAndSendInAppPurchase(string publicKey, string signature, string purchaseData, string price, string currency, System.Collections.Generic.Dictionary<string, string> additionalParameters, UnityEngine.MonoBehaviour gameObject)
        {
            var val_5;
            int val_6;
            object val_7;
            val_5 = null;
            val_5 = null;
            object[] val_1 = new object[7];
            val_6 = val_1.Length;
            val_1[0] = publicKey;
            if(signature != null)
            {
                    val_6 = val_1.Length;
            }
            
            val_1[1] = signature;
            if(purchaseData != null)
            {
                    val_6 = val_1.Length;
            }
            
            val_1[2] = purchaseData;
            if(price != null)
            {
                    val_6 = val_1.Length;
            }
            
            val_1[3] = price;
            if(currency != null)
            {
                    val_6 = val_1.Length;
            }
            
            val_1[4] = currency;
            val_1[5] = AppsFlyerSDK.AppsFlyerAndroid.convertDictionaryToJavaMap(dictionary:  additionalParameters);
            val_7 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  gameObject)) != false)
            {
                    val_7 = gameObject.name;
            }
            
            val_1[6] = val_7;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "validateAndTrackInAppPurchase", args:  val_1);
        }
        public static bool isSDKStopped()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic<System.Boolean>(methodName:  "isTrackingStopped", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void setMinTimeBetweenSessions(int seconds)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = seconds;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setMinTimeBetweenSessions", args:  val_1);
        }
        public static void setHost(string hostPrefixName, string hostName)
        {
            var val_2;
            int val_3;
            val_2 = null;
            val_2 = null;
            object[] val_1 = new object[2];
            val_3 = val_1.Length;
            val_1[0] = hostPrefixName;
            if(hostName != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[1] = hostName;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setHost", args:  val_1);
        }
        public static string getHostName()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic<System.String>(methodName:  "getHostName", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static string getHostPrefix()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic<System.String>(methodName:  "getHostPrefix", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void setSharingFilterForAllPartners()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setSharingFilterForAllPartners", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void setSharingFilter(string[] partners)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = partners;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setSharingFilter", args:  val_1);
        }
        public static void getConversionData(string objectName)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = objectName;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "getConversionData", args:  val_1);
        }
        public static void initInAppPurchaseValidatorListener(UnityEngine.MonoBehaviour gameObject)
        {
            var val_4;
            object val_5;
            val_4 = null;
            val_4 = null;
            object[] val_1 = new object[1];
            val_5 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  gameObject)) != false)
            {
                    val_5 = gameObject.name;
            }
            
            val_1[0] = val_5;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "initInAppPurchaseValidatorListener", args:  val_1);
        }
        public static void setCollectOaid(bool isCollect)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = isCollect;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "setCollectOaid", args:  val_2);
        }
        public static void attributeAndOpenStore(string promoted_app_id, string campaign, System.Collections.Generic.Dictionary<string, string> userParams)
        {
            var val_3;
            int val_4;
            val_3 = null;
            val_3 = null;
            object[] val_1 = new object[3];
            val_4 = val_1.Length;
            val_1[0] = promoted_app_id;
            if(campaign != null)
            {
                    val_4 = val_1.Length;
            }
            
            val_1[1] = campaign;
            val_1[2] = AppsFlyerSDK.AppsFlyerAndroid.convertDictionaryToJavaMap(dictionary:  userParams);
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "attributeAndOpenStore", args:  val_1);
        }
        public static void recordCrossPromoteImpression(string appID, string campaign, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            var val_3;
            int val_4;
            val_3 = null;
            val_3 = null;
            object[] val_1 = new object[3];
            val_4 = val_1.Length;
            val_1[0] = appID;
            if(campaign != null)
            {
                    val_4 = val_1.Length;
            }
            
            val_1[1] = campaign;
            val_1[2] = AppsFlyerSDK.AppsFlyerAndroid.convertDictionaryToJavaMap(dictionary:  parameters);
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "recordCrossPromoteImpression", args:  val_1);
        }
        public static void generateUserInviteLink(System.Collections.Generic.Dictionary<string, string> parameters, UnityEngine.MonoBehaviour gameObject)
        {
            var val_5;
            object val_6;
            val_5 = null;
            val_5 = null;
            object[] val_1 = new object[2];
            val_1[0] = AppsFlyerSDK.AppsFlyerAndroid.convertDictionaryToJavaMap(dictionary:  parameters);
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  gameObject)) != false)
            {
                    val_6 = gameObject.name;
            }
            
            val_1[1] = val_6;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "createOneLinkInviteListener", args:  val_1);
        }
        public static void handlePushNotifications()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "handlePushNotifications", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void addPushNotificationDeepLinkPath(string[] paths)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = paths;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "addPushNotificationDeepLinkPath", args:  val_1);
        }
        public static void subscribeForDeepLink(string objectName)
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = objectName;
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid.CallStatic(methodName:  "subscribeForDeepLink", args:  val_1);
        }
        private static UnityEngine.AndroidJavaObject getEmailType(AppsFlyerSDK.EmailCryptType cryptType)
        {
            return new UnityEngine.AndroidJavaClass(className:  "com.appsflyer.AppsFlyerProperties$EmailsCryptType").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  (cryptType == 1) ? "SHA256" : "NONE");
        }
        private static UnityEngine.AndroidJavaObject convertDictionaryToJavaMap(System.Collections.Generic.Dictionary<string, string> dictionary)
        {
            object val_6;
            var val_7;
            var val_14;
            UnityEngine.jvalue val_15;
            int val_16;
            val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            UnityEngine.AndroidJavaObject val_1 = new UnityEngine.AndroidJavaObject(className:  "java.util.HashMap", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(dictionary == null)
            {
                    return val_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = dictionary.GetEnumerator();
            label_20:
            if(val_7.MoveNext() == false)
            {
                goto label_9;
            }
            
            object[] val_9 = new object[2];
            if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_6 != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_16 = val_9.Length;
            if(val_16 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_9[0] = val_6;
            if(val_6 != 0)
            {
                    val_16 = val_9.Length;
            }
            
            val_9[1] = val_6;
            UnityEngine.jvalue[] val_10 = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  val_9);
            IntPtr val_12 = UnityEngine.AndroidJNI.CallObjectMethod(obj:  val_1.GetRawObject(), methodID:  UnityEngine.AndroidJNIHelper.GetMethodID(javaClass:  val_1.GetRawClass(), methodName:  "put", signature:  "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"), args:  val_10);
            if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_10.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_15 = val_10[0];
            UnityEngine.AndroidJNI.DeleteLocalRef(obj:  val_15);
            if(val_10.Length <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            UnityEngine.AndroidJNI.DeleteLocalRef(obj:  val_10[1]);
            goto label_20;
            label_9:
            val_7.Dispose();
            return val_1;
        }
        public AppsFlyerAndroid()
        {
        
        }
        private static AppsFlyerAndroid()
        {
            AppsFlyerSDK.AppsFlyerAndroid.appsFlyerAndroid = new UnityEngine.AndroidJavaClass(className:  "com.appsflyer.unity.AppsFlyerAndroidWrapper");
        }
    
    }

}
