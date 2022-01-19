using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
	[SerializeField]
	InputField inputCreate;
	[SerializeField]
	InputField inputJoin;
	[SerializeField]
	TMP_Text errorText;

	public void CreateRoom()
	{
		RoomOptions options = new RoomOptions();
		options.MaxPlayers = 2;
		PhotonNetwork.CreateRoom(inputCreate.text, options);
	}

	public void JoinRoom()
	{
		PhotonNetwork.JoinRoom(inputJoin.text);
	}

	public override void OnJoinedRoom()
	{
		PhotonNetwork.LoadLevel("Game");
	}

	public override void OnJoinRoomFailed(short returnCode, string message)
	{
		errorText.text = $"{message}\n{returnCode}";
	}

	public override void OnCreateRoomFailed(short returnCode, string message)
	{
		errorText.text = $"{message}\n{returnCode}";
	}
}
