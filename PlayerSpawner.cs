using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

    public enum SpawnState { Spawning, Waiting, Counting };

    [System.Serializable]
    public class Wave
    {
        public string name;
        public GameObject enemy;
        public int count;
        public float rate;
    }
    private healthBar health;
    public Wave[] waves;
    private int nextWave = 0;
    public int Recorder = 0;
    public float timeBetweenWaves = 5f;
    public float waveCountdown;
    private float searchCountdown = 1f;
    public GameObject[] spawnPoints;

    public SpawnState state = SpawnState.Counting;

    void Awake()
    {
        waveCountdown = timeBetweenWaves;
        health = FindObjectOfType<healthBar>();
    }

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (state == SpawnState.Waiting)
        {
            if (!EnemyIsAlive())
            {
                WaveCompleted();
            }
            else
            {
                return;
            }
        }


        if (waveCountdown <= 0)
        {
            if (state != SpawnState.Spawning && !GameObject.FindGameObjectWithTag("Player").activeInHierarchy)
            {

                
                   StartCoroutine(SpawnWave(waves[nextWave]));
                
               
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;

            if (GameObject.FindGameObjectWithTag("Player") == null)
            {
                return false;
            }
        }

        return true;
    }

    void WaveCompleted()
    {
        state = SpawnState.Counting;
        waveCountdown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            print("All waves Complete");

        }

        

        else
        {
            nextWave++;
        }

    }



    IEnumerator SpawnWave(Wave _wave)
    {

        state = SpawnState.Spawning;
        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            Recorder= _wave.count;
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        if(_wave.count == 3)
        {
            _wave.count = 1;
        }
        state = SpawnState.Waiting;

        yield break;

    }

    void SpawnEnemy(GameObject _enemy)
    {




        GameObject _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        //GameObject inst = Instantiate(_enemy, transform.position, transform.rotation) as GameObject;
        Instantiate(Resources.Load("Character Container Knight"), transform.position, transform.rotation);
    }
}
