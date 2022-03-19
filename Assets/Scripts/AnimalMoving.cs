using UnityEngine;
public class AnimalMoving : MonoBehaviour
{
    // Fields
    private string animIdle;
    private string animWalk;
    private Spine.Unity.SkeletonGraphic anim;
    private float idleDuration;
    private float walkDuration;
    private AnimalState animalState;
    private float currentTime;
    
    // Methods
    private void Start()
    {
        this.anim = this.GetComponent<Spine.Unity.SkeletonGraphic>();
        this.idleDuration = UnityEngine.Random.Range(min:  3f, max:  8f);
        this.animalState = 0;
        Spine.Animation val_3 = this.anim.skeleton.data.FindAnimation(animationName:  this.animWalk);
        this.walkDuration = val_3.duration;
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.currentTime + val_1;
        this.currentTime = val_1;
        if(this.animalState != 1)
        {
                if(this.animalState != 0)
        {
                return;
        }
        
            if(val_1 < this.idleDuration)
        {
                return;
        }
        
            this.currentTime = 0f;
            Spine.TrackEntry val_2 = this.anim.state.SetAnimation(trackIndex:  0, animationName:  this.animWalk, loop:  true);
            this.animalState = 1;
            this.idleDuration = UnityEngine.Random.Range(min:  3f, max:  8f);
            return;
        }
        
        if(val_1 < this.walkDuration)
        {
                return;
        }
        
        this.currentTime = 0f;
        Spine.TrackEntry val_4 = this.anim.state.SetAnimation(trackIndex:  0, animationName:  this.animIdle, loop:  true);
        this.animalState = 0;
    }
    public AnimalMoving()
    {
        this.animIdle = "idle";
        this.animWalk = "walk";
    }

}
