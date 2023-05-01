using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PatrolState : State
{
    public override void Enter()
    {
        owner.GetComponent<FollowPath>().enabled = true;
    }

    public override void Think()
    {
        if (Vector3.Distance(
            owner.GetComponent<FightingFish>().enemy.transform.position,
            owner.transform.position) < 10)
        {
            owner.ChangeState(new FleeState());
        }
    }
    public override void Exit()
    {
        owner.GetComponent<FollowPath>().enabled = false;
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
            foreach (GameObject targetObject in owner.GetComponent<Flee>().targetGameObject)
            {
                //owner.GetComponent<Flee>().targetGameObject = owner.GetComponent<FightingFish>().enemy;
                owner.GetComponent<Flee>().enabled = true;
            }
        }

        public override void Think()
        {
            if (Vector3.Distance(
                owner.GetComponent<FightingFish>().enemy.transform.position,
                owner.transform.position) > 30)
            {
                owner.ChangeState(new PatrolState());
            }
        }
        public override void Exit()
        {
            owner.GetComponent<Flee>().enabled = false;
        }
    }

  
    



