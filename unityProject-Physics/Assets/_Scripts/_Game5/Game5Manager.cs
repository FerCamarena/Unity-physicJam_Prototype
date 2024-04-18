using UnityEngine;
public class Game5Manager : MonoBehaviour {
    [SerializeField] private Collider2D player11;
    [SerializeField] private Collider2D player12;
    [SerializeField] private Collider2D player21;
    [SerializeField] private Collider2D player22;
    [SerializeField] private Collider2D player31;
    [SerializeField] private Collider2D player32;
    [SerializeField] private Collider2D player41;
    [SerializeField] private Collider2D player42;
    [SerializeField] private Collider2D test1;
    [SerializeField] private Collider2D test2;
    [SerializeField] private Collider2D test3;
    [SerializeField] private Collider2D test4;
    [SerializeField] private KeyCode player1Key = KeyCode.Q;
    [SerializeField] private KeyCode player2Key = KeyCode.C;
    [SerializeField] private KeyCode player3Key = KeyCode.KeypadMinus;
    [SerializeField] private KeyCode player4Key = KeyCode.KeypadPeriod;
    [SerializeField] private Transform player1Lane;
    [SerializeField] private Transform player2Lane;
    [SerializeField] private Transform player3Lane;
    [SerializeField] private Transform player4Lane;
    [SerializeField] private GameObject positive_Prefab;
    [SerializeField] private GameObject negative_Prefab;
    [SerializeField] private Color positive;
    [SerializeField] private Color negative;
    private void Start() {
        InvokeRepeating("GenerateObstacles", 1.0f, 1.0f);
    }
    private void GenerateObstacles() {
        Player1Obstacles();
        Player2Obstacles();
        Player3Obstacles();
        Player4Obstacles();
    }
    private void Player1Obstacles() {
        Instantiate(Random.Range(0, 2) == 1 ? positive_Prefab : negative_Prefab, player1Lane.transform.position, Quaternion.identity);
    }
    private void Player2Obstacles() {
        Instantiate(Random.Range(0, 2) == 1 ? positive_Prefab : negative_Prefab, player2Lane.transform.position, Quaternion.identity);
    }
    private void Player3Obstacles() {
        Instantiate(Random.Range(0, 2) == 1 ? positive_Prefab : negative_Prefab, player3Lane.transform.position, Quaternion.identity);
    }
    private void Player4Obstacles() {
        Instantiate(Random.Range(0, 2) == 1 ? positive_Prefab : negative_Prefab, player4Lane.transform.position, Quaternion.identity);
    }
    private void Update() {
        if (Input.GetKey(player1Key)) {
            player11.GetComponent<SpriteRenderer>().color = negative;
            player11.enabled = true;
            player12.enabled = false;
        } else {
            player11.GetComponent<SpriteRenderer>().color = positive;
            player11.enabled = false;
            player12.enabled = true;
        }
        if (Input.GetKey(player2Key)) {
            player21.enabled = true;
            player22.enabled = false;
            player21.GetComponent<SpriteRenderer>().color = negative;
        } else {
            player21.GetComponent<SpriteRenderer>().color = positive;
            player21.enabled = false;
            player22.enabled = true;
        }
        if (Input.GetKey(player3Key)) {
            player31.GetComponent<SpriteRenderer>().color = negative;
            player31.enabled = true;
            player32.enabled = false;
        } else {
            player31.GetComponent<SpriteRenderer>().color = positive;
            player31.enabled = false;
            player32.enabled = true;
        }
        if (Input.GetKey(player4Key)) {
            player41.GetComponent<SpriteRenderer>().color = negative;
            player41.enabled = true;
            player42.enabled = false;
        } else {
            player41.GetComponent<SpriteRenderer>().color = positive;
            player41.enabled = false;
            player42.enabled = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D collided) {
        if(collided != null) {
            if(collided.otherCollider == test1) {
                Debug.Log("lose 1");
            }
            if(collided.otherCollider == test2) {
                Debug.Log("lose 2");
            }
            if(collided.otherCollider == test3) {
                Debug.Log("lose 3");
            }
            if(collided.otherCollider == test4) {
                Debug.Log("lose 4");
            }
        }
    }
}