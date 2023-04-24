using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float moveX, moveY;

    [Header("�̵��ӵ� ����")]
    [SerializeField] [Range(1f, 30f)] float movespeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //�̵� ( �����¿�Ű : WASD )
        moveX = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }
}
