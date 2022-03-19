using UnityEngine;
public class SoundManager : MonoBehaviour
{
    // Fields
    private bool loadAllSoundsAtStart;
    private string soundPath;
    private string soundIntro;
    private UnityEngine.UI.Toggle soundToggle;
    private static System.Collections.Generic.Dictionary<string, UnityEngine.AudioClip> allSounds;
    private int soundObjTempList;
    private UnityEngine.Transform parrentTransform;
    private static SoundManager <instance>k__BackingField;
    private static UnityEngine.AudioSource currentBattle;
    private static System.Collections.Generic.List<SoundManager.SoundObj> soundObjList;
    
    // Properties
    private static SoundManager instance { get; set; }
    public static string TAG { get; }
    
    // Methods
    private static SoundManager get_instance()
    {
        null = null;
        return (SoundManager)SoundManager.<instance>k__BackingField;
    }
    private static void set_instance(SoundManager value)
    {
        null = null;
        SoundManager.<instance>k__BackingField = value;
    }
    public static string get_TAG()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((SoundManager.<instance>k__BackingField) == 0)
        {
                return "";
        }
        
        val_4 = null;
        val_4 = null;
        return "[" + SoundManager.<instance>k__BackingField.GetType()(SoundManager.<instance>k__BackingField.GetType()) + "] ";
    }
    public void Awake()
    {
        null = null;
        SoundManager.<instance>k__BackingField = this;
        this.parrentTransform = this.transform;
    }
    private void Start()
    {
        if(this.loadAllSoundsAtStart != false)
        {
                SoundManager.LoadAllSounds(path:  "");
            this.InitSoundObjTempList();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.soundToggle)) != false)
        {
                this.soundToggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  public System.Void SoundManager::ToggleSound(bool isOn)));
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  SoundManager.TAG + " soundToggle NULL");
        }
        
        if((System.String.IsNullOrEmpty(value:  this.soundIntro)) == true)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.soundToggle)) != false)
        {
                if(this.soundToggle.m_IsOn == true)
        {
            goto label_19;
        }
        
        }
        
        if(this.soundToggle != 0)
        {
                return;
        }
        
        label_19:
        if(MusicManager.IsOn == false)
        {
                return;
        }
        
        SoundManager.Play(fileName:  this.soundIntro);
    }
    public void ToggleSound(bool isOn)
    {
        if(isOn != false)
        {
                SoundManager.Play(fileName:  "sfx_click");
            return;
        }
        
        SoundManager.StopBattle();
    }
    public static void LoadAllSounds(string path = "")
    {
        string val_8;
        System.Collections.Generic.Dictionary<System.String, UnityEngine.AudioClip> val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_8 = path;
        if((System.String.IsNullOrEmpty(value:  val_8)) != false)
        {
                val_9 = 1152921504882139136;
            val_10 = null;
            val_10 = null;
            if((UnityEngine.Object.op_Implicit(exists:  SoundManager.<instance>k__BackingField)) != false)
        {
                val_11 = null;
            val_11 = null;
            val_8 = mem[SoundManager.<instance>k__BackingField + 32];
            val_8 = SoundManager.<instance>k__BackingField.soundPath;
        }
        
        }
        
        T[] val_3 = UnityEngine.Resources.LoadAll<UnityEngine.AudioClip>(path:  val_8);
        if(val_3 != null)
        {
                if(val_3.Length < 1)
        {
                return;
        }
        
            var val_8 = 0;
            do
        {
            val_12 = null;
            val_12 = null;
            val_9 = SoundManager.allSounds;
            if((val_9.ContainsKey(key:  1152921505727743600.name)) != true)
        {
                val_13 = null;
            val_13 = null;
            val_9 = SoundManager.allSounds;
            val_9.Add(key:  1152921505727743600.name, value:  1152921505727743600);
        }
        
            val_8 = val_8 + 1;
        }
        while(val_8 < val_3.Length);
        
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "[LoadAllSounds] " + val_8 + " is not correct!?"(" is not correct!?"));
    }
    public void UIPlay(string fileName)
    {
        SoundManager.Play(fileName:  fileName);
    }
    public static void Play(string fileName)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_14 = null;
        val_14 = null;
        if((UnityEngine.Object.op_Implicit(exists:  SoundManager.<instance>k__BackingField)) == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  fileName)) == true)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(SoundManager.allSounds == null)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = null;
        if((SoundManager.<instance>k__BackingField.soundToggle) != 0)
        {
                val_18 = null;
            val_18 = null;
            if((UnityEngine.Object.op_Implicit(exists:  SoundManager.<instance>k__BackingField.soundToggle)) == false)
        {
                return;
        }
        
            val_17 = null;
            val_17 = null;
        }
        
        val_17 = null;
        if((SoundManager.allSounds.ContainsKey(key:  fileName)) != true)
        {
                val_19 = null;
            val_19 = null;
            UnityEngine.AudioClip val_7 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  SoundManager.<instance>k__BackingField.soundPath(SoundManager.<instance>k__BackingField.soundPath) + "/"("/") + fileName);
            if(val_7 != 0)
        {
                val_20 = null;
            val_20 = null;
            if((SoundManager.allSounds.ContainsKey(key:  fileName)) != true)
        {
                val_21 = null;
            val_21 = null;
            SoundManager.allSounds.Add(key:  fileName, value:  val_7);
        }
        
        }
        
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = null;
        if((SoundManager.allSounds.ContainsKey(key:  fileName)) != false)
        {
                val_23 = null;
            SoundManager.PlayTemp(clip:  SoundManager.allSounds.Item[fileName], setPos:  false, pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  SoundManager.TAG + " There is no sound file with the name [" + fileName + "] in any of the Resources folders.\n Check that the spelling of the fileName (without the extension) is correct or if the file exists in under a Resources folder");
    }
    public static void PlayBattle(string fileName)
    {
        string val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        System.Func<SoundObj, System.Boolean> val_37;
        var val_38;
        UnityEngine.Transform val_39;
        var val_40;
        val_23 = fileName;
        val_24 = null;
        val_24 = null;
        if((UnityEngine.Object.op_Implicit(exists:  SoundManager.<instance>k__BackingField)) == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_23)) == true)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        if(SoundManager.allSounds == null)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        val_27 = null;
        if((SoundManager.<instance>k__BackingField.soundToggle) != 0)
        {
                val_28 = null;
            val_28 = null;
            if((UnityEngine.Object.op_Implicit(exists:  SoundManager.<instance>k__BackingField.soundToggle)) == false)
        {
                return;
        }
        
            val_27 = null;
            val_27 = null;
        }
        
        val_27 = null;
        if((SoundManager.allSounds.ContainsKey(key:  val_23)) != true)
        {
                val_29 = null;
            val_29 = null;
            UnityEngine.AudioClip val_7 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  SoundManager.<instance>k__BackingField.soundPath(SoundManager.<instance>k__BackingField.soundPath) + "/"("/") + val_23);
            if(val_7 != 0)
        {
                val_30 = null;
            val_30 = null;
            if((SoundManager.allSounds.ContainsKey(key:  val_23)) != true)
        {
                val_31 = null;
            val_31 = null;
            SoundManager.allSounds.Add(key:  val_23, value:  val_7);
        }
        
        }
        
        }
        
        val_32 = null;
        val_32 = null;
        if((SoundManager.allSounds.ContainsKey(key:  val_23)) == false)
        {
            goto label_62;
        }
        
        val_33 = null;
        val_33 = null;
        .clip = SoundManager.allSounds.Item[val_23];
        if((System.Linq.Enumerable.FirstOrDefault<SoundObj>(source:  SoundManager.soundObjList, predicate:  new System.Func<SoundObj, System.Boolean>(object:  new SoundManager.<>c__DisplayClass20_0(), method:  System.Boolean SoundManager.<>c__DisplayClass20_0::<PlayBattle>b__0(SoundManager.SoundObj x)))) == null)
        {
                val_34 = null;
            val_34 = null;
            val_35 = null;
            val_23 = SoundManager.soundObjList;
            val_35 = null;
            val_37 = SoundManager.<>c.<>9__20_1;
            if(val_37 == null)
        {
                System.Func<SoundObj, System.Boolean> val_15 = null;
            val_37 = val_15;
            val_15 = new System.Func<SoundObj, System.Boolean>(object:  SoundManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SoundManager.<>c::<PlayBattle>b__20_1(SoundManager.SoundObj x));
            SoundManager.<>c.<>9__20_1 = val_37;
        }
        
            if((System.Linq.Enumerable.FirstOrDefault<SoundObj>(source:  val_23, predicate:  val_15)) == null)
        {
                return;
        }
        
        }
        
        val_38 = null;
        val_38 = null;
        if((SoundManager.<instance>k__BackingField) == null)
        {
            goto label_82;
        }
        
        val_39 = mem[SoundManager.<instance>k__BackingField + 64];
        val_39 = SoundManager.<instance>k__BackingField.parrentTransform;
        goto label_83;
        label_62:
        UnityEngine.Debug.LogWarning(message:  SoundManager.TAG + " There is no sound file with the name [" + val_23 + "] in any of the Resources folders.\n Check that the spelling of the fileName (without the extension) is correct or if the file exists in under a Resources folder");
        return;
        label_82:
        val_39 = 0;
        label_83:
        SoundManager.SoundObj val_21 = new SoundManager.SoundObj(name:  "TempAudio - "("TempAudio - ") + (SoundManager.<>c__DisplayClass20_0)[1152921513406478384].clip.name((SoundManager.<>c__DisplayClass20_0)[1152921513406478384].clip.name), parent:  val_39);
        (SoundManager.SoundObj)[1152921513406523440].aSource.clip = (SoundManager.<>c__DisplayClass20_0)[1152921513406478384].clip;
        val_40 = null;
        val_40 = null;
        SoundManager.currentBattle = (SoundManager.SoundObj)[1152921513406523440].aSource;
        SoundManager.currentBattle.Play();
        UnityEngine.Object.Destroy(obj:  (SoundManager.SoundObj)[1152921513406523440].gameObject, t:  (SoundManager.<>c__DisplayClass20_0)[1152921513406478384].clip.length);
    }
    public static void StopBattle()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((UnityEngine.Object.op_Implicit(exists:  SoundManager.currentBattle)) == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        SoundManager.currentBattle.Stop();
    }
    private static void PlayClipAt(UnityEngine.AudioClip clip, bool setPos = False, UnityEngine.Vector3 pos)
    {
        var val_6;
        UnityEngine.Transform val_7;
        val_6 = null;
        val_6 = null;
        if((SoundManager.<instance>k__BackingField) != null)
        {
                val_7 = mem[SoundManager.<instance>k__BackingField + 64];
            val_7 = SoundManager.<instance>k__BackingField.parrentTransform;
        }
        else
        {
                val_7 = 0;
        }
        
        SoundManager.SoundObj val_3 = new SoundManager.SoundObj(name:  "TempAudio - "("TempAudio - ") + clip.name, parent:  val_7);
        if(setPos != false)
        {
                (SoundManager.SoundObj)[1152921513406817072].gameObject.transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        }
        
        (SoundManager.SoundObj)[1152921513406817072].aSource.PlayOneShot(clip:  clip);
        UnityEngine.Object.Destroy(obj:  (SoundManager.SoundObj)[1152921513406817072].gameObject, t:  clip.length);
    }
    public void InitSoundObjTempList()
    {
        var val_2;
        if(this.soundObjTempList < 1)
        {
                return;
        }
        
        var val_2 = 0;
        do
        {
            val_2 = null;
            val_2 = null;
            SoundManager.soundObjList.Add(item:  new SoundManager.SoundObj(name:  "SoundObj", parent:  this.parrentTransform));
            val_2 = val_2 + 1;
        }
        while(val_2 < this.soundObjTempList);
    
    }
    public static void PlayTemp(UnityEngine.AudioClip clip, bool setPos = False, UnityEngine.Vector3 pos)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        System.Func<SoundObj, System.Boolean> val_12;
        .clip = clip;
        val_7 = null;
        val_7 = null;
        SoundObj val_3 = System.Linq.Enumerable.FirstOrDefault<SoundObj>(source:  SoundManager.soundObjList, predicate:  new System.Func<SoundObj, System.Boolean>(object:  new SoundManager.<>c__DisplayClass25_0(), method:  System.Boolean SoundManager.<>c__DisplayClass25_0::<PlayTemp>b__0(SoundManager.SoundObj x)));
        val_8 = val_3;
        if(val_3 != null)
        {
            goto label_4;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_10 = null;
        val_12 = SoundManager.<>c.<>9__25_1;
        if(val_12 == null)
        {
                System.Func<SoundObj, System.Boolean> val_4 = null;
            val_12 = val_4;
            val_4 = new System.Func<SoundObj, System.Boolean>(object:  SoundManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SoundManager.<>c::<PlayTemp>b__25_1(SoundManager.SoundObj x));
            SoundManager.<>c.<>9__25_1 = val_12;
        }
        
        SoundObj val_5 = System.Linq.Enumerable.FirstOrDefault<SoundObj>(source:  SoundManager.soundObjList, predicate:  val_4);
        val_8 = val_5;
        if(val_5 == null)
        {
            goto label_12;
        }
        
        label_4:
        if(setPos != false)
        {
                val_5.gameObject.transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        }
        
        val_5.aSource.PlayOneShot(clip:  (SoundManager.<>c__DisplayClass25_0)[1152921513407130256].clip);
        return;
        label_12:
        SoundManager.PlayClipAt(clip:  (SoundManager.<>c__DisplayClass25_0)[1152921513407130256].clip, setPos:  false, pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    public void TestComboSound()
    {
        null = null;
        Dictionary.Enumerator<TKey, TValue> val_1 = SoundManager.allSounds.GetEnumerator();
        label_7:
        if(0.MoveNext() == false)
        {
            goto label_4;
        }
        
        SoundManager.Play(fileName:  0);
        goto label_7;
        label_4:
        0.Dispose();
    }
    public SoundManager()
    {
        this.loadAllSoundsAtStart = true;
        this.soundPath = "Sounds";
        this.soundObjTempList = 10;
        this.soundIntro = "sfx_intro";
    }
    private static SoundManager()
    {
        SoundManager.allSounds = new System.Collections.Generic.Dictionary<System.String, UnityEngine.AudioClip>();
        SoundManager.soundObjList = new System.Collections.Generic.List<SoundObj>();
    }

}
