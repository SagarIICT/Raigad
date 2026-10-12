using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public Button button;

    

    private void Start()
    {
        if (button != null)
        {
            button.interactable = false;
        }
       
    }
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            if (button != null)
            {
                button.interactable = true;
            }

            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (button != null)
            {
                button.interactable = false;
            }

        }
    }
}