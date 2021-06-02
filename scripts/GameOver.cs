/*Libraries and documentation*/
using UnityEngine;
using UnityEngine.SceneManagement; // https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html

public class GameOver : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        /*
         * If game object is active, then you can press R key for restart or Q to get into MainMenu(scene index 0)
         * 
         */

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(0);
        }

    }
}
