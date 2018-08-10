using UnityEngine;

[CreateAssetMenu]
public class IfStatements : ScriptableObject
{
    private void OnEnable()
    {
        if(2 + 2 == 4)
        {
            Debug.Log("True");
        }
    }
}
