using Player;
using UnityEngine;
using Zenject;

namespace SupportScripts
{
    public class CameraFollow : MonoBehaviour
    {
        private PlayerController player;
        
        [Inject]
        private void Construct(PlayerController playerController)
        {
            player = playerController;
        }
        
        private void LateUpdate()
        {
            if (player.transform.position.y > transform.position.y)
            {
                transform.position =
                    new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            }
        }
    }
}
