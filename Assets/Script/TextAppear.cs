using UnityEngine;
using TMPro;
using System.Collections;

public class TextAppear : MonoBehaviour
{
    public GameObject TextActive1;
    

    public TMP_Text text1;
    
    public string scrollText1 = "";
    

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
                TypeText1("" + scrollText1)
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

        
        text1.text = "";
    }

    void StartTyping2()
    {
        if (typingCoroutine2 == null)
        {
            typingCoroutine2 = StartCoroutine(
                TypeText1("" + scrollText1)
            );
        }
    }

    IEnumerator TypeText2(string message)
    {
        text1.text = "";

        foreach (char letter in message)
        {
            text1.text += letter;
            yield return new WaitForSeconds(0.05f);
        }

        typingCoroutine2 = null;
    }
}