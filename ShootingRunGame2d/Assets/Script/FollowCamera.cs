using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject playerObj;
    MoveCharacterAction player;
    Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerObj =
            GameObject.FindGameObjectWithTag("Player");
        player =
            playerObj.GetComponent<MoveCharacterAction>();
        playerTransform = playerObj.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        MoveCamera();
    }
    void MoveCamera()
    {

        transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
        /*if (playerTransform != null ) 
        {
            MOve:*/
    }
}
