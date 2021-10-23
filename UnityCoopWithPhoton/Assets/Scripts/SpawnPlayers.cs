using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour
{
	[SerializeField]
	GameObject playerPrefab;
	[SerializeField]
	float minX;
	[SerializeField]
	float maxX;
	[SerializeField]
	float minY;
	[SerializeField]
	float maxY;

	private void Start()
	{
		Vector3 random = new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minY, maxY));
		PhotonNetwork.Instantiate(playerPrefab.name, random, Quaternion.identity);
	}
}
