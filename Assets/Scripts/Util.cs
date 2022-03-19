using UnityEngine;
public static class Util
{
    // Methods
    public static bool InternetConnection()
    {
        var val_3;
        UnityEngine.Networking.UnityWebRequest val_1 = new UnityEngine.Networking.UnityWebRequest(url:  "http://google.com");
        if(UnityEngine.Application.internetReachability != 0)
        {
                UnityEngine.Debug.LogWarning(message:  "Have internet connection");
            val_3 = 1;
            return (bool)val_3;
        }
        
        UnityEngine.Debug.LogWarning(message:  "No internet connection");
        val_3 = 0;
        return (bool)val_3;
    }
    public static void DisplaySpineAnim(string animName, Spine.Unity.SkeletonAnimation anim, bool isLoop = True, float timeScale = 1)
    {
        Spine.AnimationState val_3;
        if(anim == null)
        {
                throw new NullReferenceException();
        }
        
        val_3 = anim.state;
        if(val_3 == null)
        {
                throw new NullReferenceException();
        }
        
        if((val_3.SetAnimation(trackIndex:  0, animationName:  animName, loop:  isLoop)) == null)
        {
                throw new NullReferenceException();
        }
        
        val_2.timeScale = timeScale;
    }
    public static float GetSpineAnimDuration(string animName, Spine.Unity.SkeletonAnimation anim)
    {
        Spine.SkeletonData val_4;
        string val_5;
        if(anim == null)
        {
                throw new NullReferenceException();
        }
        
        val_5 = 0;
        if(anim.Skeleton == null)
        {
                throw new NullReferenceException();
        }
        
        val_4 = val_1.data;
        if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
        val_5 = animName;
        if((val_4.FindAnimation(animationName:  val_5)) == null)
        {
                throw new NullReferenceException();
        }
        
        return (float)(val_2.duration >= 0f) ? val_2.duration : 0f;
    }
    public static void DisplaySpineAnim(string animName, Spine.Unity.SkeletonGraphic anim, bool isLoop = True, float timeScale = 1)
    {
        Spine.AnimationState val_3;
        if(anim == null)
        {
                throw new NullReferenceException();
        }
        
        val_3 = anim.state;
        if(val_3 == null)
        {
                throw new NullReferenceException();
        }
        
        if((val_3.SetAnimation(trackIndex:  0, animationName:  animName, loop:  isLoop)) == null)
        {
                throw new NullReferenceException();
        }
        
        val_2.timeScale = timeScale;
    }
    public static float GetSpineAnimDuration(string animName, Spine.Unity.SkeletonGraphic anim)
    {
        Spine.SkeletonData val_3;
        if(anim == null)
        {
                throw new NullReferenceException();
        }
        
        if(anim.skeleton == null)
        {
                throw new NullReferenceException();
        }
        
        val_3 = anim.skeleton.data;
        if(val_3 == null)
        {
                throw new NullReferenceException();
        }
        
        if((val_3.FindAnimation(animationName:  animName)) == null)
        {
                throw new NullReferenceException();
        }
        
        return (float)(val_1.duration >= 0f) ? val_1.duration : 0f;
    }

}
