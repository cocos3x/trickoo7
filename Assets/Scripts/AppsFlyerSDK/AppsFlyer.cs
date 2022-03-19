using UnityEngine;

namespace AppsFlyerSDK
{
    public class AppsFlyer : MonoBehaviour
    {
        // Fields
        public static readonly string kAppsFlyerPluginVersion;
        public static string CallBackObjectName;
        private static System.EventHandler onRequestResponse;
        private static System.EventHandler onInAppResponse;
        private static System.EventHandler onDeepLinkReceived;
        
        // Methods
        public static void initSDK(string devKey, string appID)
        {
            AppsFlyerSDK.AppsFlyer.initSDK(devKey:  devKey, appID:  appID, gameObject:  0);
        }
        public static void initSDK(string devKey, string appID, UnityEngine.MonoBehaviour gameObject)
        {
            string val_3;
            var val_4;
            if(gameObject != 0)
            {
                    val_3 = gameObject.name;
                val_4 = null;
                val_4 = null;
                AppsFlyerSDK.AppsFlyer.CallBackObjectName = val_3;
            }
            
            AppsFlyerSDK.AppsFlyerAndroid.initSDK(devkey:  devKey, gameObject:  gameObject);
        }
        public static void startSDK()
        {
            null = null;
            AppsFlyerSDK.AppsFlyerAndroid.startSDK(shouldCallback:  (AppsFlyerSDK.AppsFlyer.onRequestResponse != 0) ? 1 : 0, callBackObjectName:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void sendEvent(string eventName, System.Collections.Generic.Dictionary<string, string> eventValues)
        {
            null = null;
            AppsFlyerSDK.AppsFlyerAndroid.sendEvent(eventName:  eventName, eventValues:  eventValues, shouldCallback:  (AppsFlyerSDK.AppsFlyer.onInAppResponse != 0) ? 1 : 0, callBackObjectName:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void stopSDK(bool isSDKStopped)
        {
            AppsFlyerSDK.AppsFlyerAndroid.stopSDK(isSDKStopped:  isSDKStopped);
        }
        public static bool isSDKStopped()
        {
            return AppsFlyerSDK.AppsFlyerAndroid.isSDKStopped();
        }
        public static string getSdkVersion()
        {
            return AppsFlyerSDK.AppsFlyerAndroid.getSdkVersion();
        }
        public static void setIsDebug(bool shouldEnable)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setIsDebug(shouldEnable:  shouldEnable);
        }
        public static void setCustomerUserId(string id)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setCustomerUserId(id:  id);
        }
        public static void setAppInviteOneLinkID(string oneLinkId)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setAppInviteOneLinkID(oneLinkId:  oneLinkId);
        }
        public static void setAdditionalData(System.Collections.Generic.Dictionary<string, string> customData)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setAdditionalData(customData:  customData);
        }
        public static void setResolveDeepLinkURLs(string[] urls)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setResolveDeepLinkURLs(urls:  urls);
        }
        public static void setOneLinkCustomDomain(string[] domains)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setOneLinkCustomDomain(domains:  domains);
        }
        public static void setCurrencyCode(string currencyCode)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setCurrencyCode(currencyCode:  currencyCode);
        }
        public static void recordLocation(double latitude, double longitude)
        {
            AppsFlyerSDK.AppsFlyerAndroid.recordLocation(latitude:  latitude, longitude:  longitude);
        }
        public static void anonymizeUser(bool shouldAnonymizeUser)
        {
            AppsFlyerSDK.AppsFlyerAndroid.anonymizeUser(isDisabled:  shouldAnonymizeUser);
        }
        public static string getAppsFlyerId()
        {
            return AppsFlyerSDK.AppsFlyerAndroid.getAppsFlyerId();
        }
        public static void setMinTimeBetweenSessions(int seconds)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setMinTimeBetweenSessions(seconds:  seconds);
        }
        public static void setHost(string hostPrefixName, string hostName)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setHost(hostPrefixName:  hostPrefixName, hostName:  hostName);
        }
        public static void setUserEmails(AppsFlyerSDK.EmailCryptType cryptMethod, string[] emails)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setUserEmails(cryptMethod:  cryptMethod, emails:  emails);
        }
        public static void setPhoneNumber(string phoneNumber)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setPhoneNumber(phoneNumber:  phoneNumber);
        }
        public static void setSharingFilterForAllPartners()
        {
            AppsFlyerSDK.AppsFlyerAndroid.setSharingFilterForAllPartners();
        }
        public static void setSharingFilter(string[] partners)
        {
            AppsFlyerSDK.AppsFlyerAndroid.setSharingFilter(partners:  partners);
        }
        public static void getConversionData(string objectName)
        {
            AppsFlyerSDK.AppsFlyerAndroid.getConversionData(objectName:  objectName);
        }
        public static void attributeAndOpenStore(string appID, string campaign, System.Collections.Generic.Dictionary<string, string> userParams, UnityEngine.MonoBehaviour gameObject)
        {
            AppsFlyerSDK.AppsFlyerAndroid.attributeAndOpenStore(promoted_app_id:  appID, campaign:  campaign, userParams:  userParams);
        }
        public static void recordCrossPromoteImpression(string appID, string campaign, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            AppsFlyerSDK.AppsFlyerAndroid.recordCrossPromoteImpression(appID:  appID, campaign:  campaign, parameters:  parameters);
        }
        public static void generateUserInviteLink(System.Collections.Generic.Dictionary<string, string> parameters, UnityEngine.MonoBehaviour gameObject)
        {
            AppsFlyerSDK.AppsFlyerAndroid.generateUserInviteLink(parameters:  parameters, gameObject:  gameObject);
        }
        public static void addPushNotificationDeepLinkPath(string[] paths)
        {
            AppsFlyerSDK.AppsFlyerAndroid.addPushNotificationDeepLinkPath(paths:  paths);
        }
        public static void subscribeForDeepLink()
        {
            null = null;
            AppsFlyerSDK.AppsFlyerAndroid.subscribeForDeepLink(objectName:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void add_OnRequestResponse(System.EventHandler value)
        {
            null = null;
            System.Delegate val_1 = System.Delegate.Combine(a:  AppsFlyerSDK.AppsFlyer.onRequestResponse, b:  value);
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            AppsFlyerSDK.AppsFlyer.onRequestResponse = val_1;
            return;
            label_4:
        }
        public static void remove_OnRequestResponse(System.EventHandler value)
        {
            null = null;
            System.Delegate val_1 = System.Delegate.Remove(source:  AppsFlyerSDK.AppsFlyer.onRequestResponse, value:  value);
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            AppsFlyerSDK.AppsFlyer.onRequestResponse = val_1;
            return;
            label_4:
        }
        public static void add_OnInAppResponse(System.EventHandler value)
        {
            null = null;
            System.Delegate val_1 = System.Delegate.Combine(a:  AppsFlyerSDK.AppsFlyer.onInAppResponse, b:  value);
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            AppsFlyerSDK.AppsFlyer.onInAppResponse = val_1;
            return;
            label_4:
        }
        public static void remove_OnInAppResponse(System.EventHandler value)
        {
            null = null;
            System.Delegate val_1 = System.Delegate.Remove(source:  AppsFlyerSDK.AppsFlyer.onInAppResponse, value:  value);
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            AppsFlyerSDK.AppsFlyer.onInAppResponse = val_1;
            return;
            label_4:
        }
        public static void add_OnDeepLinkReceived(System.EventHandler value)
        {
            null = null;
            System.Delegate val_1 = System.Delegate.Combine(a:  AppsFlyerSDK.AppsFlyer.onDeepLinkReceived, b:  value);
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            AppsFlyerSDK.AppsFlyer.onDeepLinkReceived = val_1;
            AppsFlyerSDK.AppsFlyer.subscribeForDeepLink();
            return;
            label_4:
        }
        public static void remove_OnDeepLinkReceived(System.EventHandler value)
        {
            null = null;
            System.Delegate val_1 = System.Delegate.Remove(source:  AppsFlyerSDK.AppsFlyer.onDeepLinkReceived, value:  value);
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            AppsFlyerSDK.AppsFlyer.onDeepLinkReceived = val_1;
            return;
            label_4:
        }
        public void inAppResponseReceived(string response)
        {
            null = null;
            if(AppsFlyerSDK.AppsFlyer.onInAppResponse == null)
            {
                    return;
            }
            
            AppsFlyerSDK.AppsFlyer.onInAppResponse.Invoke(sender:  0, e:  AppsFlyerSDK.AppsFlyer.parseRequestCallback(response:  response));
        }
        public void requestResponseReceived(string response)
        {
            null = null;
            if(AppsFlyerSDK.AppsFlyer.onRequestResponse == null)
            {
                    return;
            }
            
            AppsFlyerSDK.AppsFlyer.onRequestResponse.Invoke(sender:  0, e:  AppsFlyerSDK.AppsFlyer.parseRequestCallback(response:  response));
        }
        public void onDeepLinking(string response)
        {
            var val_2;
            System.EventHandler val_3;
            val_2 = null;
            val_2 = null;
            val_3 = AppsFlyerSDK.AppsFlyer.onDeepLinkReceived;
            if(val_3 == null)
            {
                    return;
            }
            
            val_3 = AppsFlyerSDK.AppsFlyer.onDeepLinkReceived;
            val_3.Invoke(sender:  0, e:  new AppsFlyerSDK.DeepLinkEventsArgs(str:  response));
        }
        private static AppsFlyerSDK.AppsFlyerRequestEventArgs parseRequestCallback(string response)
        {
            string val_7;
            var val_8;
            var val_9;
            val_7 = response;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(str:  val_7);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_1.ContainsKey(key:  "errorDescription")) == false)
            {
                goto label_4;
            }
            
            val_7 = val_1.Item["errorDescription"];
            if(val_7 != null)
            {
                goto label_5;
            }
            
            goto label_7;
            label_4:
            val_7 = "";
            label_5:
            val_8 = null;
            if(val_7 != val_8)
            {
                goto label_15;
            }
            
            label_7:
            object val_4 = val_1.Item["statusCode"];
            val_8 = null;
            return (AppsFlyerSDK.AppsFlyerRequestEventArgs)new AppsFlyerSDK.AppsFlyerRequestEventArgs(code:  18903040, description:  val_7);
            label_15:
            val_9 = val_7;
            if(W1 == 1)
            {
                    if((null & 1) != 0)
            {
                    AppsFlyerSDK.AppsFlyer.AFLog(methodName:  "parseRequestCallback", str:  System.String.Format(format:  "{0} Exception caught.", arg0:  1152921504621490176));
                return (AppsFlyerSDK.AppsFlyerRequestEventArgs)new AppsFlyerSDK.AppsFlyerRequestEventArgs(code:  18903040, description:  val_7);
            }
            
                mem[8] = null;
                val_9 = 8;
            }
        
        }
        public static System.Collections.Generic.Dictionary<string, object> CallbackStringToDictionary(string str)
        {
            var val_3;
            if(str != null)
            {
                    if((Json.Parser.Parse(jsonString:  str)) == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>);
            }
            
            }
            
            val_3 = 0;
            return (System.Collections.Generic.Dictionary<System.String, System.Object>);
        }
        public static void AFLog(string methodName, string str)
        {
            null = null;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "AppsFlyer_Unity_v{0} {1} called with {2}", arg0:  AppsFlyerSDK.AppsFlyer.kAppsFlyerPluginVersion, arg1:  methodName, arg2:  str));
        }
        public AppsFlyer()
        {
        
        }
        private static AppsFlyer()
        {
            AppsFlyerSDK.AppsFlyer.kAppsFlyerPluginVersion = "6.2.41";
            AppsFlyerSDK.AppsFlyer.CallBackObjectName = 0;
        }
    
    }

}
