using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwitchController : MonoBehaviour
{
    public bool switchActive;
    public SpriteRenderer theRenderer;
    public RadioController theRadio;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        bool upPressed = Input.GetKeyDown(KeyCode.UpArrow);
        bool downPressed = Input.GetKeyDown(KeyCode.DownArrow);

        if ((downPressed == true) && (switchActive == true))
        {
            theRenderer.color = Color.white;
            theRadio.StopPlayingSong();
        }
        else if ((upPressed == true) && (switchActive == true))
        {
            theRenderer.color = Color.green;
            theRadio.PlayNextSong();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switchActive = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switchActive = false;
        }
    }
}
