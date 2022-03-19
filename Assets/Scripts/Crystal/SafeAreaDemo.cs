using UnityEngine;

namespace Crystal
{
    public class SafeAreaDemo : MonoBehaviour
    {
        // Fields
        private UnityEngine.KeyCode KeySafeArea;
        private Crystal.SafeArea.SimDevice[] Sims;
        private int SimIdx;
        
        // Methods
        private void Awake()
        {
            if(UnityEngine.Application.isEditor != true)
            {
                    UnityEngine.Object.Destroy(obj:  this);
            }
            
            if((System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != null)
            {
                    if(X0 == false)
            {
                goto label_9;
            }
            
            }
            
            this.Sims = null;
            return;
            label_9:
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  this.KeySafeArea)) == false)
            {
                    return;
            }
            
            this.ToggleSafeArea();
        }
        private void ToggleSafeArea()
        {
            int val_2;
            int val_3;
            var val_4;
            val_2 = this.SimIdx + 1;
            this.SimIdx = val_2;
            val_3 = this.Sims.Length;
            if(val_2 >= val_3)
            {
                    this.SimIdx = 0;
                val_3 = this.Sims.Length;
                val_2 = 0;
            }
            
            val_4 = null;
            val_4 = null;
            Crystal.SafeArea.Sim = this.Sims[0];
            object[] val_1 = new object[2];
            val_1[0] = this.Sims[(this.SimIdx) << 2];
            val_1[1] = this.KeySafeArea;
            UnityEngine.Debug.LogFormat(format:  "Switched to sim device {0} with debug key \'{1}\'", args:  val_1);
        }
        public SafeAreaDemo()
        {
            this.KeySafeArea = 97;
        }
    
    }

}
