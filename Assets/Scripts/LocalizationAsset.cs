using UnityEngine;
public class LocalizationAsset : ScriptableObject
{
    // Fields
    public string associatedSheetId;
    public string associatedWorksheet;
    public System.Collections.Generic.List<GGLocalizationData> localization;
    
    // Methods
    public void ResetData()
    {
        bool val_2 = true;
        var val_5 = 0;
        label_11:
        if(val_5 > (val_2 - 1))
        {
            goto label_2;
        }
        
        if(val_2 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + 0;
        var val_3 = (true + 0) + 32;
        mem2[0] = val_5;
        if(val_3 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        var val_4 = ((true + 0) + 32 + 0) + 32;
        mem2[0] = "";
        if(val_4 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        val_5 = val_5 + 1;
        mem2[0] = "";
        if(this.localization != null)
        {
            goto label_11;
        }
        
        throw new NullReferenceException();
        label_2:
        UnityEngine.Debug.Log(message:  "Reset Localization");
    }
    public void UpdateData(GGLocalizationData data)
    {
        .data = data;
        if((System.Linq.Enumerable.FirstOrDefault<GGLocalizationData>(source:  this.localization, predicate:  new System.Func<GGLocalizationData, System.Boolean>(object:  new LocalizationAsset.<>c__DisplayClass4_0(), method:  System.Boolean LocalizationAsset.<>c__DisplayClass4_0::<UpdateData>b__0(GGLocalizationData x)))) != null)
        {
                mem2[0] = (LocalizationAsset.<>c__DisplayClass4_0)[1152921513424631056].data;
            mem2[0] = (LocalizationAsset.<>c__DisplayClass4_0)[1152921513424631056].data;
            val_3.English = (LocalizationAsset.<>c__DisplayClass4_0)[1152921513424631056].data.English;
            val_3.Vietnamese = (LocalizationAsset.<>c__DisplayClass4_0)[1152921513424631056].data.Vietnamese;
            return;
        }
        
        UnityEngine.Debug.Log(message:  "Update Failed Level " + ((LocalizationAsset.<>c__DisplayClass4_0)[1152921513424631056].data) + 32.ToString()(((LocalizationAsset.<>c__DisplayClass4_0)[1152921513424631056].data) + 32.ToString()));
    }
    public void AddLevel(int maxLevel)
    {
        GGLocalizationData val_5;
        System.Collections.Generic.List<GGLocalizationData> val_1 = this.localization + 1;
        if(val_1 > maxLevel)
        {
                return;
        }
        
        do
        {
            GGLocalizationData val_2 = null;
            val_5 = val_2;
            val_2 = new GGLocalizationData();
            mem[1152921513424826096] = "Level_" + val_1;
            mem[1152921513424826104] = "Level_" + val_1;
            .English = "Unknown";
            .Vietnamese = "Unknown";
            this.localization.Add(item:  val_2);
            val_1 = val_1 + 1;
        }
        while(val_1 <= maxLevel);
    
    }
    public LocalizationAsset()
    {
        this.associatedSheetId = "";
        this.associatedWorksheet = "";
        this.localization = new System.Collections.Generic.List<GGLocalizationData>();
    }

}
