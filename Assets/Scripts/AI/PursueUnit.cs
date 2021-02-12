using UnityEngine;

namespace UnityMovementAI
{
    public class PursueUnit : MonoBehaviour
    {
        public MovementAIRigidbody target1;
        public MovementAIRigidbody target2;
        public MovementAIRigidbody target3;
        public MovementAIRigidbody target4;

        public Felt felt;

        int whichTarget;

        SteeringBasics steeringBasics;
        Pursue pursue;

        void Start()
        {
            ChoiceNumber();
            
            steeringBasics = GetComponent<SteeringBasics>();
            pursue = GetComponent<Pursue>();
        }

        void FixedUpdate()
        {
            ChoiceTarget();
            steeringBasics.LookWhereYoureGoing();
        }

        void ChoiceNumber()
        {
            int choiceTarget = Random.Range(1, 5);
            whichTarget = choiceTarget;
        }

        void ChoiceTarget()
        {

            switch (whichTarget)
            {
                case 1:
                    if (felt.enemy1Dead != true)
                    {
                        Vector3 accel1 = pursue.GetSteering(target1);
                        steeringBasics.Steer(accel1);
                        if (felt.enemy1Dead == true)
                        {
                            ChoiceTarget();
                        }
                    }
                    break;
                case 2:
                    if (felt.enemy2Dead != true)
                    {
                        Vector3 accel2 = pursue.GetSteering(target2);
                        steeringBasics.Steer(accel2);
                        if(felt.enemy2Dead == true)
                        {
                            ChoiceTarget();
                        }
                    }
                    break;
                case 3:
                    if (felt.enemy3Dead != true)
                    {
                        Vector3 accel3 = pursue.GetSteering(target3);
                        steeringBasics.Steer(accel3);
                        if (felt.enemy3Dead == true)
                        {
                            ChoiceTarget();
                        }
                    }
                    break;
                case 4:
                    if (felt.playerDead != true)
                    {
                        Vector3 accel4 = pursue.GetSteering(target4);
                        steeringBasics.Steer(accel4);
                        if (felt.playerDead == true)
                        {
                            ChoiceTarget();
                        }
                    }
                    break;
            }
        }
    }
}