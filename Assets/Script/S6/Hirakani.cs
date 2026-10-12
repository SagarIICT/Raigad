using UnityEngine;
using UnityEngine.UI;

public class Hirakani : MonoBehaviour
{
    public Animator hirakaniAnimtor;
    public Animator scrollBackGroundMountain;
    public Animator ScrollOpen;
    public Animator ScrollClose;

    public GameObject Scroll;
    public GameObject Text;

    public GameObject scrollBackgroundImage;
    public GameObject scrollbackGroundMountain;
    public GameObject hirakani;
    public GameObject Image;
    public Slider mySlider;
    public float Timer = 0;
    private bool isInputOn = true;

    private float currentTime;
    private float maxTime = 5;

    void Start()
    {
        hirakaniAnimtor.speed = 0;
        scrollBackGroundMountain.speed = 0;
        Scroll.SetActive(false);
        scrollBackgroundImage.SetActive(false);
        scrollbackGroundMountain.SetActive(false);
        hirakani.SetActive(false);
        //Image.SetActive(false);
        mySlider.gameObject.SetActive(false);
        Text.SetActive(false);
    }

    
    void Update()
    {
        if (isInputOn == false)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            hirakaniAnimtor.speed = 1;
            scrollBackGroundMountain.speed = 1;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Timer = Timer + Time.deltaTime;
            currentTime = Timer;
            mySlider.value = currentTime / maxTime;
            if (Timer >= 5)
            {
                mySlider.value = 1;
                isInputOn = false;
                hirakaniAnimtor.speed = 0;
                scrollBackGroundMountain.speed = 0;
                ScrollClose.SetTrigger("CloseScroll");
                scrollBackgroundImage.SetActive(false);
                scrollbackGroundMountain.SetActive(false);
                hirakani.SetActive(false);
                Text.SetActive(false);
                mySlider.gameObject.SetActive(false);

                Invoke(nameof(HideScroll), 0.5f);
            }
       
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            hirakaniAnimtor.speed = 0;
            scrollBackGroundMountain.speed = 0;
        }
    }
    private void HideScroll()
    {
        
        Scroll.SetActive(false);
    }
    public void OnPlayerEnter2D()
    {
        
        
            Scroll.SetActive(true);
            Invoke(nameof(ShowScroll), 1.1f);
            mySlider.gameObject.SetActive(true);
        
    }
    public void ShowScroll()
    {
       // Image.SetActive(true);
        scrollBackgroundImage.SetActive(true);
        scrollbackGroundMountain.SetActive(true);
        hirakani.SetActive(true);
        Text.SetActive(true);
    }
}
