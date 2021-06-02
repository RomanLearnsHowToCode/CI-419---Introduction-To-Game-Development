/*Libraries and documentation*/
using UnityEngine;
using UnityEngine.SceneManagement; // https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html

public class SceneControl : MonoBehaviour
{
    /*
     * Basic scene manager, where if function is called then LoadScene in tags "", or build index number
     * 
     */


    public void Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Level2()
        
    {
        SceneManager.LoadScene("Level2");
    }
    
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }


    public void LevelAdvance()
    {
        SceneManager.LoadScene("LevelAdvance");
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

}
