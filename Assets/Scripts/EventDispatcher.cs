using UnityEngine;
public class EventDispatcher : LazySingleton<EventDispatcher>
{
    // Fields
    private System.Collections.Generic.Dictionary<EventID, System.Action<object>> _earlyListeners;
    private System.Collections.Generic.Dictionary<EventID, System.Action<object>> _lateListeners;
    private System.Collections.Generic.Dictionary<EventID, System.Action<object>> _normalListeners;
    
    // Methods
    public void RegisterListener(EventID eventID, System.Action<object> callback, EventType eventType = 1)
    {
        if(eventType == 2)
        {
            goto label_0;
        }
        
        if(eventType == 1)
        {
            goto label_1;
        }
        
        if(eventType != 0)
        {
                return;
        }
        
        this.RegisterListener(listener:  this._earlyListeners, eventID:  eventID, callback:  callback);
        return;
        label_0:
        this.RegisterListener(listener:  this._lateListeners, eventID:  eventID, callback:  callback);
        return;
        label_1:
        this.RegisterListener(listener:  this._normalListeners, eventID:  eventID, callback:  callback);
    }
    private void RegisterListener(System.Collections.Generic.Dictionary<EventID, System.Action<object>> listener, EventID eventID, System.Action<object> callback)
    {
        if((listener.ContainsKey(key:  eventID)) != true)
        {
                listener.Add(key:  eventID, value:  0);
        }
        
        System.Delegate val_3 = System.Delegate.Combine(a:  listener.Item[eventID], b:  callback);
        if(val_3 != null)
        {
                if(null != null)
        {
            goto label_4;
        }
        
        }
        
        listener.set_Item(key:  eventID, value:  val_3);
        return;
        label_4:
    }
    public void PostEvent(EventID eventID, object param)
    {
        this.PostEvent(listener:  this._earlyListeners, eventID:  eventID, param:  param);
        this.PostEvent(listener:  this._normalListeners, eventID:  eventID, param:  param);
        this.PostEvent(listener:  this._lateListeners, eventID:  eventID, param:  param);
    }
    private void PostEvent(System.Collections.Generic.Dictionary<EventID, System.Action<object>> listener, EventID eventID, object param)
    {
        if((listener.ContainsKey(key:  eventID)) == false)
        {
                return;
        }
        
        System.Action<System.Object> val_2 = listener.Item[eventID];
        if(val_2 != null)
        {
                val_2.Invoke(obj:  param);
            return;
        }
        
        bool val_3 = listener.Remove(key:  eventID);
    }
    public void RemoveListener(EventID eventID, System.Action<object> callback)
    {
        this.RemoveListener(listener:  this._earlyListeners, eventID:  eventID, callback:  callback);
        this.RemoveListener(listener:  this._normalListeners, eventID:  eventID, callback:  callback);
        this.RemoveListener(listener:  this._lateListeners, eventID:  eventID, callback:  callback);
    }
    private void RemoveListener(System.Collections.Generic.Dictionary<EventID, System.Action<object>> listener, EventID eventID, System.Action<object> callback)
    {
        if((listener.ContainsKey(key:  eventID)) == false)
        {
                return;
        }
        
        System.Delegate val_3 = System.Delegate.Remove(source:  listener.Item[eventID], value:  callback);
        if(val_3 != null)
        {
                if(null != null)
        {
            goto label_4;
        }
        
        }
        
        listener.set_Item(key:  eventID, value:  val_3);
        return;
        label_4:
    }
    public void ClearAllListener()
    {
        this._earlyListeners.Clear();
        this._normalListeners.Clear();
        this._lateListeners.Clear();
    }
    public EventDispatcher()
    {
        this._earlyListeners = new System.Collections.Generic.Dictionary<EventID, System.Action<System.Object>>();
        this._lateListeners = new System.Collections.Generic.Dictionary<EventID, System.Action<System.Object>>();
        this._normalListeners = new System.Collections.Generic.Dictionary<EventID, System.Action<System.Object>>();
    }

}
