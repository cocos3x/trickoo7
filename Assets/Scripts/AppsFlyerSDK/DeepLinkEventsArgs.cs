using UnityEngine;

namespace AppsFlyerSDK
{
    public class DeepLinkEventsArgs : EventArgs
    {
        // Fields
        public System.Collections.Generic.Dictionary<string, object> deepLink;
        private readonly AppsFlyerSDK.DeepLinkStatus <status>k__BackingField;
        private readonly AppsFlyerSDK.DeepLinkError <error>k__BackingField;
        
        // Properties
        public AppsFlyerSDK.DeepLinkStatus status { get; }
        public AppsFlyerSDK.DeepLinkError error { get; }
        
        // Methods
        public AppsFlyerSDK.DeepLinkStatus get_status()
        {
            return (AppsFlyerSDK.DeepLinkStatus)this.<status>k__BackingField;
        }
        public AppsFlyerSDK.DeepLinkError get_error()
        {
            return (AppsFlyerSDK.DeepLinkError)this.<error>k__BackingField;
        }
        public string getMatchType()
        {
            return this.getDeepLinkParameter(name:  "match_type");
        }
        public string getDeepLinkValue()
        {
            return this.getDeepLinkParameter(name:  "deep_link_value");
        }
        public string getClickHttpReferrer()
        {
            return this.getDeepLinkParameter(name:  "click_http_referrer");
        }
        public string getMediaSource()
        {
            return this.getDeepLinkParameter(name:  "media_source");
        }
        public string getCampaign()
        {
            return this.getDeepLinkParameter(name:  "campaign");
        }
        public string getCampaignId()
        {
            return this.getDeepLinkParameter(name:  "campaign_id");
        }
        public string getAfSub1()
        {
            return this.getDeepLinkParameter(name:  "af_sub1");
        }
        public string getAfSub2()
        {
            return this.getDeepLinkParameter(name:  "af_sub2");
        }
        public string getAfSub3()
        {
            return this.getDeepLinkParameter(name:  "af_sub3");
        }
        public string getAfSub4()
        {
            return this.getDeepLinkParameter(name:  "af_sub4");
        }
        public string getAfSub5()
        {
            return this.getDeepLinkParameter(name:  "af_sub5");
        }
        public bool isDeferred()
        {
            string val_5;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6;
            string val_7;
            val_5 = this;
            val_6 = this.deepLink;
            if(val_6 == null)
            {
                    return (bool)val_6;
            }
            
            val_7 = "is_deferred";
            if((val_6.ContainsKey(key:  val_7)) != false)
            {
                    if(this.deepLink == null)
            {
                    throw new NullReferenceException();
            }
            
                object val_2 = this.deepLink.Item["is_deferred"];
                val_7 = null;
                var val_3 = (null != 0) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public System.Collections.Generic.Dictionary<string, object> getDeepLinkDictionary()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.deepLink;
        }
        public DeepLinkEventsArgs(string str)
        {
            string val_18;
            string val_19;
            var val_21;
            string val_22;
            AppsFlyerSDK.DeepLinkStatus val_23;
            AppsFlyerSDK.DeepLinkError val_24;
            val_19 = 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(str:  str);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_21 = "status";
            val_22 = "";
            val_18 = val_22;
            if((val_1.ContainsKey(key:  "status")) != false)
            {
                    val_18 = val_22;
                if(val_1.Item["status"] != null)
            {
                    val_19 = "status";
                object val_4 = val_1.Item[val_19];
                if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_18 = val_4;
            }
            
            }
            
            val_21 = "error";
            if((val_1.ContainsKey(key:  "error")) != false)
            {
                    if(val_1.Item["error"] != null)
            {
                    val_19 = "error";
                object val_7 = val_1.Item[val_19];
                if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_22 = val_7;
            }
            
            }
            
            if((val_1.ContainsKey(key:  "deepLink")) != false)
            {
                    if(val_1.Item["deepLink"] != null)
            {
                    this.deepLink = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(str:  val_1.Item["deepLink"]);
            }
            
            }
            
            if((System.String.op_Equality(a:  val_18, b:  "FOUND")) != false)
            {
                    this.<status>k__BackingField = 0;
            }
            else
            {
                    if((System.String.op_Equality(a:  val_18, b:  "NOT_FOUND")) != false)
            {
                    val_23 = 1;
            }
            else
            {
                    val_23 = 2;
            }
            
                this.<status>k__BackingField = val_23;
            }
            
            if((System.String.op_Equality(a:  val_22, b:  "TIMEOUT")) != false)
            {
                    this.<error>k__BackingField = 0;
                return;
            }
            
            if((System.String.op_Equality(a:  val_22, b:  "NETWORK")) != false)
            {
                    val_24 = 1;
            }
            else
            {
                    if((System.String.op_Equality(a:  val_22, b:  "HTTP_STATUS_CODE")) != false)
            {
                    val_24 = 2;
            }
            else
            {
                    val_24 = 3;
            }
            
            }
            
            this.<error>k__BackingField = val_24;
        }
        private string getDeepLinkParameter(string name)
        {
            string val_9 = name;
            if(this.deepLink == null)
            {
                    return 0;
            }
            
            if((this.deepLink.ContainsKey(key:  val_9 = name)) == false)
            {
                    return 0;
            }
            
            if(this.deepLink.Item[val_9] == null)
            {
                    return 0;
            }
            
            object val_3 = this.deepLink.Item[val_9];
            val_9 = ???;
            goto typeof(System.Object).__il2cppRuntimeField_160;
        }
    
    }

}
