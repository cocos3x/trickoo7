using UnityEngine;
public class SampleTimer : MonoBehaviour
{
    // Fields
    private System.DateTime simpleTimerEndTimestamp;
    private System.DateTime unbiasedTimerEndTimestamp;
    
    // Methods
    private void Awake()
    {
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_2 = val_1.dateData.AddSeconds(value:  60);
        System.DateTime val_3 = val_2.dateData.ReadTimestamp(key:  "simpleTimer", defaultValue:  new System.DateTime() {dateData = val_2.dateData});
        this.simpleTimerEndTimestamp = val_3;
        System.DateTime val_5 = UnbiasedTime.Instance.Now();
        System.DateTime val_6 = val_5.dateData.AddSeconds(value:  60);
        System.DateTime val_7 = val_6.dateData.ReadTimestamp(key:  "unbiasedTimer", defaultValue:  new System.DateTime() {dateData = val_6.dateData});
        this.unbiasedTimerEndTimestamp = val_7;
    }
    private void OnApplicationPause(bool paused)
    {
        if(paused != false)
        {
                this.WriteTimestamp(key:  "simpleTimer", time:  new System.DateTime() {dateData = this.simpleTimerEndTimestamp});
            this.WriteTimestamp(key:  "unbiasedTimer", time:  new System.DateTime() {dateData = this.unbiasedTimerEndTimestamp});
            return;
        }
        
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_2 = val_1.dateData.AddSeconds(value:  60);
        System.DateTime val_3 = val_2.dateData.ReadTimestamp(key:  "simpleTimer", defaultValue:  new System.DateTime() {dateData = val_2.dateData});
        this.simpleTimerEndTimestamp = val_3;
        System.DateTime val_5 = UnbiasedTime.Instance.Now();
        System.DateTime val_6 = val_5.dateData.ReadTimestamp(key:  "unbiasedTimer", defaultValue:  new System.DateTime() {dateData = val_5.dateData});
        this.unbiasedTimerEndTimestamp = val_6;
        System.DateTime val_8 = UnbiasedTime.Instance.Now();
        System.DateTime val_9 = val_8.dateData.ReadTimestamp(key:  "unbiasedTimer", defaultValue:  new System.DateTime() {dateData = val_8.dateData});
        string val_10 = val_9.dateData.ToString(format:  "MM/dd/yyyy");
    }
    private void OnApplicationQuit()
    {
        this.WriteTimestamp(key:  "simpleTimer", time:  new System.DateTime() {dateData = this.simpleTimerEndTimestamp});
        this.WriteTimestamp(key:  "unbiasedTimer", time:  new System.DateTime() {dateData = this.unbiasedTimerEndTimestamp});
    }
    private void OnGUI()
    {
        var val_54;
        var val_55;
        float val_56;
        string val_57;
        val_54 = 1152921504616112128;
        System.DateTime val_1 = System.DateTime.Now;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = this.simpleTimerEndTimestamp}, d2:  new System.DateTime() {dateData = val_1.dateData});
        System.DateTime val_4 = UnbiasedTime.Instance.Now();
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = this.unbiasedTimerEndTimestamp}, d2:  new System.DateTime() {dateData = val_4.dateData});
        UnityEngine.GUIStyle val_9 = UnityEngine.GUI.skin.box;
        float val_60 = (float)UnityEngine.Screen.height;
        float val_54 = 12f;
        val_54 = val_60 * val_54;
        val_54 = val_54 / 480f;
        val_54 = (val_54 == Infinityf) ? (-(double)val_54) : ((double)val_54);
        val_9.fontSize = (int)val_54;
        UnityEngine.GUIStyle val_11 = UnityEngine.GUI.skin.label;
        float val_55 = 24f;
        val_55 = val_60 * val_55;
        val_55 = val_55 / 480f;
        val_55 = (val_55 == Infinityf) ? (-(double)val_55) : ((double)val_55);
        val_11.fontSize = (int)val_55;
        val_11.alignment = 1;
        UnityEngine.GUIStyle val_13 = UnityEngine.GUI.skin.button;
        float val_56 = 14f;
        val_56 = val_60 * val_56;
        val_56 = val_56 / 480f;
        val_56 = (val_56 == Infinityf) ? (-(double)val_56) : ((double)val_56);
        val_13.fontSize = (int)val_56;
        val_55 = "END";
        if(val_2._ticks.TotalSeconds > 0f)
        {
                val_54 = val_54;
        }
        
        float val_57 = 0.2f;
        float val_58 = 0.6f;
        float val_19 = (float)UnityEngine.Screen.width * 0.075f;
        float val_20 = (float)UnityEngine.Screen.width * 0.4f;
        val_57 = val_60 * val_57;
        val_58 = val_60 * val_58;
        UnityEngine.Rect val_21 = new UnityEngine.Rect(x:  val_19, y:  val_57, width:  val_20, height:  val_58);
        UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = val_21.m_XMin, m_YMin = val_21.m_YMin, m_Width = val_21.m_Width, m_Height = val_21.m_Height}, text:  "Simple timer", style:  val_9);
        float val_59 = 0.1f;
        float val_22 = val_60 * 0.3f;
        float val_23 = val_60 * val_59;
        UnityEngine.Rect val_24 = new UnityEngine.Rect(x:  val_19, y:  val_22, width:  val_20, height:  val_23);
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_24.m_XMin, m_YMin = val_24.m_YMin, m_Width = val_24.m_Width, m_Height = val_24.m_Height}, text:  System.String.Format(format:  "{0}:{1:D2}:{2:D2}", arg0:  val_2._ticks.Hours, arg1:  val_2._ticks.Minutes, arg2:  val_2._ticks.Seconds), style:  val_11);
        val_59 = (float)UnityEngine.Screen.width * val_59;
        float val_25 = val_60 * 0.5f;
        float val_26 = (float)UnityEngine.Screen.width * 0.35f;
        UnityEngine.Rect val_27 = new UnityEngine.Rect(x:  val_59, y:  val_25, width:  val_26, height:  val_23);
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_27.m_XMin, m_YMin = val_27.m_YMin, m_Width = val_27.m_Width, m_Height = val_27.m_Height}, text:  "+60 seconds", style:  val_13)) != false)
        {
                System.DateTime val_29 = this.simpleTimerEndTimestamp.AddSeconds(value:  60);
            this.simpleTimerEndTimestamp = val_29;
            val_29.dateData.WriteTimestamp(key:  "simpleTimer", time:  new System.DateTime() {dateData = val_29.dateData});
        }
        
        val_60 = val_60 * 0.65f;
        UnityEngine.Rect val_30 = new UnityEngine.Rect(x:  val_59, y:  val_60, width:  val_26, height:  val_23);
        val_56 = val_30.m_XMin;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_56, m_YMin = val_30.m_YMin, m_Width = val_30.m_Width, m_Height = val_30.m_Height}, text:  "Reset", style:  val_13)) != false)
        {
                System.DateTime val_32 = System.DateTime.Now;
            val_56 = 60;
            System.DateTime val_33 = val_32.dateData.AddSeconds(value:  val_56);
            this.simpleTimerEndTimestamp = val_33;
            val_33.dateData.WriteTimestamp(key:  "simpleTimer", time:  new System.DateTime() {dateData = val_33.dateData});
        }
        
        val_57 = "END";
        if(val_5._ticks.TotalSeconds > 0f)
        {
                val_55 = 1152921504619307008;
            val_57 = System.String.Format(format:  "{0}:{1:D2}:{2:D2}", arg0:  val_5._ticks.Hours, arg1:  val_5._ticks.Minutes, arg2:  val_5._ticks.Seconds);
        }
        
        float val_42 = (float)UnityEngine.Screen.width * 0.525f;
        UnityEngine.Rect val_43 = new UnityEngine.Rect(x:  val_42, y:  val_57, width:  val_20, height:  val_58);
        UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = val_43.m_XMin, m_YMin = val_43.m_YMin, m_Width = val_43.m_Width, m_Height = val_43.m_Height}, text:  (UnbiasedTime.Instance.UsingSystemTimeAndroid() != true) ? "Unbiased fallback" : "Unbiased timer", style:  val_9);
        UnityEngine.Rect val_44 = new UnityEngine.Rect(x:  val_42, y:  val_22, width:  val_20, height:  val_23);
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_44.m_XMin, m_YMin = val_44.m_YMin, m_Width = val_44.m_Width, m_Height = val_44.m_Height}, text:  val_57, style:  val_11);
        float val_45 = (float)UnityEngine.Screen.width * 0.55f;
        UnityEngine.Rect val_46 = new UnityEngine.Rect(x:  val_45, y:  val_25, width:  val_26, height:  val_23);
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_46.m_XMin, m_YMin = val_46.m_YMin, m_Width = val_46.m_Width, m_Height = val_46.m_Height}, text:  "+60 seconds", style:  val_13)) != false)
        {
                System.DateTime val_48 = this.unbiasedTimerEndTimestamp.AddSeconds(value:  60);
            this.unbiasedTimerEndTimestamp = val_48;
            val_48.dateData.WriteTimestamp(key:  "unbiasedTimer", time:  new System.DateTime() {dateData = val_48.dateData});
        }
        
        UnityEngine.Rect val_49 = new UnityEngine.Rect(x:  val_45, y:  val_60, width:  val_26, height:  val_23);
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_49.m_XMin, m_YMin = val_49.m_YMin, m_Width = val_49.m_Width, m_Height = val_49.m_Height}, text:  "Reset", style:  val_13)) == false)
        {
                return;
        }
        
        System.DateTime val_52 = UnbiasedTime.Instance.Now();
        System.DateTime val_53 = val_52.dateData.AddSeconds(value:  60);
        this.unbiasedTimerEndTimestamp = val_53;
        val_53.dateData.WriteTimestamp(key:  "unbiasedTimer", time:  new System.DateTime() {dateData = val_53.dateData});
    }
    private System.DateTime ReadTimestamp(string key, System.DateTime defaultValue)
    {
        long val_2 = System.Convert.ToInt64(value:  UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  "0"));
        if(val_2 == 0)
        {
                return (System.DateTime)defaultValue.dateData;
        }
        
        return System.DateTime.FromBinary(dateData:  val_2);
    }
    private void WriteTimestamp(string key, System.DateTime time)
    {
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  time.dateData.ToBinary().ToString());
    }
    public SampleTimer()
    {
    
    }

}
