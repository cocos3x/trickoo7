using UnityEngine;
private sealed class Json.Serializer
{
    // Fields
    private System.Text.StringBuilder builder;
    
    // Methods
    private Json.Serializer()
    {
        this.builder = new System.Text.StringBuilder();
    }
    public static string Serialize(object obj)
    {
        new Json.Serializer().SerializeValue(value:  obj);
        goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
    }
    private void SerializeValue(object value)
    {
        System.Text.StringBuilder val_4;
        var val_5;
        val_4 = this;
        if(value == null)
        {
            goto label_1;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        if(null == null)
        {
            goto label_3;
        }
        
        if(X0 == false)
        {
            goto label_4;
        }
        
        this.SerializeArray(anArray:  X0);
        return;
        label_1:
        val_5 = "null";
        goto label_6;
        label_2:
        label_10:
        this.SerializeString(str:  value);
        return;
        label_3:
        val_4 = this.builder;
        label_6:
        System.Text.StringBuilder val_2 = val_4.Append(value:  (null == 0) ? "false" : "true");
        return;
        label_4:
        if(X0 != false)
        {
                this.SerializeObject(obj:  X0);
            return;
        }
        
        if(null != null)
        {
                this.SerializeOther(value:  value);
            return;
        }
        
        string val_3 = 0.CreateString(c:  '瀀', count:  1);
        goto label_10;
    }
    private void SerializeObject(System.Collections.IDictionary obj)
    {
        var val_11;
        var val_14;
        var val_17;
        var val_18;
        var val_20;
        val_11 = obj;
        if(this.builder == null)
        {
                throw new NullReferenceException();
        }
        
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '{');
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        System.Collections.ICollection val_3 = val_11.Keys;
        if(val_3 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_14 = val_3.GetEnumerator();
        label_30:
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(val_14.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_17 = public System.Object System.Collections.IEnumerator::get_Current();
        object val_9 = val_14.Current;
        if((1 & 1) == 0)
        {
                if(this.builder == null)
        {
                throw new NullReferenceException();
        }
        
            val_17 = 44;
            System.Text.StringBuilder val_10 = this.builder.Append(value:  ',');
        }
        
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        this.SerializeString(str:  val_9);
        if(this.builder == null)
        {
                throw new NullReferenceException();
        }
        
        val_18 = 0;
        System.Text.StringBuilder val_11 = this.builder.Append(value:  ':');
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_18 = 0;
        this.SerializeValue(value:  val_11.Item[val_9]);
        goto label_30;
        label_17:
        val_11 = 0;
        if(X0 == false)
        {
            goto label_31;
        }
        
        var val_22 = X0;
        val_14 = X0;
        if((X0 + 294) == 0)
        {
            goto label_35;
        }
        
        var val_20 = X0 + 176;
        var val_21 = 0;
        val_20 = val_20 + 8;
        label_34:
        if(((X0 + 176 + 8) + -8) == null)
        {
            goto label_33;
        }
        
        val_21 = val_21 + 1;
        val_20 = val_20 + 16;
        if(val_21 < (X0 + 294))
        {
            goto label_34;
        }
        
        goto label_35;
        label_33:
        val_22 = val_22 + (((X0 + 176 + 8)) << 4);
        val_20 = val_22 + 304;
        label_35:
        val_14.Dispose();
        label_31:
        if(val_11 != 0)
        {
                throw val_11;
        }
        
        if(this.builder == null)
        {
                throw new NullReferenceException();
        }
        
        System.Text.StringBuilder val_14 = this.builder.Append(value:  '}');
    }
    private void SerializeArray(System.Collections.IList anArray)
    {
        object val_8;
        var val_12;
        if(this.builder == null)
        {
                throw new NullReferenceException();
        }
        
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '[');
        if(anArray == null)
        {
                throw new NullReferenceException();
        }
        
        var val_10 = 0;
        val_10 = val_10 + 1;
        System.Collections.IEnumerator val_3 = anArray.GetEnumerator();
        label_19:
        var val_11 = 0;
        val_11 = val_11 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_8 = val_3.Current;
        if((1 & 1) == 0)
        {
                if(this.builder == null)
        {
                throw new NullReferenceException();
        }
        
            System.Text.StringBuilder val_8 = this.builder.Append(value:  ',');
        }
        
        this.SerializeValue(value:  val_8);
        goto label_19;
        label_12:
        val_8 = 0;
        if(X0 == false)
        {
            goto label_20;
        }
        
        var val_15 = X0;
        if((X0 + 294) == 0)
        {
            goto label_24;
        }
        
        var val_13 = X0 + 176;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_23:
        if(((X0 + 176 + 8) + -8) == null)
        {
            goto label_22;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (X0 + 294))
        {
            goto label_23;
        }
        
        goto label_24;
        label_22:
        val_15 = val_15 + (((X0 + 176 + 8)) << 4);
        val_12 = val_15 + 304;
        label_24:
        X0.Dispose();
        label_20:
        if(val_8 != 0)
        {
                throw val_8;
        }
        
        if(this.builder == null)
        {
                throw new NullReferenceException();
        }
        
        System.Text.StringBuilder val_9 = this.builder.Append(value:  ']');
    }
    private void SerializeString(string str)
    {
        System.Text.StringBuilder val_9;
        string val_10;
        var val_11;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '"');
        System.Char[] val_2 = str.ToCharArray();
        int val_9 = val_2.Length;
        if(val_9 < 1)
        {
            goto label_4;
        }
        
        var val_12 = 0;
        val_9 = val_9 & 4294967295;
        goto label_30;
        label_18:
        System.Text.StringBuilder val_3 = val_2.Append(value:  '');
        goto label_6;
        label_30:
        if(1152921504904953320 > 5)
        {
            goto label_8;
        }
        
        var val_10 = mem[4611686019639956392];
        val_10 = val_10 + 20143112;
        goto (mem[4611686019639956392] + 20143112);
        label_8:
        if(null == 92)
        {
            goto label_11;
        }
        
        if(null != 34)
        {
            goto label_12;
        }
        
        val_10 = "\\\"";
        goto label_22;
        label_12:
        int val_4 = System.Convert.ToInt32(value:  '뷰');
        var val_11 = val_4;
        val_11 = val_11 - 32;
        if(val_11 <= 94)
        {
            goto label_18;
        }
        
        System.Text.StringBuilder val_5 = this.builder.Append(value:  "\\u");
        val_9 = this.builder;
        val_11 = val_4.ToString(format:  "x4");
        goto label_28;
        label_11:
        val_10 = "\\\\";
        label_22:
        label_28:
        System.Text.StringBuilder val_7 = this.builder.Append(value:  val_10);
        label_6:
        val_12 = val_12 + 1;
        if(val_12 < (val_2.Length << ))
        {
            goto label_30;
        }
        
        label_4:
        System.Text.StringBuilder val_8 = this.builder.Append(value:  '"');
    }
    private void SerializeOther(object value)
    {
        System.Text.StringBuilder val_6;
        if(null == null)
        {
            goto label_2;
        }
        
        if((((((((null == null) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null))
        {
            goto label_10;
        }
        
        if((null == null) || (null == null))
        {
            goto label_12;
        }
        
        this.SerializeString(str:  value);
        return;
        label_2:
        val_6 = this.builder;
        string val_1 = null.ToString(format:  "R");
        if(val_6 != null)
        {
            goto label_14;
        }
        
        label_10:
        System.Text.StringBuilder val_2 = this.builder.Append(value:  value);
        return;
        label_12:
        val_6 = this.builder;
        label_14:
        System.Text.StringBuilder val_5 = val_6.Append(value:  System.Convert.ToDouble(value:  value).ToString(format:  "R"));
    }

}
