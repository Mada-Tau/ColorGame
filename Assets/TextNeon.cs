using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextNeon : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    //[SerializeField] private GameObject textObj;
    




    // Update is called once per frame
    void Update()
    {
        Debug.Log(Inventory.Instance);
        Debug.Log(Inventory.Instance.Neon);
        int neon = Inventory.Instance.Neon;
        text.text = ("Neon: " + neon);
    }

}
