using UnityEngine;

public class Hirakani : MonoBehaviour
{
    public Animator hirakaniAnimtor;

    void Start()
    {
        hirakaniAnimtor.speed = 0;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hirakaniAnimtor.speed = 1;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            hirakaniAnimtor.speed = 0;
        }

        
    }
}
