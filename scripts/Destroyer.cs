/*Libraries and documentation*/
using UnityEngine; 

public class Destroyer : MonoBehaviour
{
    // Variable which will set lifetime of gameobjects
    public float lifetime;

    // Start is called before the first frame update
    // Destroy gameobject after lifetime value 
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
