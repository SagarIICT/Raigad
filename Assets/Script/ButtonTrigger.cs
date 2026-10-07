using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public Button button1;
    public Button button2;

    private void Start()
    {
        if (button1 != null)
        {
            button1.interactable = false;
        }

        if (button2 != null)
        {
            button2.interactable = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (button1 != null)
            {
                button1.interactable = true;
            }

            if (button2 != null)
            {
                button2.interactable = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (button1 != null)
            {
                button1.interactable = false;
            }

            if (button2 != null)
            {
                button2.interactable = false;
            }
        }
    }
}