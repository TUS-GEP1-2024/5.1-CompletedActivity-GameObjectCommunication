using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource theAudioSource;
    
    public void PlayNextSong()
    {
        theAudioSource.Play();
    }

    public void StopPlayingSong()
    {
        theAudioSource.Stop();
    }
}
