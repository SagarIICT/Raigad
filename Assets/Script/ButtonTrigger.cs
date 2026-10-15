using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public Button button;
    public Animator scrollAnimator;
    public GameObject CloseButton;
    public GameObject text1;
    public TMP_Text text;




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
                scrollAnimator.ResetTrigger("OpenScroll");
                scrollAnimator.SetTrigger("CloseScroll");
                CloseButton.SetActive(false);
                text1.SetActive(false);
                text.text = "";
            }

        }
    }
}