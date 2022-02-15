using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _prefabItem;
    [SerializeField]
    private GameObject[] _prefabDamage
        ;
    [SerializeField]
    private float _spawnIntervalTime;

    private float _time;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        _time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        if (_time >= _spawnIntervalTime)
        {
            Spawn();
            _time = 0f;
        }
    }
    public void Spawn()
    {
        int randomNum = Random.Range(0, 11);
        if (randomNum <= 5)
        {
            int index = Random.Range(0, _prefabItem.Length); //=> MAX EXCLUSIVE

            Instantiate(_prefabItem[index], new Vector2(Random.Range(-8,8),transform.position.y), _prefabItem[index].transform.rotation);
        }
        else
        {
            int index = Random.Range(0, _prefabDamage.Length); 

            Instantiate(_prefabDamage[index], new Vector2(Random.Range(-8, 8), transform.position.y), _prefabDamage[index].transform.rotation);
        }
    }
}
