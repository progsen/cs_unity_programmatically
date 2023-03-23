using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GameEngine : MonoBehaviour
{
    public GameObject pigModel;
    public GameObject tileModel;
    public GameObject towerModel;

    private Tower tower;
    private Enemy enemy;

    //maak hier private class variable, LETOP dit wordt een ARRAY van GameObject(en):
	//1 (acces=private, Type= GameObject[], name=path)
	//gebruik nog geen new
	private ??? 

    void Start()
    {

		//maak hier een lokale variable,
        //1 (Type= RelAdd[], name=pathplus)
        //maak deze meteen ook met new aan, 10 groot graag
        ??? = new ???
        //geef path (class variable) hier een waarde met new, even groot als pathplus! 
        //- gebruik pathplus.Length voor de grote!
        ??? = new ???
		//nu maken we een for loop over pathplus 
		//zet binnen de forloop deze code neer:
        //- loop tot pathplus.Length!
		
		//path[i] = Instantiate(tileModel, new Vector3(i*2, 0, 0), Quaternion.identity);
		
		
		//pak hier het eerste GameObject uit path
		GameObject enemyStart = ???;
        GameObject enemyObj = Instantiate(pigModel,enemyStart.transform.position, Quaternion.identity);
        enemy = new Enemy(enemyObj);//deze werkt nog niet ga naar Enemy.cs en los de ??? op
        enemy.from = 0;
        enemy.to = 1;

		//pak hier het 5de GameObject uit path
		GameObject towerPlace = ???;
        GameObject onTile = Instantiate(tileModel,   towerPlace.transform.position+new Vector3(0, 0, 2), Quaternion.identity);
        GameObject towerObj = Instantiate(towerModel, onTile.transform.position + new Vector3(0, 0.1f, 0), Quaternion.identity);
        tower = new Tower(towerObj, 5, onTile);//deze werkt nog niet ga naar Tower.cs en los de ??? op
    }



    void Update()
    {
    }
}
