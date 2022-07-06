using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Platforms
{
    public class SpawnPlatform : MonoBehaviour
    {
        [Header("Platform Prefabs")]
        [SerializeField] private GameObject staticPlatform;
        [SerializeField] private GameObject flyPlatform;
        [SerializeField] private GameObject fallingPlatform;
        [SerializeField] private GameObject finishPlatform;
        

        private Vector3 _min;
        private Vector3 _max;

        private float _chanceStaticSpawn = 0.5f;
        private float _chanceFlySpawn = 0.3f;
        private float _chanceFallingSpawn = 0.1f;
        
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
                spawnPosition.y += Random.Range(0.23f, 0.8f);

                if (Random.value < _chanceStaticSpawn)
                {
                    Instantiate(staticPlatform, spawnPosition, Quaternion.identity);
                } else
                {
                    if (Random.value < _chanceStaticSpawn)
                    {
                        Instantiate(flyPlatform, spawnPosition, Quaternion.identity);
                    } else
                    {
                        Instantiate(fallingPlatform, spawnPosition, Quaternion.identity);
                    }
                }
            }
            spawnPosition.x = Random.Range(_min.x, _max.x);
            spawnPosition.y += Random.Range(0.23f, 0.8f);

            Instantiate(finishPlatform, spawnPosition, Quaternion.identity);
        }
    }
}
