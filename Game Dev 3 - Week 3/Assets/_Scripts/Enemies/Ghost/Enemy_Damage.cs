using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco
{
    public class Enemy_Damage : MonoBehaviour
    {
        public Player_Health player_Health;
        public int damage = 2;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.tag == "Player")
            {
                player_Health.TakeDamage(1);
            }
        }
    }
}
