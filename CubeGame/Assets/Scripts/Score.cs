using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update() {
        float playerDistance = player.position.z + 200; // We add 200 because the player z position is -200. 
        scoreText.text = playerDistance.ToString("0"); // Add "0" to get rid of the decimals. What other parameters do we use in ToString()?
    }

}