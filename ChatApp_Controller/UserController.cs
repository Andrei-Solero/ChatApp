using ChatApp_Model;
using ChatAppDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public class UserController
    {
        IMessageModel MessageView;
        ILoginModel LogginIn;
        IUserInterface UserInterface;
        IRecentMessage RecentMessage;
        IUserFriendProcessAdd addFriendProcessor;
        IUserModel UserModel;
        IUserFriendProcessRequests friendRequestsProcessor;
        IUserFriendProcessAccept friendRequestAccept;

        MessageProcessor MessageProcessing;
        LoginProcessor LoginProcessing;
        MessageDashboardProcessor MessageDashboardProcessor;
        MessageViewProcessor MessageViewProcessor;
        UsersAvailable UsersAvailable;
        UserFriendProcessor UserFriendProcessor;
        UserProcessor userProcessing;
        public UserController(IMessageModel MessageView)
        {
            this.MessageView = MessageView;
            MessageView.SetController(this);
            MessageProcessing = new MessageProcessor(MessageView);
        }
        public UserController(ILoginModel LogginIn)
        {
            this.LogginIn = LogginIn;
            LogginIn.SetController(this);
            LoginProcessing = new LoginProcessor(LogginIn);
        }
        public UserController(IUserInterface UserInterface)
        {
            this.UserInterface = UserInterface;
            UserInterface.SetController(this);

            MessageDashboardProcessor = new MessageDashboardProcessor(UserInterface.MainUserData);
            UsersAvailable = new UsersAvailable(UserInterface.MainUserData);
            UserFriendProcessor = new UserFriendProcessor(UserInterface.MainUserData);
        }
        public UserController(IRecentMessage RecentMessage)
        {
            this.RecentMessage = RecentMessage;
            RecentMessage.SetController(this);
            MessageViewProcessor = new MessageViewProcessor(RecentMessage);
        }
        public UserController(IUserFriendProcessAdd FriendProcessor)
        {
            this.addFriendProcessor = FriendProcessor;
            FriendProcessor.SetController(this);
            UserFriendProcessor = new UserFriendProcessor(FriendProcessor.MainUserData, FriendProcessor.AvailableUserData);
        }
        public UserController(IUserFriendProcessRequests friendRequestProcess)
        {
            this.friendRequestsProcessor = friendRequestProcess;
            friendRequestProcess.SetController(this);
            UserFriendProcessor = new UserFriendProcessor(friendRequestProcess.MainUserData, friendRequestProcess.AvailableUserData);
            friendRequestProcess.GetFriendRequests();
        }
        public UserController(IUserModel userModel)
        {
            this.UserModel = userModel;
            UserModel.SetController(this);
            userProcessing = new UserProcessor(userModel);
        }

        public UserController(IUserFriendProcessAccept friendRequestAccept)
        {
            this.friendRequestAccept = friendRequestAccept;
            friendRequestAccept.SetController(this);
            UserFriendProcessor = new UserFriendProcessor(friendRequestAccept.AvailableUserData, friendRequestAccept.MainUserData);
        }

        public void SendMessage()
        {
            MessageProcessing.InsertMessageData();
        }

        public List<MessageModel> GetActiveMessages()
        {
            return MessageProcessing.ActiveMessages();
        }

        public User Login()
        {
            return LoginProcessing.GetDataByAccount();
        }

        public List<User> ShowUserFriends()
        {
            return MessageDashboardProcessor.UserFriend();
        }

        public MessageModel MessageViewer()
        {
            return MessageViewProcessor.GetRecentMessage();
        }

        public void MessageStatusUpdating()
        {
            MessageProcessing.UpdateMessageStatus();
        }

        public void UpdateMessageStatus()
        {
            MessageViewProcessor.UpdateMessageStatus();
        }

        public List<User> ShowAllAvailableUsers()
        {
            return UsersAvailable.AllAvailableUsers();
        }

        public bool HasSentMainUserRequest(User availableUser)
        {
            return UsersAvailable.HasSentMainUserRequst(availableUser);
        }

        public void AddFriend()
        {
            UserFriendProcessor.AddFriendToDB();
        }

        public int CheckAvailableUserFriendStatus()
        {
            return UserFriendProcessor.CheckAvailableUserFriendStatus();
        }

        public int CreateUser()
        {
            return userProcessing.CreateUser();
        }

        public List<User> FriendRequests()
        {
            return UserFriendProcessor.GetFriendRequests();
        }

        public void Accept()
        {
            UserFriendProcessor.AcceptRequest();
        }

    }
}
