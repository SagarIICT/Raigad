using UnityEngine;
using TMPro;
using System.Collections;

public class TextAppear : MonoBehaviour
{
    public GameObject TextActive;
    public TMP_Text text;

    public void ShowText()
    {
        TextActive.SetActive(true);

        Invoke("StartTyping", 1f);
    }
    

    void StartTyping()
    {
        StartCoroutine(TypeText("Raigad — The proud capital of the Maratha Empire and the royal seat of Chhatrapati Shivaji Maharaj."));
    }

    IEnumerator TypeText(string message)
    {
        text.text = "";

        foreach (char letter in message)
        {
            text.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
}