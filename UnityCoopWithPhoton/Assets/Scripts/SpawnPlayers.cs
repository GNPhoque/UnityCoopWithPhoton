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
	[SerializeField]
	Transform hostSpawnPos;
	[SerializeField]
	Transform clienSpawnPos;

	private void Start()
	{
		//Vector3 random = new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minY, maxY));
		Vector3 random = Random.insideUnitCircle;
		if (PhotonNetwork.IsMasterClient)
		{
			PhotonNetwork.Instantiate(playerPrefab.name, hostSpawnPos.position + random, Quaternion.identity); 
		}
		else
		{
			PhotonNetwork.Instantiate(playerPrefab.name, hostSpawnPos.position + random, Quaternion.identity);
		}
	}
}
