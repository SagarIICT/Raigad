
using UnityEngine;
using TMPro;
using System.Collections;

public class TextAppear : MonoBehaviour
{
    // TEXT 1
    public GameObject TextActive1;
    public TMP_Text text1;
    public string scrollText1 = "";

    // TEXT 2
    public GameObject TextActive2;
    public TMP_Text text2;
    public string scrollText2 = "";

    public bool isTextAnim = false;

    private Coroutine typingCoroutine1;
    private Coroutine typingCoroutine2;

    // SHOW TEXT 1
    public void ShowText()
    {
        TextActive1.SetActive(true);

        CancelInvoke(nameof(StartTyping1));

        if (typingCoroutine1 != null)
        {
            StopCoroutine(typingCoroutine1);
            typingCoroutine1 = null;
        }

        Invoke(nameof(StartTyping1), 1f);
    }

    // HIDE TEXT 1
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

        UpdateAnimationState();
    }

    // START TYPING TEXT 1
    void StartTyping1()
    {
        if (typingCoroutine1 == null)
        {
            typingCoroutine1 = StartCoroutine(
                TypeText1(scrollText1)
            );
        }
    }

    // TYPE TEXT 1
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
        UpdateAnimationState();
    }

    // SHOW TEXT 2
    public void ShowText2()
    {
        TextActive2.SetActive(true);

        CancelInvoke(nameof(StartTyping2));

        if (typingCoroutine2 != null)
        {
            StopCoroutine(typingCoroutine2);
            typingCoroutine2 = null;
        }

        Invoke(nameof(StartTyping2), 1f);
    }

    // HIDE TEXT 2
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

        UpdateAnimationState();
    }

    // START TYPING TEXT 2
    void StartTyping2()
    {
        if (typingCoroutine2 == null)
        {
            typingCoroutine2 = StartCoroutine(
                TypeText2(scrollText2)
            );
        }
    }

    // TYPE TEXT 2
    IEnumerator TypeText2(string message)
    {
        isTextAnim = true;
        text2.text = "";

        foreach (char letter in message)
        {
            text2.text += letter;
            yield return new WaitForSeconds(0.05f);
        }

        typingCoroutine2 = null;
        UpdateAnimationState();
    }

    // UPDATE ANIMATION STATE
    void UpdateAnimationState()
    {
        isTextAnim =
            typingCoroutine1 != null ||
            typingCoroutine2 != null;
    }
}
