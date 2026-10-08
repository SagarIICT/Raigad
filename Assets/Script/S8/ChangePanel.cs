using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;

    private int currentPanel = 1;

    void Start()
    {
        ShowPanel(1);
    }

    public void PanelChange()
    {
        if (currentPanel < 6)
        {
            currentPanel++;
            ShowPanel(currentPanel);
        }
    }

    void ShowPanel(int panelNumber)
    {
        // Turn all panels OFF
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);

        // Turn the required panel ON
        if (panelNumber == 1)
            panel1.SetActive(true);

        else if (panelNumber == 2)
            panel2.SetActive(true);

        else if (panelNumber == 3)
            panel3.SetActive(true);

        else if (panelNumber == 4)
            panel4.SetActive(true);

        else if (panelNumber == 5)
            panel5.SetActive(true);

        else if (panelNumber == 6)
            panel6.SetActive(true);
    }
}