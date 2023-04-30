using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PatrolState : State
{
    public override void Enter()
    {
        owner.GetComponent<FollowPath1>().enabled = true;
    }

    public override void Think()
    {
        if (Vector3.Distance(
            owner.GetComponent<FightingFish>().enemy.transform.position,
            owner.transform.position) < 10)
        {
            owner.ChangeState(new DefendState());
        }
    }

    public override void Exit()
    {
        owner.GetComponent<FollowPath1>().enabled = false;
    }

    public class DefendState : State
    {
        public override void Enter()
        {
            owner.GetComponent<Pursue>().target = owner.GetComponent<FightingFish>().enemy.GetComponent<Boid>();
            owner.GetComponent<Pursue>().enabled = true;
        }

        public override void Think()
        {
            Vector3 toEnemy = owner.GetComponent<FightingFish>().enemy.transform.position - owner.transform.position;
            if (Vector3.Angle(owner.transform.forward, toEnemy) < 45 && toEnemy.magnitude < 20)
            {
                GameObject bullet = GameObject.Instantiate(owner.GetComponent<FightingFish>().bullet, owner.transform.position + owner.transform.forward * 2, owner.transform.rotation);
                owner.GetComponent<FightingFish>().ammo--;
            }
            if (Vector3.Distance(
                owner.GetComponent<FightingFish>().enemy.transform.position,
                owner.transform.position) > 30)
            {
                owner.ChangeState(new PatrolState());
            }
        }

        public override void Exit()
        {
            owner.GetComponent<Pursue>().enabled = false;
        }

    }

    public class AttackState : State
    {
        public override void Enter()
        {
            owner.GetComponent<Pursue>().target = owner.GetComponent<FightingFish>().enemy.GetComponent<Boid>();
            owner.GetComponent<Pursue>().enabled = true;
        }

        public override void Think()
        {
            Vector3 toEnemy = owner.GetComponent<FightingFish>().enemy.transform.position - owner.transform.position;
            if (Vector3.Angle(owner.transform.forward, toEnemy) < 45 && toEnemy.magnitude < 30)
            {
                GameObject bullet = GameObject.Instantiate(owner.GetComponent<FightingFish>().bullet, owner.transform.position + owner.transform.forward * 2, owner.transform.rotation);
                owner.GetComponent<FightingFish>().ammo--;
            }
            if (Vector3.Distance(
                owner.GetComponent<FightingFish>().enemy.transform.position,
                owner.transform.position) < 10)
            {
                owner.ChangeState(new FleeState());
            }

        }

        public override void Exit()
        {
            owner.GetComponent<Pursue>().enabled = false;
        }
    }

    public class FleeState : State
    {
        public override void Enter()
        {
            owner.GetComponent<Flee>().targetGameObject = owner.GetComponent<FightingFish>().enemy;
            owner.GetComponent<Flee>().enabled = true;
        }

        public override void Think()
        {
            if (Vector3.Distance(
                owner.GetComponent<FightingFish>().enemy.transform.position,
                owner.transform.position) > 30)
            {
                owner.ChangeState(new AttackState());
            }
        }
        public override void Exit()
        {
            owner.GetComponent<Flee>().enabled = false;
        }
    }

  
    


}
