using UnityEngine;
[Serializable]
public class SaveData
{
    // Fields
    public string name;
    public string id;
    public string idThumb;
    public int index;
    public string description;
    public UnlockType unlockType;
    public int unlockPrice;
    public bool isUnlocked;
    public bool isSelected;
    public int count;
    public int countHit;
    public int unlockPay;
    
    // Properties
    public bool isCanUnlock { get; }
    
    // Methods
    public bool get_isCanUnlock()
    {
        return ItemExtend.IsCanUnlock(item:  this);
    }
    public SaveData()
    {
        this.unlockType = 2.12199579294153E-314;
    }
    public SaveData(int index, string id, string name, string description = "", bool isSelected = False, bool isUnlocked = False, int unlockPrice = 1, UnlockType unlockType = 4)
    {
        this.unlockType = 2.12199579294153E-314;
        val_1 = new System.Object();
        this.index = index;
        this.description = description;
        this.name = name;
        this.id = val_1;
        this.isUnlocked = isUnlocked;
        this.isSelected = isSelected;
        this.unlockType = unlockType;
        this.unlockPrice = unlockPrice;
    }

}
