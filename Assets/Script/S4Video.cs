using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S4Video : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        if (SceneManager.GetActiveScene().name == "Video")
        {
            Invoke(nameof(next), 9f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void next()
    {
        SceneManager.LoadScene("S5 Raj Sadar");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("hii");
            SceneManager.LoadScene("Video");


        }
    }
}
