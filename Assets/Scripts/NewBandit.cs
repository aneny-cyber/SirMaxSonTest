using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBandit : MonoBehaviour
{
    public float speed;
    public float distance;
    private Animator m_animator;
    private bool moovingRight = true;
    private Rigidbody2D m_body2d;

    public Transform groundDetection;

    void Start()
    {
        m_animator = GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        
        

        if (groundInfo.collider == false)
        {
            if (moovingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moovingRight = false;
            } 
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moovingRight = true;
            }
        }
        if (speed !=0)
            m_animator.SetInteger("AnimState", 2);
    }
}
