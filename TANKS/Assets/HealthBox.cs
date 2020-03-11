using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Complete
{
    public class HealthBox : MonoBehaviour
    {
        // Start is called before the first frame update
        public float m_HealAmount = 50f;
        

        void Start()
        {   
            
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void PlayClip() {
            AudioSource audioData = this.GetComponent<AudioSource>();
            audioData.Play();
            
        }


        public void OnTriggerEnter(Collider other)
        {


            if (other.GetComponent<TankHealth>())
            {
                

                TankHealth targetHealth = other.GetComponent<TankHealth>();
                targetHealth.TakeHeal(m_HealAmount);
                Destroy(gameObject);
            }
        }
    }
}
