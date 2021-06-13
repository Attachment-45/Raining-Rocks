using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_manager : MonoBehaviour
{

[SerializeField]
    private GameObject _enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(spawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

IEnumerator spawnRoutine()
{
  while(true)
  {
      Vector3 posToSpawn = new Vector3(Random.Range(5f, -5f ), 4, 0);
     Instantiate(_enemyPrefab, posToSpawn, Quaternion.identity);
     yield return new WaitForSeconds(1.0f);
  }


}


}
