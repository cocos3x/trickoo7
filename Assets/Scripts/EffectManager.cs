using UnityEngine;
public class EffectManager : MonoBehaviour
{
    // Fields
    private static EffectManager instance;
    private UnityEngine.GameObject efxWin;
    
    // Methods
    private void Awake()
    {
        EffectManager.instance = this;
    }
    public static void SpawnEfxWin()
    {
        SetActive(value:  true);
    }
    public EffectManager()
    {
    
    }

}
