using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlMail : MonoBehaviour 
{
    public float speed = 10f;
    public Vector2 vt;
    public void ThongBao(GameObject tintuc)
    {
        GameObject tb = Instantiate(tintuc);
        tb.GetComponent<Transform>().parent = this.transform;
        tb.GetComponent<Transform>().position = this.transform.position;
        tb.GetComponent<Rigidbody2D>().velocity = vt * Time.deltaTime * speed;
    }

   
}
