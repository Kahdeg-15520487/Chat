namespace Utility
{
    public enum Messages
    {
        Accept,     //accept a request
        Deny,       //deny a request
        Request,    //request doing a command
        Success,    //Success in doing a command
        Fail        //Failed to do a command
    }

    public enum Commands
    {
        Message,    //send to a client in the same room with <clientId> the message of <msg>
        Broadcast,  //send the message of <msg> to every client in the same room
        Inform,     //inform the server/client about something
        GetRoom,    //request the roomid of this client if the client is in a room,
                    //else the client is assigned to a room
        JoinRoom    //request to join the room with <roomId>
    }

    public static class Constants
    {
        public static int MaxTimeOut = 3;
    }
}
