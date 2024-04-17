using UnityEngine;
public class game4Player : MonoBehaviour {
    [SerializeField] private float force;
    [SerializeField] private float timeLeft = 5.0f;
    [SerializeField] private KeyCode playerKey;
    private void Update() {
        if(timeLeft > 0) timeLeft -= Time.fixedDeltaTime;

        force -= Time.fixedDeltaTime;

        if (Input.GetKeyDown(playerKey) && timeLeft > 0) {
            force += 1.0f;
        }

        if (timeLeft <= 0) {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
    }
}