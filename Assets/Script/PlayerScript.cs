using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	//ステータスボーナス
	public int maxHPbonus = 0;
	public int powerbonus = 0;
	public int defencebonus = 0;
	//状態フラグ
	public bool attackflg = false;
	public bool damageflg = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//可視化するステータス
		int MaxHP = 3 + maxHPbonus;
		int power = 1 + powerbonus;
		int defence = 0 + defencebonus;

	}

}
