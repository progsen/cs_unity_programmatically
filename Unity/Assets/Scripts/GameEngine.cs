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
	

    void Start()
    {


        GameObject enemyObj = Instantiate(pigModel,new Vector3(0, 0, 0), Quaternion.identity);
        enemy = new Enemy(enemyObj);//deze werkt nog niet ga naar Enemy.cs en los de ??? op
        enemy.from = 0;
        enemy.to = 1;

        GameObject onTile = Instantiate(tileModel,  new Vector3(0, 0, 0), Quaternion.identity);
        GameObject towerObj = Instantiate(towerModel, onTile.transform.position + new Vector3(0, 0.1f, 0), Quaternion.identity);
        tower = new Tower(towerObj, 5, onTile);//deze werkt nog niet ga naar Tower.cs en los de ??? op
    }



    void Update()
    {
    }
}