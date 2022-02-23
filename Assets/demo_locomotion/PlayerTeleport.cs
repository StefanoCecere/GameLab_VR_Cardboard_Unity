using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public static PlayerTeleport I;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Teleport(Transform destination)
    {
        transform.position = destination.position;
    }
}