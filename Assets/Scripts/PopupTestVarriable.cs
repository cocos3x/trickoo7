using UnityEngine;
public class PopupTestVarriable : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.InputField maxDelay;
    public UnityEngine.UI.InputField bannerDelay;
    public UnityEngine.UI.InputField interDelay;
    public UnityEngine.UI.InputField rewardDelay;
    private float maxDelaySecond;
    private float bannerDelaySecond;
    private float interDelaySecond;
    private float rewardDelaySecond;
    
    // Methods
    private void Start()
    {
        this.GetVarriable();
    }
    private void GetVarriable()
    {
        this.maxDelaySecond = UnityEngine.PlayerPrefs.GetFloat(key:  "maxDelaySecond", defaultValue:  0f);
        mem[1152921513477705932] = UnityEngine.PlayerPrefs.GetFloat(key:  "bannerDelaySecond", defaultValue:  0f);
        mem[1152921513477705936] = UnityEngine.PlayerPrefs.GetFloat(key:  "interDelaySecond", defaultValue:  0f);
        mem[1152921513477705940] = UnityEngine.PlayerPrefs.GetFloat(key:  "rewardDelaySecond", defaultValue:  0f);
        this.maxDelay.text = this.maxDelaySecond.ToString();
        this.bannerDelay.text = mem[1152921513477705932].ToString();
        this.interDelay.text = mem[1152921513477705936].ToString();
        this.rewardDelay.text = mem[1152921513477705940].ToString();
    }
    public void SaveVarriable()
    {
        this.maxDelaySecond = System.Single.Parse(s:  this.maxDelay.m_Text);
        this.bannerDelaySecond = System.Single.Parse(s:  this.bannerDelay.m_Text);
        this.interDelaySecond = System.Single.Parse(s:  this.interDelay.m_Text);
        this.rewardDelaySecond = System.Single.Parse(s:  this.rewardDelay.m_Text);
        UnityEngine.PlayerPrefs.SetFloat(key:  "maxDelaySecond", value:  this.maxDelaySecond);
        UnityEngine.PlayerPrefs.SetFloat(key:  "bannerDelaySecond", value:  this.bannerDelaySecond);
        UnityEngine.PlayerPrefs.SetFloat(key:  "interDelaySecond", value:  this.interDelaySecond);
        UnityEngine.PlayerPrefs.SetFloat(key:  "rewardDelaySecond", value:  this.rewardDelaySecond);
        UnityEngine.PlayerPrefs.Save();
    }
    public PopupTestVarriable()
    {
    
    }

}
