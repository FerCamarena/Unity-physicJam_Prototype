using UnityEngine;

public class Game2Manager : MonoBehaviour {
    [SerializeField] private GameObject[] players;
    [SerializeField] private GameObject rope;
    [SerializeField] private float friction = 0.95f;
    private void Start() {
        players = GameObject.FindGameObjectsWithTag("Player");
    }
    private void Update() {
        rope.GetComponent<Rigidbody2D>().velocity *= friction;

        players[0].transform.position = Vector3.down + rope.transform.position + (Vector3.left * 5);
        players[2].transform.position = Vector3.down + rope.transform.position + (Vector3.left * 10);
        players[3].transform.position = Vector3.down + rope.transform.position + (Vector3.right * 5);
        players[1].transform.position = Vector3.down + rope.transform.position + (Vector3.right * 10);
    }
    private void OnTriggerEnter2D(Collider2D collided) {
        if(collided != null && collided.CompareTag("Player")) {
            if(collided.transform.position.x < 0) {
                Debug.Log("Derrota izq");
            } else {
                Debug.Log("Derrota der");
            }
        }
    }
}