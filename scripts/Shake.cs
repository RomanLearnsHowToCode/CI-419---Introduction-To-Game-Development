/*Libraries and documentation*/
using UnityEngine;

//if shake is triggered, then play camAnim animation
public class Shake : MonoBehaviour
{
    public Animator camAnim;

    public void CamShake()
    {
        camAnim.SetTrigger("shake");
    }
}
