using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    private List<IObserver> _observers = new List<IObserver>();
    // Start is called before the first frame update
    
    public void ThemMayChuDeLangNghe(IObserver observer)
    {
        _observers.Add(observer);
    }
    public void LoaiBoMayChuLangNghe(IObserver observer) {
        _observers.Remove(observer);
    }

    public void ThongBaoMayChu(Subject subject , object arg)
    {
        _observers.ForEach((observer) => observer.ThongBao(subject, arg));
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
