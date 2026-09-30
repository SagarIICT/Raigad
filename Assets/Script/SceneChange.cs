using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Animator CloudAnimator;
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
        SceneManager.LoadScene("S4 Maha Darwaja");
    }


}


