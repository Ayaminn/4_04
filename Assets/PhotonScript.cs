﻿using UnityEngine;
using System.Collections;


//Animationの設定を行うスクリプト
public class Synchronizer : Photon.MonoBehaviour {
	protected Animator anim;


//	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
//		// データを送る
//		if (stream.isWriting) {
//			//データの送信
//			stream.SendNext(transform.position);
//
//		} else {
//			//データの受信
//			transform.position = (Vector3)stream.ReceiveNext();
//			//	gameObject.GetComponent<Renderer> ().material.color= ()stream.ReceiveNext();
//		}
//	}
}