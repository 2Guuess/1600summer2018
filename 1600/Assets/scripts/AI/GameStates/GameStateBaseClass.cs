using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateBaseClass : ScriptableObject, IGameStateClass
{

    public virtual void Run()
    {
        Debug.Log("Running");
    }

}

public interface IGameStateClass
{
    void Run();
}
