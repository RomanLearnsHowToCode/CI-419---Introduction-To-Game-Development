/*Libraries and documentation*/
using UnityEngine;
using UnityEngine.UI; // https://docs.unity3d.com/ScriptReference/UI.Text.html
using UnityEngine.SceneManagement; // https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html

public class ScoreManager : MonoBehaviour
{ 
    // Variable will create score integer
    public int score;
    // Variable will create Text game object of value scoreDisplay
    public Text scoreDisplay;

    private void Update()
    {
        // Will show Score text + actual score value
        scoreDisplay.text = "Score " + score.ToString();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        // If ScoreManager collide with gameobject of "enemy" tag, then add to score 1
        if (other.CompareTag("enemy"))
        {
            score++;
            Debug.Log(score);
        }

        // If score equals to value of 10, then LoadScene "LevelAdvance"
        if (score == 10)
        {
            SceneManager.LoadScene("LevelAdvance");
            Debug.Log("Change scene");
        }

        // If score equals to value of 30, then LoadScene "LevelAdvance2"
        if (score == 30)
        {
            SceneManager.LoadScene("LevelAdvance2");
            Debug.Log("Change scene 2");
        }

        // If score equals to value of 50, then LoadScene "LevelAdvance3"
        if (score == 50)
        {
            SceneManager.LoadScene("LevelAdvance3");
            Debug.Log("Change scene 3");
        }

    }
}
