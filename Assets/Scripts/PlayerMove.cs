using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 2f; //이동 속도
    public bool isFighting = false;

    void Update()
    {
        //전투중아닐때만이동
        if (!isFighting)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
