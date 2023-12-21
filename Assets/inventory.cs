using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    
    public static Inventory Instance { get; private set; }
	private int neon = 0;

	public int Neon
	{
		get { return neon; }
		set { neon = value; }
	}
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.
        Debug.Log("It happened");
        if (Instance != null && Instance != this)
        {
            Debug.Log("It happened");
            Destroy(this);
        }
        else
        {
            Debug.Log("It happened");
            Instance = this;
        }
    }
}

