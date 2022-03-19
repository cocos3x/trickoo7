using UnityEngine;
public class SROptions : INotifyPropertyChanged
{
    // Fields
    private static readonly SROptions _current;
    private SROptionsPropertyChanged PropertyChanged;
    private System.ComponentModel.PropertyChangedEventHandler InterfacePropertyChangedEventHandler;
    
    // Properties
    public static SROptions Current { get; }
    
    // Methods
    public static SROptions get_Current()
    {
        null = null;
        return (SROptions)SROptions._current;
    }
    public static void OnStartup()
    {
        var val_2 = null;
        SRF.Service.SRServiceManager.GetService<SRDebugger.Internal.InternalOptionsRegistry>().AddOptionContainer(obj:  SROptions._current);
    }
    public void add_PropertyChanged(SROptionsPropertyChanged value)
    {
        do
        {
            if((System.Delegate.Combine(a:  this.PropertyChanged, b:  value)) != null)
        {
                if(null != null)
        {
            goto label_2;
        }
        
        }
        
        }
        while(this.PropertyChanged != 1152921513513310512);
        
        return;
        label_2:
    }
    public void remove_PropertyChanged(SROptionsPropertyChanged value)
    {
        do
        {
            if((System.Delegate.Remove(source:  this.PropertyChanged, value:  value)) != null)
        {
                if(null != null)
        {
            goto label_2;
        }
        
        }
        
        }
        while(this.PropertyChanged != 1152921513513447088);
        
        return;
        label_2:
    }
    public void OnPropertyChanged(string propertyName)
    {
        if(this.PropertyChanged != null)
        {
                this.PropertyChanged.Invoke(sender:  this, propertyName:  propertyName);
        }
        
        if(this.InterfacePropertyChangedEventHandler == null)
        {
                return;
        }
        
        this.InterfacePropertyChangedEventHandler.Invoke(sender:  this, e:  new System.ComponentModel.PropertyChangedEventArgs(propertyName:  propertyName));
    }
    private void add_InterfacePropertyChangedEventHandler(System.ComponentModel.PropertyChangedEventHandler value)
    {
        do
        {
            if((System.Delegate.Combine(a:  this.InterfacePropertyChangedEventHandler, b:  value)) != null)
        {
                if(null != null)
        {
            goto label_2;
        }
        
        }
        
        }
        while(this.InterfacePropertyChangedEventHandler != 1152921513513728440);
        
        return;
        label_2:
    }
    private void remove_InterfacePropertyChangedEventHandler(System.ComponentModel.PropertyChangedEventHandler value)
    {
        do
        {
            if((System.Delegate.Remove(source:  this.InterfacePropertyChangedEventHandler, value:  value)) != null)
        {
                if(null != null)
        {
            goto label_2;
        }
        
        }
        
        }
        while(this.InterfacePropertyChangedEventHandler != 1152921513513865016);
        
        return;
        label_2:
    }
    private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
    {
        this.add_InterfacePropertyChangedEventHandler(value:  value);
    }
    private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
    {
        this.remove_InterfacePropertyChangedEventHandler(value:  value);
    }
    public SROptions()
    {
    
    }
    private static SROptions()
    {
        SROptions._current = new SROptions();
    }

}
