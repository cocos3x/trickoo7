using UnityEngine;
public class ShapeDetect : MonoBehaviour
{
    // Fields
    public LevelDraw level;
    public UnityEngine.GameObject linePrefab;
    public UnityEngine.GameObject pencil;
    private UnityEngine.GameObject currentLine;
    private UnityEngine.Vector3 virtualKeyPosition;
    private System.Collections.Generic.List<UnityEngine.Vector2> fingerPositions;
    private UnityEngine.RuntimePlatform platform;
    private UnityEngine.LineRenderer lineRenderer;
    private UnityEngine.Rect drawArea;
    private float DefaultZ;
    private bool isDrawing;
    private bool canDraw;
    private bool isFinishGame;
    private bool internetConnection;
    public int interpolationFramesCount;
    private int elapsedFrames;
    private bool touchHint;
    private bool touchWall;
    
    // Methods
    private void Start()
    {
        this.platform = UnityEngine.Application.platform;
        UnityEngine.Rect val_4 = new UnityEngine.Rect(x:  0f, y:  0f, width:  (float)UnityEngine.Screen.width, height:  (float)UnityEngine.Screen.height);
        this.drawArea = val_4.m_XMin;
    }
    private void Update()
    {
        float val_35;
        float val_36;
        float val_38;
        if(true != 0)
        {
                return;
        }
        
        if(this.level.canPlay() == false)
        {
                return;
        }
        
        if(this.canDraw == false)
        {
                return;
        }
        
        if(this.isFinishGame != false)
        {
                return;
        }
        
        if(this.internetConnection == false)
        {
                return;
        }
        
        if(this.platform != 11)
        {
                if(this.platform != 8)
        {
            goto label_8;
        }
        
        }
        
        if(UnityEngine.Input.touchCount < 1)
        {
            goto label_11;
        }
        
        UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  0);
        UnityEngine.Vector2 val_4 = position;
        UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
        UnityEngine.Vector2 val_6 = position;
        UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  val_4.x, y:  val_6.y);
        val_35 = val_7.x;
        val_36 = val_7.z;
        goto label_10;
        label_8:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_11;
        }
        
        UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_10 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_9.x, y:  val_10.y);
        val_35 = val_11.x;
        val_36 = val_11.z;
        label_10:
        this.virtualKeyPosition = val_35;
        mem[1152921513464526832] = val_36;
        label_11:
        if((this.drawArea.Contains(point:  new UnityEngine.Vector3() {x = this.virtualKeyPosition, y = val_10.y, z = val_10.z})) == false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                this.CreateLine();
            this.isDrawing = true;
            UnityEngine.Vector3 val_15 = new UnityEngine.Vector3(x:  this.virtualKeyPosition, y:  val_10.y, z:  this.DefaultZ);
            UnityEngine.Vector3 val_16 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = new UnityEngine.Vector3(x:  0.35f, y:  0.5f, z:  0f);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_38 = val_18.y;
            this.pencil.transform.position = new UnityEngine.Vector3() {x = val_18.x, y = val_38, z = val_18.z};
        }
        
        if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
        {
                this.UpdateLine();
            UnityEngine.Vector3 val_22 = new UnityEngine.Vector3(x:  this.virtualKeyPosition, y:  val_38, z:  this.DefaultZ);
            UnityEngine.Vector3 val_23 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            int val_33 = this.interpolationFramesCount;
            UnityEngine.Vector3 val_24 = new UnityEngine.Vector3(x:  0.35f, y:  0.5f, z:  0f);
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            UnityEngine.Vector3 val_27 = this.pencil.transform.position;
            val_33 = (float)this.elapsedFrames / (float)val_33;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, t:  val_33);
            this.pencil.transform.position = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            int val_35 = this.interpolationFramesCount;
            int val_34 = this.elapsedFrames;
            val_34 = val_34 + 1;
            val_35 = val_35 + 1;
            val_34 = val_34 - ((val_34 / val_35) * val_35);
            this.elapsedFrames = val_34;
            if(this.pencil.activeSelf != true)
        {
                this.pencil.SetActive(value:  true);
        }
        
            this.CheckTouch();
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
                return;
        }
        
        if(this.isDrawing == false)
        {
                return;
        }
        
        this.DetectShape();
        this.isDrawing = false;
    }
    private void OnEnable()
    {
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  14, callback:  new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::ShowListLevelHandle(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  15, callback:  new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::HideListLevelHandle(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  12, callback:  new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::FinishLevelHandle(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  10, callback:  new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::InitLevelHandle(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  22, callback:  new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::InternetHandle(object obj)), eventType:  1);
    }
    private void OnDisable()
    {
        System.Action<System.Object> val_11;
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 != null)
        {
                System.Action<System.Object> val_2 = null;
            val_11 = val_2;
            val_2 = new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::ShowListLevelHandle(object obj));
            val_1.RemoveListener(eventID:  14, callback:  val_2);
        }
        
        EventDispatcher val_3 = LazySingleton<EventDispatcher>.Instance;
        if(val_3 != null)
        {
                System.Action<System.Object> val_4 = null;
            val_11 = val_4;
            val_4 = new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::HideListLevelHandle(object obj));
            val_3.RemoveListener(eventID:  15, callback:  val_4);
        }
        
        EventDispatcher val_5 = LazySingleton<EventDispatcher>.Instance;
        if(val_5 != null)
        {
                System.Action<System.Object> val_6 = null;
            val_11 = val_6;
            val_6 = new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::FinishLevelHandle(object obj));
            val_5.RemoveListener(eventID:  12, callback:  val_6);
        }
        
        EventDispatcher val_7 = LazySingleton<EventDispatcher>.Instance;
        if(val_7 != null)
        {
                System.Action<System.Object> val_8 = null;
            val_11 = val_8;
            val_8 = new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::InitLevelHandle(object obj));
            val_7.RemoveListener(eventID:  10, callback:  val_8);
        }
        
        EventDispatcher val_9 = LazySingleton<EventDispatcher>.Instance;
        if(val_9 == null)
        {
                return;
        }
        
        val_9.RemoveListener(eventID:  22, callback:  new System.Action<System.Object>(object:  this, method:  System.Void ShapeDetect::InternetHandle(object obj)));
    }
    private void InternetHandle(object obj)
    {
        this.internetConnection = null;
    }
    private void ShowListLevelHandle(object obj)
    {
        this.CreateLine();
        this.canDraw = false;
    }
    private void HideListLevelHandle(object obj)
    {
        this.canDraw = true;
    }
    private void FinishLevelHandle(object obj)
    {
        this.isFinishGame = true;
    }
    private void InitLevelHandle(object obj)
    {
        this.isFinishGame = false;
    }
    private void CreateLine()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.currentLine)) != false)
        {
                UnityEngine.Object.Destroy(obj:  this.currentLine);
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.linePrefab, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        this.currentLine = val_4;
        this.lineRenderer = val_4.GetComponent<UnityEngine.LineRenderer>();
        this.fingerPositions.Clear();
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.virtualKeyPosition, y = val_2.x, z = val_2.y});
        this.fingerPositions.Add(item:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.virtualKeyPosition, y = val_6.y, z = val_2.y});
        this.fingerPositions.Add(item:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        this.pencil.SetActive(value:  false);
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  this.virtualKeyPosition, y:  val_7.y, z:  this.DefaultZ);
        UnityEngine.Vector3 val_10 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        this.lineRenderer.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  this.virtualKeyPosition, y:  val_10.y, z:  this.DefaultZ);
        UnityEngine.Vector3 val_13 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        this.lineRenderer.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        this.lineRenderer.BakeMesh(mesh:  new UnityEngine.Mesh(), useTransform:  true);
    }
    private void UpdateLine()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.virtualKeyPosition, y = V8.16B, z = V9.16B});
        this.fingerPositions.Add(item:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        this.lineRenderer.positionCount = this.lineRenderer.positionCount + 1;
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  this.virtualKeyPosition, y:  val_1.y, z:  this.DefaultZ);
        UnityEngine.Vector3 val_7 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.lineRenderer.SetPosition(index:  this.lineRenderer.positionCount - 1, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
    }
    private void DetectShape()
    {
        if(this.currentLine == 0)
        {
                return;
        }
        
        .lineRenderer = this.lineRenderer;
        .touchHint = this.touchHint;
        .touchWall = this.touchWall;
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  110, param:  new CheckData());
        this.touchHint = false;
        this.touchWall = false;
        UnityEngine.Object.Destroy(obj:  this.currentLine);
        this.fingerPositions.Clear();
        this.pencil.SetActive(value:  false);
    }
    private void CheckTouch()
    {
        var val_12;
        UnityEngine.Vector3 val_2 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = this.virtualKeyPosition});
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.up;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        UnityEngine.Color val_7 = UnityEngine.Color.green;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, dir:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, color:  new UnityEngine.Color() {r = val_7.r, g = val_7.b, a = val_4.y});
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.up;
        UnityEngine.RaycastHit2D val_9 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, direction:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, distance:  0f);
        if(val_12.collider == 0)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_12.collider.tag, b:  "Wall")) != false)
        {
                this.touchWall = true;
            return;
        }
        
        if((System.String.op_Equality(a:  val_12.collider.tag, b:  "Hint")) == false)
        {
                return;
        }
        
        this.touchHint = true;
    }
    public ShapeDetect()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        this.virtualKeyPosition = val_2;
        mem[1152921513466381004] = val_2.y;
        mem[1152921513466381008] = val_2.z;
        this.fingerPositions = new System.Collections.Generic.List<UnityEngine.Vector2>();
        this.DefaultZ = 9f;
        this.canDraw = true;
        this.internetConnection = true;
        this.interpolationFramesCount = 45;
    }

}
