using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarObjetos : MonoBehaviour
{
    Rigidbody2D rbSelect;
    public float fuerza = 500;
    public float tiempoDeVida = 3;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Basureros"))
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if(rbSelect)
        {
            Vector3 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - rbSelect.transform.position;
            rbSelect.velocity = dir * fuerza * Time.fixedDeltaTime;
        }
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rbSelect = GetRigidBodyFromMouseClick();
        }

        if (Input.GetMouseButtonUp(0))
        {
            rbSelect = null;
        }
        tiempoDeVida = tiempoDeVida - 1 * Time.deltaTime;
        if(tiempoDeVida <= 0)
        {
            Destroy(gameObject);
        }
    }


  Rigidbody2D GetRigidBodyFromMouseClick()
 {
        Vector2 clickPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(clickPoint, Vector2.zero);

        if(hit)
        {
            if(hit.collider.gameObject.GetComponent<Rigidbody2D>())
            {
                return hit.collider.gameObject.GetComponent<Rigidbody2D>();
            }
        }

        return null;
 }
}
