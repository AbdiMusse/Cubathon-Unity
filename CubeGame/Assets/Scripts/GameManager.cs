using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject completeLevelUI;
    bool gameHasEnded;

    public void completeLevel() {
        FindObjectOfType<PlayerMovement>().enabled = false;
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            Invoke(nameof(RestartGame), 1f);
        }
    }

    // Returns the name of the current scene and then the scene manger reloads that scene. You can also just call the 
    // name of the scene directly if it will always be the same.
    void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}