using UnityEngine;

namespace Assets.SimpleLocalization
{
    public class Downloader : MonoBehaviour
    {
        // Fields
        private static System.Action OnNetworkReady;
        private static Assets.SimpleLocalization.Downloader _instance;
        
        // Properties
        public static Assets.SimpleLocalization.Downloader Instance { get; }
        
        // Methods
        public static void add_OnNetworkReady(System.Action value)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((System.Delegate.Combine(a:  Assets.SimpleLocalization.Downloader.OnNetworkReady, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            return;
            label_4:
        }
        public static void remove_OnNetworkReady(System.Action value)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((System.Delegate.Remove(source:  Assets.SimpleLocalization.Downloader.OnNetworkReady, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            return;
            label_4:
        }
        public static Assets.SimpleLocalization.Downloader get_Instance()
        {
            var val_3;
            Assets.SimpleLocalization.Downloader val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = Assets.SimpleLocalization.Downloader._instance;
            if(val_4 != null)
            {
                    return val_4;
            }
            
            val_5 = null;
            val_4 = new UnityEngine.GameObject(name:  "Downloader").AddComponent<Assets.SimpleLocalization.Downloader>();
            val_5 = null;
            Assets.SimpleLocalization.Downloader._instance = val_4;
            return val_4;
        }
        public void OnDestroy()
        {
            null = null;
            Assets.SimpleLocalization.Downloader._instance = 0;
        }
        public static void Download(string url, System.Action<UnityEngine.WWW> callback)
        {
            object[] val_1 = new object[1];
            val_1[0] = url;
            UnityEngine.Debug.LogFormat(format:  "downloading {0}", args:  val_1);
            UnityEngine.Coroutine val_4 = Assets.SimpleLocalization.Downloader.Instance.StartCoroutine(routine:  Assets.SimpleLocalization.Downloader.Coroutine(url:  url, callback:  callback));
        }
        private static System.Collections.IEnumerator Coroutine(string url, System.Action<UnityEngine.WWW> callback)
        {
            .<>1__state = 0;
            .url = url;
            .callback = callback;
            return (System.Collections.IEnumerator)new Downloader.<Coroutine>d__8();
        }
        private static string CleaunupText(string text)
        {
            return text.Replace(oldValue:  "\n", newValue:  " ").Replace(oldValue:  "\t", newValue:  0);
        }
        public Downloader()
        {
        
        }
        private static Downloader()
        {
            null = null;
            Assets.SimpleLocalization.Downloader.OnNetworkReady = new System.Action(object:  Downloader.<>c.<>9, method:  System.Void Downloader.<>c::<.cctor>b__11_0());
        }
    
    }

}
