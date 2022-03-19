using UnityEngine;

namespace ScratchCardAsset
{
    public class ScratchCardManager : MonoBehaviour
    {
        // Fields
        public UnityEngine.Camera MainCamera;
        public ScratchCardAsset.ScratchCardManager.ScratchCardRenderType RenderType;
        public UnityEngine.Sprite ScratchSurfaceSprite;
        public bool ScratchSurfaceSpriteHasAlpha;
        public float MaskProgressCutOffValue;
        public UnityEngine.Texture EraseTexture;
        public UnityEngine.Vector2 EraseTextureScale;
        public bool InputEnabled;
        public ScratchCardAsset.ScratchCard Card;
        public ScratchCardAsset.ScratchCard.ScratchMode Mode;
        public ScratchCardAsset.EraseProgress Progress;
        public UnityEngine.GameObject MeshCard;
        public UnityEngine.GameObject SpriteCard;
        public UnityEngine.GameObject ImageCard;
        public UnityEngine.Shader MaskShader;
        public UnityEngine.Shader BrushShader;
        public UnityEngine.Shader MaskProgressShader;
        public UnityEngine.Shader MaskProgressCutOffShader;
        private UnityEngine.Material eraserMaterial;
        private const string MaskProgressCutOffField = "_CutOff";
        
        // Methods
        private void Awake()
        {
            var val_39;
            var val_40;
            object val_41;
            UnityEngine.Camera val_42;
            UnityEngine.Material val_43;
            UnityEngine.Material val_44;
            UnityEngine.Object val_45;
            var val_46;
            string val_48;
            object val_49;
            val_39 = this;
            val_40 = 1152921504729477120;
            if(this.Card != 0)
            {
                goto label_3;
            }
            
            val_41 = "ScratchCard is null!";
            goto label_6;
            label_3:
            if(this.Card.MainCamera != 0)
            {
                goto label_10;
            }
            
            if(this.MainCamera == 0)
            {
                goto label_13;
            }
            
            val_42 = this.MainCamera;
            if(this.Card != null)
            {
                goto label_14;
            }
            
            label_13:
            label_14:
            this.Card.MainCamera = UnityEngine.Camera.main;
            label_10:
            val_43 = 0;
            if(this.Card.ScratchSurface == 0)
            {
                    UnityEngine.Material val_6 = null;
                val_43 = val_6;
                val_6 = new UnityEngine.Material(shader:  this.MaskShader);
                val_6.mainTexture = this.ScratchSurfaceSprite.texture;
                this.Card.ScratchSurface = val_43;
            }
            
            if(this.Card.Eraser == 0)
            {
                    UnityEngine.Material val_9 = new UnityEngine.Material(shader:  this.BrushShader);
                val_9.mainTexture = this.EraseTexture;
                this.eraserMaterial = val_9;
                this.Card.Eraser = val_9;
            }
            
            this.Card.BrushScale = this.EraseTextureScale;
            this.Card.Mode = this.Mode;
            val_44 = this.Card.Progress;
            if(val_44 == 0)
            {
                    var val_11 = (this.ScratchSurfaceSpriteHasAlpha == false) ? 144 : 152;
                UnityEngine.Material val_12 = null;
                val_44 = val_12;
                val_12 = new UnityEngine.Material(shader:  1152921504897421312);
                if(this.ScratchSurfaceSpriteHasAlpha != false)
            {
                    val_12.SetFloat(name:  "_CutOff", value:  this.MaskProgressCutOffValue);
            }
            
                this.Card.Progress = val_44;
            }
            
            if(this.RenderType == 2)
            {
                goto label_39;
            }
            
            if(this.RenderType == 1)
            {
                goto label_40;
            }
            
            if(this.RenderType != 0)
            {
                    return;
            }
            
            this.MeshCard.SetActive(value:  true);
            if(this.SpriteCard != 0)
            {
                    this.SpriteCard.SetActive(value:  false);
            }
            
            if(this.ImageCard != 0)
            {
                    this.ImageCard.SetActive(value:  false);
            }
            
            this.Card.Surface = this.MeshCard.transform;
            val_45 = this.MeshCard.GetComponent<UnityEngine.Renderer>();
            if(val_45 == 0)
            {
                goto label_56;
            }
            
            if(val_45 != null)
            {
                goto label_57;
            }
            
            label_39:
            if(this.MeshCard != 0)
            {
                    this.MeshCard.SetActive(value:  false);
            }
            
            if(this.SpriteCard != 0)
            {
                    this.SpriteCard.SetActive(value:  false);
            }
            
            this.ImageCard.SetActive(value:  true);
            this.Card.Surface = this.ImageCard.transform;
            val_45 = this.ImageCard.GetComponent<UnityEngine.UI.Image>();
            if(val_45 == 0)
            {
                goto label_73;
            }
            
            val_45.sprite = this.ScratchSurfaceSprite;
            val_43 = ???;
            val_46 = ???;
            val_40 = ???;
            goto typeof(UnityEngine.UI.Image).__il2cppRuntimeField_340;
            label_40:
            if((val_46 + 104) != 0)
            {
                    val_46 + 104.SetActive(value:  false);
            }
            
            val_46 + 112.SetActive(value:  true);
            if((val_46 + 120) != 0)
            {
                    val_46 + 120.SetActive(value:  false);
            }
            
            mem2[0] = val_46 + 112.transform;
            val_45 = val_46 + 112.GetComponent<UnityEngine.SpriteRenderer>();
            if(val_45 == 0)
            {
                goto label_89;
            }
            
            val_45.sprite = val_46 + 40;
            label_57:
            val_45.material = val_43;
            return;
            label_73:
            string val_35 = this.ImageCard.name;
            val_48 = "Can\'t find Image component on ";
            goto label_94;
            label_89:
            string val_36 = val_46 + 112.name;
            val_48 = "Can\'t find SpriteRenderer component on ";
            goto label_94;
            label_56:
            val_48 = "Can\'t find Renderer component on ";
            label_94:
            val_49 = val_48 + this.MeshCard.name + " GameObject!"(" GameObject!");
            val_41 = val_49;
            label_6:
            UnityEngine.Debug.LogError(message:  val_41);
        }
        public void SetEraseTexture(UnityEngine.Texture texture)
        {
            if(this.eraserMaterial != null)
            {
                    this.eraserMaterial.mainTexture = texture;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ResetScratchCard()
        {
            if(this.Card != null)
            {
                    this.Card.ResetRenderTexture();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ClearInstantly()
        {
            if(this.Card != null)
            {
                    this.Card.FillInstantly();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void SetInputEnable(bool inputEnable)
        {
            if(this.Card != null)
            {
                    this.Card.InputEnabled = inputEnable;
                return;
            }
            
            throw new NullReferenceException();
        }
        public ScratchCardManager()
        {
            this.MaskProgressCutOffValue = 0.33f;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
            this.EraseTextureScale = val_1;
            mem[1152921513675494020] = val_1.y;
            this.InputEnabled = true;
        }
    
    }

}
