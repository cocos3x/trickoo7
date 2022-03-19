using UnityEngine;
public class UILevelMap : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image img;
    private UnityEngine.UI.Text text;
    private UnityEngine.UI.Button btn;
    private UnityEngine.Sprite current;
    private UnityEngine.Sprite done;
    private UnityEngine.Sprite sprLock;
    private int index;
    
    // Methods
    public void FillData(int _index)
    {
        this.index = _index;
        this.UpdateStatus();
    }
    public void UpdateStatus()
    {
        UnityEngine.Sprite val_7;
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        if((val_1.stagesAsset.StageStatus(index:  this.index)) == null)
        {
                return;
        }
        
        StageData val_4 = LazySingleton<DataManager>.Instance.CurrentStage;
        this.btn.interactable = false;
        string val_5 = val_2.level.ToString();
        if(null != null)
        {
                var val_6 = (null == typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0) ? 48 : 56;
        }
        else
        {
                val_7 = this.sprLock;
        }
        
        this.img.sprite = val_7;
    }
    public void GoToLevel()
    {
        SoundManager.Play(fileName:  "Button");
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        StageData val_2 = val_1.stagesAsset.StageSelect(index:  this.index);
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  15);
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  10);
    }
    public UILevelMap()
    {
    
    }

}
