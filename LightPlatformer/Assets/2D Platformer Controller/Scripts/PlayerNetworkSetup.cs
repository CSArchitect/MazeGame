using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerNetworkSetup : NetworkBehaviour {
    public GameObject mask;

	public override void OnStartLocalPlayer()
    {
        GetComponent<Controller2D>().enabled = true;
        GetComponent<Player>().enabled = true;
        Camera.main.GetComponent<CameraFollow>().setTarget(gameObject.GetComponent<Controller2D>());
        Destroy(mask);
    }

}
