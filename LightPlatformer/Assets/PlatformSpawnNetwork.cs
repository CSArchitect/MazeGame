using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class PlatformSpawnNetwork : NetworkBehaviour {

    public GameObject movingPlatform;

    public override void OnStartServer()
    {
        base.OnStartServer();

        var platform1 = (GameObject)Instantiate(movingPlatform, transform.position, transform.rotation);
        NetworkServer.Spawn(movingPlatform);
    }
}
