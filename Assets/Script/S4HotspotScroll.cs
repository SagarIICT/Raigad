using UnityEngine;


public class S4HotspotScroll : MonoBehaviour
{
    public Animator scrollAnimator;

    public Animator GradientUpAnimator;
    public Animator GradientDownAnimator;

    public GameObject Gradient;
    public GameObject ScrollOpen;
    public GameObject CloseButton;



    // OPEN SCROLL + GRADIENT
    public void OpenScroll()
    {
        ScrollOpen.SetActive(true);


        Gradient.SetActive(true);
        scrollAnimator.ResetTrigger("CloseScroll");
        scrollAnimator.SetTrigger("OpenScroll");
        CloseButton.SetActive(true);
        

    }
    public void OpenScrollS5()
    {
        ScrollOpen.SetActive(true);


        //Gradient.SetActive(true);
        scrollAnimator.ResetTrigger("CloseScroll");
        scrollAnimator.SetTrigger("OpenScroll");
        CloseButton.SetActive(true);
        Debug.Log("S6");

    }


    // CLOSE SCROLL + GRADIENT
    public void CloseScroll()
    {

        scrollAnimator.ResetTrigger("OpenScroll");
        scrollAnimator.SetTrigger("CloseScroll");

        Gradient.SetActive(false);
        CloseButton.SetActive(false);
        Debug.Log("Hii");
    }
    public void CloseScrollS6()
    {

        scrollAnimator.ResetTrigger("OpenScroll");
        scrollAnimator.SetTrigger("CloseScroll");

        CloseButton.SetActive(false);
        Debug.Log("Hii");
    }


    // GRADIENT UP
    public void GradientUp()
    {
        GradientUpAnimator.SetTrigger("Up");
    }


    // GRADIENT DOWN
    public void GradientDown()
    {
        GradientDownAnimator.SetTrigger("Down");
    }


    // TURN OFF GRADIENT
    public void GradientOff()
    {
        Gradient.SetActive(false);
    }


    // SCROLL ACTIVE
    public void ScrollActive()
    {
        ScrollOpen.SetActive(true);

    }


    // SCROLL OFF
    public void ScrollOff()
    {
        ScrollOpen.SetActive(false);

    }
    public void OpenAnimatinComp()
    {
        scrollAnimator.SetBool("IsOpen", true);
    }
    public void CloseAnimatinComp()
    {
        scrollAnimator.SetBool("IsOpen", false);
    }
}
