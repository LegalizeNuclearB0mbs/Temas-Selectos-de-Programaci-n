using UnityEngine;

public class Trigger : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Entra trigger con " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other){
        Debug.Log("Mantiene trigger con " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other){
        Debug.Log("Sale de trigger con " + other.gameObject.name);
    }

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
