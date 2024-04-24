using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoDataNew : QuanLySuKien 
{
    public GameObject thongbao;
    // public QuanLySuKien ql = new QuanLySuKien();

     void Start()
    {

    }
    void Update()
    { 
         if (Input.GetKeyDown(KeyCode.Space))
        {
            this.ThongBaoSuKien(thongbao);
        }

        
    }
}
