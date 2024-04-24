using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Youtube : MonoBehaviour,ISuKienLangNghe
{
    
    public float speed = 10f;
    public Vector2 vt;
 
    void Start()
    { 
        var video = FindObjectOfType<VideoDataNew>();
        video.ThemDoiTuongLangNghe(this);

        video.XoaDoiTuongLangNghe(this);
    }
    
    public void capnhat(GameObject t)
    {
        GameObject tb = Instantiate(t);
        tb.GetComponent<Transform>().parent = this.transform;
        tb.GetComponent<Transform>().position = this.transform.position;
        tb.GetComponent<Rigidbody2D>().velocity = vt * Time.deltaTime * speed;


    }
}
