using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    void Start()
    {
        Shoot(new Vector3(0, 200, 2000));
    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;   //붙어있도록
        GetComponent<ParticleSystem>().Play();          //파티클 터트리기
    }
}
