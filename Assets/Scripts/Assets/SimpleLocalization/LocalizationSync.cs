using UnityEngine;

namespace Assets.SimpleLocalization
{
    public class LocalizationSync : MonoBehaviour
    {
        // Fields
        public string TableId;
        public Assets.SimpleLocalization.Sheet[] Sheets;
        public UnityEngine.Object SaveFolder;
        private const string UrlPattern = "https://docs.google.com/spreadsheets/d/{0}/export?format=csv&gid={1}";
        
        // Methods
        public LocalizationSync()
        {
        
        }
    
    }

}
