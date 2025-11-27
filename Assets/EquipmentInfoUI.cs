using UnityEngine;
using TMPro;

public class EquipmentInfoUI : MonoBehaviour
{
    [Header("UI References")]
    public GameObject panel;   // Panel_Explanation
    public TMP_Text titleText; // Text_Title
    public TMP_Text bodyText;  // Text_Body

    [Header("Explanations")]
    [TextArea] public string drierText;
    [TextArea] public string evaporatorText;
    [TextArea] public string moistureIndicatorText;
    [TextArea] public string condenserText;
    [TextArea] public string compressorText;
    [TextArea] public string receiverTankText;
    [TextArea] public string safetyText;

    void Start()
    {
        // make sure panel starts hidden
        if (panel != null)
            panel.SetActive(false);
    }

    void ShowInfo(string title, string body)
    {
        if (panel != null)
            panel.SetActive(true);

        if (titleText != null)
            titleText.text = title;

        if (bodyText != null)
            bodyText.text = body;
    }

    // One function per equipment (these are what the buttons call)
    public void ShowDrier()
    {
        ShowInfo("Drier", drierText);
    }

    public void ShowEvaporator()
    {
        ShowInfo("Evaporator", evaporatorText);
    }

    public void ShowMoistureIndicator()
    {
        ShowInfo("Moisture Liquid Indicator", moistureIndicatorText);
    }

    public void ShowCondenser()
    {
        ShowInfo("Condenser", condenserText);
    }

    public void ShowCompressor()
    {
        ShowInfo("Compressor", compressorText);
    }

    public void ShowReceiverTank()
    {
        ShowInfo("Receiver Tank", receiverTankText);
    }

    public void ShowSafety()
    {
        ShowInfo("Safety", safetyText);
    }

    public void ClosePanel()
    {
        if (panel != null)
            panel.SetActive(false);
    }
}

