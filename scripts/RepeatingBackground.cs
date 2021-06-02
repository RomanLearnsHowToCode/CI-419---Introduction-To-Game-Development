/*Libraries and documentation*/
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    public float speed; // Variable will set speed of background transformation

    public float endX; // Variable will set endX value, where our image finish
    public float startX; // Variable will set startX value, where our image beggins

    // Update is called once per frame
    private void Update()
    {
        // Will move background image to left in value of speed
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // If X value is less or equal to endX value then new Vectro2 position will be startX
        if (transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }

    }
}
