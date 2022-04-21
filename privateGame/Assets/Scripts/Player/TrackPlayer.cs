using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private float DistanceToPlayer;

    private void Update()
    {
        Vector3 playerInfo = Player.transform.transform.position;
        transform.position = new Vector3(playerInfo.x, playerInfo.y, playerInfo.z - DistanceToPlayer);
    }

}
