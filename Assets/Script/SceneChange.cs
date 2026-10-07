using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Animator CloudAnimatorLeft;
    public Animator CloudAnimatorRight;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void OnHomeButtonclick()
    {
        SceneManager.LoadScene("Loading");
    }
 
    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
    public void GoForward()
    {
        Debug.Log("Next");
        //CloudAnimator.SetTrigger("In");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExplorerModeButton()
    {
        
        CloudAnimatorLeft.SetTrigger("Cloud left in");
        CloudAnimatorRight.SetTrigger("Cloud Right In");
        //SceneManager.LoadScene("S4 Maha Darwaja");
    }


}


