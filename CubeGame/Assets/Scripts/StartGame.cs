using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public void StartTheGame() {
        // You can use the build index that is in setting -> build settings to load up a new level.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}