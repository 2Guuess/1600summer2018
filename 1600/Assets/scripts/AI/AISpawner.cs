using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISpawner : MonoBehaviour
{
    public GameObject AI;
    public Transform destination;
    public Level CurrentLevel;

    private int aiCount;

    private void Start()
    {
        aiCount = CurrentLevel.AiCount;
        StartCoroutine(StartSpawn());
    }

    IEnumerator StartSpawn()
    {
        while(aiCount > 0)
        {
            GameObject newAI = Instantiate(AI);
            newAI.GetComponent<AIMovement>().Destination = destination;
            aiCount--;
            yield return new WaitForSeconds(CurrentLevel.Time);
        }
        CurrentLevel.CheckAICount();
    }
}
