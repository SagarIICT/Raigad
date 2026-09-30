using UnityEngine;

public class ShowButtonsAfterTime : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;

    public float delay = 5f;

    void Start()
    {
        button1.SetActive(false);
        button2.SetActive(false);

        Invoke("ShowButtons", delay);
    }

    void ShowButtons()
    {
        button1.SetActive(true);
        button2.SetActive(true);
    }
}