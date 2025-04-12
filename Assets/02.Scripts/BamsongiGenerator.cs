using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public Text count_Text;

    public int bamsongi_Count;
    void Update()
    {
        count_Text.text = bamsongi_Count.ToString() + "/5";

        if(Input.GetMouseButtonDown(0) && bamsongi_Count > 0)
        {
            bamsongi_Count--;

            GameObject bamsongi = Instantiate(bamsongiPrefab);

            // 스크린 좌표를 전달하여 -> 월드 좌표계로 계산
            // 곱하기 계산 편하게 하기 위해 정규화하여 단위 벡터로 만듦
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction.normalized;

            // 앞에 "bamsongi." 붙여야 한다는 게 크뤡이네..
            bamsongi.GetComponent<BamsongiController>().Shoot(worldDir * 2000);
        }
    }
}
