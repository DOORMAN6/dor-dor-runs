using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int CoinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;
    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + CoinCount;
        coinEndDisplay.GetComponent<Text>().text = "" + CoinCount;
    }
}
