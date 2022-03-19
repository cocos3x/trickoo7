using UnityEngine;

namespace SuperScrollView
{
    public class RotateScript : MonoBehaviour
    {
        // Fields
        public float speed;
        
        // Methods
        private void Update()
        {
            UnityEngine.Vector3 val_3 = this.gameObject.transform.localEulerAngles;
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = this.speed * val_4;
            val_3.z = val_3.z + val_4;
            this.gameObject.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public RotateScript()
        {
            this.speed = 1f;
        }
    
    }

}
