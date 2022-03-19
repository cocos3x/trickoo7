using UnityEngine;

namespace ScratchCardAsset.Demo
{
    public class ScratchDemoUI : MonoBehaviour
    {
        // Fields
        public ScratchCardAsset.ScratchCardManager CardManager;
        public UnityEngine.Texture[] Brushes;
        public UnityEngine.UI.Toggle[] BrushToggles;
        public UnityEngine.UI.Toggle ProgressToggle;
        public UnityEngine.UI.Text ProgressText;
        public UnityEngine.UI.Dropdown ScratchModeDropdown;
        public UnityEngine.UI.Slider BrushScaleSlider;
        public UnityEngine.UI.Text BrushScaleText;
        public ScratchCardAsset.EraseProgress EraseProgress;
        private string ToggleKey;
        private string BrushKey;
        private string ScaleKey;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction<T0> val_8;
            UnityEngine.Application.targetFrameRate = 60;
            this.ProgressToggle.isOn = ((UnityEngine.PlayerPrefs.GetInt(key:  this.ToggleKey, defaultValue:  0)) == 0) ? 1 : 0;
            mem[1152921513683665840] = this;
            mem[1152921513683665848] = System.Void ScratchCardAsset.Demo.ScratchDemoUI::OnEraseProgress(float progress);
            mem[1152921513683665824] = System.Void ScratchCardAsset.Demo.ScratchDemoUI::OnEraseProgress(float progress);
            this.EraseProgress.add_OnProgress(value:  new EraseProgress.ProgressHandler());
            this.BrushScaleSlider.m_OnValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void ScratchCardAsset.Demo.ScratchDemoUI::OnSlider(float val)));
            UnityEngine.Events.UnityAction<System.Int32> val_4 = null;
            val_8 = val_4;
            val_4 = new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void ScratchCardAsset.Demo.ScratchDemoUI::OnDropdown(int id));
            this.ScratchModeDropdown.m_OnValueChanged.AddListener(call:  val_4);
            float val_5 = UnityEngine.PlayerPrefs.GetFloat(key:  this.ScaleKey, defaultValue:  1f);
            if(this.BrushToggles.Length >= 1)
            {
                    var val_9 = 0;
                do
            {
                UnityEngine.UI.Toggle val_8 = this.BrushToggles[val_9];
                UnityEngine.Events.UnityAction<System.Boolean> val_6 = null;
                val_8 = val_6;
                val_6 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void ScratchCardAsset.Demo.ScratchDemoUI::OnChange(bool val));
                this.BrushToggles[0x0][0].onValueChanged.AddListener(call:  val_6);
                val_9 = val_9 + 1;
            }
            while(val_9 < this.BrushToggles.Length);
            
            }
            
            this.BrushToggles[UnityEngine.PlayerPrefs.GetInt(key:  this.BrushKey)].isOn = true;
        }
        private void Update()
        {
            bool val_1 = UnityEngine.Input.GetKeyDown(key:  27);
            if(val_1 == false)
            {
                    return;
            }
            
            val_1.Restart();
        }
        private void OnDropdown(int id)
        {
            this.CardManager.Card.Mode = id;
        }
        private void OnSlider(float val)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  val);
            this.CardManager.Card.BrushScale = val_2;
            mem2[0] = val_2.y;
            string val_4 = System.Math.Round(value:  (double)val, digits:  2).ToString();
            UnityEngine.PlayerPrefs.SetFloat(key:  this.ScaleKey, value:  val);
        }
        private void OnChange(bool val)
        {
            if(this.BrushToggles.Length < 1)
            {
                    return;
            }
            
            label_5:
            UnityEngine.UI.Toggle val_1 = this.BrushToggles[0];
            if(this.BrushToggles[0x0][0].m_IsOn == true)
            {
                goto label_4;
            }
            
            if(1 < this.BrushToggles.Length)
            {
                goto label_5;
            }
            
            return;
            label_4:
            this.CardManager.eraserMaterial.mainTexture = this.Brushes[0];
            UnityEngine.PlayerPrefs.SetInt(key:  this.BrushKey, value:  0);
        }
        private void OnEraseProgress(float progress)
        {
            var val_1;
            var val_4;
            float val_5;
            float val_4 = progress;
            val_4 = val_4 * 100f;
            if(val_4 >= 0f)
            {
                goto label_3;
            }
            
            if((double)val_4 != (-0.5))
            {
                goto label_4;
            }
            
            val_4 = val_1;
            val_5 = -1f;
            goto label_5;
            label_3:
            if((double)val_4 != 0.5)
            {
                goto label_6;
            }
            
            val_4 = val_1;
            val_5 = 1f;
            label_5:
            float val_5 = (float)val_4;
            val_5 = val_5 + val_5;
            val_5 = (((long)val_4 & 1) != 0) ? (val_5) : (val_5);
            goto label_8;
            label_4:
            float val_6 = -0.5f;
            val_6 = val_4 + val_6;
            goto label_8;
            label_6:
            float val_7 = 0.5f;
            val_7 = val_4 + val_7;
            label_8:
            string val_3 = System.String.Format(format:  "Progress: {0}%", arg0:  val_7.ToString());
        }
        public void OnCheck(bool check)
        {
            this.EraseProgress.enabled = this.ProgressToggle.m_IsOn;
            UnityEngine.PlayerPrefs.SetInt(key:  this.ToggleKey, value:  this.ProgressToggle.m_IsOn ^ 1);
        }
        public void Restart()
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_1.m_Handle.name);
        }
        public ScratchDemoUI()
        {
            this.ToggleKey = "Toggle";
            this.BrushKey = "Brush";
            this.ScaleKey = "Scale";
        }
    
    }

}
