using UnityEngine;

public class Credits : MonoBehaviour {

    // This will close down the application. It will not work when you're in Unity but when you export the game,
    // you will see it take effect.
    public void QuitGame() {
        Application.Quit();
    }

}