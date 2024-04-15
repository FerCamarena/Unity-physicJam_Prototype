using UnityEngine;

public class player : MonoBehaviour {
    [SerializeField] private GameObject pointer;
    [SerializeField] private KeyCode c;
    [SerializeField] private Color color;
    [SerializeField] private float force;
    [SerializeField] private float friction = 0.98f;
    [SerializeField] private float stop = 0.01f;
    [SerializeField] private float maxForce = 75.0f;
    private Vector3 start;
    private Vector3 end;
    private Vector3 direction;

    private void Start() {
        GetComponent<SpriteRenderer>().color = color;
    }

    private void Update() {
        GetComponent<Rigidbody2D>().velocity *= friction;
        if (force > maxForce) force = maxForce;
        if (GetComponent<Rigidbody2D>().velocity.magnitude < stop) {
            force += 1f;
            if (Input.GetKeyDown(c)) {
                force = 0;
                start = pointer.transform.position;
            }
            if(Input.GetKeyUp(c)) {
                end = transform.position;
                direction = start - end;

                GetComponent<Rigidbody2D>().velocity = direction.normalized * force;
                force = 0;
            }
        }
    }
}
