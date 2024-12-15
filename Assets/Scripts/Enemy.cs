using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 1;

    public float attackRange = 2f;
    
    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player")) 
        {
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage); 
            }
        }
    }

    
