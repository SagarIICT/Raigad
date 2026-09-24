using System.Collections;
using UnityEngine;

public class S4HotspotScroll : MonoBehaviour
{
    public Animator scrollAnimator;
    public Animator GradientUpAnimator;
    public Animator GradientDownAnimator;

    public GameObject Gradient;
    public GameObject ScrollOpen;
    public GameObject ScrollClose;

    // OPEN SCROLL
    public void OpenScroll()
    {
        ScrollOpen.SetActive(true);
        ScrollClose.SetActive(false);

        StartCoroutine(PlayOpenAnimation());
    }

    IEnumerator PlayOpenAnimation()
    {
        yield return null;

        scrollAnimator.SetTrigger("OpenScroll");
    }

    // CLOSE SCROLL
    public void CloseScroll()
    {
        scrollAnimator.SetTrigger("CloseScroll");

        StartCoroutine(HideScrollAfterAnimation());
    }

    IEnumerator HideScrollAfterAnimation()
    {
        yield return new WaitForSeconds(0.5f);

        ScrollOpen.SetActive(false);
        ScrollClose.SetActive(true);
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
        ScrollClose.SetActive(false);
    }

    // SCROLL OFF
    public void ScrollOff()
    {
        ScrollOpen.SetActive(false);
        ScrollClose.SetActive(true);
    }
}