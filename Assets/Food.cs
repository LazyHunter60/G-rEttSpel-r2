using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : UseItem
{

    public float saturation;
    public bool isYummy;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {

    }

    public override string UseText()
    {
        return string.Format("Du har nu ätit {1} {0} och har nu ökat mättnaden med {2} procent", Name, Uses, saturation);    
        
     
    }
    
}
