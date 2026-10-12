using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke(nameof(loading), 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void loading()
    {
        SceneManager.LoadScene("S2 Title And Mode Select");
    }
}
