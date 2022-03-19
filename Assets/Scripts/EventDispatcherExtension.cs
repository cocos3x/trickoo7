using UnityEngine;
public static class EventDispatcherExtension
{
    // Methods
    public static void RegisterListener(UnityEngine.MonoBehaviour listener, EventID eventID, System.Action<object> callback, EventType eventType = 1)
    {
        LazySingleton<EventDispatcher>.Instance.RegisterListener(eventID:  eventID, callback:  callback, eventType:  eventType);
    }
    public static void PostEvent(UnityEngine.MonoBehaviour listener, EventID eventID, object param)
    {
        LazySingleton<EventDispatcher>.Instance.PostEvent(eventID:  eventID, param:  param);
    }
    public static void PostEvent(UnityEngine.MonoBehaviour sender, EventID eventID)
    {
        LazySingleton<EventDispatcher>.Instance.PostEvent(eventID:  eventID, param:  0);
    }

}
