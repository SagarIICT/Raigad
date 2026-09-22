using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public GameObject onButton;
    public GameObject offButton;

    public void TurnOff()
    {
        onButton.SetActive(false);
        offButton.SetActive(true);
    }

    public void TurnOn()
    {
        offButton.SetActive(false);
        onButton.SetActive(true);
    }
}