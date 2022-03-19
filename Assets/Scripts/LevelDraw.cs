using UnityEngine;
public class LevelDraw : Level
{
    // Fields
    public UnityEngine.SpriteRenderer drawObject;
    public bool lineEnterWall;
    private UnityEngine.GameObject hintGroup;
    private System.Collections.Generic.List<UnityEngine.SpriteRenderer> hints;
    private UnityEngine.Color originColor;
    private UnityEngine.Color hideColor;
    private float minArea;
    private float maxArea;
    
    // Methods
    private void Awake()
    {
        mem[1152921513422820452] = 7;
    }
    protected override void Start()
    {
        this.Start();
        mem[1152921513422932448] = 0;
    }
    protected override void OnEnable()
    {
        var val_9;
        var val_15;
        var val_16;
        this.OnEnable();
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  110, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelDraw::OnCheckLevelDrawHandler(object obj)), eventType:  1);
        UnityEngine.Color val_2 = UnityEngine.Color.clear;
        if(this.drawObject == null)
        {
                throw new NullReferenceException();
        }
        
        this.drawObject.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        if(this.hintGroup == null)
        {
                throw new NullReferenceException();
        }
        
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<UnityEngine.SpriteRenderer>(source:  this.hintGroup.GetComponentsInChildren<UnityEngine.SpriteRenderer>());
        this.hints = val_4;
        if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
        if((public static System.Collections.Generic.List<TSource> System.Linq.Enumerable::ToList<UnityEngine.SpriteRenderer>(System.Collections.Generic.IEnumerable<TSource> source)) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((public Assets.SimpleLocalization.Sheet Array.EmptyInternalEnumerator<Assets.SimpleLocalization.Sheet>::get_Current()) == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Color val_5 = color;
        mem[1152921513423122392] = val_5.b;
        mem[1152921513423122396] = val_5.a;
        UnityEngine.Color val_6;
        this.originColor = val_5;
        mem[1152921513423122388] = val_5.g;
        val_6 = new UnityEngine.Color(r:  val_5.r, g:  val_5.g, b:  val_5.b, a:  0f);
        this.hideColor = val_6.r;
        if(this.hints == null)
        {
                throw new NullReferenceException();
        }
        
        var val_14 = 0;
        label_10:
        if(val_14 >= 1152921513423071600)
        {
            goto label_7;
        }
        
        if(1152921513423071600 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((public Assets.SimpleLocalization.Sheet Array.EmptyInternalEnumerator<Assets.SimpleLocalization.Sheet>::get_Current()) == 0)
        {
                throw new NullReferenceException();
        }
        
        color = new UnityEngine.Color() {r = this.hideColor, g = val_5.g, b = val_5.b, a = 0f};
        val_14 = val_14 + 1;
        if(this.hints != null)
        {
            goto label_10;
        }
        
        throw new NullReferenceException();
        label_7:
        System.Collections.Generic.List<UnityEngine.Vector2> val_7 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        if(this.hints == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_8 = this.hints.GetEnumerator();
        label_18:
        val_15 = public System.Boolean List.Enumerator<UnityEngine.SpriteRenderer>::MoveNext();
        if(val_6.r.MoveNext() == false)
        {
            goto label_12;
        }
        
        val_16 = val_9;
        if(val_16 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_15 = 0;
        UnityEngine.Transform val_11 = val_16.transform;
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector3 val_12 = val_11.position;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_7.Add(item:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        goto label_18;
        label_12:
        val_6.r.Dispose();
        this.HandleTutorial(positions:  val_7);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 == null)
        {
                return;
        }
        
        val_1.RemoveListener(eventID:  110, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelDraw::OnCheckLevelDrawHandler(object obj)));
    }
    protected override void ShowHintHandler(object obj)
    {
        this.ShowHintHandler(obj:  obj);
        this.HideHint();
        var val_6 = 4;
        do
        {
            var val_1 = val_6 - 4;
            if(val_1 >= W24)
        {
                return;
        }
        
            if(W24 <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            1818323059.color = new UnityEngine.Color() {r = this.originColor};
            if(20140032 <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  1818323059, endValue:  new UnityEngine.Color() {r = this.hideColor, g = (float)W24}, duration:  0.6f), loops:  0, loopType:  1), delay:  (float)val_1 / (float)W24);
            val_6 = val_6 + 1;
        }
        while(this.hints != null);
        
        throw new NullReferenceException();
    }
    public void OnChildTriggerEnter(UnityEngine.Collider2D other)
    {
        this.lineEnterWall = true;
        UnityEngine.Debug.Log(message:  "OnChildTriggerEnter");
    }
    public void OnChildTriggerExit(UnityEngine.Collider2D other)
    {
        this.lineEnterWall = false;
        UnityEngine.Debug.Log(message:  "OnChildTriggerExit");
    }
    private void OnCheckLevelDrawHandler(object obj)
    {
        if(obj == null)
        {
                return;
        }
        
        if(( & (this.PassSize(lineRenderer:  null))) != false)
        {
                UnityEngine.Debug.Log(message:  "Pass Level");
            mem[1152921513423867936] = 1;
            mem[1152921513423867925] = 0;
            this.DisplayResult();
            this.HideHint();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.WaitAnimWin());
            return;
        }
        
        StageData val_6 = LazySingleton<DataManager>.Instance.CurrentStage;
        int val_7 = val_6.failCount;
        val_7 = val_7 + 1;
        val_6.failCount = val_7;
    }
    private void HideHint()
    {
        var val_3 = 4;
        do
        {
            var val_1 = val_3 - 4;
            if(val_1 >= true)
        {
                return;
        }
        
            if(true <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            int val_2 = DG.Tweening.ShortcutExtensions.DOKill(target:  null, complete:  false);
            if(true <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            color = new UnityEngine.Color() {r = this.hideColor};
            this.hints = this.hints;
            val_3 = val_3 + 1;
        }
        while(this.hints != null);
        
        throw new NullReferenceException();
    }
    private bool PassSize(UnityEngine.LineRenderer lineRenderer)
    {
        var val_13;
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        var val_21;
        if(lineRenderer.positionCount >= 1)
        {
                var val_17 = 0;
            do
        {
            UnityEngine.Vector3 val_2 = lineRenderer.GetPosition(index:  0);
            var val_3 = (100f > val_2.x) ? val_2.x : 100f;
            var val_4 = (0f < 0) ? val_2.x : 0f;
            var val_5 = (100f > val_2.y) ? val_2.y : 100f;
            var val_6 = (0f < 0) ? val_2.y : 0f;
            val_17 = val_17 + 1;
        }
        while(val_17 < lineRenderer.positionCount);
        
        }
        else
        {
                val_17 = 100f;
            val_18 = 0f;
            val_20 = 0f;
            val_19 = val_17;
        }
        
        float val_9 = val_18 - val_17;
        float val_10 = val_20 - val_19;
        UnityEngine.Bounds val_11 = this.drawObject.GetComponent<UnityEngine.SpriteRenderer>().bounds;
        UnityEngine.Vector3 val_14 = val_13.size;
        val_14.x = val_14.x * val_14.y;
        val_14.x = (val_20 * val_19) / val_14.x;
        if(val_14.x > this.minArea)
        {
                var val_16 = (val_14.x < 0) ? 1 : 0;
            return (bool)val_21;
        }
        
        val_21 = 0;
        return (bool)val_21;
    }
    public LevelDraw()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        this.originColor = val_1;
        mem[1152921513424281812] = val_1.g;
        mem[1152921513424281816] = val_1.b;
        mem[1152921513424281820] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.clear;
        this.hideColor = val_2;
        mem[1152921513424281828] = val_2.g;
        mem[1152921513424281832] = val_2.b;
        mem[1152921513424281836] = val_2.a;
        this.minArea = 0.2f;
        this.maxArea = 2f;
    }

}
