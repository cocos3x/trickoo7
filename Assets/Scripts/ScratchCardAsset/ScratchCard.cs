using UnityEngine;

namespace ScratchCardAsset
{
    public class ScratchCard : MonoBehaviour
    {
        // Fields
        public UnityEngine.Camera MainCamera;
        public UnityEngine.Transform Surface;
        public ScratchCardAsset.ScratchCard.Quality RenderTextureQuality;
        public UnityEngine.Material Eraser;
        public UnityEngine.Material Progress;
        public UnityEngine.Material ScratchSurface;
        public UnityEngine.RenderTexture RenderTexture;
        public UnityEngine.Vector2 BrushScale;
        public bool InputEnabled;
        private ScratchCardAsset.ScratchCard.ScratchMode _mode;
        private ScratchCardAsset.Core.ScratchCardRenderer cardRenderer;
        private ScratchCardAsset.Core.ScratchCardInput cardInput;
        private ScratchCardAsset.Core.Data.Triangle triangle;
        private UnityEngine.SpriteRenderer surfaceSpriteRenderer;
        private UnityEngine.MeshFilter surfaceMeshFilter;
        private UnityEngine.Renderer surfaceRenderer;
        private UnityEngine.RectTransform surfaceRectTransform;
        private UnityEngine.Vector2 boundsSize;
        private UnityEngine.Vector2 imageSize;
        private bool isCanvasOverlay;
        private bool isFirstFrame;
        private int lastFrameId;
        private const string BlendOpShaderParam = "_BlendOpValue";
        
        // Properties
        public ScratchCardAsset.ScratchCard.ScratchMode Mode { get; set; }
        public bool IsScratching { get; }
        public bool IsScratched { get; set; }
        
        // Methods
        public ScratchCardAsset.ScratchCard.ScratchMode get_Mode()
        {
            return (ScratchMode)this._mode;
        }
        public void set_Mode(ScratchCardAsset.ScratchCard.ScratchMode value)
        {
            this._mode = value;
            if(this.Eraser == 0)
            {
                    return;
            }
            
            this.Eraser.SetInt(name:  "_BlendOpValue", value:  (this._mode == 0) ? 0 : 2);
        }
        public bool get_IsScratching()
        {
            if(this.cardInput != null)
            {
                    return this.cardInput.IsScratching;
            }
            
            throw new NullReferenceException();
        }
        public bool get_IsScratched()
        {
            if(this.cardRenderer == null)
            {
                    return false;
            }
            
            return (bool)(this.cardRenderer.IsScratched == true) ? 1 : 0;
        }
        private void set_IsScratched(bool value)
        {
            if(this.cardRenderer != null)
            {
                    this.cardRenderer.IsScratched = value;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void Start()
        {
            this.Init();
        }
        private void OnDestroy()
        {
            if(this.RenderTexture != 0)
            {
                    if(this.RenderTexture.IsCreated() != false)
            {
                    this.RenderTexture.Release();
                UnityEngine.Object.Destroy(obj:  this.RenderTexture);
            }
            
            }
            
            this.cardRenderer.Release();
        }
        private void Update()
        {
            if(this.lastFrameId == UnityEngine.Time.frameCount)
            {
                    return;
            }
            
            this.cardInput.Update();
            if(this.isFirstFrame != false)
            {
                    UnityEngine.Color val_2 = UnityEngine.Color.clear;
                this.cardRenderer.FillRenderTextureWithColor(color:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
                this.isFirstFrame = false;
            }
            
            if(this.cardInput.IsScratching != false)
            {
                    this.cardInput.Scratch();
            }
            else
            {
                    this.cardRenderer.IsScratched = false;
            }
            
            this.lastFrameId = UnityEngine.Time.frameCount;
        }
        private void Init()
        {
            this.GetScratchBounds();
            this.InitVariables();
            this.InitTriangle();
        }
        private void GetScratchBounds()
        {
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            UnityEngine.Renderer val_1 = this.Surface.GetComponent<UnityEngine.Renderer>();
            this.surfaceRenderer = val_1;
            if(val_1 == 0)
            {
                goto label_4;
            }
            
            UnityEngine.Texture val_4 = this.surfaceRenderer.sharedMaterial.mainTexture;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  (float)val_4, y:  (float)val_4);
            this.imageSize = val_5.x;
            UnityEngine.MeshFilter val_6 = this.Surface.GetComponent<UnityEngine.MeshFilter>();
            this.surfaceMeshFilter = val_6;
            if(val_6 == 0)
            {
                goto label_11;
            }
            
            if((this.surfaceMeshFilter == 0) || (this.MainCamera.orthographic == true))
            {
                goto label_43;
            }
            
            UnityEngine.Bounds val_11 = this.surfaceMeshFilter.sharedMesh.bounds;
            goto label_51;
            label_4:
            UnityEngine.RectTransform val_12 = this.Surface.GetComponent<UnityEngine.RectTransform>();
            this.surfaceRectTransform = val_12;
            if(val_12 == 0)
            {
                goto label_23;
            }
            
            UnityEngine.Canvas val_14 = this.Surface.GetComponentInParent<UnityEngine.Canvas>();
            if(val_14 != 0)
            {
                    this.isCanvasOverlay = (val_14.renderMode == 0) ? 1 : 0;
            }
            
            UnityEngine.Rect val_18 = this.surfaceRectTransform.rect;
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_18.m_XMin.width, y:  val_18.m_XMin.height);
            this.imageSize = val_21.x;
            if(this.MainCamera.orthographic != true)
            {
                    if(this.isCanvasOverlay == false)
            {
                goto label_52;
            }
            
            }
            
            UnityEngine.Vector2 val_23 = val_18.m_XMin.size;
            val_37 = val_23.x;
            UnityEngine.Vector3 val_24 = this.surfaceRectTransform.lossyScale;
            val_38 = val_24.x;
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_38, y = val_24.y, z = val_24.z});
            val_39 = val_37;
            val_40 = val_23.y;
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_39, y = val_40}, b:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            goto label_52;
            label_23:
            UnityEngine.Debug.LogError(message:  "Can\'t find Renderer or RectTransform Component!");
            return;
            label_11:
            UnityEngine.SpriteRenderer val_27 = this.Surface.GetComponent<UnityEngine.SpriteRenderer>();
            this.surfaceSpriteRenderer = val_27;
            if(val_27 != 0)
            {
                    if(this.MainCamera.orthographic == false)
            {
                goto label_45;
            }
            
            }
            
            label_43:
            UnityEngine.Bounds val_30 = this.surfaceRenderer.bounds;
            label_51:
            UnityEngine.Vector3 val_32 = val_21.x.size;
            val_37 = val_32.x;
            val_38 = val_32.z;
            val_39 = val_37;
            val_40 = val_32.y;
            UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_38});
            label_52:
            this.boundsSize = val_33;
            mem[1152921513672086796] = val_33.y;
            return;
            label_45:
            UnityEngine.Bounds val_35 = this.surfaceSpriteRenderer.sprite.bounds;
            goto label_51;
        }
        private void InitVariables()
        {
            ScratchCardAsset.Core.ScratchCardInput val_1 = new ScratchCardAsset.Core.ScratchCardInput(card:  this);
            this.cardInput = val_1;
            mem[1152921513672431280] = this;
            mem[1152921513672431288] = System.Void ScratchCardAsset.ScratchCard::OnScratchStart();
            mem[1152921513672431264] = System.Void ScratchCardAsset.ScratchCard::OnScratchStart();
            val_1.remove_OnScratchStart(value:  new ScratchCardInput.ScratchStartHandler());
            mem[1152921513672439472] = this;
            mem[1152921513672439480] = System.Void ScratchCardAsset.ScratchCard::OnScratchStart();
            mem[1152921513672439456] = System.Void ScratchCardAsset.ScratchCard::OnScratchStart();
            this.cardInput.add_OnScratchStart(value:  new ScratchCardInput.ScratchStartHandler());
            mem[1152921513672447664] = this;
            mem[1152921513672447672] = System.Void ScratchCardAsset.ScratchCard::OnScratchHole(UnityEngine.Vector2 position);
            mem[1152921513672447648] = System.Void ScratchCardAsset.ScratchCard::OnScratchHole(UnityEngine.Vector2 position);
            this.cardInput.remove_OnScratchHole(value:  new ScratchCardInput.ScratchHoleHandler());
            mem[1152921513672455856] = this;
            mem[1152921513672455864] = System.Void ScratchCardAsset.ScratchCard::OnScratchHole(UnityEngine.Vector2 position);
            mem[1152921513672455840] = System.Void ScratchCardAsset.ScratchCard::OnScratchHole(UnityEngine.Vector2 position);
            this.cardInput.add_OnScratchHole(value:  new ScratchCardInput.ScratchHoleHandler());
            mem[1152921513672464048] = this;
            mem[1152921513672464056] = System.Void ScratchCardAsset.ScratchCard::OnScratchLine(UnityEngine.Vector2 start, UnityEngine.Vector2 end);
            mem[1152921513672464032] = System.Void ScratchCardAsset.ScratchCard::OnScratchLine(UnityEngine.Vector2 start, UnityEngine.Vector2 end);
            this.cardInput.remove_OnScratchLine(value:  new ScratchCardInput.ScratchLineHandler());
            mem[1152921513672472240] = this;
            mem[1152921513672472248] = System.Void ScratchCardAsset.ScratchCard::OnScratchLine(UnityEngine.Vector2 start, UnityEngine.Vector2 end);
            mem[1152921513672472224] = System.Void ScratchCardAsset.ScratchCard::OnScratchLine(UnityEngine.Vector2 start, UnityEngine.Vector2 end);
            this.cardInput.add_OnScratchLine(value:  new ScratchCardInput.ScratchLineHandler());
            mem[1152921513672480432] = this;
            mem[1152921513672480440] = UnityEngine.Vector2 ScratchCardAsset.ScratchCard::GetScratchPosition(UnityEngine.Vector2 position);
            mem[1152921513672480416] = UnityEngine.Vector2 ScratchCardAsset.ScratchCard::GetScratchPosition(UnityEngine.Vector2 position);
            this.cardInput.remove_OnScratch(value:  new ScratchCardInput.ScratchHandler());
            mem[1152921513672488624] = this;
            mem[1152921513672488632] = UnityEngine.Vector2 ScratchCardAsset.ScratchCard::GetScratchPosition(UnityEngine.Vector2 position);
            mem[1152921513672488608] = UnityEngine.Vector2 ScratchCardAsset.ScratchCard::GetScratchPosition(UnityEngine.Vector2 position);
            this.cardInput.add_OnScratch(value:  new ScratchCardInput.ScratchHandler());
            if(this.cardRenderer != null)
            {
                    this.cardRenderer.Release();
            }
            
            this.cardRenderer = new ScratchCardAsset.Core.ScratchCardRenderer(card:  this);
            .imageSize = this.imageSize;
            this.cardRenderer.CreateRenderTexture();
        }
        private void InitTriangle()
        {
            UnityEngine.Vector2 val_9 = this.boundsSize;
            val_9 = val_9 * (-0.5f);
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  val_9, y:  S1 * (-0.5f), z:  0f);
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_10 = this.boundsSize;
            val_10 = val_10 * (-0.5f);
            val_3.y = val_3.y * 0.5f;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  val_10, y:  val_3.y, z:  0f);
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.up;
            UnityEngine.Vector2 val_11 = this.boundsSize;
            val_11 = val_11 * 0.5f;
            val_5.y = val_5.y * 0.5f;
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  val_11, y:  val_5.y, z:  0f);
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.one;
            this.triangle = new ScratchCardAsset.Core.Data.Triangle(vertex0:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, vertex1:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, vertex2:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.z, z = val_3.x}, uv0:  new UnityEngine.Vector2() {x = val_5.x, y = val_7.x}, uv1:  new UnityEngine.Vector2(), uv2:  new UnityEngine.Vector2() {x = val_5.y, y = val_6.x});
        }
        private void OnScratchStart()
        {
            if(this.cardRenderer != null)
            {
                    this.cardRenderer.IsScratched = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnScratchHole(UnityEngine.Vector2 position)
        {
            if(this.cardRenderer != null)
            {
                    this.cardRenderer.ScratchHole(position:  new UnityEngine.Vector2() {x = position.x, y = position.y});
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnScratchLine(UnityEngine.Vector2 start, UnityEngine.Vector2 end)
        {
            if(this.cardRenderer != null)
            {
                    this.cardRenderer.ScratchLine(startPosition:  new UnityEngine.Vector2() {x = start.x, y = start.y}, endPosition:  new UnityEngine.Vector2() {x = end.x, y = end.y});
                return;
            }
            
            throw new NullReferenceException();
        }
        private UnityEngine.Vector2 GetScratchPosition(UnityEngine.Vector2 position)
        {
            float val_22;
            float val_23;
            float val_30;
            float val_31;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            if(this.MainCamera.orthographic == false)
            {
                goto label_4;
            }
            
            if(this.isCanvasOverlay == true)
            {
                goto label_5;
            }
            
            val_30 = position.x;
            val_31 = position.y;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_30, y = val_31});
            UnityEngine.Vector3 val_4 = this.MainCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            goto label_9;
            label_4:
            if(this.isCanvasOverlay == false)
            {
                goto label_10;
            }
            
            label_5:
            val_30 = position.x;
            val_31 = position.y;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_30, y = val_31});
            label_9:
            UnityEngine.Vector3 val_6 = this.Surface.lossyScale;
            UnityEngine.Vector3 val_7 = this.Surface.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = this.boundsSize, y = val_9.y}, d:  2f);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            UnityEngine.Vector2 val_30 = this.imageSize;
            val_30 = val_30 / this.boundsSize;
            val_12.y = val_12.y / val_11.y;
            val_30 = val_30 / val_6.x;
            val_12.y = val_12.y / val_6.y;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_30, y:  val_12.y);
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            return new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
            label_10:
            UnityEngine.Vector3 val_17 = this.Surface.forward;
            UnityEngine.Vector3 val_18 = this.Surface.position;
            UnityEngine.Plane val_19 = new UnityEngine.Plane(inNormal:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, inPoint:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            UnityEngine.Ray val_21 = this.MainCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            if((val_19.m_Normal.x.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_23, y = val_23, z = val_23}, m_Direction = new UnityEngine.Vector3() {x = val_23, y = val_22, z = val_22}}, enter: out  float val_24 = 7.542528E-22f)) == false)
            {
                    return new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
            }
            
            UnityEngine.Vector3 val_26 = val_23.GetPoint(distance:  0f);
            UnityEngine.Vector3 val_27 = this.Surface.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            UnityEngine.Vector2 val_28 = this.triangle.GetUV(point:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            val_28.x = val_28.x * this.imageSize;
            val_28.y = val_28.y * val_18.x;
            UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_28.x, y:  val_28.y);
            return new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
        }
        public void FillInstantly()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.cardRenderer.FillRenderTextureWithColor(color:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            this.cardRenderer.IsScratched = true;
        }
        public void ClearInstantly()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.clear;
            this.cardRenderer.FillRenderTextureWithColor(color:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            this.cardRenderer.IsScratched = true;
        }
        public void Clear()
        {
            this.isFirstFrame = true;
            if(this.cardRenderer != null)
            {
                    this.cardRenderer.IsScratched = true;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ResetRenderTexture()
        {
            this.cardRenderer.CreateRenderTexture();
            this.isFirstFrame = true;
            this.cardRenderer.IsScratched = true;
        }
        public void ScratchHole(UnityEngine.Vector2 position)
        {
            this.cardRenderer.ScratchHole(position:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            this.cardRenderer.IsScratched = true;
        }
        public void ScratchLine(UnityEngine.Vector2 startPosition, UnityEngine.Vector2 endPosition)
        {
            this.cardRenderer.ScratchLine(startPosition:  new UnityEngine.Vector2() {x = startPosition.x, y = startPosition.y}, endPosition:  new UnityEngine.Vector2() {x = endPosition.x, y = endPosition.y});
            this.cardRenderer.IsScratched = true;
        }
        public UnityEngine.Texture2D GetScratchTexture()
        {
            UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  this.RenderTexture, height:  this.RenderTexture, textureFormat:  5, mipChain:  false);
            UnityEngine.RenderTexture.active = this.RenderTexture;
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  0f, y:  0f, width:  (float)val_2.width, height:  (float)val_2.height);
            val_2.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = val_5.m_XMin, m_YMin = val_5.m_YMin, m_Width = val_5.m_Width, m_Height = val_5.m_Height}, destX:  0, destY:  0, recalculateMipMaps:  false);
            val_2.Apply();
            UnityEngine.RenderTexture.active = UnityEngine.RenderTexture.active;
            return val_2;
        }
        public void SetScratchTexture(UnityEngine.Texture2D texture)
        {
            this.Init();
            this.ClearInstantly();
            UnityEngine.Graphics.Blit(source:  texture, dest:  this.RenderTexture);
            this.cardRenderer.IsScratched = true;
        }
        public ScratchCard()
        {
            this.RenderTextureQuality = 1;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
            this.BrushScale = val_1;
            mem[1152921513674311332] = val_1.y;
            this.InputEnabled = 1;
            this.isFirstFrame = 1;
        }
    
    }

}
