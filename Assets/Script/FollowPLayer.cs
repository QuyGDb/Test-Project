using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void Start()
    {
    }
    void LateUpdate()
    {
        transform.position = player.position + offset;
        //transform.LookAt(player.localPosition);
    }
}
