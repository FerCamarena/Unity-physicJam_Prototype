using UnityEngine;

public class Game2Player : MonoBehaviour {
    [SerializeField] private GameObject rope;
    [SerializeField] private KeyCode key;
    [SerializeField] private float force = 2;
    [SerializeField] private float direction;
    private void Update() {
        if (Input.GetKeyDown(key)) {
            rope.GetComponent<Rigidbody2D>().AddForce(Vector2.left * direction * force, ForceMode2D.Impulse);
        }
    }
}