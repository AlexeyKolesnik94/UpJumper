using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Platforms
{
    public class SpawnPlatform : MonoBehaviour
    {
        [SerializeField] private GameObject[] platformsPrefabs;

        private Vector3 _min;
        private Vector3 _max;
        
        private void Start()
        {
            _min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));   
            _max = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1f, Camera.main.nearClipPlane));
            
            Spawn();
        }

        private void Spawn()
        {
            Vector3 spawnPosition = new Vector3();
            
            for (int i = 0; i < 10; i++)
            {
                spawnPosition.x = Random.Range(_min.x, _max.x);
                spawnPosition.y += Random.Range(0.6f, 1.2f);

                int rand = Random.Range(0, platformsPrefabs.Length);

                Instantiate(platformsPrefabs[rand], spawnPosition, Quaternion.identity);
            }
        }
    }
}
