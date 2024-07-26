using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public static CameraFollow Instance;
   // public GameObject complete_FX;
    public float followSmooth;

    private void Awake()
    {
        Instance = this;
       // complete_FX.SetActive(false);
    }


    private void LateUpdate()
    {
        if (!PlayerController.Instance) return;
        transform.position = Vector3.MoveTowards(transform.position, PlayerController.Instance.transform.position, Time.deltaTime * followSmooth);

    }

    //public void LevelCompleteAction()
    //{
    //    complete_FX.SetActive(true);
    //}

}