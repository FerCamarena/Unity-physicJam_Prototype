using UnityEngine;

public class Game1Manager : MonoBehaviour {
    [SerializeField] private GameObject pointer;
    [SerializeField] int count;
    GameObject[] players;

    private void Start() {
        InvokeRepeating("UpdatePointer", 0.0f, 5.0f);
        players = GameObject.FindGameObjectsWithTag("Player");
    }
    private void Update() {
        foreach (GameObject player in players) {
            Vector2 distance = player.transform.position - transform.position;
            if(distance.magnitude < 3) {
                player.transform.position = Vector3.Lerp(player.transform.position, transform.position, Time.fixedDeltaTime / (5 * distance.sqrMagnitude));
            }
        }
    }
    private void UpdatePointer() {
        pointer.transform.position = new Vector2(Random.Range(-17,17), Random.Range(-10, 10));
    }
    private void OnTriggerStay2D(Collider2D collided) {
        if(collided != null && collided.CompareTag("Player")) {
            count++;
            if (count > 200) {
                collided.gameObject.SetActive(false);
                count = 0;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collided) {
        if(collided != null && collided.CompareTag("Player")) {
            count = 0;
        }
    }
}