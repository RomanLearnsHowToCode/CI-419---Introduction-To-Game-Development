/*Libraries and documentation*/
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Damage value will decrease player health by 1
    public int damage = 1;
    // Speed of obstacle
    public float speed;

    //If we collide with enemy object, then effect will occur
    public GameObject effect;

    //If we collide with enemy object, then shake effect will occur
    private Shake shake;

    // Variable for detecting collision
    public GameObject PlayerHit;
    

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    // Function for movement of our enemy object, with value of speed
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }


    // If Collider2D was triggered do:
    void OnTriggerEnter2D(Collider2D other)
    {
       /*
        *here we are comparing TAG if enemy collided with gameobject with PLAYER tag, if yes, then
        * do following, tagging gameobjecst is very useful for various gameobjects
        * 
        */
       if (other.CompareTag("Player"))
        {
            Instantiate(PlayerHit, transform.position, Quaternion.identity);
            shake.CamShake();
            Instantiate(effect, transform.position, Quaternion.identity);

            //Player takes damage 
            other.GetComponent<Player>().health -= damage; // health - damage
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject); // destroy enemy game object
        }
    }
}
