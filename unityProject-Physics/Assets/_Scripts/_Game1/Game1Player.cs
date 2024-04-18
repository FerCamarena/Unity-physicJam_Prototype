using UnityEngine;

public class Game1Player : MonoBehaviour {
    [SerializeField] private GameObject pointer;
    [SerializeField] private KeyCode key;
    [SerializeField] private Color color;
    [SerializeField] private float force;
    [SerializeField] private float friction = 0.985f;
    [SerializeField] private float stop = 0.01f;
    [SerializeField] private float maxForce = 200.0f;
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
            if (Input.GetKeyDown(key)) {
                force = 0;
                start = pointer.transform.position;
            }
            if(Input.GetKeyUp(key)) {
                end = transform.position;
                direction = start - end;

                GetComponent<Rigidbody2D>().velocity = direction.normalized * force;
                force = 0;
            }
        }
    }
}
