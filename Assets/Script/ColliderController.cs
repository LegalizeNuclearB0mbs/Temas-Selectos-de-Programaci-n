using Unity.VisualScripting;
using UnityEngine;

public class ColliderControllerr : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;

    [SerializeField]
    private string nombre;
    [SerializeField]
    private int mult;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(horizontal, 0, vertical);
        rb.AddForce(movimiento * mult);
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log(nombre + " colisionó con " + collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision) {
        Debug.Log(nombre + " mantiene la colisión con " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision) {
        Debug.Log(nombre + " cesó la colisión con " + collision.gameObject.name);
    }

}
