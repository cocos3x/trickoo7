using UnityEngine;
public class AppsflyerHelper : MonoBehaviour
{
    // Fields
    private static AppsflyerHelper instance;
    private static string TAG;
    private static System.Collections.Generic.Dictionary<AppsflyerHelper.eventId, int> eventDic;
    
    // Methods
    private void Awake()
    {
        AppsflyerHelper.TAG = "[" + this.name + "] ";
        AppsflyerHelper.instance = this;
    }
    private void Start()
    {
        AppsFlyerSDK.AppsFlyer.setIsDebug(shouldEnable:  false);
    }
    public static void Log(AppsflyerHelper.eventId id)
    {
        eventId val_11;
        var val_12;
        int val_13;
        int val_14;
        val_11 = id;
        if(AppsflyerHelper.instance == 0)
        {
                if(AppsflyerHelper.eventDic == null)
        {
                return;
        }
        
        }
        
        int val_2 = AppsflyerHelper.SetEvent(id:  val_11, autoSave:  true);
        if(id == 0)
        {
                throw new NullReferenceException();
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_4 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(id == 0)
        {
                throw new NullReferenceException();
        }
        
        if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
        val_4.Add(key:  id.ToString(), value:  val_2.ToString());
        AppsFlyerSDK.AppsFlyer.sendEvent(eventName:  id.ToString(), eventValues:  val_4);
        object[] val_7 = new object[5];
        if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
        if(AppsflyerHelper.TAG != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        val_13 = val_7.Length;
        if(val_13 == 0)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_7[0] = AppsflyerHelper.TAG;
        val_12 = "Log ";
        if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        val_13 = val_7.Length;
        if(val_13 <= 1)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_7[1] = "Log ";
        if(id == 0)
        {
                throw new NullReferenceException();
        }
        
        string val_8 = id.ToString();
        if(val_8 != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        val_14 = val_7.Length;
        if(val_14 <= 2)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_7[2] = val_8;
        val_12 = " ";
        if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        val_14 = val_7.Length;
        if(val_14 <= 3)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_7[3] = " ";
        val_7[4] = val_2;
        val_11 = +val_7;
        UnityEngine.Debug.Log(message:  val_11);
    }
    private static void LoadEvent()
    {
        var val_10;
        var val_13;
        var val_14;
        System.Collections.Generic.Dictionary<eventId, System.Int32> val_1 = new System.Collections.Generic.Dictionary<eventId, System.Int32>();
        AppsflyerHelper.eventDic = val_1;
        System.Array val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if(val_3 == null)
        {
                throw new NullReferenceException();
        }
        
        val_10 = val_3.GetEnumerator();
        label_20:
        var val_11 = 0;
        val_11 = val_11 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_10.Current == null)
        {
                throw new NullReferenceException();
        }
        
        val_13 = null;
        if(null == 0)
        {
                throw new NullReferenceException();
        }
        
        if(AppsflyerHelper.eventDic == null)
        {
                throw new NullReferenceException();
        }
        
        val_1.Add(key:  null, value:  UnityEngine.PlayerPrefs.GetInt(key:  null.ToString(), defaultValue:  0));
        goto label_20;
        label_11:
        val_13 = 0;
        if(X0 == false)
        {
            goto label_21;
        }
        
        var val_15 = X0;
        val_10 = X0;
        if((X0 + 294) == 0)
        {
            goto label_25;
        }
        
        var val_13 = X0 + 176;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_24:
        if(((X0 + 176 + 8) + -8) == null)
        {
            goto label_23;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (X0 + 294))
        {
            goto label_24;
        }
        
        goto label_25;
        label_23:
        val_15 = val_15 + (((X0 + 176 + 8)) << 4);
        val_14 = val_15 + 304;
        label_25:
        val_10.Dispose();
        label_21:
        if(val_13 != 0)
        {
                throw X20;
        }
    
    }
    public static void SaveEvent()
    {
        if(AppsflyerHelper.eventDic == null)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_1 = AppsflyerHelper.eventDic.GetEnumerator();
        label_4:
        if(0.MoveNext() == false)
        {
            goto label_2;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  0.ToString(), value:  0);
        goto label_4;
        label_2:
        0.Dispose();
        UnityEngine.PlayerPrefs.Save();
    }
    private static int SetEvent(AppsflyerHelper.eventId id, bool autoSave = True)
    {
        System.Collections.Generic.Dictionary<eventId, System.Int32> val_6;
        var val_7;
        int val_8;
        val_7 = autoSave;
        if(AppsflyerHelper.eventDic != null)
        {
                if((AppsflyerHelper.eventDic.ContainsKey(key:  id)) != false)
        {
                val_6 = AppsflyerHelper.eventDic;
            val_6.set_Item(key:  id, value:  val_6.Item[id] + 1);
            val_8 = AppsflyerHelper.eventDic.Item[id];
            if(val_7 == false)
        {
                return (int)val_8;
        }
        
            val_7 = id;
            val_6 = id.ToString();
            UnityEngine.PlayerPrefs.SetInt(key:  val_6, value:  val_8);
            UnityEngine.PlayerPrefs.Save();
            return (int)val_8;
        }
        
        }
        
        val_8 = 0;
        return (int)val_8;
    }
    public AppsflyerHelper()
    {
    
    }

}
