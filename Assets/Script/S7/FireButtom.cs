using UnityEngine;

public class FireButtom : MonoBehaviour
{
    public GameObject FireButtonOn;
    public GameObject FireButtonOff;
    public Animator Fire;
    public Animator mujra;

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
        Invoke(nameof(Mujra), 1f);

    }
    public void OffLampButoonClick()
    {
        FireButtonOff.SetActive(true);
        FireButtonOn.SetActive(false);
        fireSprite.SetActive(true);
        Fire.Play("Fire");
        Invoke(nameof(Mujra), 1f);
    }
    public void Mujra()
    {
        mujra.SetTrigger("Mujra");
    }


}
