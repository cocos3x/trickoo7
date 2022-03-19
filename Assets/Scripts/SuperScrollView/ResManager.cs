using UnityEngine;

namespace SuperScrollView
{
    public class ResManager : MonoBehaviour
    {
        // Fields
        public UnityEngine.Sprite[] spriteObjArray;
        private static SuperScrollView.ResManager instance;
        private string[] mWordList;
        private System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> spriteObjDict;
        
        // Properties
        public static SuperScrollView.ResManager Get { get; }
        public int SpriteCount { get; }
        
        // Methods
        public static SuperScrollView.ResManager get_Get()
        {
            var val_3;
            SuperScrollView.ResManager val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = SuperScrollView.ResManager.instance;
            if(val_4 == 0)
            {
                    val_5 = null;
                val_4 = UnityEngine.Object.FindObjectOfType<SuperScrollView.ResManager>();
                val_5 = null;
                SuperScrollView.ResManager.instance = val_4;
            }
            
            val_6 = null;
            val_6 = null;
            return (SuperScrollView.ResManager)SuperScrollView.ResManager.instance;
        }
        private void InitData()
        {
            this.spriteObjDict.Clear();
            if(this.spriteObjArray.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                UnityEngine.Sprite val_2 = this.spriteObjArray[val_3];
                this.spriteObjDict.set_Item(key:  val_2.name, value:  val_2);
                val_3 = val_3 + 1;
            }
            while(val_3 < this.spriteObjArray.Length);
        
        }
        private void Awake()
        {
            null = null;
            SuperScrollView.ResManager.instance = 0;
            this.InitData();
        }
        public UnityEngine.Sprite GetSpriteByName(string spriteName)
        {
            UnityEngine.Sprite val_1 = 0;
            return (UnityEngine.Sprite)((this.spriteObjDict.TryGetValue(key:  spriteName, value: out  val_1)) != true) ? (val_1) : 0;
        }
        public string GetRandomSpriteName()
        {
            return this.spriteObjArray[UnityEngine.Random.Range(min:  0, max:  this.spriteObjArray.Length)].name;
        }
        public int get_SpriteCount()
        {
            if(this.spriteObjArray != null)
            {
                    return (int)this.spriteObjArray.Length;
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Sprite GetSpriteByIndex(int index)
        {
            UnityEngine.Sprite val_1;
            if(((index & 2147483648) == 0) && (this.spriteObjArray.Length > index))
            {
                    val_1 = this.spriteObjArray[index];
                return (UnityEngine.Sprite)val_1;
            }
            
            val_1 = 0;
            return (UnityEngine.Sprite)val_1;
        }
        public string GetSpriteNameByIndex(int index)
        {
            if((index & 2147483648) != 0)
            {
                    return "";
            }
            
            if(this.spriteObjArray.Length <= index)
            {
                    return "";
            }
            
            return this.spriteObjArray[index].name;
        }
        public ResManager()
        {
            this.spriteObjDict = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Sprite>();
        }
        private static ResManager()
        {
        
        }
    
    }

}
