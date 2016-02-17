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



//Amount it slows down, also known as damp time.
// public float friction = 0.15f;
// private Vector3 velocity = Vector3.zero;
// public Transform target;

// Update is called once per frame
//  void FixedUpdate() {
//Point in the world the mouse is at



//Vector3 point = Camera.main.WorldToViewportPoint(target.position);
//Vector3 delta = target.position - Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
//Vector3 destination = transform.position + delta;
//transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, friction);
//}
}