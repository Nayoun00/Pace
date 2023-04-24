using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    private float hp;
    [SerializeField] private float _hpMax;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name + "¿¡°Ô ´ê¾ÒÀ½!");

        if (collision.CompareTag("Enemy"))
        {
            Dead();
        }

    }

    public void RecoverHP()
    {
        hp = _hpMax;
    }

    private void Awake()
    {
        hp = -_hpMax;
        Instance = this;

    }

    public void Dead()
    {
        Destroy(gameObject);
    }
}
