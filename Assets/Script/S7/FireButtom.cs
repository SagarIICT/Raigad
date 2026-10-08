using UnityEngine;

public class FireButtom : MonoBehaviour
{
    public GameObject FireButtonOn;
    public GameObject FireButtonOff;
    public Animator Fire;

    public GameObject fireSprite;
    void Start()
    {
        FireButtonOff.SetActive(false);
        fireSprite.SetActive(false);
    }

    public void OnLampButoonClick()
    {
        FireButtonOff.SetActive(false);
        FireButtonOn.SetActive(true);
        fireSprite.SetActive(false);

    }
    public void OffLampButoonClick()
    {
        FireButtonOff.SetActive(true);
        FireButtonOn.SetActive(false);
        fireSprite.SetActive(true);
        Fire.Play("Fire");
    }


}
