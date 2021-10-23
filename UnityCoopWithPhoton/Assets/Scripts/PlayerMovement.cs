using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    PhotonView view;

    Vector3 movement;

    void Update()
    {
		if (view.IsMine)
		{
			movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;
			rb.velocity = movement * speed; 
		}
    }

	private void FixedUpdate()
	{
        //rb.MovePosition(movement * speed * Time.deltaTime);
	}
}
