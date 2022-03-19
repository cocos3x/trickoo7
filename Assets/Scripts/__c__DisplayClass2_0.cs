using UnityEngine;
private sealed class MenuSceneScript.<>c__DisplayClass2_0
{
    // Fields
    public SuperScrollView.SceneNameInfo info;
    
    // Methods
    public MenuSceneScript.<>c__DisplayClass2_0()
    {
    
    }
    internal void <Start>b__0()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  this.info.mSceneName);
    }

}
