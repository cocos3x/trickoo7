using UnityEngine;
public class TimerManager : LazySingleton<TimerManager>
{
    // Methods
    public static UnityEngine.Coroutine DelayCall(float time, System.Action callback, bool isRepeat = False)
    {
        return LazySingleton<TimerManager>.Instance.StartCoroutine(routine:  LazySingleton<TimerManager>.Instance.DOAction(time:  time, callback:  callback, isRepeat:  isRepeat));
    }
    public static void StopDelayCall(UnityEngine.Coroutine coroutine)
    {
        if(coroutine == null)
        {
                return;
        }
        
        if((LazySingleton<TimerManager>.Instance) == 0)
        {
                return;
        }
        
        LazySingleton<TimerManager>.Instance.StopCoroutine(routine:  coroutine);
    }
    private System.Collections.IEnumerator DOAction(float time, System.Action callback, bool isRepeat)
    {
        .<>1__state = 0;
        .time = time;
        .callback = callback;
        .isRepeat = isRepeat;
        return (System.Collections.IEnumerator)new TimerManager.<DOAction>d__2();
    }
    public TimerManager()
    {
    
    }

}
