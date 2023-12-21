using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorButtons : MonoBehaviour
{
    [SerializeField] private ColorManager colorManager;
    public void OnClick()
    {
        colorManager.selectedColor = (this.GetComponent<Button>().colors.normalColor);
        Debug.Log(colorManager.selectedColor);
    }
}
