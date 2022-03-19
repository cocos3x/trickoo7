using UnityEngine;
private sealed class LevelDrag.<PlayAnimInOrder>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Collections.Generic.List<Spine.Unity.SkeletonAnimation> anims;
    public LevelDrag <>4__this;
    private System.Collections.Generic.List<System.Collections.Generic.List<Spine.Unity.SkeletonAnimation>> <anims2>5__2;
    private System.Collections.Generic.List.Enumerator<System.Collections.Generic.List<Spine.Unity.SkeletonAnimation>> <>7__wrap2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelDrag.<PlayAnimInOrder>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 2)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_4;
        List.Enumerator<System.Collections.Generic.List<Spine.Unity.SkeletonAnimation>> val_5;
        var val_43;
        LevelDrag.<PlayAnimInOrder>d__22 val_44;
        LevelDrag val_45;
        System.Collections.Generic.List<Spine.Unity.SkeletonAnimation> val_46;
        var val_47;
        var val_48;
        UnityEngine.Object val_49;
        var val_50;
        int val_51;
        var val_52;
        float val_53;
        float val_58;
        val_44 = this;
        val_45 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        System.Collections.Generic.List<System.Collections.Generic.List<Spine.Unity.SkeletonAnimation>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<Spine.Unity.SkeletonAnimation>>();
        this.<anims2>5__2 = val_1;
        val_43 = 1152921504680329216;
        System.Collections.Generic.List<Spine.Unity.SkeletonAnimation> val_2 = null;
        val_46 = val_2;
        val_2 = new System.Collections.Generic.List<Spine.Unity.SkeletonAnimation>();
        if((this.<anims2>5__2) == null)
        {
                throw new NullReferenceException();
        }
        
        val_47 = 1152921513445573280;
        this.<anims2>5__2.Add(item:  val_2);
        if(this.anims == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_3 = this.anims.GetEnumerator();
        val_44 = 1152921513418366288;
        val_48 = 1152921504729477120;
        label_13:
        if(val_5.MoveNext() == false)
        {
            goto label_6;
        }
        
        val_49 = val_4;
        if((UnityEngine.Object.op_Implicit(exists:  val_49)) == false)
        {
            goto label_9;
        }
        
        if(val_46 == null)
        {
                throw new NullReferenceException();
        }
        
        val_2.Add(item:  val_49);
        goto label_13;
        label_9:
        System.Collections.Generic.List<Spine.Unity.SkeletonAnimation> val_8 = null;
        val_46 = val_8;
        val_8 = new System.Collections.Generic.List<Spine.Unity.SkeletonAnimation>();
        if((this.<anims2>5__2) == null)
        {
                throw new NullReferenceException();
        }
        
        val_1.Add(item:  val_8);
        goto label_13;
        label_2:
        this.<>1__state = 0;
        if(val_45 == null)
        {
                throw new NullReferenceException();
        }
        
        if(19269 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_49 = 1152921513418376528;
        List.Enumerator<T> val_9 = 19269.GetEnumerator();
        val_43 = 1152921513418377552;
        label_19:
        if(val_5.MoveNext() == false)
        {
            goto label_16;
        }
        
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_11 = val_4.gameObject;
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        val_11.SetActive(value:  false);
        goto label_19;
        label_1:
        val_46 = this.<>7__wrap2;
        val_43 = 0;
        this.<>1__state = -3;
        goto label_20;
        label_16:
        val_46 = 0;
        val_47 = 1152921513418382672;
        val_5.Dispose();
        if(val_46 != 0)
        {
                throw X20;
        }
        
        if(0 == 1)
        {
            goto label_22;
        }
        
        var val_12 = (268 == 268) ? -1 : 0;
        goto label_23;
        label_6:
        val_46 = 0;
        val_44 = val_44;
        val_5.Dispose();
        if(val_46 != 0)
        {
                throw X20;
        }
        
        if(val_45 == null)
        {
                throw new NullReferenceException();
        }
        
        if((this.<>4__this.mainDrag) == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_13 = this.<>4__this.mainDrag.gameObject;
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        Spine.Unity.SkeletonAnimation val_14 = val_13.GetComponent<Spine.Unity.SkeletonAnimation>();
        val_51 = 1;
        mem[1152921513445674104] = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_51;
        return (bool)val_51;
        label_22:
        val_50 = 0;
        label_23:
        if(val_5 == 0)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_16 = val_5.GetEnumerator();
        label_33:
        if(val_5.MoveNext() == false)
        {
            goto label_30;
        }
        
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_18 = val_4.gameObject;
        if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
        val_18.SetActive(value:  true);
        goto label_33;
        label_30:
        val_46 = 0;
        val_52 = 0 + 1;
        mem2[0] = 326;
        val_5.Dispose();
        if(val_46 != 0)
        {
                throw X20;
        }
        
        if(val_52 != 1)
        {
                var val_19 = ((1152921513445661776 + ((0 + 1)) << 2) == 326) ? 1 : 0;
            val_19 = ((val_52 >= 0) ? 1 : 0) & val_19;
            val_52 = val_52 - val_19;
        }
        
        mem2[0] = 0;
        this.<>4__this.isAnimPlaying = true;
        if((this.<anims2>5__2) == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_21 = this.<anims2>5__2.GetEnumerator();
        val_44 = 1152921513445614240;
        val_48 = 1152921513418365264;
        val_49 = "2";
        val_43 = 1152921513418371408;
        val_47 = 469;
        label_48:
        if(val_5.MoveNext() == false)
        {
            goto label_37;
        }
        
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_23 = val_4.GetEnumerator();
        val_53 = 0f;
        goto label_39;
        label_44:
        float val_42 = val_23.current + 40;
        label_39:
        if(val_5.MoveNext() == false)
        {
            goto label_40;
        }
        
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        if(val_4.Skeleton == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_26.data == null)
        {
                throw new NullReferenceException();
        }
        
        if((val_26.data.FindAnimation(animationName:  "2")) != null)
        {
            goto label_44;
        }
        
        throw new NullReferenceException();
        label_40:
        val_52 = val_52 + 1;
        val_46 = 0;
        mem2[0] = 469;
        val_5.Dispose();
        if(val_46 != 0)
        {
                throw X20;
        }
        
        if(val_52 != 1)
        {
                var val_28 = ((1152921513445661776 + ((((0 + 1) - (val_52 >= 0x0 ? 1 : 0 & 1152921513445661776 + ((0 + 1)) << 2 == 0x146 ? 1 : 0)) + 1)) << 2) == 469) ? 1 : 0;
            val_28 = ((val_52 >= 0) ? 1 : 0) & val_28;
            val_52 = val_52 - val_28;
        }
        
        val_42 = ((val_42 >= val_53) ? (val_42) : (val_53)) + val_42;
        mem2[0] = val_42;
        goto label_48;
        label_37:
        val_52 = val_52 + 1;
        val_46 = 0;
        mem2[0] = 512;
        val_44 = val_44;
        val_5.Dispose();
        if(val_46 != 0)
        {
                throw X20;
        }
        
        if(val_52 != 1)
        {
                var val_30 = ((1152921513445661776 + ((((0 + 1) - (val_52 >= 0x0 ? 1 : 0 & 1152921513445661776 + ((0 + 1)) << 2 == 0x146 ? 1 : 0)) + 1)) << 2) == 512) ? 1 : 0;
            val_30 = ((val_52 >= 0) ? 1 : 0) & val_30;
            val_43 = val_52 - val_30;
        }
        else
        {
                val_43 = 0;
        }
        
        List.Enumerator<T> val_32 = val_1.GetEnumerator();
        val_46 = 1152921513445674136;
        mem[1152921513445674152] = val_4;
        this.<>7__wrap2 = val_5;
        this.<>1__state = -3;
        label_20:
        if((new List.Enumerator<System.Collections.Generic.List<Spine.Unity.SkeletonAnimation>>().MoveNext()) == false)
        {
            goto label_70;
        }
        
        if(mem[1152921513445674152] == 0)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_34 = mem[1152921513445674152].GetEnumerator();
        val_49 = 1152921513418366288;
        val_45 = "2";
        val_58 = 0f;
        goto label_72;
        label_78:
        val_46 = val_4;
        if(val_46 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_4 + 224) == 0)
        {
                throw new NullReferenceException();
        }
        
        Spine.TrackEntry val_35 = val_4 + 224.SetAnimation(trackIndex:  0, animationName:  "2", loop:  false);
        if(val_46.Skeleton == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_36.data == null)
        {
                throw new NullReferenceException();
        }
        
        if((val_36.data.FindAnimation(animationName:  "2")) == null)
        {
                throw new NullReferenceException();
        }
        
        label_72:
        if(val_5.MoveNext() == true)
        {
            goto label_78;
        }
        
        var val_40 = val_43 + 1;
        val_46 = 0;
        mem2[0] = 676;
        val_5.Dispose();
        if(val_46 != 0)
        {
                throw X20;
        }
        
        mem[1152921513445674104] = new UnityEngine.WaitForSeconds(seconds:  (val_37.duration >= val_58) ? val_37.duration : (val_58));
        this.<>1__state = 2;
        val_51 = 1;
        return (bool)val_51;
        label_70:
        this.<>m__Finally1();
        this.<>7__wrap2 = 0;
        mem[1152921513445674144] = 0;
        mem[1152921513445674152] = 0;
        if(val_45 == null)
        {
                throw new NullReferenceException();
        }
        
        val_51 = 0;
        this.<>4__this.isAnimPlaying = false;
        return (bool)val_51;
        label_3:
        val_51 = 0;
        return (bool)val_51;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap2.Dispose();
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
