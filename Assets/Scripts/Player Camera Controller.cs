using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float smoothing = 0.2f;//얼마의 차이로 부드럽게 카메라가 이동하는가
    [SerializeField] Vector2 minCameraBoundary;
    [SerializeField] Vector2 maxCameraBoundary;

    private void Start(){
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

    private void FixedUpdate() {
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, transform.position.z);//현재 플레이어의 위치를 추적

        targetPos.x = Mathf.Clamp(targetPos.x, minCameraBoundary.x, maxCameraBoundary.x);//카메라 위치 제한
        targetPos.y = Mathf.Clamp(targetPos.y, minCameraBoundary.y, maxCameraBoundary.y);

        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);//천천히 카메라 이동
    }

    /*private void LateUpdate(){
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);//현재 플레이어의 위치를 추적
        transform.position = targetPos;//카메라 제한 없이 천천히 따라가기
    }
    */
}
