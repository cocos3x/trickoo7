using UnityEngine;
public class UIManager : MonoBehaviour
{
    // Fields
    private static UIManager instance;
    private UnityEngine.UI.CanvasScaler canvasScaler;
    private UnityEngine.RectTransform uiContainer;
    private int bundleVersion;
    private System.Collections.Generic.List<UnityEngine.UI.Text> versionBuildTexts;
    private string appIdDROI;
    private string appIdIOS;
    public static string shareUrl;
    private string email;
    private string emailCC;
    public UnityEngine.UI.Button takeScreenshot;
    private System.Collections.Generic.List<UnityEngine.GameObject> androidList;
    private System.Collections.Generic.List<UnityEngine.GameObject> iOSList;
    private static UIAnimation curScreen;
    private static System.Collections.Generic.List<UIAnimation> <listScreen>k__BackingField;
    private static UIAnimation curPopup;
    private static System.Collections.Generic.List<UIAnimation> <listPopup>k__BackingField;
    public static UnityEngine.Vector2 startAnchoredPosition2D;
    private UIManager.ScreenSizeChangedDelegate OnSizeChanged;
    public static bool firstPass;
    public static UIManager.UIScreenRect uiScreenRect;
    private System.Collections.Generic.List<UnityEngine.Transform> scaleRatioTransform;
    public static float screenRatio;
    public static UIManager.Orientation currentOrientation;
    private UnityEngine.Rect uiRect;
    
    // Properties
    public static UnityEngine.RectTransform UIContainer { get; set; }
    public static int BundleVersion { get; }
    public static string AppId { get; }
    public static string appVersion { get; }
    public static string appVerstionDetail { get; }
    private string urlAndroid { get; }
    private string urlIOS { get; }
    private static string screenshotFileName { get; }
    public static UIAnimation CurScreen { get; set; }
    public static System.Collections.Generic.List<UIAnimation> listScreen { get; set; }
    public static UIAnimation CurPopup { get; set; }
    public static System.Collections.Generic.List<UIAnimation> listPopup { get; set; }
    public static float scaleRatio { get; }
    
    // Methods
    public static UnityEngine.RectTransform get_UIContainer()
    {
        var val_5;
        UIManager val_6;
        var val_7;
        var val_8;
        var val_10;
        val_5 = null;
        val_5 = null;
        val_6 = UIManager.instance;
        if((UnityEngine.Object.op_Implicit(exists:  val_6)) != false)
        {
                val_7 = null;
            val_7 = null;
            val_6 = mem[UIManager.instance + 32];
            val_6 = UIManager.instance.uiContainer;
            if(val_6 == 0)
        {
                val_8 = null;
            val_8 = null;
            val_6 = UIManager.instance;
            UIManager val_3 = UnityEngine.Object.FindObjectOfType<UIManager>();
            UIManager.instance.uiContainer = val_3.GetComponent<UnityEngine.RectTransform>();
        }
        
        }
        
        val_10 = null;
        val_10 = null;
        return (UnityEngine.RectTransform)UIManager.instance.uiContainer;
    }
    public static void set_UIContainer(UnityEngine.RectTransform value)
    {
        null = null;
        UIManager.instance.uiContainer = value;
    }
    public static int get_BundleVersion()
    {
        null = null;
        return (int)UIManager.instance.bundleVersion;
    }
    public static string get_AppId()
    {
        null = null;
        return (string)UIManager.instance.appIdDROI;
    }
    public static string get_appVersion()
    {
        return UnityEngine.Application.version;
    }
    public static string get_appVerstionDetail()
    {
        int val_5;
        var val_6;
        object[] val_1 = new object[4];
        val_1[0] = "ver ";
        val_5 = val_1.Length;
        val_1[1] = UnityEngine.Application.version;
        val_6 = " build ";
        val_5 = val_1.Length;
        val_1[2] = " build ";
        val_1[3] = UIManager.BundleVersion;
        return (string)+val_1;
    }
    private string get_urlAndroid()
    {
        return "http://play.google.com/store/apps/details?id="("http://play.google.com/store/apps/details?id=") + this.appIdDROI;
    }
    private string get_urlIOS()
    {
        return "http://apps.apple.com/app/id"("http://apps.apple.com/app/id") + this.appIdIOS;
    }
    private static string get_screenshotFileName()
    {
        return UnityEngine.Application.productName.Replace(oldValue:  " ", newValue:  "_").ToLower()(UnityEngine.Application.productName.Replace(oldValue:  " ", newValue:  "_").ToLower()) + ".png";
    }
    public static UIAnimation get_CurScreen()
    {
        null = null;
        return (UIAnimation)UIManager.curScreen;
    }
    public static void set_CurScreen(UIAnimation value)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(value == UIManager.curScreen)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        UIManager.curScreen = value;
    }
    public static System.Collections.Generic.List<UIAnimation> get_listScreen()
    {
        null = null;
        return (System.Collections.Generic.List<UIAnimation>)UIManager.<listScreen>k__BackingField;
    }
    public static void set_listScreen(System.Collections.Generic.List<UIAnimation> value)
    {
        null = null;
        UIManager.<listScreen>k__BackingField = value;
    }
    public static UIAnimation get_CurPopup()
    {
        null = null;
        return (UIAnimation)UIManager.curPopup;
    }
    public static void set_CurPopup(UIAnimation value)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(value == UIManager.curPopup)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        UIManager.curPopup = value;
    }
    public static System.Collections.Generic.List<UIAnimation> get_listPopup()
    {
        null = null;
        return (System.Collections.Generic.List<UIAnimation>)UIManager.<listPopup>k__BackingField;
    }
    public static void set_listPopup(System.Collections.Generic.List<UIAnimation> value)
    {
        null = null;
        UIManager.<listPopup>k__BackingField = value;
    }
    public void add_OnSizeChanged(UIManager.ScreenSizeChangedDelegate value)
    {
        do
        {
            if((System.Delegate.Combine(a:  this.OnSizeChanged, b:  value)) != null)
        {
                if(null != null)
        {
            goto label_2;
        }
        
        }
        
        }
        while(this.OnSizeChanged != 1152921513354661920);
        
        return;
        label_2:
    }
    public void remove_OnSizeChanged(UIManager.ScreenSizeChangedDelegate value)
    {
        do
        {
            if((System.Delegate.Remove(source:  this.OnSizeChanged, value:  value)) != null)
        {
                if(null != null)
        {
            goto label_2;
        }
        
        }
        
        }
        while(this.OnSizeChanged != 1152921513354798496);
        
        return;
        label_2:
    }
    private void Awake()
    {
        null = null;
        UIManager.instance = this;
    }
    private void Start()
    {
        var val_7;
        var val_8;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_29;
        DG.Tweening.IDOTweenInit val_1 = DG.Tweening.DOTween.Init(recycleAllByDefault:  new System.Nullable<System.Boolean>() {HasValue = false}, useSafeMode:  new System.Nullable<System.Boolean>() {HasValue = false}, logBehaviour:  new System.Nullable<DG.Tweening.LogBehaviour>() {HasValue = false});
        UnityEngine.Input.multiTouchEnabled = false;
        val_24 = null;
        val_24 = null;
        UIManager.<listScreen>k__BackingField = new System.Collections.Generic.List<UIAnimation>();
        val_25 = null;
        val_25 = null;
        UIManager.<listPopup>k__BackingField = new System.Collections.Generic.List<UIAnimation>();
        this.canvasScaler = this.GetComponent<UnityEngine.UI.CanvasScaler>();
        UnityEngine.Application.targetFrameRate = 60;
        UnityEngine.Screen.sleepTimeout = 0;
        if(UnityEngine.Application.platform != 11)
        {
            goto label_11;
        }
        
        List.Enumerator<T> val_6 = this.androidList.GetEnumerator();
        label_15:
        val_26 = public System.Boolean List.Enumerator<UnityEngine.GameObject>::MoveNext();
        if(val_8.MoveNext() == false)
        {
            goto label_13;
        }
        
        val_27 = val_7;
        if(val_27 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_27.SetActive(value:  false);
        goto label_15;
        label_11:
        if(UnityEngine.Application.platform != 8)
        {
            goto label_16;
        }
        
        List.Enumerator<T> val_11 = this.iOSList.GetEnumerator();
        label_20:
        val_26 = public System.Boolean List.Enumerator<UnityEngine.GameObject>::MoveNext();
        if(val_8.MoveNext() == false)
        {
            goto label_18;
        }
        
        val_27 = val_7;
        if(val_27 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_27.SetActive(value:  false);
        goto label_20;
        label_13:
        val_8.Dispose();
        string val_13 = this.urlAndroid;
        goto label_21;
        label_18:
        val_8.Dispose();
        label_21:
        val_29 = null;
        val_29 = null;
        UIManager.shareUrl = this.urlIOS;
        label_16:
        List.Enumerator<T> val_15 = this.versionBuildTexts.GetEnumerator();
        label_32:
        if(0.MoveNext() == false)
        {
            goto label_25;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
            goto label_32;
        }
        
        val_26 = UIManager.appVerstionDetail;
        if(0 == 0)
        {
                throw new NullReferenceException();
        }
        
        goto label_32;
        label_25:
        0.Dispose();
        UnityEngine.Coroutine val_22 = this.StartCoroutine(routine:  this.StartCoroutine(routine:  this.GetScreenSize()).GetOrientation());
    }
    public static void ResetAllUIAnimaion(System.Action actionOnDone)
    {
        var val_2;
        var val_3;
        var val_7;
        var val_9;
        var val_10;
        var val_11;
        val_7 = null;
        val_7 = null;
        List.Enumerator<T> val_1 = UIManager.<listPopup>k__BackingField.GetEnumerator();
        label_9:
        val_9 = public System.Boolean List.Enumerator<UIAnimation>::MoveNext();
        if(val_3.MoveNext() == false)
        {
            goto label_7;
        }
        
        val_10 = val_2;
        if(val_10 == 0)
        {
                throw new NullReferenceException();
        }
        
        goto label_9;
        label_7:
        val_3.Dispose();
        val_11 = null;
        val_11 = null;
        List.Enumerator<T> val_5 = UIManager.<listScreen>k__BackingField.GetEnumerator();
        label_18:
        val_9 = public System.Boolean List.Enumerator<UIAnimation>::MoveNext();
        if(val_3.MoveNext() == false)
        {
            goto label_16;
        }
        
        val_10 = val_2;
        if(val_10 == 0)
        {
                throw new NullReferenceException();
        }
        
        goto label_18;
        label_16:
        val_3.Dispose();
        if(actionOnDone == null)
        {
                return;
        }
        
        actionOnDone.Invoke();
    }
    public static float get_scaleRatio()
    {
        var val_2;
        float val_3;
        float val_4;
        double val_5;
        val_2 = null;
        val_2 = null;
        val_3 = 1f;
        val_4 = UIManager.screenRatio;
        if(val_4 <= val_3)
        {
            goto label_3;
        }
        
        val_2 = null;
        val_4 = UIManager.screenRatio;
        val_5 = (double)val_4;
        if(val_5 <= 1.34)
        {
            goto label_6;
        }
        
        val_2 = null;
        val_4 = UIManager.screenRatio;
        val_5 = (double)val_4;
        if(val_5 <= 1.67)
        {
            goto label_9;
        }
        
        val_2 = null;
        val_4 = UIManager.screenRatio;
        val_5 = (double)val_4;
        if(val_5 <= 1.78)
        {
                return val_3;
        }
        
        val_2 = null;
        val_4 = UIManager.screenRatio;
        if(val_4 <= 2f)
        {
                return val_3;
        }
        
        val_4 = UIManager.screenRatio;
        var val_1 = ((double)val_4 <= 2.06) ? 0.95f : 1f;
        return val_3;
        label_3:
        val_3 = 1.22f;
        return val_3;
        label_6:
        val_3 = 1.12f;
        return val_3;
        label_9:
        val_3 = 1.02f;
        return val_3;
    }
    public static UnityEngine.Vector2 GetPosition(UnityEngine.RectTransform rectTransform, UIManager.Position position)
    {
        var val_52;
        UnityEngine.Object val_53;
        var val_54;
        float val_60;
        float val_61;
        float val_71;
        if(rectTransform == null)
        {
                throw new NullReferenceException();
        }
        
        val_52 = 0;
        UnityEngine.Transform val_1 = rectTransform.parent;
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        val_53 = val_1.GetComponent<UnityEngine.RectTransform>();
        if(val_53 == 0)
        {
                val_53 = UIManager.UIContainer;
        }
        
        val_54 = null;
        val_54 = null;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = UIManager.startAnchoredPosition2D, y = UIManager.instance.__il2cppRuntimeField_34});
        UnityEngine.Canvas val_6 = rectTransform.GetComponent<UnityEngine.Canvas>();
        if(val_6 == 0)
        {
                val_52 = 0;
            UnityEngine.Transform val_8 = rectTransform.root;
            if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
            UnityEngine.Canvas val_9 = val_8.GetComponentInChildren<UnityEngine.Canvas>();
        }
        else
        {
                if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
            val_52 = 0;
            UnityEngine.Canvas val_10 = val_6.rootCanvas;
        }
        
        if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
        val_52 = public UnityEngine.RectTransform UnityEngine.Component::GetComponent<UnityEngine.RectTransform>();
        UnityEngine.RectTransform val_11 = val_10.GetComponent<UnityEngine.RectTransform>();
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Rect val_12 = val_11.rect;
        float val_51 = val_12.m_XMin.width;
        UnityEngine.Rect val_14 = rectTransform.rect;
        UnityEngine.Vector2 val_16 = rectTransform.pivot;
        float val_54 = val_12.m_XMin.height;
        UnityEngine.Rect val_18 = rectTransform.rect;
        UnityEngine.Vector2 val_20 = rectTransform.pivot;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
        if(position <= 5)
        {
                var val_53 = 20145264 + (position) << 2;
            float val_52 = 0.5f;
            val_51 = (val_51 * val_52) + (val_14.m_XMin.width * val_16.x);
            val_52 = val_54 * val_52;
            val_53 = val_53 + 20145264;
            val_54 = val_52 + (val_18.m_XMin.height * val_20.y);
        }
        else
        {
                val_71 = val_5.y;
            val_60 = val_5.x;
            val_61 = val_5.z;
            UnityEngine.Debug.LogWarning(message:  "[UIAnimaion] This should not happen! DoMoveIn in UIAnimator went to the default setting!");
            UnityEngine.Vector2 val_46 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {});
            return new UnityEngine.Vector2() {x = val_46.x, y = val_46.y};
        }
    
    }
    private System.Collections.IEnumerator GetScreenSize()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new UIManager.<GetScreenSize>d__63(<>1__state:  0);
    }
    public static void UpdateUIScreenRect()
    {
        var val_10;
        UIManager val_11;
        val_10 = null;
        val_10 = null;
        UIManager.uiScreenRect = new UIManager.UIScreenRect();
        UIManager.instance.uiRect
        UnityEngine.Vector2 val_2 = UIManager.instance.uiRect.size;
        mem[1152921513355897120] = val_2.x;
        mem[1152921513355897124] = val_2.y;
        UIManager.instance.uiRect
        UnityEngine.Vector2 val_3 = UIManager.instance.uiRect.position;
        mem[1152921513355897128] = val_3.x;
        mem[1152921513355897132] = val_3.y;
        float val_10 = mem[1152921513355897120];
        val_10 = mem[1152921513355897124] / val_10;
        UIManager.screenRatio = val_10;
        val_11 = UIManager.instance;
        if(val_11 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        val_11 = UIManager.instance;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_18:
        if(0.MoveNext() == false)
        {
            goto label_14;
        }
        
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  UIManager.scaleRatio, y:  UIManager.scaleRatio, z:  UIManager.scaleRatio);
        if(0 == 0)
        {
                throw new NullReferenceException();
        }
        
        0.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        goto label_18;
        label_14:
        0.Dispose();
    }
    private System.Collections.IEnumerator GetOrientation()
    {
        return (System.Collections.IEnumerator)new UIManager.<GetOrientation>d__66(<>1__state:  0);
    }
    public static void CheckDeviceOrientation()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        if(UnityEngine.Screen.orientation != 3)
        {
                if(UnityEngine.Screen.orientation != 3)
        {
                if(UnityEngine.Screen.orientation != 4)
        {
            goto label_3;
        }
        
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        if(UIManager.currentOrientation == 0)
        {
                return;
        }
        
        label_23:
        val_7 = null;
        val_7 = null;
        UIManager.currentOrientation = 0;
        return;
        label_3:
        if(UnityEngine.Screen.orientation != 1)
        {
                if(UnityEngine.Screen.orientation != 2)
        {
            goto label_23;
        }
        
        }
        
        val_8 = null;
        val_8 = null;
        if(UIManager.currentOrientation == 1)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        UIManager.currentOrientation = 1;
    }
    public static void ChangeOrientation(UIManager.Orientation newOrientation)
    {
        null = null;
        UIManager.currentOrientation = newOrientation;
    }
    public static void DoStartCoroutine(System.Collections.IEnumerator ienumerator)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UIManager.instance)) == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.Coroutine val_2 = UIManager.instance.StartCoroutine(routine:  ienumerator);
    }
    public static void DoStopCoroutine(System.Collections.IEnumerator ienumerator)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UIManager.instance)) == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        UIManager.instance.StopCoroutine(routine:  ienumerator);
    }
    private void LateUpdate()
    {
        var val_9;
        var val_10;
        UnityEngine.Vector2 val_11;
        float val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        if(UIManager.uiScreenRect == null)
        {
                return;
        }
        
        UnityEngine.Vector2 val_1 = this.uiRect.size;
        if(val_1.x == 0f)
        {
                UnityEngine.Rect val_4 = UIManager.UIContainer.GetComponent<UnityEngine.RectTransform>().rect;
            this.uiRect = val_4;
            mem[1152921513356635540] = val_4.m_YMin;
            mem[1152921513356635544] = val_4.m_Width;
            mem[1152921513356635548] = val_4.m_Height;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = mem[UIManager.uiScreenRect + 16];
        val_11 = UIManager.uiScreenRect.size;
        UnityEngine.Vector2 val_5 = this.uiRect.size;
        val_12 = val_5.x;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_11, y = UIManager.uiScreenRect + 16 + 4}, rhs:  new UnityEngine.Vector2() {x = val_12, y = val_5.y})) != true)
        {
                val_13 = null;
            val_13 = null;
            val_11 = mem[UIManager.uiScreenRect + 24];
            val_11 = UIManager.uiScreenRect.position;
            UnityEngine.Vector2 val_7 = this.uiRect.position;
            val_12 = val_7.x;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_11, y = UIManager.uiScreenRect + 24 + 4}, rhs:  new UnityEngine.Vector2() {x = val_12, y = val_7.y})) == false)
        {
                return;
        }
        
        }
        
        UIManager.UpdateUIScreenRect();
        UIManager.CheckDeviceOrientation();
        if(this.OnSizeChanged == null)
        {
                return;
        }
        
        this.OnSizeChanged.Invoke();
    }
    public void OpenUrl(string url)
    {
        UnityEngine.Application.OpenURL(url:  url);
    }
    private static string escapeURL(string url)
    {
        return UnityEngine.Networking.UnityWebRequest.EscapeURL(s:  url).Replace(oldValue:  "+", newValue:  "%20");
    }
    public static void Share(string title, string shareSubject, string shareMessage, string filePath = "", string fileType = "image/png", string shareUrl = "")
    {
    
    }
    public static void CallSocialShareAdvanced(string subject, string message, string img = "", string url = "")
    {
    
    }
    public static void Feedback(string data)
    {
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        int val_22;
        int val_23;
        int val_24;
        System.String[] val_25;
        var val_26;
        int val_27;
        var val_28;
        var val_29;
        int val_30;
        string val_3 = UIManager.escapeURL(url:  "Feedback from " + UnityEngine.Application.productName);
        object[] val_4 = new object[16];
        val_18 = val_4.Length;
        val_4[0] = "Please enter your message here\n\n\n\n\n";
        if(data != null)
        {
                val_18 = val_4.Length;
        }
        
        val_4[1] = data;
        val_18 = val_4.Length;
        val_4[2] = "!!! Please DO NOT modify this: \n";
        val_19 = val_4.Length;
        val_4[3] = UIManager.appVerstionDetail;
        val_19 = val_4.Length;
        val_4[4] = "\nDevice Model: ";
        val_20 = val_4.Length;
        val_4[5] = UnityEngine.SystemInfo.deviceModel;
        val_20 = val_4.Length;
        val_4[6] = "\nSystem Memory: ";
        val_21 = val_4.Length;
        val_4[7] = UnityEngine.SystemInfo.systemMemorySize;
        val_21 = val_4.Length;
        val_4[8] = "\nGraphics Memory: ";
        val_22 = val_4.Length;
        val_4[9] = UnityEngine.SystemInfo.graphicsMemorySize;
        val_22 = val_4.Length;
        val_4[10] = "\nGraphics Name: ";
        val_23 = val_4.Length;
        val_4[11] = UnityEngine.SystemInfo.graphicsDeviceName;
        val_23 = val_4.Length;
        val_4[12] = "\nGraphics Vendor: ";
        val_24 = val_4.Length;
        val_4[13] = UnityEngine.SystemInfo.graphicsDeviceVendor;
        val_24 = val_4.Length;
        val_4[14] = "\nGraphics Version: ";
        val_4[15] = UnityEngine.SystemInfo.graphicsDeviceVersion;
        string val_13 = UIManager.escapeURL(url:  +val_4);
        if((System.String.IsNullOrEmpty(value:  UIManager.instance.emailCC)) != false)
        {
                val_25 = new string[6];
            val_25[0] = "mailto:";
            val_26 = null;
            val_26 = null;
            val_27 = val_15.Length;
            val_25[1] = UIManager.instance.email;
            val_27 = val_15.Length;
            val_25[2] = "?subject=";
            if(val_3 != null)
        {
                val_27 = val_15.Length;
        }
        
            val_25[3] = val_3;
            val_28 = "&body=";
            val_27 = val_15.Length;
            val_25[4] = "&body=";
            if(val_13 != null)
        {
                val_27 = val_15.Length;
        }
        
            val_25[5] = val_13;
        }
        else
        {
                string[] val_16 = new string[8];
            val_25 = val_16;
            val_25[0] = "mailto:";
            val_29 = null;
            val_29 = null;
            val_30 = val_16.Length;
            val_25[1] = UIManager.instance.email;
            val_30 = val_16.Length;
            val_25[2] = "?cc=";
            if(null != 0)
        {
                val_30 = val_16.Length;
        }
        
            val_25[3] = UIManager.instance.emailCC;
            val_30 = val_16.Length;
            val_25[4] = "&subject=";
            if(val_3 != null)
        {
                val_30 = val_16.Length;
        }
        
            val_25[5] = val_3;
            val_28 = "&body=";
            val_30 = val_16.Length;
            val_25[6] = "&body=";
            if(val_13 != null)
        {
                val_30 = val_16.Length;
        }
        
            val_25[7] = val_13;
        }
        
        UnityEngine.Application.OpenURL(url:  +val_16);
    }
    public static float DeviceDiagonalSizeInInches()
    {
        float val_8;
        object val_9;
        float val_2 = UnityEngine.Screen.dpi;
        float val_9 = (float)UnityEngine.Screen.height;
        float val_8 = (float)UnityEngine.Screen.width;
        val_8 = val_8 / val_2;
        val_8 = val_8 * val_8;
        val_9 = (val_9 / UnityEngine.Screen.dpi) * (val_9 / UnityEngine.Screen.dpi);
        val_8 = val_8 + val_9;
        if(val_2 >= _TYPE_MAX_)
        {
                val_8 = val_8;
        }
        
        val_9 = "Getting device inches: "("Getting device inches: ") + val_8;
        UnityEngine.Debug.Log(message:  val_9);
        if(val_8 <= 6.5f)
        {
                return val_8;
        }
        
        val_9 = "Tablets: "("Tablets: ") + val_8;
        UnityEngine.Debug.Log(message:  val_9);
        return val_8;
    }
    public UIManager()
    {
        this.bundleVersion = 1901010000;
        this.versionBuildTexts = new System.Collections.Generic.List<UnityEngine.UI.Text>();
        this.appIdDROI = "com.yogame.test";
        this.appIdIOS = "123456789";
        this.email = "";
        this.emailCC = "";
        this.androidList = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.iOSList = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }
    private static UIManager()
    {
        UIManager.shareUrl = "https://play.google.com/store/apps/";
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        UIManager.startAnchoredPosition2D = val_1.x;
        UIManager.instance.__il2cppRuntimeField_34 = val_1.y;
        UIManager.firstPass = true;
        UIManager.screenRatio = 1.78f;
        UIManager.currentOrientation = 2;
    }

}
