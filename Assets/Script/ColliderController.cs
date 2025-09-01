using UnityEngine;

public class ColliderControllerr : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    
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
        Debug.Log("Colisión con :" + collision.gameObject.name);
    }

}
