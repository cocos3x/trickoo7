using UnityEngine;

namespace ScratchCardAsset.Core
{
    public class ScratchCardRenderer
    {
        // Fields
        public bool IsScratched;
        private ScratchCardAsset.ScratchCard scratchCard;
        private UnityEngine.Mesh meshHole;
        private UnityEngine.Mesh meshLine;
        private UnityEngine.Rendering.CommandBuffer commandBuffer;
        private UnityEngine.Rendering.RenderTargetIdentifier rti;
        private UnityEngine.Bounds localBounds;
        private UnityEngine.Vector2 imageSize;
        private const string MaskTexProperty = "_MaskTex";
        private const string MainTexProperty = "_MainTex";
        private const string SourceTexProperty = "_SourceTex";
        
        // Methods
        public ScratchCardRenderer(ScratchCardAsset.ScratchCard card)
        {
            this.scratchCard = card;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  2f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Bounds val_6 = new UnityEngine.Bounds(center:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, size:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            mem[1152921513681359328] = val_6.m_Extents.y;
            this.localBounds = val_6.m_Center.x;
            UnityEngine.Rendering.CommandBuffer val_7 = new UnityEngine.Rendering.CommandBuffer();
            val_7.name = "ScratchCardRenderer";
            this.commandBuffer = val_7;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            this.meshHole = ScratchCardAsset.Tools.MeshGenerator.GenerateQuad(size:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, offset:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        }
        public void Release()
        {
            if(this.commandBuffer != null)
            {
                    this.commandBuffer.Release();
            }
            
            if(this.meshHole != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.meshHole);
            }
            
            if(this.meshLine == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.meshLine);
        }
        public void CreateRenderTexture()
        {
            Quality val_8 = this.scratchCard.RenderTextureQuality;
            val_8 = this.imageSize / (float)val_8;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_8, y:  S2 / (float)val_8);
            UnityEngine.RenderTexture val_4 = null;
            double val_9 = (double)val_2.x;
            val_9 = (val_2.x == Infinityf) ? (-val_9) : (val_9);
            val_4 = new UnityEngine.RenderTexture(width:  (int)val_9, height:  (int)(val_2.y == Infinityf) ? (-(double)val_2.y) : ((double)val_2.y), depth:  0, format:  0);
            this.scratchCard.RenderTexture = val_4;
            this.scratchCard.ScratchSurface.SetTexture(name:  "_MaskTex", value:  this.scratchCard.RenderTexture);
            this.scratchCard.Progress.SetTexture(name:  "_MainTex", value:  this.scratchCard.RenderTexture);
            if((this.scratchCard.Progress.HasProperty(name:  "_SourceTex")) != false)
            {
                    this.scratchCard.Progress.SetTexture(name:  "_SourceTex", value:  this.scratchCard.ScratchSurface.mainTexture);
            }
            
            UnityEngine.Rendering.RenderTargetIdentifier val_7 = new UnityEngine.Rendering.RenderTargetIdentifier(tex:  this.scratchCard.RenderTexture);
            mem[1152921513681710568] = val_7.m_CubeFace;
            mem[1152921513681710552] = val_7.m_BufferPointer;
            this.rti = val_7.m_Type;
        }
        private bool IsInBounds(UnityEngine.Rect rect)
        {
            UnityEngine.Vector2 val_1 = rect.m_XMin.min;
            UnityEngine.Vector2 val_2 = rect.m_XMin.max;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_1.x, y:  val_2.y);
            UnityEngine.Vector2 val_4 = rect.m_XMin.max;
            UnityEngine.Vector2 val_5 = rect.m_XMin.min;
            UnityEngine.Vector2 val_6 = rect.m_XMin.max;
            UnityEngine.Vector2 val_7 = rect.m_XMin.min;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_6.x, y:  val_7.y);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            if((this.localBounds.Contains(point:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) == true)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            if((this.localBounds.Contains(point:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) == true)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            if((this.localBounds.Contains(point:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z})) == false)
            {
                goto label_9;
            }
            
            label_6:
            var val_17 = 1;
            label_12:
            val_17 = val_17 & 1;
            return (bool)val_17;
            label_9:
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            bool val_16 = this.localBounds.Contains(point:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            goto label_12;
        }
        public void ScratchHole(UnityEngine.Vector2 position)
        {
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_27;
            var val_28;
            UnityEngine.Mesh val_29;
            val_27 = position.y;
            val_28 = this;
            val_29 = this.scratchCard.Eraser.mainTexture;
            float val_26 = (float)this.scratchCard.Eraser.mainTexture;
            float val_27 = 0.5f;
            val_26 = val_26 * val_27;
            val_27 = (float)val_29 * val_27;
            float val_28 = (float)this.scratchCard.Eraser.mainTexture;
            val_26 = val_26 * this.scratchCard.BrushScale;
            val_27 = val_27 * S13;
            val_28 = this.scratchCard.BrushScale * val_28;
            val_26 = position.x - val_26;
            val_27 = val_27 - val_27;
            float val_5 = S3 * (float)this.scratchCard.Eraser.mainTexture;
            val_28 = val_28 / this.imageSize;
            val_26 = val_26 / this.imageSize;
            val_27 = val_27 / S12;
            val_5 = val_5 / S4;
            UnityEngine.Rect val_6 = new UnityEngine.Rect(x:  val_26, y:  val_27, width:  val_28, height:  val_5);
            if((this.IsInBounds(rect:  new UnityEngine.Rect() {m_XMin = val_6.m_XMin, m_YMin = val_6.m_YMin, m_Width = val_6.m_Width, m_Height = val_6.m_Height})) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3[] val_8 = new UnityEngine.Vector3[4];
            UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_6.m_XMin.xMin, y:  val_6.m_XMin.yMax, z:  0f);
            val_8[0] = val_11.x;
            val_8[1] = val_11.z;
            UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_6.m_XMin.xMax, y:  val_6.m_XMin.yMax, z:  0f);
            val_8[1] = val_14.x;
            val_8[2] = val_14.z;
            UnityEngine.Vector3 val_17 = new UnityEngine.Vector3(x:  val_6.m_XMin.xMax, y:  val_6.m_XMin.yMin, z:  0f);
            val_8[3] = val_17.x;
            val_8[4] = val_17.z;
            val_27 = val_6.m_XMin.xMin;
            UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_27, y:  val_6.m_XMin.yMin, z:  0f);
            val_8[4] = val_20.x;
            val_8[5] = val_20.z;
            this.meshHole.vertices = val_8;
            UnityEngine.GL.LoadOrtho();
            this.commandBuffer.Clear();
            this.commandBuffer.SetRenderTarget(rt:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = this.rti, m_NameID = this.rti, m_InstanceID = this.rti, m_BufferPointer = val_27, m_CubeFace = val_20.x});
            val_29 = this.meshHole;
            UnityEngine.Matrix4x4 val_21 = UnityEngine.Matrix4x4.identity;
            this.commandBuffer.DrawMesh(mesh:  val_29, matrix:  new UnityEngine.Matrix4x4() {m00 = val_24, m10 = val_24, m20 = val_24, m30 = val_24, m01 = val_25, m11 = val_25, m21 = val_25, m31 = val_25, m02 = val_22, m12 = val_22, m22 = val_22, m32 = val_22, m03 = val_23, m13 = val_23, m23 = val_23, m33 = val_23}, material:  this.scratchCard.Eraser);
            UnityEngine.Graphics.ExecuteCommandBuffer(buffer:  this.commandBuffer);
            this.IsScratched = true;
        }
        public void ScratchLine(UnityEngine.Vector2 startPosition, UnityEngine.Vector2 endPosition)
        {
            float val_47;
            float val_48;
            float val_49;
            var val_51;
            UnityEngine.Rendering.CommandBuffer val_52;
            var val_53;
            var val_54;
            UnityEngine.Mesh val_55;
            val_51 = this;
            float val_1 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = startPosition.x, y = startPosition.y}, b:  new UnityEngine.Vector2() {x = endPosition.x, y = endPosition.y});
            val_1 = (val_1 == Infinityf) ? (-(double)val_1) : ((double)val_1);
            Quality val_2 = (int)val_1 / this.scratchCard.RenderTextureQuality;
            System.Collections.Generic.List<UnityEngine.Vector3> val_3 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            System.Collections.Generic.List<UnityEngine.Color> val_4 = new System.Collections.Generic.List<UnityEngine.Color>();
            System.Collections.Generic.List<System.Int32> val_5 = null;
            val_52 = val_5;
            val_5 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<UnityEngine.Vector2> val_6 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if(val_2 >= 1)
            {
                    val_53 = 0;
                var val_55 = 0;
                do
            {
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = endPosition.x, y = endPosition.y}, b:  new UnityEngine.Vector2() {x = startPosition.x, y = startPosition.y});
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, d:  (float)val_2);
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, d:  0f);
                float val_54 = val_9.y;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = startPosition.x, y = startPosition.y}, b:  new UnityEngine.Vector2() {x = val_9.x, y = val_54});
                val_54 = this.scratchCard.Eraser.mainTexture;
                float val_50 = (float)this.scratchCard.Eraser.mainTexture;
                float val_53 = 0.5f;
                val_50 = val_50 * 0.5f;
                float val_51 = (float)val_54;
                float val_52 = (float)this.scratchCard.Eraser.mainTexture;
                val_51 = val_51 * val_53;
                val_52 = this.scratchCard.BrushScale * val_52;
                val_50 = val_50 * this.scratchCard.BrushScale;
                val_53 = val_51 * S12;
                float val_16 = val_10.x - val_50;
                float val_17 = val_10.y - val_53;
                val_54 = val_54 * (float)this.scratchCard.Eraser.mainTexture;
                val_16 = val_16 / this.imageSize;
                val_17 = val_17 / S15;
                val_54 = val_54 / S4;
                UnityEngine.Rect val_18 = new UnityEngine.Rect(x:  val_16, y:  val_17, width:  val_52 / this.imageSize, height:  val_54);
                if((this.IsInBounds(rect:  new UnityEngine.Rect() {m_XMin = val_18.m_XMin, m_YMin = val_18.m_YMin, m_Width = val_18.m_Width, m_Height = val_18.m_Height})) != false)
            {
                    UnityEngine.Vector3 val_22 = new UnityEngine.Vector3(x:  val_18.m_XMin.xMin, y:  val_18.m_XMin.yMax, z:  0f);
                val_3.Add(item:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
                UnityEngine.Vector3 val_25 = new UnityEngine.Vector3(x:  val_18.m_XMin.xMax, y:  val_18.m_XMin.yMax, z:  0f);
                val_3.Add(item:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
                UnityEngine.Vector3 val_28 = new UnityEngine.Vector3(x:  val_18.m_XMin.xMax, y:  val_18.m_XMin.yMin, z:  0f);
                val_3.Add(item:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
                UnityEngine.Vector3 val_31 = new UnityEngine.Vector3(x:  val_18.m_XMin.xMin, y:  val_18.m_XMin.yMin, z:  0f);
                val_3.Add(item:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
                UnityEngine.Color val_32 = UnityEngine.Color.white;
                val_4.Add(item:  new UnityEngine.Color() {r = val_32.r, g = val_32.g, b = val_32.b, a = val_32.a});
                UnityEngine.Color val_33 = UnityEngine.Color.white;
                val_4.Add(item:  new UnityEngine.Color() {r = val_33.r, g = val_33.g, b = val_33.b, a = val_33.a});
                UnityEngine.Color val_34 = UnityEngine.Color.white;
                val_4.Add(item:  new UnityEngine.Color() {r = val_34.r, g = val_34.g, b = val_34.b, a = val_34.a});
                UnityEngine.Color val_35 = UnityEngine.Color.white;
                val_4.Add(item:  new UnityEngine.Color() {r = val_35.r, g = val_35.g, b = val_35.b, a = val_35.a});
                UnityEngine.Vector2 val_36 = UnityEngine.Vector2.up;
                val_6.Add(item:  new UnityEngine.Vector2() {x = val_36.x, y = val_36.y});
                UnityEngine.Vector2 val_37 = UnityEngine.Vector2.one;
                val_6.Add(item:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y});
                UnityEngine.Vector2 val_38 = UnityEngine.Vector2.right;
                val_6.Add(item:  new UnityEngine.Vector2() {x = val_38.x, y = val_38.y});
                UnityEngine.Vector2 val_39 = UnityEngine.Vector2.zero;
                val_6.Add(item:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
                val_5.Add(item:  0);
                val_5.Add(item:  1);
                val_5.Add(item:  2);
                val_5.Add(item:  2);
                val_5.Add(item:  3);
                val_5.Add(item:  0);
                val_53 = val_53 + 1;
            }
            
                val_55 = val_55 + 1;
            }
            while(val_55 < val_2);
            
            }
            
            if(val_2 < 1)
            {
                    return;
            }
            
            if(this.meshLine != 0)
            {
                    this.meshLine.Clear(keepVertexLayout:  false);
                val_55 = this.meshLine;
            }
            else
            {
                    UnityEngine.Mesh val_41 = null;
                val_55 = val_41;
                val_41 = new UnityEngine.Mesh();
                this.meshLine = val_55;
            }
            
            val_41.vertices = val_3.ToArray();
            this.meshLine.uv = val_6.ToArray();
            this.meshLine.triangles = val_5.ToArray();
            this.meshLine.colors = val_4.ToArray();
            UnityEngine.GL.LoadOrtho();
            this.commandBuffer.Clear();
            this.commandBuffer.SetRenderTarget(rt:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = this.rti, m_NameID = this.rti, m_InstanceID = this.rti, m_BufferPointer = val_39.x, m_CubeFace = 1152921513682505968});
            val_52 = this.commandBuffer;
            UnityEngine.Matrix4x4 val_46 = UnityEngine.Matrix4x4.identity;
            val_52.DrawMesh(mesh:  this.meshLine, matrix:  new UnityEngine.Matrix4x4() {m00 = val_22.x, m01 = val_49, m11 = val_49, m21 = val_49, m31 = val_49, m02 = val_47, m12 = val_47, m22 = val_47, m32 = val_47, m03 = val_48, m13 = val_48, m23 = val_48, m33 = val_48}, material:  this.scratchCard.Eraser);
            UnityEngine.Graphics.ExecuteCommandBuffer(buffer:  this.commandBuffer);
            this.IsScratched = true;
        }
        public void FillRenderTextureWithColor(UnityEngine.Color color)
        {
            this.commandBuffer.SetRenderTarget(rt:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = this.rti, m_NameID = this.rti, m_InstanceID = this.rti, m_BufferPointer = color.r, m_CubeFace = true});
            this.commandBuffer.ClearRenderTarget(clearDepth:  false, clearColor:  true, backgroundColor:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
            UnityEngine.Graphics.ExecuteCommandBuffer(buffer:  this.commandBuffer);
        }
        public void SetImageSize(UnityEngine.Vector2 size)
        {
            this.imageSize = size;
            mem[1152921513683136140] = size.y;
        }
    
    }

}
