using UnityEngine;

public class AnimationController : MonoBehaviour {
    
    public Animator animator;
    public string triggerName = "startAnimation";
    public string boolName = "Reposo";

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void ActivateTrigger() {
        animator.SetTrigger(triggerName);
    }

    public void ToggleBool() {
        bool currentValue = animator.GetBool(boolName);
        animator.SetBool(boolName, !currentValue);
    }

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
