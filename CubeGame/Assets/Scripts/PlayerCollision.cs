using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    // This can be called on any body that has a Rigid Body and a Box Collider component. 
    // FindObjectOfType will find that script at that moment in time as long as you have it in your scene.
    private void OnCollisionEnter(Collision collisionInfo) {
        if (!collisionInfo.collider.CompareTag("Obstacle")) return;

        FindObjectOfType<PlayerMovement>().enabled = false;
        FindObjectOfType<GameManager>().EndGame();
    }

}