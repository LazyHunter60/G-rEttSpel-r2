using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : Item
{

    public float Uses;
    public float MaxUses;

    // Use this for initialization
    public override string ToString()
    {
        return base.ToString() + string.Format("  Uses: {0}  MaxUses: {1}", Uses, MaxUses);
    }
    private void OnMouseUpAsButton()
    {
        Use();


    }

    public virtual void Use()
    {
        if (Uses < MaxUses)
        {
            Uses = Uses + 1;
            Debug.Log(UseText());
            
            Debug.Log(Antal());
        }

        //string.Format("Du kan nu använda itemet {0} gånger till", (10 - Uses));
        if (Uses == MaxUses)
        {
            Debug.Log(NoUsesRemaningText());
        }

    }

    public virtual string UseText()
    {
        return string.Format("Du har nu använt {1} {0} gånger", Uses, Name);
    }

    public string NoUsesRemaningText()
    {
        return string.Format("Du har gjort slut på {0}", Name);
    }
    public string Antal()
    {
        return string.Format("Du har nu {0} styckna {1} kvar", MaxUses - Uses, Name);
    }

}



