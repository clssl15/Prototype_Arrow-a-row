using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float spawnRate = 1.0f;

    public int ArrowDistance = 1;
    public int ArrowSpeed = 1;

    //public GameObject projectilePrefab;
    void Start()
    {
        StartCoroutine(SpawnArrow());
    }

    
    void Update()
    {
        
    }

    IEnumerator SpawnArrow()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            GameObject pooledProjectile = ObjectPooler.sharedInstance.GetPooledObject();
            if(pooledProjectile != null)
            {
                pooledProjectile.SetActive(true);
                pooledProjectile.transform.position = transform.position;
            }
        }
    }
}
