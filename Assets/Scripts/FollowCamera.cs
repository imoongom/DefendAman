using UnityEngine;
using System.Collections;

/*
Carson:
Makes Camera.main (main Camera) follow whatever target is attached (gonna be used for player)
*/

public class FollowCamera : MonoBehaviour {
    public float cameraDistOffset = 10;
    private Camera mainCamera;
    private GameObject player;

    // Use this for initialization
    void Start () {
        mainCamera = GetComponent<Camera>();
        player = GameObject.Find("Wall1");
    }

    // Update is called once per frame
    void Update () {
        Vector3 playerInfo = player.transform.transform.position;
        mainCamera.transform.position = new Vector3(playerInfo.x, playerInfo.y, playerInfo.z - cameraDistOffset);
    }
}