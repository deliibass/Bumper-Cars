using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public bool gPActive, bPActive, rPActive, lPActive;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            m_Car.Move(h, v, v, 0f);

            if (gPActive)
            {
                Handheld.Vibrate();
                m_Car.Move(0f, 1f, 1f, 0f);
            }

            if (bPActive)
            {
                Handheld.Vibrate();
                m_Car.Move(0f, -1f, -1f, 0f);
            }

            if (rPActive)
            {
                Handheld.Vibrate();
                m_Car.Move(1f, 0f, 0f, 0f);
            }

            if (lPActive)
            {
                Handheld.Vibrate();
                m_Car.Move(-1f, 0f, 0f, 0f);
            }
        }

        public void VibrateButton()
        {
            Handheld.Vibrate();
        }

        public void GasPedalActive()
        {
            gPActive = true;
        }

        public void GasPedalDeactive()
        {
            gPActive = false;
        }

        public void BreakPedalActive()
        {
            bPActive = true;
        }

        public void BreakPedalDeactive()
        {
            bPActive = false;
        }

        ////////////////////////////////////////////////
        public void RightPedalActive()
        {
            rPActive = true;
        }

        public void RightPedalDeactive()
        {
            rPActive = false;
        }

        public void LeftPedalActive()
        {
            lPActive = true;
        }

        public void LeftPedalDeactive()
        {
            lPActive = false;
        }
    }
}
