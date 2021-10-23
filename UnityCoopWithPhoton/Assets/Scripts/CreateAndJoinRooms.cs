using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
	[SerializeField]
	InputField inputCreate;
	[SerializeField]
	InputField inputJoin;

	public void CreateRoom()
	{
		PhotonNetwork.CreateRoom(inputCreate.text);
	}

	public void JoinRoom()
	{
		PhotonNetwork.JoinRoom(inputJoin.text);
	}

	public override void OnJoinedRoom()
	{
		PhotonNetwork.LoadLevel("Game");
	}
}
