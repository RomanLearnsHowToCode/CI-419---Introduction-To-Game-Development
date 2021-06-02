/*Libraries and documentation*/
using UnityEngine;

public class ButtonSFX : MonoBehaviour
{
    public AudioSource ButtonSound; 
    public AudioClip ButtonHover; // Variable of soundclip with value of ButtonHover
    public AudioClip ButtonClick; // Variable of soundclip with value of ButtonClick

    public void HoverSound()
    {
        ButtonSound.PlayOneShot(ButtonHover); // Play soundclip stored in ButtonHover variable
    }

    public void ClickSound()
    {
        ButtonSound.PlayOneShot(ButtonClick); // Play soundclip stored in ButtonClick variable
    }

}
