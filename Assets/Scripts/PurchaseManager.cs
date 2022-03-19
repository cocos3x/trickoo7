using UnityEngine;
public class PurchaseManager : MonoBehaviour, IStoreListener
{
    // Fields
    private static PurchaseManager <Instance>k__BackingField;
    private static UnityEngine.Purchasing.IStoreController m_StoreController;
    private static UnityEngine.Purchasing.IExtensionProvider m_StoreExtensionProvider;
    private string idRemoveAds;
    private System.Action callBackPurchaseFail;
    private System.Action callBackPurchaseSuccess;
    
    // Properties
    public static PurchaseManager Instance { get; set; }
    
    // Methods
    public static PurchaseManager get_Instance()
    {
        return (PurchaseManager)PurchaseManager.<Instance>k__BackingField;
    }
    public static void set_Instance(PurchaseManager value)
    {
        PurchaseManager.<Instance>k__BackingField = value;
    }
    private void Awake()
    {
        PurchaseManager.<Instance>k__BackingField = this;
    }
    private void Start()
    {
        if(PurchaseManager.m_StoreController != null)
        {
                return;
        }
        
        this.InitializePurchasing();
    }
    public void InitializePurchasing()
    {
        var val_8;
        if(this.IsInitialized() != false)
        {
                return;
        }
        
        val_8 = mem[public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 302];
        val_8 = public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 302;
        val_8 = mem[public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 302];
        val_8 = public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 302;
        UnityEngine.Purchasing.ConfigurationBuilder val_3 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  UnityEngine.Purchasing.StandardPurchasingModule.Instance(), rest:  public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 184);
        UnityEngine.Purchasing.IDs val_4 = new UnityEngine.Purchasing.IDs();
        string[] val_5 = new string[1];
        val_5[0] = "AppleAppStore";
        val_4.Add(id:  this.idRemoveAds, stores:  val_5);
        string[] val_6 = new string[1];
        val_6[0] = "GooglePlay";
        val_4.Add(id:  this.idRemoveAds, stores:  val_6);
        UnityEngine.Purchasing.ConfigurationBuilder val_7 = val_3.AddProduct(id:  this.idRemoveAds, type:  1, storeIDs:  val_4);
        UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  this, builder:  val_3);
    }
    private bool IsInitialized()
    {
        var val_2;
        if(PurchaseManager.m_StoreController != null)
        {
                var val_1 = (PurchaseManager.m_StoreExtensionProvider != 0) ? 1 : 0;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
    {
        UnityEngine.Debug.Log(message:  "OnInitializeFailed InitializationFailureReason:"("OnInitializeFailed InitializationFailureReason:") + error);
    }
    public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs args)
    {
        if((System.String.Equals(a:  args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField, b:  this.idRemoveAds, comparisonType:  4)) == false)
        {
            goto label_4;
        }
        
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "ProcessPurchase: PASS. Product: \'{0}\'", arg0:  args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField));
        if(this.callBackPurchaseSuccess != null)
        {
            goto label_9;
        }
        
        throw new NullReferenceException();
        label_4:
        label_9:
        this.callBackPurchaseFail.Invoke();
        return 0;
    }
    public void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.PurchaseFailureReason p)
    {
        UnityEngine.Debug.Log(message:  "OnInitializeFailed InitializationFailureReason:"("OnInitializeFailed InitializationFailureReason:") + p);
    }
    public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
    {
        UnityEngine.Debug.Log(message:  "OnInitialized: PASS");
        PurchaseManager.m_StoreController = controller;
        PurchaseManager.m_StoreExtensionProvider = extensions;
    }
    public void BuyNonConsumable(System.Action callBackSuccess, System.Action callBackFail)
    {
        this.callBackPurchaseFail = callBackFail;
        this.callBackPurchaseSuccess = callBackSuccess;
        this.BuyProductID(productId:  this.idRemoveAds);
    }
    public void BuyProductID(string productId)
    {
        string val_6;
        object val_8;
        var val_9;
        val_6 = productId;
        if(this.IsInitialized() == false)
        {
            goto label_1;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        goto label_6;
        label_1:
        val_8 = "BuyProductID FAIL. Not initialized.";
        goto label_9;
        label_6:
        UnityEngine.Purchasing.Product val_4 = PurchaseManager.m_StoreController.products.WithID(id:  val_6);
        if(val_4 == null)
        {
            goto label_12;
        }
        
        val_6 = val_4;
        if((val_4.<availableToPurchase>k__BackingField) == false)
        {
            goto label_12;
        }
        
        val_9 = 0;
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Purchasing product asychronously: \'{0}\'", arg0:  val_4.<definition>k__BackingField.<id>k__BackingField));
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = 1;
        goto label_20;
        label_12:
        val_8 = "BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase";
        label_9:
        UnityEngine.Debug.Log(message:  val_8);
        return;
        label_20:
        PurchaseManager.m_StoreController.InitiatePurchase(product:  val_6);
    }
    public void RestorePurchases()
    {
        IntPtr val_9;
        var val_11;
        System.Action<System.Boolean> val_13;
        if(this.IsInitialized() == false)
        {
            goto label_1;
        }
        
        if(UnityEngine.Application.platform != 8)
        {
                if(UnityEngine.Application.platform != 1)
        {
            goto label_3;
        }
        
        }
        
        UnityEngine.Debug.Log(message:  "RestorePurchases started ...");
        var val_9 = 0;
        val_9 = val_9 + 1;
        goto label_10;
        label_1:
        UnityEngine.Debug.Log(message:  "RestorePurchases FAIL. Not initialized.");
        return;
        label_3:
        UnityEngine.Debug.Log(message:  "RestorePurchases FAIL. Not supported on this platform. Current = "("RestorePurchases FAIL. Not supported on this platform. Current = ") + UnityEngine.Application.platform);
        return;
        label_10:
        val_11 = null;
        val_11 = null;
        val_13 = PurchaseManager.<>c.<>9__19_0;
        if(val_13 == null)
        {
                System.Action<System.Boolean> val_7 = null;
            val_13 = val_7;
            val_9 = System.Void PurchaseManager.<>c::<RestorePurchases>b__19_0(bool result);
            val_7 = new System.Action<System.Boolean>(object:  PurchaseManager.<>c.__il2cppRuntimeField_static_fields, method:  val_9);
            PurchaseManager.<>c.<>9__19_0 = val_13;
        }
        
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_9 = 0;
        PurchaseManager.m_StoreExtensionProvider.RestoreTransactions(callback:  val_7);
    }
    public PurchaseManager()
    {
        this.idRemoveAds = "drawIt_RemoveAds";
    }

}
