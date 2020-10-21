
using System;
namespace OpenVidu
{
    [Serializable] 
    public class OpenViduSessionInfo
    {
        public string SessionId;
        public long CreatedAt;
        public string MediaMode;
        public string RecordingMode;
        public string DefaultOutputMode;
        public string DefaultRecordingLayout;
        public string CustomSessionId;
        public Connections Connections;
        public bool Recording;
    }

    [Serializable] 
    public class Connections
    {
        public long NumberOfElements;
        public Content[] Content;
    }

    [Serializable] 
    public class Content
    {
        public string ConnectionId;
        public long CreatedAt;
        public string Location;
        public string Platform;
        public string Role;
        public string ServerData;
        public string ClientData;
        public Publisher[] Publishers;
        public Subscriber[] Subscribers;
        public string Token;
    }

    [Serializable] 
    public class Publisher
    {
        public long CreatedAt;
        public string StreamId;
        public string RtspUri;
        public MediaOptions MediaOptions;
    }

    [Serializable] 
    public class MediaOptions
    {
        public bool HasAudio;
        public bool AudioActive;
        public bool HasVideo;
        public bool VideoActive;
        public string TypeOfVideo;
        public long? FrameRate;
        public string VideoDimensions;
        public Filter Filter;
        public bool? AdaptativeBitrate;
        public bool? OnlyPlayWithSubscribers;
    }

    [Serializable] 
    public class Filter
    {
    }

    [Serializable] 
    public class Subscriber
    {
        public long CreatedAt;
        public string StreamId;
    }








    [Serializable]
    public class OpenViduMessageJson
    {
        public long id;
        public string Jsonrpc;
        public string Method;
    }


    public class OpenViduJoinRoomAnswer : OpenViduMessageJson
    {

        public JoinRoomAnswerResult result;

    }

    [Serializable]
    public class JoinRoomAnswerResult
    {
        public string id;
        public long createdAt;
        public string metadata;
        public JoinRoomAnswerValue[] value;
        public string sessionId;
    }

    [Serializable]
    public class JoinRoomAnswerValue
    {
        public string id;
        public long createdAt;
        public string metadata;
        public JoinRoomAnswerStream[] streams;
    }

    [Serializable]
    public class JoinRoomAnswerStream
    {
        public string Id;
        public long CreatedAt;
        public bool HasAudio;
        public bool HasVideo;
        public bool VideoActive;
        public bool AudioActive;
        public string TypeOfVideo;
        public long FrameRate;
        public string VideoDimensions;
        public JoinRoomAnswerFilter Filter;
    }

    [Serializable]
    public class JoinRoomAnswerFilter
    {
    }


    [Serializable]
    public class OpenViduPublishVideoAnswer : OpenViduMessageJson
    {
        public OpenViduPublishVideoResult Result;

    }


    [Serializable]
    public class OpenViduPublishVideoResult
    {
        public string SdpAnswer;
        public string Id;
        public long CreatedAt;
        public string SessionId;
    }


    [Serializable]
    public class OpenViduReceiveVideoAnswer : OpenViduMessageJson
    {
        public ReceiveVideoResult Result;

    }

    [Serializable]
    public class ReceiveVideoResult
    {
        public string SdpAnswer;
        public string SessionId;
    }

    [Serializable]
    public class OpenViduOnIceCandidateAnswer : OpenViduMessageJson
    {

        public OnIceCandidateResult Result;

    }

    [Serializable]
    public class OnIceCandidateResult
    {
        public string SessionId;
    }


    [Serializable]
    public class OpenViduIceCandidateEvent : OpenViduMessageJson
    {

        public IceCandidatParams Params;

    }


    [Serializable]
    public class IceCandidatParams
    {
        public string SenderConnectionId;
        public string EndpointName;
        public int SdpMLineIndex;
        public string SdpMid;
        public string Candidate;
    }



    [Serializable]
    public class OpenViduGetToken
    {


        /// (mandatory string) : the sessionId for which the token should be associated
        public string session;


        /// (optional string)
        ///  Check OpenViduRole section of OpenVidu Node Client for a complete description)
        ///           SUBSCRIBER
        ///           PUBLISHER(default)
        ///           MODERATOR
        public string role;

    }
    [Serializable]
    public class OpenViduToken
    {
        /// token value.Send it to one client to pass it as a parameter in openvidu-browser method Session.connect
        public string token;
        ///same as in the body request
        public string session;
        ///same as in the body request
        public string role;
        ///same as in the body request
        public string data;
        ///same value as token
        public string id;
    }
}