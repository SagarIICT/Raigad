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
        
        CloudAnimatorLeft.SetTrigger("Cloud left in");
        CloudAnimatorRight.SetTrigger("Cloud Right In");
        Invoke(nameof(sceneChangeBackward), 2f);

    }
    public void GoForward()
    {
        Debug.Log("Next");
        //CloudAnimator.SetTrigger("In");
        
        CloudAnimatorLeft.SetTrigger("Cloud left in");
        CloudAnimatorRight.SetTrigger("Cloud Right In");
        Invoke(nameof(sceneChangeForward), 2f);
    }
    public void ExplorerModeButton()
    {
        
        CloudAnimatorLeft.SetTrigger("Cloud left in");
        CloudAnimatorRight.SetTrigger("Cloud Right In");
        Invoke(nameof(LoadMahaDarwaja), 2f);
    }
    void LoadMahaDarwaja()
    {
        SceneManager.LoadScene("S4 Maha Darwaja");
    }
    void sceneChangeForward()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void sceneChangeBackward()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


}


