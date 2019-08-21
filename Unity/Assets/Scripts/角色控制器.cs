using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 角色控制器 : MonoBehaviour
{
    private new Transform transform;
    public float 移动速度 = 2;
    public float 奔跑速度 = 6;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        //控制移动
        float appSpeed = 移动速度;
        if (Input.GetKey(KeyCode.LeftShift))
            appSpeed = 奔跑速度;
        //if (Input.GetKey(KeyCode.W))
        //    transform.Translate(Vector3.forward * appSpeed * Time.deltaTime);
        //else if (Input.GetKey(KeyCode.S))
        //    transform.Translate(Vector3.back * appSpeed * Time.deltaTime);
        //if (Input.GetKey(KeyCode.A))
        //    transform.Translate(Vector3.left * appSpeed * Time.deltaTime);
        //else if (Input.GetKey(KeyCode.D))
        //    transform.Translate(Vector3.right * appSpeed * Time.deltaTime);

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * appSpeed);
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
            //向前移动
            transform.Translate(Vector3.forward * Time.deltaTime * appSpeed);
        }
    }
}
