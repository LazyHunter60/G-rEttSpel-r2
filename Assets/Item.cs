using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public string Name;
    public float Weight;
    public float Price;

    // Use this for initialization
    public float GetPricePerWeight()
    {
        return Price / Weight;
    }

    private void OnMouseEnter()
    {
        Debug.Log(ToString());
    }
    public override string ToString()
    {
        return string.Format("Name: {0}  Weight: {1}  Price: {2}", Name, Weight, Price);
    }
    // Update is called once per frame
    void Start()
    {
        ToString();
    }
}
