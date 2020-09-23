using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public GameObject shopItemPrefrab;
    public GameObject UI;

    public Item[] shopItems;

    void Start()
    {
        foreach (var item in shopItems)
        {
            GameObject currentItem = Instantiate(shopItemPrefrab);
            currentItem.transform.GetChild(0).GetComponent<Image>().sprite = item.itemImage;
            currentItem.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = item.itemName;
            currentItem.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Price: " + item.cost.ToString("00.00") + " Muns";

            currentItem.transform.SetParent(UI.transform, false);
        }
    }
}
