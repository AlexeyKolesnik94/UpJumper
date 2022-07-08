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

        [Header("Platform Count")]
        [SerializeField] private int platformCount;

        [Header("Platform Range")]
        [SerializeField] private float platformRangeMin;
        [SerializeField] private float platformRangeMax;
        
        private Vector3 _min;
        private Vector3 _max;

        private float _chanceStaticSpawn = 0.5f;

        private void Start()
        {
            _min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));   
            _max = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1f, Camera.main.nearClipPlane));
            
            Spawn();
        }

        private void Spawn()
        {
            Vector3 spawnPosition = new Vector3();
            
            for (int i = 0; i < platformCount; i++)
            {
                spawnPosition.x = Random.Range(_min.x, _max.x);
                spawnPosition.y += Random.Range(platformRangeMin, platformRangeMax);

                if (Random.value < _chanceStaticSpawn)
                {
                    Instantiate(staticPlatform, spawnPosition, Quaternion.identity);
                } else
                {
                    Instantiate(Random.value < _chanceStaticSpawn ? flyPlatform : fallingPlatform, spawnPosition,
                        Quaternion.identity);
                }
            }
            spawnPosition.x = Random.Range(_min.x, _max.x);
            spawnPosition.y += Random.Range(platformRangeMin, platformRangeMax);

            Instantiate(finishPlatform, spawnPosition, Quaternion.identity);
        }
    }
}
