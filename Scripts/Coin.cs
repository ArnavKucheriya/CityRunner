using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            AudioManager.instance.PlaySFX(0);
            GameManager.instance.coins++;
            Destroy(gameObject);
        }
    }
}
