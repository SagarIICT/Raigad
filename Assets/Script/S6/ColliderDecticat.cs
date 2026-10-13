using UnityEngine;

public class ColliderDecticat : MonoBehaviour
{
    public Hirakani hirakani;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            hirakani.OnPlayerEnter2D1();
        }
    }
}
