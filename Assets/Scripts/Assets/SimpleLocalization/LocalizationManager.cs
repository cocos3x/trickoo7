using UnityEngine;

namespace Assets.SimpleLocalization
{
    public static class LocalizationManager
    {
        // Fields
        private static System.Action LocalizationChanged;
        public static readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Dictionary;
        private static string _language;
        
        // Properties
        public static string Language { get; set; }
        
        // Methods
        public static void add_LocalizationChanged(System.Action value)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((System.Delegate.Combine(a:  Assets.SimpleLocalization.LocalizationManager.LocalizationChanged, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            return;
            label_4:
        }
        public static void remove_LocalizationChanged(System.Action value)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((System.Delegate.Remove(source:  Assets.SimpleLocalization.LocalizationManager.LocalizationChanged, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            return;
            label_4:
        }
        public static string get_Language()
        {
            null = null;
            return (string)Assets.SimpleLocalization.LocalizationManager._language;
        }
        public static void set_Language(string value)
        {
            var val_3 = null;
            Assets.SimpleLocalization.LocalizationManager._language = (UnityEngine.Application.platform == 17) ? "English" : value;
            Assets.SimpleLocalization.LocalizationManager.LocalizationChanged.Invoke();
        }
        public static void AutoLanguage()
        {
            Assets.SimpleLocalization.LocalizationManager.Language = "English";
        }
        public static void Read(string path = "Localization")
        {
            string val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_44;
            var val_45;
            System.Func<System.String, System.String> val_47;
            string val_48;
            var val_50;
            var val_51;
            var val_52;
            System.Func<System.String, System.String> val_54;
            var val_55;
            System.Func<System.String, System.String> val_57;
            var val_59;
            val_37 = path;
            val_38 = null;
            val_38 = null;
            if(Assets.SimpleLocalization.LocalizationManager.Dictionary.Count > 0)
            {
                    return;
            }
            
            if(val_2.Length < 1)
            {
                goto label_6;
            }
            
            val_39 = 1152921504896888832;
            label_119:
            string val_5 = Assets.SimpleLocalization.LocalizationManager.ReplaceMarkers(text:  UnityEngine.Resources.LoadAll<UnityEngine.TextAsset>(path:  val_37)[0].text).Replace(oldValue:  "\"\"", newValue:  "[quotes]");
            System.Collections.IEnumerator val_7 = System.Text.RegularExpressions.Regex.Matches(input:  val_5, pattern:  "\"[\\s\\S]+?\"").GetEnumerator();
            label_56:
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_40 = val_5;
            var val_44 = 0;
            val_44 = val_44 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_44;
            }
            
            var val_45 = 0;
            val_45 = val_45 + 1;
            object val_11 = val_7.Current;
            if(val_11 == null)
            {
                    throw new NullReferenceException();
            }
            
            string val_13 = val_11.Value;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            string val_14 = val_13.Replace(oldValue:  "\"", newValue:  0);
            if(val_14 == null)
            {
                    throw new NullReferenceException();
            }
            
            string val_15 = val_14.Replace(oldValue:  ",", newValue:  "[comma]");
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_40 == null)
            {
                    throw new NullReferenceException();
            }
            
            string val_17 = val_40.Replace(oldValue:  val_11.Value, newValue:  val_15.Replace(oldValue:  "\n", newValue:  "[newline]"));
            goto label_56;
            label_44:
            var val_46 = 0;
            val_41 = 0;
            val_46 = val_46 + 1;
            if(X0 == false)
            {
                goto label_57;
            }
            
            var val_49 = X0;
            if((X0 + 294) == 0)
            {
                goto label_61;
            }
            
            var val_47 = X0 + 176;
            var val_48 = 0;
            val_47 = val_47 + 8;
            label_60:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_59;
            }
            
            val_48 = val_48 + 1;
            val_47 = val_47 + 16;
            if(val_48 < (X0 + 294))
            {
                goto label_60;
            }
            
            goto label_61;
            label_59:
            val_49 = val_49 + (((X0 + 176 + 8)) << 4);
            val_44 = val_49 + 304;
            label_61:
            X0.Dispose();
            label_57:
            var val_51 = val_46;
            if(val_41 != 0)
            {
                    throw ???;
            }
            
            var val_50 = 0;
            if(val_51 != 1)
            {
                    val_50 = val_50 ^ (val_51 >> 31);
                val_51 = val_51 + val_50;
            }
            
            string[] val_18 = new string[1];
            val_18[0] = System.Environment.NewLine;
            System.String[] val_20 = val_40.Split(separator:  val_18, options:  1);
            char[] val_21 = new char[1];
            val_21[0] = ',';
            val_45 = null;
            val_45 = null;
            val_47 = LocalizationManager.<>c.<>9__9_0;
            if(val_47 == null)
            {
                    System.Func<System.String, System.String> val_23 = null;
                val_47 = val_23;
                val_23 = new System.Func<System.String, System.String>(object:  LocalizationManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String LocalizationManager.<>c::<Read>b__9_0(string i));
                LocalizationManager.<>c.<>9__9_0 = val_47;
            }
            
            System.Collections.Generic.List<TSource> val_25 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.String, System.String>(source:  val_20[0].Split(separator:  val_21), selector:  val_23));
            if(1152921508426493856 >= 2)
            {
                    do
            {
                val_50 = null;
                val_48 = 5 - 4;
                val_50 = null;
                if(val_48 >= 1152921508426493856)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((Assets.SimpleLocalization.LocalizationManager.Dictionary.ContainsKey(key:  System.Void System.Array::InternalArray__ICollection_Add<System.Int64>(System.Int64 item))) != true)
            {
                    val_51 = null;
                val_51 = null;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                Assets.SimpleLocalization.LocalizationManager.Dictionary.Add(key:  Assets.SimpleLocalization.LocalizationManager.LocalizationChanged.__il2cppRuntimeField_28, value:  new System.Collections.Generic.Dictionary<System.String, System.String>());
            }
            
                var val_29 = 5 + 1;
            }
            while((5 - 3) < 1152921513664987328);
            
            }
            
            if((val_20 + 24) >= 2)
            {
                    var val_53 = 1;
                do
            {
                System.String[] val_30 = val_20 + 8;
                char[] val_31 = new char[1];
                val_31[0] = ',';
                val_52 = null;
                val_52 = null;
                val_54 = LocalizationManager.<>c.<>9__9_1;
                if(val_54 == null)
            {
                    System.Func<System.String, System.String> val_33 = null;
                val_54 = val_33;
                val_33 = new System.Func<System.String, System.String>(object:  LocalizationManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String LocalizationManager.<>c::<Read>b__9_1(string j));
                LocalizationManager.<>c.<>9__9_1 = val_54;
            }
            
                val_55 = null;
                val_55 = null;
                val_57 = LocalizationManager.<>c.<>9__9_2;
                if(val_57 == null)
            {
                    System.Func<System.String, System.String> val_35 = null;
                val_57 = val_35;
                val_35 = new System.Func<System.String, System.String>(object:  LocalizationManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String LocalizationManager.<>c::<Read>b__9_2(string j));
                LocalizationManager.<>c.<>9__9_2 = val_57;
            }
            
                System.Collections.Generic.List<TSource> val_37 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.String, System.String>(source:  System.Linq.Enumerable.Select<System.String, System.String>(source:  (val_20 + 8) + 32.Split(separator:  val_31), selector:  val_33), selector:  val_35));
                if((public static System.Collections.Generic.List<TSource> System.Linq.Enumerable::ToList<System.String>(System.Collections.Generic.IEnumerable<TSource> source)) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_48 = "getOrderId";
                if(((System.String.op_Equality(a:  val_48, b:  "")) != true) && ("" >= 2))
            {
                    do
            {
                val_59 = null;
                var val_39 = 5 - 4;
                val_59 = null;
                if(val_39 >= "")
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(val_39 >= 1152921513665052880)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Assets.SimpleLocalization.LocalizationManager.Dictionary.Item[public System.Void Spine.ExposedList<UnityEngine.Color32>::ForEach(System.Action<T> action)].Add(key:  val_48, value:  public System.Void SortedList.KeyList::RemoveAt(int index));
                var val_42 = 5 + 1;
            }
            while((5 - 3) < 1152921508399659680);
            
            }
            
                val_53 = val_53 + 1;
                val_39 = val_39;
            }
            while(val_53 < (val_20 + 24));
            
            }
            
            val_37 = 1;
            if(val_37 < (val_2 + 24))
            {
                goto label_119;
            }
            
            label_6:
            Assets.SimpleLocalization.LocalizationManager.AutoLanguage();
        }
        public static bool HasKey(string localizationKey)
        {
            null = null;
            return Assets.SimpleLocalization.LocalizationManager.Dictionary.Item[Assets.SimpleLocalization.LocalizationManager._language].ContainsKey(key:  localizationKey);
        }
        public static string Localize(string localizationKey)
        {
            string val_19;
            var val_20;
            var val_21;
            string val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            string val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_19 = localizationKey;
            val_20 = null;
            val_20 = null;
            if(Assets.SimpleLocalization.LocalizationManager.Dictionary.Count == 0)
            {
                    Assets.SimpleLocalization.LocalizationManager.Read(path:  "Localization");
            }
            
            val_21 = null;
            val_21 = null;
            val_21 = null;
            val_21 = null;
            if((Assets.SimpleLocalization.LocalizationManager.Dictionary.ContainsKey(key:  Assets.SimpleLocalization.LocalizationManager._language)) != true)
            {
                    Assets.SimpleLocalization.LocalizationManager.Language = "English";
            }
            
            val_23 = null;
            val_23 = null;
            val_23 = null;
            val_23 = null;
            if((Assets.SimpleLocalization.LocalizationManager.Dictionary.Item[Assets.SimpleLocalization.LocalizationManager._language].ContainsKey(key:  val_19)) == false)
            {
                goto label_23;
            }
            
            val_24 = null;
            val_24 = null;
            val_25 = null;
            if((System.String.op_Equality(a:  Assets.SimpleLocalization.LocalizationManager._language, b:  "English")) == false)
            {
                goto label_29;
            }
            
            val_26 = null;
            val_26 = null;
            val_26 = null;
            val_27 = public System.Collections.Generic.Dictionary<System.String, System.String> System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>::get_Item(System.String key);
            val_28 = Assets.SimpleLocalization.LocalizationManager._language;
            goto label_36;
            label_23:
            UnityEngine.Debug.LogWarning(message:  "Translation not found: "("Translation not found: ") + val_19);
            return "ERROR: "("ERROR: ") + val_19;
            label_29:
            val_29 = null;
            val_29 = null;
            val_29 = null;
            if((Assets.SimpleLocalization.LocalizationManager.Dictionary.Item[Assets.SimpleLocalization.LocalizationManager._language].ContainsKey(key:  val_19)) == false)
            {
                goto label_46;
            }
            
            val_30 = null;
            val_30 = null;
            val_30 = null;
            val_30 = null;
            if((System.String.IsNullOrEmpty(value:  Assets.SimpleLocalization.LocalizationManager.Dictionary.Item[Assets.SimpleLocalization.LocalizationManager._language].Item[val_19])) == false)
            {
                goto label_54;
            }
            
            label_46:
            object[] val_12 = new object[2];
            val_12[0] = val_19;
            val_31 = null;
            val_31 = null;
            val_22 = Assets.SimpleLocalization.LocalizationManager._language;
            val_12[1] = val_22;
            UnityEngine.Debug.LogWarningFormat(format:  "Translation not found: {0} ({1}).", args:  val_12);
            if((Assets.SimpleLocalization.LocalizationManager.Dictionary.Item["English"].ContainsKey(key:  val_19)) == false)
            {
                    return (string)val_19;
            }
            
            val_32 = null;
            val_32 = null;
            val_28 = "English";
            val_27 = public System.Collections.Generic.Dictionary<System.String, System.String> System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>::get_Item(System.String key);
            label_36:
            val_19 = Assets.SimpleLocalization.LocalizationManager.Dictionary.Item[val_28].Item[val_19];
            return (string)val_19;
            label_54:
            val_33 = null;
            val_33 = null;
            val_33 = null;
            val_33 = null;
            return Assets.SimpleLocalization.LocalizationManager.Dictionary.Item[Assets.SimpleLocalization.LocalizationManager._language].Item[val_19].Trim();
        }
        public static string Localize(string localizationKey, object[] args)
        {
            return System.String.Format(format:  Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  localizationKey), args:  args);
        }
        public static string GetChars()
        {
            char val_16;
            var val_17;
            var val_21;
            var val_22;
            char val_23;
            char val_24;
            var val_25;
            char val_26;
            UnityEngine.TextAsset val_1 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "Localization/Common");
            if(val_1 == 0)
            {
                    val_22 = "";
                return (string)val_22;
            }
            
            System.Collections.Generic.List<System.Char> val_3 = null;
            val_24 = public System.Void System.Collections.Generic.List<System.Char>::.ctor();
            val_3 = new System.Collections.Generic.List<System.Char>();
            val_25 = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZАаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя!\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~Ξ ";
            var val_20 = 0;
            val_23 = val_25;
            val_24 = val_20;
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_26 = Chars[0];
            val_23 = val_3;
            val_24 = val_26;
            if((val_3.Contains(item:  val_24)) != true)
            {
                    val_23 = val_3;
                val_24 = val_26;
                val_3.Add(item:  val_24);
            }
            
            val_20 = val_20 + 1;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_24 = 0;
            string val_6 = val_1.text;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_6.m_stringLength >= 1)
            {
                    val_26 = 1152921504615366656;
                do
            {
                char val_7 = val_6.Chars[0];
                val_23 = val_7;
                val_24 = 0;
                if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
                if((val_3.Contains(item:  System.Char.ToLower(c:  val_23))) != true)
            {
                    val_3.Add(item:  System.Char.ToLower(c:  val_7));
            }
            
                val_24 = System.Char.ToUpper(c:  val_7);
                val_23 = val_3;
                if((val_3.Contains(item:  val_24)) != true)
            {
                    val_24 = System.Char.ToUpper(c:  val_7);
                val_23 = val_3;
                val_3.Add(item:  val_24);
            }
            
                val_25 = 0 + 1;
            }
            while(val_25 < val_6.m_stringLength);
            
            }
            
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_3.Sort();
            System.Text.StringBuilder val_14 = new System.Text.StringBuilder();
            List.Enumerator<T> val_15 = val_3.GetEnumerator();
            val_21 = 1152921513665995456;
            label_28:
            if(val_17.MoveNext() == false)
            {
                goto label_26;
            }
            
            System.Text.StringBuilder val_19 = val_14.Append(value:  val_16);
            goto label_28;
            label_26:
            val_24 = public System.Void List.Enumerator<System.Char>::Dispose();
            val_17.Dispose();
            if(val_14 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_22 = val_14;
            return (string)val_22;
        }
        private static string ReplaceMarkers(string text)
        {
            return text.Replace(oldValue:  "[Newline]", newValue:  "\n");
        }
        private static LocalizationManager()
        {
            null = null;
            Assets.SimpleLocalization.LocalizationManager.LocalizationChanged = new System.Action(object:  LocalizationManager.<>c.<>9, method:  System.Void LocalizationManager.<>c::<.cctor>b__15_0());
            Assets.SimpleLocalization.LocalizationManager.Dictionary = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>();
            Assets.SimpleLocalization.LocalizationManager._language = "English";
        }
    
    }

}
