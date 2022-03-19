using UnityEngine;
private sealed class ObjectPool.<RemovePooledByNameCoroutine>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string objName;
    private ObjectPool.<>c__DisplayClass42_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ObjectPool.<RemovePooledByNameCoroutine>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_14;
        object val_15;
        object val_34;
        int val_35;
        UnityEngine.GameObject val_36;
        UnityEngine.Object val_37;
        var val_38;
        var val_39;
        System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>>, UnityEngine.GameObject> val_41;
        int val_42;
        int val_43;
        var val_44;
        var val_45;
        val_34 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new ObjectPool.<>c__DisplayClass42_0();
        .objName = this.objName;
        val_35 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.05f);
        this.<>1__state = val_35;
        return (bool)val_35;
        label_1:
        this.<>1__state = 0;
        val_36 = ObjectPool.instance.transform.childCount;
        System.Collections.Generic.List<UnityEngine.GameObject> val_6 = null;
        val_37 = val_6;
        val_6 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        if(val_36 >= 1)
        {
                object val_33 = 0;
            do
        {
            ObjectPool val_7 = ObjectPool.instance;
            if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
            UnityEngine.Transform val_8 = val_7.transform;
            if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
            UnityEngine.Transform val_9 = val_8.GetChild(index:  0);
            if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
            string val_10 = val_9.name;
            if((this.<>8__1) == null)
        {
                throw new NullReferenceException();
        }
        
            if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
            if((val_10.Contains(value:  this.<>8__1.objName)) != false)
        {
                if(val_37 == null)
        {
                throw new NullReferenceException();
        }
        
            val_6.Add(item:  val_9.gameObject);
        }
        
            val_33 = val_33 + 1;
        }
        while(val_33 < val_36);
        
        }
        
        if(val_37 == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_13 = val_6.GetEnumerator();
        val_36 = 1152921504729477120;
        label_26:
        if(val_15.MoveNext() == false)
        {
            goto label_21;
        }
        
        val_37 = val_14;
        if(val_37 == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Transform val_17 = val_37.transform;
        if(val_17 == null)
        {
                throw new NullReferenceException();
        }
        
        val_17.parent = 0;
        UnityEngine.Object.Destroy(obj:  val_37);
        goto label_26;
        label_21:
        val_36 = 0;
        val_37 = 0;
        val_15.Dispose();
        if(val_36 != 0)
        {
                throw val_36;
        }
        
        if(0 != 1)
        {
                var val_18 = (252 == 252) ? -1 : 0;
        }
        else
        {
                val_38 = 0;
        }
        
        val_37 = 0;
        if(ObjectPool.instance == null)
        {
                throw new NullReferenceException();
        }
        
        val_39 = null;
        val_39 = null;
        val_41 = ObjectPool.<>c.<>9__42_1;
        if(val_41 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>>, UnityEngine.GameObject> val_22 = null;
            val_41 = val_22;
            val_22 = new System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>>, UnityEngine.GameObject>(object:  ObjectPool.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject ObjectPool.<>c::<RemovePooledByNameCoroutine>b__42_1(System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>> x));
            ObjectPool.<>c.<>9__42_1 = val_41;
        }
        
        System.Collections.Generic.List<TSource> val_24 = System.Linq.Enumerable.ToList<UnityEngine.GameObject>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>>, UnityEngine.GameObject>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>>>(source:  val_19.pooledObjects, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>>, System.Boolean>(object:  this.<>8__1, method:  System.Boolean ObjectPool.<>c__DisplayClass42_0::<RemovePooledByNameCoroutine>b__0(System.Collections.Generic.KeyValuePair<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>> x))), selector:  val_22));
        val_36 = val_24;
        val_37 = System.Linq.Enumerable.Count<UnityEngine.GameObject>(source:  val_24);
        if(val_36 == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_26 = val_36.GetEnumerator();
        label_44:
        if(val_15.MoveNext() == false)
        {
            goto label_39;
        }
        
        val_36 = val_14;
        if(ObjectPool.instance == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_28.pooledObjects == null)
        {
                throw new NullReferenceException();
        }
        
        bool val_29 = val_28.pooledObjects.Remove(key:  val_36);
        goto label_44;
        label_39:
        val_36 = 0;
        val_15.Dispose();
        if(val_36 != 0)
        {
                throw val_36;
        }
        
        label_112:
        object[] val_30 = new object[6];
        val_42 = val_30.Length;
        val_30[0] = "--RemovePooledByName \'";
        if((this.<>8__1.objName) != null)
        {
                val_42 = val_30.Length;
        }
        
        val_30[1] = this.<>8__1.objName;
        val_42 = val_30.Length;
        val_30[2] = "\' realObj: ";
        val_15 = val_33;
        val_43 = val_30.Length;
        val_30[3] = val_15;
        val_43 = val_30.Length;
        val_30[4] = "   poolObj: ";
        val_30[5] = val_37;
        val_34 = +val_30;
        UnityEngine.Debug.Log(message:  val_34);
        label_2:
        val_35 = 0;
        return (bool)val_35;
        label_113:
        val_44 = 0;
        val_45 = val_36;
        if(val_44 != 1)
        {
            goto label_107;
        }
        
        if((null & 1) == 0)
        {
            goto label_108;
        }
        
        UnityEngine.Debug.LogError(message:  "GetPooledByName throw exception: "("GetPooledByName throw exception: ") + null + "  " + null);
        goto label_112;
        label_108:
        mem[8] = null;
        goto label_113;
        label_107:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
