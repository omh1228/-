using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private Dictionary<int, string> items = new Dictionary<int, string>();

    void Start()
    {
        items[1] = "Sword";
        items[2] = "Potion";

        Debug.Log(items[1]);
    }
}