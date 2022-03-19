using UnityEngine;

namespace SuperScrollView
{
    public class FPSDisplay : MonoBehaviour
    {
        // Fields
        private float deltaTime;
        private UnityEngine.GUIStyle mStyle;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GUIStyle val_1 = new UnityEngine.GUIStyle();
            this.mStyle = val_1;
            val_1.alignment = 0;
            this.mStyle.normal.background = 0;
            this.mStyle.fontSize = 25;
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  0f, g:  1f, b:  0f, a:  1f);
            this.mStyle.normal.textColor = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_1 - this.deltaTime;
            val_1 = val_1 * 0.1f;
            val_1 = this.deltaTime + val_1;
            this.deltaTime = val_1;
        }
        private void OnGUI()
        {
            int val_3 = UnityEngine.Screen.height << 1;
            val_3 = val_3 >> 63;
            val_3 = val_3 + ((val_3 >> 32) >> 5);
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  0f, y:  0f, width:  (float)UnityEngine.Screen.width, height:  (float)val_3);
            float val_7 = this.deltaTime;
            val_7 = 1f / val_7;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_5.m_XMin, m_YMin = val_5.m_YMin, m_Width = val_5.m_Width, m_Height = val_5.m_Height}, text:  System.String.Format(format:  "   {0:0.} FPS", arg0:  val_7), style:  this.mStyle);
        }
        public FPSDisplay()
        {
        
        }
    
    }

}
