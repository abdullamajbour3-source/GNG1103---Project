using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    public GameObject Panel_Compressor;
    public GameObject Panel_Condensor;
    public GameObject Panel_Drier;
    public GameObject Panel_Evaporator;
    public GameObject Panel_MoistureLiquidIndicator;
    public GameObject Panel_ReceiverTank;
    public GameObject Panel_Safety;

    void Start()
    {
        HideAll();
    }

    public void HideAll()
    {
        Panel_Compressor.SetActive(false);
        Panel_Condensor.SetActive(false);
        Panel_Drier.SetActive(false);
        Panel_Evaporator.SetActive(false);
        Panel_MoistureLiquidIndicator.SetActive(false);
        Panel_ReceiverTank.SetActive(false);
        Panel_Safety.SetActive(false);
    }

    public void ShowCompressor()
    {
        HideAll();
        Panel_Compressor.SetActive(true);
    }

    public void ShowCondensor()
    {
        HideAll();
        Panel_Condensor.SetActive(true);
    }

    public void ShowDrier()
    {
        HideAll();
        Panel_Drier.SetActive(true);
    }

    public void ShowEvaporator()
    {
        HideAll();
        Panel_Evaporator.SetActive(true);
    }

    public void ShowMoistureIndicator()
    {
        HideAll();
        Panel_MoistureLiquidIndicator.SetActive(true);
    }

    public void ShowReceiverTank()
    {
        HideAll();
        Panel_ReceiverTank.SetActive(true);
    }

    public void ShowSafety()
    {
        HideAll();
        Panel_Safety.SetActive(true);
    }
}

