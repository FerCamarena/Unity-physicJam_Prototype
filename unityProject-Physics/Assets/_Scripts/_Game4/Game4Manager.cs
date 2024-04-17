using UnityEngine;
public class Game4Manager : MonoBehaviour {
    [SerializeField] private float force1;
    [SerializeField] private float force2;
    [SerializeField] private float force3;
    [SerializeField] private float force4;
    [SerializeField] private float goal = 25.0f;
    [SerializeField] private KeyCode player1Key = KeyCode.Q;
    [SerializeField] private KeyCode player2Key = KeyCode.C;
    [SerializeField] private KeyCode player3Key = KeyCode.KeypadMinus;
    [SerializeField] private KeyCode player4Key = KeyCode.KeypadPeriod;
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    [SerializeField] private Transform player3;
    [SerializeField] private Transform player4;
    private void Update() {
        if(force1 >= goal) {
            Debug.Log("Win1");
        }
        if(force2 >= goal) {
            Debug.Log("Win2");
        }
        if(force3 >= goal) {
            Debug.Log("Win3");
        }
        if(force4 >= goal) {
            Debug.Log("Win4");
        }

        if (Input.GetKeyDown(player1Key)) {
            force1++;
        }
        if (Input.GetKeyDown(player2Key)) {
            force2++;
        }
        if (Input.GetKeyDown(player3Key)) {
            force3++;
        }
        if (Input.GetKeyDown(player4Key)) {
            force4++;
        }

        if (force1 > 1) force1 -= 0.05f;
        if (force2 > 1) force2 -= 0.05f;
        if (force3 > 1) force3 -= 0.05f;
        if (force4 > 1) force4 -= 0.05f;

        player1.localScale = Vector3.one * (1 + force1 / 4);
        player2.localScale = Vector3.one * (1 + force2 / 4);
        player3.localScale = Vector3.one * (1 + force3 / 4);
        player4.localScale = Vector3.one * (1 + force4 / 4);
    }
}