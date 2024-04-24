using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OlVideoData : MonoBehaviour
{
    public GameObject tintuc;
    public OlMail mail;
    public OlPhone phone;
    public OlYoutube youtube;

    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mail.ThongBao(tintuc);
            phone.ThongBao(tintuc);
            youtube.ThongBao(tintuc);
        }
    }
}
