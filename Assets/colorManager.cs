using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    public static ColorManager colorManager;
    [SerializeField] private GameObject placeholder; //please don't touch, will brick code
    public Color selectedColor;
}
