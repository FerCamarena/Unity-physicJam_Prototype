using UnityEngine;

public class Game3Manager : MonoBehaviour {
    [SerializeField] private GameObject platform1;
    [SerializeField] private GameObject platform2;
    [SerializeField] private GameObject spot1;
    [SerializeField] private GameObject spot2;
    [SerializeField] private GameObject mainPlatform;
    [SerializeField] private Collider2D left;
    [SerializeField] private Collider2D right;
    [SerializeField] private float team1Count = 0.0f;
    [SerializeField] private float team2Count = 0.0f;
    [SerializeField] private KeyCode player1Key = KeyCode.Q;
    [SerializeField] private KeyCode player2Key = KeyCode.KeypadMinus;
    [SerializeField] private KeyCode player3Key = KeyCode.C;
    [SerializeField] private KeyCode player4Key = KeyCode.KeypadPeriod;
    private void Start() {
    }
    private void Update() {
        if(Input.GetKeyDown(player1Key)) {
            team1Count++;
        }
        if(Input.GetKeyDown(player2Key)) {
            team2Count++;
        }
        if(Input.GetKeyDown(player3Key)) {
            team1Count++;
        }
        if(Input.GetKeyDown(player4Key)) {
            team2Count++;
        }

        if(team1Count > 0) team1Count -= 0.01f;
        if(team2Count > 0) team2Count -= 0.01f;

        mainPlatform.transform.Rotate(0, 0, (team2Count - team1Count) / 1800);

        platform1.transform.position = spot1.transform.position;
        platform2.transform.position = spot2.transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collided) {
        if(collided != null) {
            if (collided.otherCollider.GetInstanceID() == right.GetInstanceID()) {
                Debug.Log("Wins right");
            } else if(collided.otherCollider.GetInstanceID() == left.GetInstanceID()) {
                Debug.Log("Wins left");
            }
        }
    }
}