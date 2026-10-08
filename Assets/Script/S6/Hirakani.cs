using UnityEngine;
using UnityEngine.UIElements;

public class Hirakani : MonoBehaviour
{
    public Animator hirakaniAnimtor;
    public Animator scrollBackGroundMountain;
    public Animator ScrollAn;
    public GameObject Scroll;

    public GameObject scrollBackgroundImage;
    public GameObject scrollbackGroundMountain;
    public GameObject hirakani;
    public GameObject Image;

    void Start()
    {
        hirakaniAnimtor.speed = 0;
        scrollBackGroundMountain.speed = 0;
        Scroll.SetActive(false);
        scrollBackgroundImage.SetActive(false);
        scrollbackGroundMountain.SetActive(false);
        hirakani.SetActive(false);
        //Image.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hirakaniAnimtor.speed = 1;
            scrollBackGroundMountain.speed = 1;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            hirakaniAnimtor.speed = 0;
            scrollBackGroundMountain.speed = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Scroll.SetActive(true);
            Invoke(nameof(ShowScroll), 1.1f);
        }
    }
    public void ShowScroll()
    {
       // Image.SetActive(true);
        scrollBackgroundImage.SetActive(true);
        scrollbackGroundMountain.SetActive(true);
        hirakani.SetActive(true);
    }
}
