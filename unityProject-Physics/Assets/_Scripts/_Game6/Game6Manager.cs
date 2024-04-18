using UnityEngine;
using UnityEngine.UI;
public class Game6Manager : MonoBehaviour {
    [SerializeField] private float force = 2.5f;
    [SerializeField] private float friction = 0.995f;
    [SerializeField] private float player1Distance;
    [SerializeField] private float player2Distance;
    [SerializeField] private float player3Distance;
    [SerializeField] private float player4Distance;
    [SerializeField] private int player1count = 0;
    [SerializeField] private int player2count = 0;
    [SerializeField] private int player3count = 0;
    [SerializeField] private int player4count = 0;
    [SerializeField] private KeyCode player1Key = KeyCode.Q;
    [SerializeField] private KeyCode player2Key = KeyCode.C;
    [SerializeField] private KeyCode player3Key = KeyCode.KeypadMinus;
    [SerializeField] private KeyCode player4Key = KeyCode.KeypadPeriod;
    [SerializeField] private Rigidbody2D player1RB;
    [SerializeField] private Rigidbody2D player2RB;
    [SerializeField] private Rigidbody2D player3RB;
    [SerializeField] private Rigidbody2D player4RB;
    [SerializeField] private Text player1Text;
    [SerializeField] private Text player2Text;
    [SerializeField] private Text player3Text;
    [SerializeField] private Text player4Text;
    [SerializeField] private Text player1Power;
    [SerializeField] private Text player2Power;
    [SerializeField] private Text player3Power;
    [SerializeField] private Text player4Power;
    private void Start() {
    }
    private void Update() {
        if(Input.GetKeyDown(player1Key)) {
            player1RB.AddForce(Vector2.right * force * 100);
            //player1RB.velocity += Vector2.right * force;
            player1count++;
        }
        if(Input.GetKeyDown(player2Key)) {
            player2RB.AddForce(Vector2.right * force * 100);
            //player2RB.velocity += Vector2.right * force;
            player2count++;
        }
        if(Input.GetKeyDown(player3Key)) {
            player3RB.AddForce(Vector2.right * force * 100);
            //player3RB.velocity += Vector2.right * force;
            player3count++;
        }
        if(Input.GetKeyDown(player4Key)) {
            player4RB.AddForce(Vector2.right * force * 100);
            //player4RB.velocity += Vector2.right * force;
            player4count++;
        }

        player1RB.velocity *= friction;
        player2RB.velocity *= friction;
        player3RB.velocity *= friction;
        player4RB.velocity *= friction;

        player1Distance = player1RB.transform.position.x;
        player2Distance = player2RB.transform.position.x;
        player3Distance = player3RB.transform.position.x;
        player4Distance = player4RB.transform.position.x;

        //player1Power.text = (100 * force * player1count / Time.realtimeSinceStartup).ToString() + " J/s";
        //player2Power.text = (100 * force * player2count / Time.realtimeSinceStartup).ToString() + " J/s";
        //player3Power.text = (100 * force * player3count / Time.realtimeSinceStartup).ToString() + " J/s";
        //player4Power.text = (100 * force * player4count / Time.realtimeSinceStartup).ToString() + " J/s";

        player1Text.text = player1Distance.ToString() + " m";
        player2Text.text = player2Distance.ToString() + " m";
        player3Text.text = player3Distance.ToString() + " m";
        player4Text.text = player4Distance.ToString() + " m";
    }
    private void OnTriggerEnter2D(Collider2D collided) {
        if(collided != null) {
            if(collided.gameObject.layer == 9) {
                player1Power.text = (100 * force * player1count / Time.realtimeSinceStartup).ToString() + " J/s";
            }
            if(collided.gameObject.layer == 10) {
                player2Power.text = (100 * force * player2count / Time.realtimeSinceStartup).ToString() + " J/s";
            }
            if(collided.gameObject.layer == 11) {
                player3Power.text = (100 * force * player3count / Time.realtimeSinceStartup).ToString() + " J/s";
            }
            if(collided.gameObject.layer == 12) {
                player4Power.text = (100 * force * player4count / Time.realtimeSinceStartup).ToString() + " J/s";
            }
        }
    }
}