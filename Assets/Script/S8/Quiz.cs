using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;

    public GameObject RightAnswer;
    public GameObject WrongAnswers1;
    public GameObject WrongAnswers2;
    public GameObject WrongAnswers3;
    public GameObject WrongAnswers4;

    void Start()
    {
        RightAnswer.SetActive(false);

        WrongAnswers1.SetActive(false);
        WrongAnswers2.SetActive(false);
        //WrongAnswers3.SetActive(false);
        WrongAnswers4.SetActive(false);
    }

    public void OnButtonClick()
    {
        A.GetComponent<Button>().enabled = false;
        B.GetComponent<Button>().enabled = false;
        C.GetComponent<Button>().enabled = false;
        D.GetComponent<Button>().enabled = false;

        RightAnswer.SetActive(true);

        WrongAnswers1.SetActive(true);
        WrongAnswers2.SetActive(true);
        WrongAnswers3.SetActive(true);
        WrongAnswers4.SetActive(true);
    }
}