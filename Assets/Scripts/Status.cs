﻿using UnityEngine;
using System.Collections;

public class Status : MonoBehaviour {

	public int playerNumber;
	public NetworkPlayer myPlayer;
	public Color primary;
	public Color secondary;
	public string playerName;
	public string playerCharacter;
	public TextMesh status;
	
		
	private Transform body;

	// Use this for initialization
	void Start () {
		body = transform.FindChild("Robot1");
		status = transform.FindChild("Status").GetComponent<TextMesh>();
		status.color = Color.red;
		status.text = "X";
	}
	
	public void SetMyPlayer (int player, Color primaryColor, Color secondaryColor, string newPlayerName){
		myPlayer = NetworkManager.playerList[player];
		playerNumber = player;
		primary = primaryColor;
		secondary = secondaryColor;
		playerName = newPlayerName;
		if(newPlayerName.Length>0){
			playerCharacter = newPlayerName[0].ToString();
		}
		else{
			playerCharacter = "";
		}
		body.FindChild("Sphere").renderer.material.color = primary;
		body.FindChild("Character").GetComponent<TextMesh>().color = secondary;
		body.FindChild("Character").GetComponent<TextMesh>().text = playerCharacter;
	}
}
