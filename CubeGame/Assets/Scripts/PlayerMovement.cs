using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody body;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    // Update is called once per frame.
    // This update depends on the frame rate of your computer or how many things 
    // is going on in the background or screen on your laptop. So we use Time.DeltaTime to
    // balance it out.
    // We use FixedUpdate whenever we do some unity physics stuff.
    void FixedUpdate() {
        // Going forward
        body.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Going right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            body.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // Going left
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            body.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (body.position.y < -1f) {
            // We put -1 because y should always be around 1.
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}