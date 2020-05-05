using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBtn : MonoBehaviour {

    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickfx;

    public void HoverSound() {
        myFx.PlayOneShot(hoverFx);
    }
    public void ClickSound()
    {
        myFx.PlayOneShot(clickfx);
    }
	
}
