using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctinoTypes : MonoBehaviour
{
    void NoReturnType()
    {

    }

    void VoidWithParams(string s, string t)
    {

    }
    
    int NameOfFunctions()
    {
        return 0;
    }

    GameObject ReturnGameObject(GameObject obj)
    {
        return obj;
    }

    IEnumerator CorroutineName()
    {
        yield return new WaitForSeconds(1);
    }
}
