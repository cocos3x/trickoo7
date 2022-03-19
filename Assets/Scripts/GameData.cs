using UnityEngine;
[Serializable]
public class GameData
{
    // Fields
    public UserData user;
    public System.Collections.Generic.List<StageData> stages;
    public int typeMap;
    public bool isSetupRemoteConfig;
    
    // Methods
    public GameData()
    {
        this.user = new UserData();
        this.stages = new System.Collections.Generic.List<StageData>();
        this.typeMap = 0;
    }

}
