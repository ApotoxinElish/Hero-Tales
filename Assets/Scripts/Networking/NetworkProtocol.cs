using Mirror;

namespace HeroTales
{
    // Every network message has a corresponding message class that carries the information needed
    // per message.

    public struct SendChatTextMessage : NetworkMessage
    {
        public NetworkIdentity senderNetId;
        public string text;
    }
}
