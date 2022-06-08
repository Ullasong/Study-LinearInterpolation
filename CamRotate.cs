using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //1. 선형보간 시작지점을 찍는다. (0m)
    // 시작지점을 '반대로 마우스 휠을 위로 스크롤하면 플레이어와 카메라의 거리가 가까워지도록 한다.'에 해당
    Vector3 nearPosition;

    //2. 선형보간의 끝 지점을 찍는다. (5m)
    // 끝지점을 '마우스 휠을 아래로 스크롤하면 플레이어와 카메라의 거리가 멀어지게 한다'에 해당
    Vector3 farPositon;
    float wheelAxis = 0;

    void Start()
    {
        // 3. 시작지점을 0으로 하므로 현재 위치라고 한다.
        nearPosition = transform.position;
        Debug.Log(nearPosition);

        // 4. 끝 지점은 내(현재 위치Om) 뒤로 5m
        farPositon = nearPosition + (transform.forward * -5);
        Debug.Log(farPositon);     
    }

    void Update()
    {
        wheelAxis -= Input.GetAxis("Mouse ScrollWheel");
        Debug.Log(wheelAxis);

        // 시작위치 - 종료 위치 중의 임의의 지점을 구한다.
        // Learp 함수 사용하기 
        // 선형보간 개념과 사용이유 말로 설명할 수 있기
        // Learp 예제 만들어 풀기
        // Vector3 c = nearPosition - farPositon;
        Vector3.Lerp(nearPosition, farPositon, wheelAxis);
    }
}
