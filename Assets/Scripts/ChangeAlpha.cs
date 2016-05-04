using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeAlpha : MonoBehaviour
{
    public void ChangeObjectColor(string color)
    {
        string[] rgb = color.Split(',');

        this.GetComponent<Image>().color = new Color(int.Parse(rgb[0]), 
                                                     int.Parse(rgb[1]), 
                                                     int.Parse(rgb[2]), 
                                                     this.GetComponent<Image>().color.a);
    }
    
    public void ChangeObjectAlpha(float value)
    {
        this.GetComponent<Image>().color = new Color(this.GetComponent<Image>().color.r,
                                                 this.GetComponent<Image>().color.g,
                                                 this.GetComponent<Image>().color.b,
                                                 value);
    }
}







