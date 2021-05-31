using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material Soapbubble;
    Color SelectColor;

    private void Start()
    {
        SelectColor = Color.black;
        Soapbubble.SetColor("Color_69D01C78", SelectColor);
    }
    public void Green()
    {
        Debug.Log("초록");
        SelectColor = Color.green;
        Soapbubble.SetColor("Color_69D01C78", SelectColor);
    }
    public void Red()
    {
        Debug.Log("레드");
        SelectColor = Color.red;
        Soapbubble.SetColor("Color_69D01C78", SelectColor);
    }
    public void Blue()
    {
        Debug.Log("블루");
        SelectColor = Color.blue;
        Soapbubble.SetColor("Color_69D01C78", SelectColor);
    }
    public void White()
    {
        Debug.Log("흰색");
        SelectColor = Color.white;
        Soapbubble.SetColor("Color_69D01C78", SelectColor);
    }
    public void Black()
    {
        Debug.Log("복귀");
        SelectColor = Color.black;
        Soapbubble.SetColor("Color_69D01C78", SelectColor);
    }
}