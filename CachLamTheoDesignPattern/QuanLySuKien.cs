using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuanLySuKien : MonoBehaviour
{
    public List<ISuKienLangNghe> lg = new List<ISuKienLangNghe>();

    // them su kien vao danh sach
    public void ThemDoiTuongLangNghe(ISuKienLangNghe chuthelangnghe)
    {
        lg.Add(chuthelangnghe);
    }

    public void XoaDoiTuongLangNghe(ISuKienLangNghe chuthelangnghe)
    {
        lg.Remove(chuthelangnghe);
    }
    public void ThongBaoSuKien(GameObject thongbao)
    {
        foreach(var i in lg)
        {
            i.capnhat(thongbao);
        }
    }

}
