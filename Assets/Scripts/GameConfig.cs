using UnityEngine;
[Serializable]
public class GameConfig
{
    // Fields
    public int timePlayToShowAds;
    public bool isShowRate;
    public int levelPlayToShowAds;
    public int showRateLevel;
    public int brainPointAds;
    public int brainPointHint;
    public int levelStartCheck;
    public int levelCountdown;
    public bool isShowAOA;
    public bool isUseBrainPoint;
    
    // Methods
    public GameConfig()
    {
        this.timePlayToShowAds = 20;
        this.levelStartCheck = 10;
        this.levelCountdown = 3;
        this.levelPlayToShowAds = ;
        this.showRateLevel = ;
        this.brainPointAds = 214748364875;
        this.brainPointHint = 50;
        this.isShowAOA = true;
        this.isUseBrainPoint = true;
    }

}
