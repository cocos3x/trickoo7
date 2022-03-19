using UnityEngine;

namespace AppsFlyerSDK
{
    public class AppsFlyerRequestEventArgs : EventArgs
    {
        // Fields
        private readonly int <statusCode>k__BackingField;
        private readonly string <errorDescription>k__BackingField;
        
        // Properties
        public int statusCode { get; }
        public string errorDescription { get; }
        
        // Methods
        public AppsFlyerRequestEventArgs(int code, string description)
        {
            this.<statusCode>k__BackingField = code;
            this.<errorDescription>k__BackingField = description;
        }
        public int get_statusCode()
        {
            return (int)this.<statusCode>k__BackingField;
        }
        public string get_errorDescription()
        {
            return (string)this.<errorDescription>k__BackingField;
        }
    
    }

}
