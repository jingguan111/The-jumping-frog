using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    // Start is called before the first frame update

        private void OnCollisionEnter2D(Collision2D enemy)
        {
            if (enemy.gameObject.tag == "Player")
            {
                print("ƒ„À¿¡À");
            Time.timeScale = 0;
        }
 
            
        }
    
    }

