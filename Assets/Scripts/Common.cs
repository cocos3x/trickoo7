using UnityEngine;
public class Common
{
    // Methods
    public static void Log(object message)
    {
        UnityEngine.Debug.Log(message:  message);
    }
    public static void Log(string format, object[] args)
    {
        UnityEngine.Debug.Log(message:  System.String.Format(format:  format, args:  args));
    }
    public static void LogWarning(object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.LogWarning(message:  message, context:  context);
    }
    public static void LogWarning(UnityEngine.Object context, string format, object[] args)
    {
        UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  format, args:  args), context:  context);
    }
    public static void Warning(bool condition, object message)
    {
        if(condition != false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  message);
    }
    public static void Warning(bool condition, object message, UnityEngine.Object context)
    {
        if(condition != false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  message, context:  context);
    }
    public static void Warning(bool condition, UnityEngine.Object context, string format, object[] args)
    {
        if(condition != false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  format, args:  args), context:  context);
    }
    public static void Assert(bool condition)
    {
        if(condition == false)
        {
                throw new UnityEngine.UnityException();
        }
    
    }
    public static void Assert(bool condition, string message)
    {
        if(condition == false)
        {
                throw new UnityEngine.UnityException(message:  message);
        }
    
    }
    public static void Assert(bool condition, string format, object[] args)
    {
        if(condition == false)
        {
                throw new UnityEngine.UnityException(message:  System.String.Format(format:  format, args:  args));
        }
    
    }
    public Common()
    {
    
    }

}
