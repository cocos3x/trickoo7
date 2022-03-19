using UnityEngine;
private sealed class Json.Parser : IDisposable
{
    // Fields
    private const string WORD_BREAK = "{}[],:\"";
    private System.IO.StringReader json;
    
    // Properties
    private char PeekChar { get; }
    private char NextChar { get; }
    private string NextWord { get; }
    private AFMiniJSON.Json.Parser.TOKEN NextToken { get; }
    
    // Methods
    public static bool IsWordBreak(char c)
    {
        var val_4;
        if((System.Char.IsWhiteSpace(c:  c)) == false)
        {
                return (bool)((IndexOf(value:  c)) != 1) ? 1 : 0;
        }
        
        val_4 = 1;
        return (bool)((IndexOf(value:  c)) != 1) ? 1 : 0;
    }
    private Json.Parser(string jsonString)
    {
        this.json = new System.IO.StringReader(s:  jsonString);
    }
    public static object Parse(string jsonString)
    {
        Json.Parser val_1 = new Json.Parser(jsonString:  jsonString);
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_1.Dispose();
        if(0 != 0)
        {
                throw ???;
        }
        
        return (object)val_1.ParseByToken(token:  val_1.NextToken);
    }
    public void Dispose()
    {
        this.json.Dispose();
        this.json = 0;
    }
    private System.Collections.Generic.Dictionary<string, object> ParseObject()
    {
        var val_7;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = null;
        val_7 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        goto label_6;
        label_9:
        if(this.NextToken != 5)
        {
            goto label_7;
        }
        
        val_1.set_Item(key:  this.json, value:  this.ParseByToken(token:  this.NextToken));
        do
        {
            label_6:
            TOKEN val_5 = this.NextToken;
        }
        while(val_5 == 6);
        
        if(val_5 == 0)
        {
            goto label_7;
        }
        
        if(val_5 == 2)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_7;
        }
        
        if(this.ParseString() != null)
        {
            goto label_9;
        }
        
        label_7:
        val_7 = 0;
        return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_7;
    }
    private System.Collections.Generic.List<object> ParseArray()
    {
        goto label_5;
    }
    private object ParseValue()
    {
        return this.ParseByToken(token:  this.NextToken);
    }
    private object ParseByToken(AFMiniJSON.Json.Parser.TOKEN token)
    {
        var val_10 = 0;
        if((token - 1) > 9)
        {
                return (object);
        }
        
        var val_10 = 20143072 + ((token - 1)) << 2;
        val_10 = val_10 + 20143072;
        goto (20143072 + ((token - 1)) << 2 + 20143072);
    }
    private string ParseString()
    {
        char val_14;
        label_14:
        if(this.json == 1)
        {
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        
        char val_2 = this.NextChar;
        char val_3 = val_2 & 65535;
        if(val_3 == '\')
        {
            goto label_4;
        }
        
        if(val_3 == '"')
        {
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        
        val_14 = val_2;
        goto label_29;
        label_4:
        if(this.json == 1)
        {
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        
        char val_4 = this.NextChar;
        char val_5 = val_4 & 65535;
        val_14 = val_4;
        if(val_5 > '\')
        {
            goto label_10;
        }
        
        val_5 = val_5 - 34;
        if(val_5 > (':'))
        {
            goto label_21;
        }
        
        val_5 = 1 << val_5;
        if((val_5 & ' ') != 0)
        {
            goto label_21;
        }
        
        label_29:
        System.Text.StringBuilder val_6 = new System.Text.StringBuilder().Append(value:  val_14);
        label_21:
        if(this.json != null)
        {
            goto label_14;
        }
        
        label_10:
        if(val_5 > 'f')
        {
            goto label_16;
        }
        
        char val_7 = val_14 & 65535;
        if(val_7 == 'b')
        {
            goto label_29;
        }
        
        if(val_7 != 'f')
        {
            goto label_21;
        }
        
        goto label_29;
        label_16:
        char val_8 = val_14 & 65535;
        val_8 = val_8 - 110;
        if(val_8 > '')
        {
            goto label_21;
        }
        
        var val_14 = 20143040 + (((val_4 & 65535) - 110)) << 2;
        val_14 = val_14 + 20143040;
        goto (20143040 + (((val_4 & 65535) - 110)) << 2 + 20143040);
    }
    private object ParseNumber()
    {
        var val_7;
        var val_8;
        long val_5 = 0;
        string val_1 = this.NextWord;
        if((val_1.IndexOf(value:  '.')) != 1)
        {
                bool val_4 = System.Double.TryParse(s:  val_1, result: out  double val_3 = 1.28823235616651E-231);
            val_7 = 0;
            val_8 = null;
            return (object)0;
        }
        
        bool val_6 = System.Int64.TryParse(s:  val_1, result: out  val_5);
        val_7 = val_5;
        val_8 = null;
        return (object)0;
    }
    private void EatWhitespace()
    {
        do
        {
            if((System.Char.IsWhiteSpace(c:  this.PeekChar)) == false)
        {
                return;
        }
        
        }
        while(this.json != 1);
    
    }
    private char get_PeekChar()
    {
        return System.Convert.ToChar(value:  this.json);
    }
    private char get_NextChar()
    {
        return System.Convert.ToChar(value:  this.json);
    }
    private string get_NextWord()
    {
        var val_6;
        System.Text.StringBuilder val_1 = null;
        val_6 = 0;
        val_1 = new System.Text.StringBuilder();
        label_4:
        if((Json.Parser.IsWordBreak(c:  this.PeekChar)) == true)
        {
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        
        System.Text.StringBuilder val_5 = val_1.Append(value:  this.NextChar);
        if(this.json != 1)
        {
            goto label_4;
        }
        
        goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
    }
    private AFMiniJSON.Json.Parser.TOKEN get_NextToken()
    {
        var val_9;
        this.EatWhitespace();
        if(this.json == 1)
        {
            goto label_2;
        }
        
        char val_2 = this.PeekChar & 65535;
        if(val_2 > '[')
        {
            goto label_3;
        }
        
        if((val_2 - 34) > '')
        {
            goto label_4;
        }
        
        var val_9 = 20142940;
        val_9 = (20142940 + (((val_1 & 65535) - 34)) << 2) + val_9;
        goto (20142940 + (((val_1 & 65535) - 34)) << 2 + 20142940);
        label_2:
        val_9 = 0;
        return (TOKEN)val_9;
        label_3:
        if(val_2 == ']')
        {
                return (TOKEN)val_9;
        }
        
        if(val_2 == '{')
        {
                return (TOKEN)val_9;
        }
        
        if(val_2 != '}')
        {
            goto label_14;
        }
        
        return (TOKEN)val_9;
        label_4:
        if(val_2 == '[')
        {
                return (TOKEN)val_9;
        }
        
        label_14:
        string val_4 = this.NextWord;
        if((System.String.op_Equality(a:  val_4, b:  "false")) != false)
        {
                return (TOKEN)val_9;
        }
        
        if((System.String.op_Equality(a:  val_4, b:  "true")) != false)
        {
                return (TOKEN)val_9;
        }
        
        var val_8 = ((System.String.op_Equality(a:  val_4, b:  "null")) != true) ? 11 : 0;
        return (TOKEN)val_9;
    }

}
