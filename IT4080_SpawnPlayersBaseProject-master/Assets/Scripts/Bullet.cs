using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Bullet : NetworkBehaviour
{
    public NetworkVariable<int> Damage = new Unity.Netcode.NetworkVariable<int>(1);
}
