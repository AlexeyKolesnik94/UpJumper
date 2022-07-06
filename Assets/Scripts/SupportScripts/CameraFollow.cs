using System;
using Player;
using UnityEngine;

namespace SupportScripts
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private PlayerController player;

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
