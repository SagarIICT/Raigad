using UnityEngine;

public class S4HotspotScroll : MonoBehaviour
{

    public Animator scrollAnimator;

    public void OpenScroll()
    {
        scrollAnimator.SetTrigger("OpenScroll");
    }
    
        public void CloseScroll()
    {
        scrollAnimator.SetTrigger("CloseScroll");
    }
}

