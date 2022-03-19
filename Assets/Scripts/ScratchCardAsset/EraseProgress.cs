using UnityEngine;

namespace ScratchCardAsset
{
    public class EraseProgress : MonoBehaviour
    {
        // Fields
        public ScratchCardAsset.ScratchCard Card;
        private ScratchCardAsset.EraseProgress.ProgressHandler OnProgress;
        private ScratchCardAsset.EraseProgress.ProgressHandler OnCompleted;
        private ScratchCardAsset.ScratchCard.ScratchMode scratchMode;
        private UnityEngine.RenderTexture percentRenderTexture;
        private UnityEngine.Rendering.RenderTargetIdentifier rti;
        private UnityEngine.Rendering.CommandBuffer commandBuffer;
        private UnityEngine.Mesh mesh;
        private float currentProgress;
        private bool isCompleted;
        
        // Methods
        public void add_OnProgress(ScratchCardAsset.EraseProgress.ProgressHandler value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnProgress, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnProgress != 1152921513668489216);
            
            return;
            label_2:
        }
        public void remove_OnProgress(ScratchCardAsset.EraseProgress.ProgressHandler value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnProgress, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnProgress != 1152921513668625792);
            
            return;
            label_2:
        }
        public void add_OnCompleted(ScratchCardAsset.EraseProgress.ProgressHandler value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnCompleted, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCompleted != 1152921513668762376);
            
            return;
            label_2:
        }
        public void remove_OnCompleted(ScratchCardAsset.EraseProgress.ProgressHandler value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnCompleted, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCompleted != 1152921513668898952);
            
            return;
            label_2:
        }
        private void Start()
        {
            this.Init();
        }
        private void OnDestroy()
        {
            if(this.percentRenderTexture != 0)
            {
                    if(this.percentRenderTexture.IsCreated() != false)
            {
                    this.percentRenderTexture.Release();
                UnityEngine.Object.Destroy(obj:  this.percentRenderTexture);
            }
            
            }
            
            if(this.mesh != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.mesh);
            }
            
            if(this.commandBuffer == null)
            {
                    return;
            }
            
            this.commandBuffer.Release();
        }
        private void Update()
        {
            if(this.Card != null)
            {
                    if(this.Card._mode != this.scratchMode)
            {
                    this.scratchMode = this.Card._mode;
                this.isCompleted = false;
            }
            
                if(this.Card.cardRenderer == null)
            {
                    return;
            }
            
                if(this.Card.cardRenderer.IsScratched == false)
            {
                    return;
            }
            
                if(this.isCompleted != false)
            {
                    return;
            }
            
                this.UpdateProgress();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void Init()
        {
            this.scratchMode = this.Card._mode;
            UnityEngine.Rendering.CommandBuffer val_1 = new UnityEngine.Rendering.CommandBuffer();
            val_1.name = "EraseProgress";
            this.commandBuffer = val_1;
            UnityEngine.RenderTexture val_2 = new UnityEngine.RenderTexture(width:  1, height:  1, depth:  0, format:  0);
            this.percentRenderTexture = val_2;
            UnityEngine.Rendering.RenderTargetIdentifier val_3 = new UnityEngine.Rendering.RenderTargetIdentifier(tex:  val_2);
            mem[1152921513669469984] = val_3.m_CubeFace;
            this.rti = val_3.m_Type;
            mem[1152921513669469968] = val_3.m_BufferPointer;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.mesh = ScratchCardAsset.Tools.MeshGenerator.GenerateQuad(size:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, offset:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        }
        private void CalcProgress()
        {
            if(this.isCompleted != false)
            {
                    return;
            }
            
            UnityEngine.RenderTexture.active = this.percentRenderTexture;
            UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  this.percentRenderTexture, height:  this.percentRenderTexture, textureFormat:  5, mipChain:  false, linear:  true);
            UnityEngine.Rect val_3 = new UnityEngine.Rect(x:  0f, y:  0f, width:  (float)this.percentRenderTexture, height:  (float)this.percentRenderTexture);
            val_2.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = val_3.m_XMin, m_YMin = val_3.m_YMin, m_Width = val_3.m_Width, m_Height = val_3.m_Height}, destX:  0, destY:  0);
            val_2.Apply();
            UnityEngine.RenderTexture.active = UnityEngine.RenderTexture.active;
            UnityEngine.Color val_4 = val_2.GetPixel(x:  0, y:  0);
            this.currentProgress = val_4.r;
            if(this.OnProgress == null)
            {
                    return;
            }
            
            this.OnProgress.Invoke(progress:  val_4.r);
            if(val_4.r != ((this.Card._mode == 0) ? 1f : 0f))
            {
                    return;
            }
            
            if(this.OnCompleted != null)
            {
                    this.OnCompleted.Invoke(progress:  val_4.r);
            }
            
            this.isCompleted = true;
        }
        public float GetProgress()
        {
            return (float)this.currentProgress;
        }
        public void UpdateProgress()
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            UnityEngine.GL.LoadOrtho();
            this.commandBuffer.Clear();
            this.commandBuffer.SetRenderTarget(rt:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = this.rti, m_NameID = this.rti, m_InstanceID = this.rti, m_BufferPointer = ???, m_MipLevel = ???, m_CubeFace = true});
            UnityEngine.Color val_1 = UnityEngine.Color.clear;
            this.commandBuffer.ClearRenderTarget(clearDepth:  false, clearColor:  true, backgroundColor:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            UnityEngine.Matrix4x4 val_2 = UnityEngine.Matrix4x4.identity;
            this.commandBuffer.DrawMesh(mesh:  this.mesh, matrix:  new UnityEngine.Matrix4x4() {m00 = val_5, m10 = val_5, m20 = val_5, m30 = val_5, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_3, m12 = val_3, m22 = val_3, m32 = val_3, m03 = val_4, m13 = val_4, m23 = val_4, m33 = val_4}, material:  this.Card.Progress);
            UnityEngine.Graphics.ExecuteCommandBuffer(buffer:  this.commandBuffer);
            this.CalcProgress();
        }
        public void ResetProgress()
        {
            this.isCompleted = false;
        }
        public EraseProgress()
        {
        
        }
    
    }

}
