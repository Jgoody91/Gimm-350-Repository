using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoneTower : Tower {

    public GameObject spikePrefab;

    protected override void AttackEnemy()
    {
        base.AttackEnemy();

        // Shoot a stone
        GameObject spike = (GameObject)Instantiate(spikePrefab, towerPieceToAim.position, Quaternion.identity);
        spike.GetComponent<Spike>().enemyToFollow = targetEnemy;
        spike.GetComponent<Spike>().damage = attackPower;
    }
}
