using UnityEngine;

namespace SuperScrollView
{
    public class ListItem7 : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text mText;
        public int mValue;
        
        // Properties
        public int Value { get; set; }
        
        // Methods
        public void Init()
        {
        
        }
        public int get_Value()
        {
            return (int)this.mValue;
        }
        public void set_Value(int value)
        {
            this.mValue = value;
        }
        public ListItem7()
        {
        
        }
    
    }

}
