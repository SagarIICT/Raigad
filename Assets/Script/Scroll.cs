using UnityEngine;

public class Scroll : MonoBehaviour
{
    public Animator scrollOpen;
    public Animator scrollClose;
    public Animator GradientUpAnimator;
    public Animator GradientDownAnimator;
    public GameObject OpenScroll;
    public GameObject CloseScroll;
    
    bool isScrollOpen;
    bool isGradientOn;

    
    public void openScroll()
    {
        OpenScroll.SetActive(true);
    }
    public void closeScroll()
    {

    }
}
