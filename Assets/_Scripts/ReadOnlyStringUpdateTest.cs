using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static F;

public class ReadOnlyStringUpdateTest : MonoBehaviour
{
    public StringVariable stringVariable;
    public TextReplacer textReplacer;

    public void ChangeStringVariable()
    {
        //stringVariable.SetValue("This is a new value set from Code");
        stringVariable = StringVariable.CreateAsReadOnly(new StringVariable() { Value = Some("NEW STRING VARIABLE!") });
        textReplacer.GetValueToString = stringVariable.GetValueToString;
    }

    public void ChangeStringValue()
    {
        stringVariable.SetValue("ERROR! NEW STRING VALUE!");
    }
}
