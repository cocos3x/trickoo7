using UnityEngine;

namespace Crystal
{
    public class SafeArea : MonoBehaviour
    {
        // Fields
        public static Crystal.SafeArea.SimDevice Sim;
        private UnityEngine.Rect[] NSA_iPhoneX;
        private UnityEngine.Rect[] NSA_iPhoneXsMax;
        private UnityEngine.Rect[] NSA_Pixel3XL_LSL;
        private UnityEngine.Rect[] NSA_Pixel3XL_LSR;
        private UnityEngine.RectTransform Panel;
        private UnityEngine.Rect LastSafeArea;
        private UnityEngine.Vector2Int LastScreenSize;
        private UnityEngine.ScreenOrientation LastOrientation;
        private bool ConformX;
        private bool ConformY;
        private bool Logging;
        
        // Methods
        private void Awake()
        {
            UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
            this.Panel = val_1;
            if(val_1 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "Cannot apply safe area - no RectTransform found on "("Cannot apply safe area - no RectTransform found on ") + this.name);
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            }
            
            this.Refresh();
        }
        private void Update()
        {
            this.Refresh();
        }
        private void Refresh()
        {
            UnityEngine.Vector2Int val_11;
            UnityEngine.Rect val_1 = this.GetSafeArea();
            if((UnityEngine.Rect.op_Inequality(lhs:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height}, rhs:  new UnityEngine.Rect() {m_XMin = this.LastSafeArea})) != false)
            {
                    val_11 = this.LastScreenSize;
            }
            else
            {
                    val_11 = this.LastScreenSize;
                if((UnityEngine.Screen.width == val_11.x) && (UnityEngine.Screen.height == val_11.y))
            {
                    if(UnityEngine.Screen.orientation == this.LastOrientation)
            {
                    return;
            }
            
            }
            
            }
            
            val_11.x = UnityEngine.Screen.width;
            val_11.y = UnityEngine.Screen.height;
            this.LastOrientation = UnityEngine.Screen.orientation;
            this.ApplySafeArea(r:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height});
        }
        private UnityEngine.Rect GetSafeArea()
        {
            var val_27;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            var val_33;
            var val_34;
            var val_35;
            val_27 = this;
            UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
            val_29 = val_1.m_XMin;
            val_30 = val_1.m_YMin;
            val_31 = val_1.m_Width;
            val_32 = val_1.m_Height;
            if(UnityEngine.Application.isEditor == false)
            {
                    return new UnityEngine.Rect() {m_XMin = val_29, m_YMin = val_30, m_Width = val_31, m_Height = val_32};
            }
            
            val_33 = 1152921504898060288;
            val_34 = null;
            val_34 = null;
            if(Crystal.SafeArea.Sim == 0)
            {
                    return new UnityEngine.Rect() {m_XMin = val_29, m_YMin = val_30, m_Width = val_31, m_Height = val_32};
            }
            
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  0f, y:  0f, width:  (float)UnityEngine.Screen.width, height:  (float)UnityEngine.Screen.height);
            val_35 = null;
            val_35 = null;
            SimDevice val_27 = Crystal.SafeArea.Sim;
            val_27 = val_27 - 1;
            if(val_27 <= 3)
            {
                    var val_28 = 20143248 + ((Crystal.SafeArea.Sim - 1)) << 2;
                val_28 = val_28 + 20143248;
            }
            else
            {
                    val_27 = UnityEngine.Screen.width;
                val_33 = UnityEngine.Screen.width;
                UnityEngine.Rect val_22 = new UnityEngine.Rect(x:  null.x * (float)val_27, y:  null.y * (float)UnityEngine.Screen.height, width:  null.width * (float)val_33, height:  null.height * (float)UnityEngine.Screen.height);
                val_29 = val_22.m_XMin;
                val_30 = val_22.m_YMin;
                val_31 = val_22.m_Width;
                val_32 = val_22.m_Height;
                return new UnityEngine.Rect() {m_XMin = val_29, m_YMin = val_30, m_Width = val_31, m_Height = val_32};
            }
        
        }
        private void ApplySafeArea(UnityEngine.Rect r)
        {
            System.Object[] val_23;
            float val_24;
            float val_25;
            float val_26;
            val_24 = r.m_Height;
            val_25 = r.m_YMin;
            this.LastSafeArea = r;
            mem[1152921513686452308] = val_25;
            mem[1152921513686452312] = r.m_Width;
            mem[1152921513686452316] = val_24;
            if(this.ConformX != true)
            {
                    r.m_XMin.x = 0f;
                val_26 = (float)UnityEngine.Screen.width;
                r.m_XMin.width = val_26;
            }
            
            if(this.ConformY != true)
            {
                    r.m_XMin.y = 0f;
                val_26 = (float)UnityEngine.Screen.height;
                r.m_XMin.height = val_26;
            }
            
            if((UnityEngine.Screen.width >= 1) && (UnityEngine.Screen.height >= 1))
            {
                    UnityEngine.Vector2 val_5 = r.m_XMin.position;
                float val_22 = val_5.x;
                val_24 = val_5.y;
                UnityEngine.Vector2 val_6 = r.m_XMin.position;
                UnityEngine.Vector2 val_7 = r.m_XMin.size;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
                val_25 = val_8.y;
                val_26 = (float)UnityEngine.Screen.width;
                val_22 = val_22 / val_26;
                val_23 = UnityEngine.Screen.width;
                if(val_22 >= 0f)
            {
                    val_26 = (float)UnityEngine.Screen.height;
                float val_13 = val_24 / val_26;
                if(val_13 >= 0f)
            {
                    val_26 = (float)val_23;
                val_24 = val_8.x / val_26;
                if(val_24 >= 0f)
            {
                    val_26 = (float)UnityEngine.Screen.height;
                val_25 = val_25 / val_26;
                if(val_25 >= 0f)
            {
                    this.Panel.anchorMin = new UnityEngine.Vector2() {x = val_22, y = val_13};
                val_26 = val_24;
                this.Panel.anchorMax = new UnityEngine.Vector2() {x = val_26, y = val_25};
            }
            
            }
            
            }
            
            }
            
            }
            
            if(this.Logging == false)
            {
                    return;
            }
            
            object[] val_14 = new object[7];
            val_23 = val_14;
            val_23[0] = this.name;
            val_23[1] = r.m_XMin.x;
            val_23[2] = r.m_XMin.y;
            val_23[3] = r.m_XMin.width;
            val_23[4] = r.m_XMin.height;
            val_23[5] = UnityEngine.Screen.width;
            val_23[6] = UnityEngine.Screen.height;
            UnityEngine.Debug.LogFormat(format:  "New safe area applied to {0}: x={1}, y={2}, w={3}, h={4} on full extents w={5}, h={6}", args:  val_14);
        }
        public SafeArea()
        {
            UnityEngine.Rect[] val_1 = new UnityEngine.Rect[2];
            UnityEngine.Rect val_2 = new UnityEngine.Rect(x:  0f, y:  0.04187192f, width:  1f, height:  0.9039409f);
            val_1[0] = val_2.m_XMin;
            UnityEngine.Rect val_3 = new UnityEngine.Rect(x:  0.05418719f, y:  0.056f, width:  0.8916256f, height:  0.944f);
            val_1[1] = val_3.m_XMin;
            this.NSA_iPhoneX = val_1;
            UnityEngine.Rect[] val_4 = new UnityEngine.Rect[2];
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  0f, y:  0.03794643f, width:  1f, height:  0.9129464f);
            val_4[0] = val_5.m_XMin;
            UnityEngine.Rect val_6 = new UnityEngine.Rect(x:  0.04910714f, y:  0.05072464f, width:  0.9017857f, height:  0.9492754f);
            val_4[1] = val_6.m_XMin;
            this.NSA_iPhoneXsMax = val_4;
            UnityEngine.Rect[] val_7 = new UnityEngine.Rect[2];
            UnityEngine.Rect val_8 = new UnityEngine.Rect(x:  0f, y:  0f, width:  1f, height:  0.9422297f);
            val_7[0] = val_8.m_XMin;
            UnityEngine.Rect val_9 = new UnityEngine.Rect(x:  0f, y:  0f, width:  0.9422297f, height:  1f);
            val_7[1] = val_9.m_XMin;
            this.NSA_Pixel3XL_LSL = val_7;
            UnityEngine.Rect[] val_10 = new UnityEngine.Rect[2];
            UnityEngine.Rect val_11 = new UnityEngine.Rect(x:  0f, y:  0f, width:  1f, height:  0.9422297f);
            val_10[0] = val_11.m_XMin;
            UnityEngine.Rect val_12 = new UnityEngine.Rect(x:  0.05777027f, y:  0f, width:  0.9422297f, height:  1f);
            val_10[1] = val_12.m_XMin;
            this.NSA_Pixel3XL_LSR = val_10;
            UnityEngine.Rect val_13 = new UnityEngine.Rect(x:  0f, y:  0f, width:  0f, height:  0f);
            this.LastSafeArea = val_13.m_XMin;
            UnityEngine.Vector2Int val_14 = new UnityEngine.Vector2Int(x:  0, y:  0);
            this.LastOrientation = 5;
            this.LastScreenSize = val_14.m_X;
            this.ConformX = true;
            this.ConformY = true;
        }
        private static SafeArea()
        {
        
        }
    
    }

}
