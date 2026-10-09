using UnityEngine;
using TMPro;
using System.Collections;

public class TextAppear : MonoBehaviour
{
    public GameObject TextActive1;
    public GameObject TextActive2;

    public TMP_Text text1;
    public TMP_Text text2;

    public bool isTextAnim = false;

    private Coroutine typingCoroutine1;
    private Coroutine typingCoroutine2;

    public void ShowText()
    {
        TextActive1.SetActive(true);

        CancelInvoke(nameof(StartTyping1));
        Invoke(nameof(StartTyping1), 1f);
    }

    public void HideText()
    {
        CancelInvoke(nameof(StartTyping1));

        if (typingCoroutine1 != null)
        {
            StopCoroutine(typingCoroutine1);
            typingCoroutine1 = null;
        }

        TextActive1.SetActive(false);
        text1.text = "";
        isTextAnim = false;
    }

    void StartTyping1()
    {
        if (typingCoroutine1 == null)
        {
            typingCoroutine1 = StartCoroutine(
                TypeText1("The Maha Darwaza was the main entrance, part of Raigad's defences. Its blind curves slowed attackers, exposing them to defenders...")
            );
        }
    }

    IEnumerator TypeText1(string message)
    {
        isTextAnim = true;
        text1.text = "";

        foreach (char letter in message)
        {
            text1.text += letter;
            yield return new WaitForSeconds(0.05f);
        }

        typingCoroutine1 = null;
        isTextAnim = false;
    }

    // TEXT 2
    public void ShowText2()
    {
        TextActive2.SetActive(true);
        TextActive1.SetActive(true);

        CancelInvoke(nameof(StartTyping2));
        Invoke(nameof(StartTyping2), 1f);
    }

    public void HideText2()
    {
        CancelInvoke(nameof(StartTyping2));

        if (typingCoroutine2 != null)
        {
            StopCoroutine(typingCoroutine2);
            typingCoroutine2 = null;
        }

        TextActive2.SetActive(false);
        text2.text = "";
    }

    void StartTyping2()
    {
        if (typingCoroutine2 == null)
        {
            typingCoroutine2 = StartCoroutine(
                TypeText2("The Maha Darwaza was the primary access route and was traditionally opened at dawn and closed at sunset...")
            );
        }
    }

    IEnumerator TypeText2(string message)
    {
        text2.text = "";

        foreach (char letter in message)
        {
            text2.text += letter;
            yield return new WaitForSeconds(0.05f);
        }

        typingCoroutine2 = null;
    }
}