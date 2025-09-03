using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class Selection : MonoBehaviour {
    public Material InactiveMaterial;
    public Material GazedMaterial;

    private Renderer MyRenderer;

    public static bool gazedAt;

    void Start() {
        InactiveMaterial = this.gameObject.GetComponent<Material>();
        gazedAt = false;
    }

    public void OnPointerEnter() {
        gazedAt = true;
        SetMaterial(gazedAt);
    }

    public void OnPointerExit() {
        gazedAt = false;
        SetMaterial(gazedAt);
    }

    private void SetMaterial(bool gazedAt) {
        if (InactiveMaterial != null && GazedMaterial != null) {
            MyRenderer.material = gazedAt ? GazedMaterial : InactiveMaterial;
        }
    }
    
    void Update() {
        
    }
}
