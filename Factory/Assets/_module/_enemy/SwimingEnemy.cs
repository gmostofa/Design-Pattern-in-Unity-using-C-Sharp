﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimingEnemy : IEnemy
{
    int health;
    int attackDmg;
    EnemyType enemyType;
    public SwimingEnemy()
    {
        health = 10;
        attackDmg = 5;
        enemyType = EnemyType.SWIMING_ENEMY;
    }
        public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public int AttackDmg
    {
        get
        {
            return attackDmg;
        }

        set
        {
            attackDmg = value;
        }
    }

    public EnemyType EnemyType
    {
        get
        {
            return enemyType;
        }

        set
        {
            enemyType = value;
        }
    }

    public void Attact()
    {
        Debug.Log("Swiming Enemy Attack Called");
    }

    public void Move()
    {
         Debug.Log("Swiming Enemy Attack Called");
    }

    public void TakeDamage()
    {
        Debug.Log("Swiming Enemy Attack Called");
    }
}
