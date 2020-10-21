using Microsoft.MixedReality.WebRTC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenViduLogger : MonoBehaviour
{
    public PeerConnection PeerConnection;

    // Start is called before the first frame update
    void Start()
    {


      
        PeerConnection.RenegotiationNeeded += Connection_RenegotiationNeeded;
        PeerConnection.IceGatheringStateChanged += Connection_IceGatheringStateChanged;
        PeerConnection.IceStateChanged += Connection_IceStateChanged;

    }

    private void Connection_IceStateChanged(IceConnectionState newState)
    {
        Debug.LogWarning("IceGatheringStateChanged");
    }

    private void Connection_IceGatheringStateChanged(IceGatheringState newState)
    {
        Debug.LogWarning("IceGatheringStateChanged");
    }

    private void Connection_RenegotiationNeeded()
    {
        Debug.LogWarning("RenegotiationNEeded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInitialized()
    {
        Debug.Log("<color=pink>OnInitialized</color>");
    }

    public void OnShutdown()
    {
        Debug.Log("<color=pink>OnShutdown</color>");
    }

    public void OnError(string s)
    {
        Debug.Log("<color=pink>OnError </color>"+ s);
    }
}
