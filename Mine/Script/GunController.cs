using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunController : MonoBehaviour
{
    public GameObject bullet,gunPoint,gameoverpanel;
    public GameObject[] BulletImages;
    LineRenderer line;
    int BltCount = 5;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 gunPos = transform.position;
        Vector2 mousePos =Camera.main.ScreenToWorldPoint(Input.mousePosition);
        line.SetPosition(0, gunPoint.transform.position);
        line.SetPosition(1, Input.mousePosition);
        Vector2 offset = new Vector2(mousePos.x-gunPos.x,mousePos.y-gunPos.y);
        float angle = Mathf.Atan2(offset.y,offset.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle);
        if (Input.GetMouseButtonUp(0))
        {
            BltCount--;
            bulletFire();
            BulletImages[BltCount].SetActive(false);
        }
        if(BltCount==0)
        {
            Time.timeScale = 0;
            gameoverpanel.SetActive(true);
        }
    }
    void bulletFire()
    {
        Vector2 dir = (Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position)).normalized;
        GameObject g = Instantiate(bullet,gunPoint. transform.position,Quaternion.identity);
        g.GetComponent<Rigidbody2D>().AddForce(dir*1500);
        Destroy(g,3f);
    }
}
