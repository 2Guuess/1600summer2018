﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;

    public Text waveCountdownText;

    private float countDown = 2f;
    private int waveIndex = 0;

	void Update ()
    {
		if(countDown <= 0)
        {
            countDown = timeBetweenWaves;
            StartCoroutine(SpawnWave());
        }
        countDown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Floor(countDown).ToString();
	}
	

	IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
	}

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
