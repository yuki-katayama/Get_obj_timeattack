using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public GameManager gameManager;
    private GameObject player;
    private NavMeshAgent agent;
    private Animator anim;
    private Vector3 followerPos;
    private float currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        if (gameManager.goal == true)
        {
            agent.enabled = false;
        }
        currentSpeed = (transform.position - followerPos).magnitude / Time.deltaTime;
        followerPos = transform.position;
        anim.SetFloat("FollowerSpeed", currentSpeed);
     }
}