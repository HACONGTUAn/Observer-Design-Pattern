using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class thongbaoquaYoutube : IObserver
{
    public thongbaoquaYoutube (Subject subject)
    {
        this.subject = subject;
        this.subject.ThemMayChuDeLangNghe(this);
    }
    public override void ThongBao(Subject subject, object arg)
    {
        if (subject is VideoData videoData)
        {
            Console.WriteLine(
               string.Format($"Notify all subscribers via EMAIL with new data" +
                               "\n\tName: {0}" +
                               "\n\tDescription: {1}" +
            "\n\tFile name: {2}",
                              videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName()));
        }
    }
}
