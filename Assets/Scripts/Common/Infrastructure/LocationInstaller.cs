using Player;
using UnityEngine;
using Zenject;

namespace Common.Infrastructure
{
    public class LocationInstaller : MonoInstaller
    {
        [SerializeField] private Transform startPoint;
        [SerializeField] private GameObject playerPrefabs;

        public override void InstallBindings()
        {
            BindPlayer();
        }

        private void BindPlayer()
        {
            PlayerController playerController = Container
                .InstantiatePrefabForComponent<PlayerController>(playerPrefabs, startPoint.position,
                    Quaternion.identity, null);

            Container
                .Bind<PlayerController>()
                .FromInstance(playerController)
                .AsSingle();
        }
        
    }
}