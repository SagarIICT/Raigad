using UnityEngine;
using TMPro;
using System.Collections;

public class TextAppear : MonoBehaviour
{
    public GameObject TextActive;
    public TMP_Text text;
    public bool isTextAnim = false;

    public void ShowText()
    {
        TextActive.SetActive(true);

        Invoke("StartTyping", 1f);
    }
    public void HideText()
    {
        TextActive.SetActive(false);
        text.text = "";

    }


    void StartTyping()
    {
        if (!isTextAnim)
        {
            StartCoroutine(TypeText("Raigad — The proud capital of the Maratha Empire and the royal seat of Chhatrapati Shivaji Maharaj."));
            isTextAnim = true;
        }
    }

    IEnumerator TypeText(string message)
    {
        text.text = "";

        foreach (char letter in message)
        {
            text.text += letter;
            yield return new WaitForSeconds(0.01f);

        }
        isTextAnim = false;
        Debug.Log("Animation Complet");
    }
}