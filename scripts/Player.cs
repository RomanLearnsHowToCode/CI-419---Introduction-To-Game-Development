/*Libraries and documentation*/
using UnityEngine; 
using UnityEngine.SceneManagement; // https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html
using UnityEngine.UI; // https://docs.unity3d.com/ScriptReference/UI.Text.html

public class Player : MonoBehaviour
{ 
    private Vector2 targetPos; 
    // https://docs.unity3d.com/ScriptReference/Vector2.html
    public float Yincrement;
    // Variable with value of Y axis increment
    public float speed;
    /* 
     * Variable with value of speed in use of Time.deltaTime will create value which
     * will set correct speed. So game won't be slower or faster at different CPU
     */
    public float maxHeight;
    /*
     *This variable will set max Height of movement for our player 
     * (so it won't go out of screen boundaries at top of the screen)
     */
    public float minHeight;
    /*
     *This variable will set min Height of movement for our player 
     * (so it won't go out of screen boundaries at the bottom of the screen)
     */
    public int health = 3;
    // Amount of health points of our character
    public GameObject effect;  
    // Effect I created and will occur if player is moving up or down
    public Text healthDisplay;
    // Health Display will display text HP + actual amount of HP points

    public GameObject PlayerMove;
    // Variable created for PlayerMove effect, audio and Destroyer script, which will delete effect and audio after time
    public GameObject PlayerMoveDown;
    // Variable created for PlayerMoveDown effect, audio and Destroyer script, which will delete effect and audio after time
    public GameObject GameOver;
    // GameOver game object is called IF player health is 0.
    public GameObject ScoreManager;
    // Score Manager game object is responsible for counting our score points.


    // Update is called once per frame
    void Update()
    {

        
        healthDisplay.text = "Hp " + health.ToString();
        // Will show text Hp + amount of actual health
        
        if(health <= 0)
        {
            GameOver.SetActive(true);
            Destroy(gameObject);
            Destroy(ScoreManager);
        }

        /*
         *If health is less or equal to 0, then set GameOver active, Destroy GameObject player  
         * And destroy ScoreManager game object (so player won't get score after is destroyed.
         */
        
        {
            if (Input.GetKeyDown(KeyCode.E))
                SceneManager.LoadScene(0);
        }

        /*
         *If you press key E, then game will end and take you to main menu 
         */

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        // function responsible for updating position of our player game object

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(PlayerMove, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);  
        }

        /*
         * IF key input is arrow UP and is less than maxHeight value, then do player move,
         * do effect, transform player position to new Vector2 + Yinctrement
         */

        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(PlayerMoveDown, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }

        /*
         * IF key input is arrow down and is more than minHeight value, then do player move,
         * do effect, transform player position to new Vector2 - Yinctrement
         */

    }
}
    

