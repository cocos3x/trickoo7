using UnityEngine;
public class UILevel : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image img;
    private UnityEngine.UI.Text text;
    private UnityEngine.UI.Text smallText;
    private UnityEngine.UI.Image unlock;
    private UnityEngine.GameObject iconLock;
    private UnityEngine.GameObject selected;
    private UnityEngine.UI.Button btn;
    private UnityEngine.Sprite current;
    private UnityEngine.Sprite done;
    private UnityEngine.Sprite sprLock;
    private int index;
    
    // Methods
    public void FillData(int _index)
    {
        UnityEngine.UI.Text val_12;
        UnityEngine.Sprite val_13;
        this.index = _index;
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        if((val_1.stagesAsset.StageStatus(index:  this.index)) == null)
        {
                return;
        }
        
        DataManager val_3 = LazySingleton<DataManager>.Instance;
        StageData val_4 = val_3.stagesAsset.MaxStageUnlock();
        bool val_5 = (W9 == 0) ? 1 : 0;
        this.iconLock.SetActive(value:  val_5);
        this.btn.interactable = val_5;
        if(this.iconLock == null)
        {
            goto label_8;
        }
        
        if(this.iconLock != W9)
        {
            goto label_10;
        }
        
        if(this.smallText != null)
        {
            goto label_11;
        }
        
        return;
        label_8:
        val_12 = this.text;
        string val_6 = val_2.level.ToString();
        this.selected.SetActive(value:  false);
        val_13 = this.sprLock;
        goto label_17;
        label_10:
        string val_7 = val_2.level.ToString();
        label_11:
        string val_8 = val_2.level.ToString();
        bool val_9 = (typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0 == null) ? 1 : 0;
        this.selected.SetActive(value:  val_9);
        val_12 = this.img;
        val_13 = this.current;
        if(val_12 == null)
        {
                DataManager val_10 = LazySingleton<DataManager>.Instance;
            val_13 = val_10.thumbnailAsset.getSpriteByLevel(level:  val_9);
        }
        
        label_17:
        val_12.sprite = val_13;
    }
    public void GoToLevel()
    {
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        StageData val_2 = val_1.stagesAsset.StageSelect(index:  this.index);
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  15);
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  10);
    }
    public UILevel()
    {
    
    }

}
