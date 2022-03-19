using UnityEngine;

namespace ScratchCardAsset.Core
{
    public class ScratchCardInput
    {
        // Fields
        private ScratchCardAsset.Core.ScratchCardInput.ScratchHandler OnScratch;
        private ScratchCardAsset.Core.ScratchCardInput.ScratchStartHandler OnScratchStart;
        private ScratchCardAsset.Core.ScratchCardInput.ScratchLineHandler OnScratchLine;
        private ScratchCardAsset.Core.ScratchCardInput.ScratchHoleHandler OnScratchHole;
        private ScratchCardAsset.ScratchCard scratchCard;
        private UnityEngine.Vector2[] eraseStartPositions;
        private UnityEngine.Vector2[] eraseEndPositions;
        private UnityEngine.Vector2 erasePosition;
        private bool[] isScratching;
        private bool[] isStartPosition;
        private bool isWebgl;
        private const int MaxTouchCount = 10;
        
        // Properties
        public bool IsScratching { get; }
        
        // Methods
        public void add_OnScratch(ScratchCardAsset.Core.ScratchCardInput.ScratchHandler value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnScratch, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnScratch != 1152921513675775632);
            
            return;
            label_2:
        }
        public void remove_OnScratch(ScratchCardAsset.Core.ScratchCardInput.ScratchHandler value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnScratch, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnScratch != 1152921513675912208);
            
            return;
            label_2:
        }
        public void add_OnScratchStart(ScratchCardAsset.Core.ScratchCardInput.ScratchStartHandler value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnScratchStart, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnScratchStart != 1152921513676048792);
            
            return;
            label_2:
        }
        public void remove_OnScratchStart(ScratchCardAsset.Core.ScratchCardInput.ScratchStartHandler value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnScratchStart, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnScratchStart != 1152921513676185368);
            
            return;
            label_2:
        }
        public void add_OnScratchLine(ScratchCardAsset.Core.ScratchCardInput.ScratchLineHandler value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnScratchLine, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnScratchLine != 1152921513676321952);
            
            return;
            label_2:
        }
        public void remove_OnScratchLine(ScratchCardAsset.Core.ScratchCardInput.ScratchLineHandler value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnScratchLine, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnScratchLine != 1152921513676458528);
            
            return;
            label_2:
        }
        public void add_OnScratchHole(ScratchCardAsset.Core.ScratchCardInput.ScratchHoleHandler value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnScratchHole, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnScratchHole != 1152921513676595112);
            
            return;
            label_2:
        }
        public void remove_OnScratchHole(ScratchCardAsset.Core.ScratchCardInput.ScratchHoleHandler value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnScratchHole, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnScratchHole != 1152921513676731688);
            
            return;
            label_2:
        }
        public bool get_IsScratching()
        {
            if(this.isScratching == null)
            {
                    return false;
            }
            
            if(this.isScratching.Length < 1)
            {
                    return false;
            }
            
            var val_1 = 0;
            label_4:
            if(val_1 >= this.isScratching.Length)
            {
                goto label_2;
            }
            
            if(null != null)
            {
                    return true;
            }
            
            val_1 = val_1 + 1;
            if(val_1 < this.isScratching.Length)
            {
                goto label_4;
            }
            
            return false;
            label_2:
            throw new IndexOutOfRangeException();
        }
        public ScratchCardInput(ScratchCardAsset.ScratchCard card)
        {
            this.scratchCard = card;
            this.isScratching = new bool[10];
            this.isStartPosition = new bool[10];
            this.eraseStartPositions = new UnityEngine.Vector2[10];
            this.eraseEndPositions = new UnityEngine.Vector2[10];
            var val_5 = 0;
            do
            {
                if(val_5 >= (this.isStartPosition.Length << ))
            {
                    return;
            }
            
                this.isStartPosition[val_5] = true;
                val_5 = val_5 + 1;
            }
            while(this.isStartPosition != null);
            
            throw new NullReferenceException();
        }
        public void Update()
        {
            if(this.scratchCard.InputEnabled == false)
            {
                    return;
            }
            
            if(UnityEngine.Input.touchSupported != false)
            {
                    if(UnityEngine.Input.touchCount >= 1)
            {
                    if(this.isWebgl == false)
            {
                goto label_5;
            }
            
            }
            
            }
            
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
            {
                    this.isScratching[0] = false;
                this.isStartPosition[0] = true;
            }
            
            if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                this.TryScratch(fingerId:  0, position:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            }
            
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
            {
                    return;
            }
            
            this.isScratching[0] = false;
            return;
            label_5:
            int val_17 = val_8.Length;
            if(val_17 < 1)
            {
                    return;
            }
            
            var val_19 = 0;
            val_17 = val_17 & 4294967295;
            label_31:
            var val_18 = UnityEngine.Input.touches[32];
            int val_10 = fingerId + 1;
            if(phase == 0)
            {
                    this.isScratching[(long)val_10] = false;
                this.isStartPosition[(long)val_10] = true;
            }
            
            if(phase != 1)
            {
                    if(phase != 2)
            {
                goto label_26;
            }
            
            }
            
            UnityEngine.Vector2 val_14 = position;
            this.TryScratch(fingerId:  val_10, position:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            label_26:
            if(phase != 3)
            {
                    if(phase != 4)
            {
                goto label_28;
            }
            
            }
            
            this.isScratching[val_10] = false;
            label_28:
            val_19 = val_19 + 1;
            if(val_19 < (val_8.Length << ))
            {
                goto label_31;
            }
        
        }
        private void TryScratch(int fingerId, UnityEngine.Vector2 position)
        {
            UnityEngine.Vector2[] val_2;
            if(this.OnScratch != null)
            {
                    UnityEngine.Vector2 val_1 = this.OnScratch.Invoke(position:  new UnityEngine.Vector2() {x = position.x, y = position.y});
                this.erasePosition = val_1;
                mem[1152921513678355916] = val_1.y;
            }
            
            val_2 = this.eraseEndPositions;
            if(this.isStartPosition[(long)fingerId] != false)
            {
                    val_2[(long)fingerId] = this.eraseStartPositions[(long)fingerId];
                val_2 = this.eraseStartPositions;
            }
            
            val_2[(long)fingerId] = this.erasePosition;
            bool val_4 = this.isStartPosition[(long)fingerId];
            val_4 = val_4 ^ 1;
            this.isStartPosition[(long)fingerId] = val_4;
            if(this.isScratching[(long)fingerId] == true)
            {
                    return;
            }
            
            this.eraseEndPositions[(long)fingerId] = this.eraseStartPositions[(long)fingerId];
            this.isScratching[(long)fingerId] = true;
        }
        public void Scratch()
        {
            var val_2;
            var val_11 = 0;
            val_2 = 0;
            label_20:
            if(val_2 >= (this.isScratching.Length << ))
            {
                    return;
            }
            
            if(this.isScratching[val_2] == false)
            {
                goto label_15;
            }
            
            if(this.OnScratchStart != null)
            {
                    this.OnScratchStart.Invoke();
            }
            
            UnityEngine.Vector2 val_4 = this.eraseStartPositions[val_11];
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.eraseStartPositions[val_11], y = val_4}, rhs:  new UnityEngine.Vector2() {x = this.eraseEndPositions[val_11], y = this.eraseEndPositions[val_11]})) == false)
            {
                goto label_12;
            }
            
            if(this.OnScratchHole == null)
            {
                goto label_15;
            }
            
            this.OnScratchHole.Invoke(position:  new UnityEngine.Vector2() {x = this.erasePosition, y = val_4});
            goto label_15;
            label_12:
            if(this.OnScratchLine != null)
            {
                    this.OnScratchLine.Invoke(start:  new UnityEngine.Vector2() {x = this.eraseStartPositions[val_11], y = this.eraseStartPositions[val_11]}, end:  new UnityEngine.Vector2() {x = this.eraseEndPositions[val_11], y = this.eraseEndPositions[val_11]});
            }
            
            label_15:
            val_2 = val_2 + 1;
            val_11 = val_11 + 8;
            if(this.isScratching != null)
            {
                goto label_20;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
