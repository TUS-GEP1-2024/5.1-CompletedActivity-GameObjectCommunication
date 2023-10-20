using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource theAudioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayNextSong()
    {
        theAudioSource.Play();
    }

    public void StopPlayingSong()
    {
        theAudioSource.Stop();
    }
}
