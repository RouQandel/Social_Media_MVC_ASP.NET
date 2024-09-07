CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    DateOfBirth DATE,
    ProfilePicture VARCHAR(255),
    Bio NVARCHAR(255),
    DateCreated DATETIME DEFAULT GETDATE()
);


CREATE TABLE Posts (
    PostID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Content NVARCHAR(MAX) NOT NULL,
    ImageURL NVARCHAR(255),
    DateCreated DATETIME DEFAULT GETDATE()
);
 go 
 CREATE TABLE Comments (
    CommentID INT PRIMARY KEY IDENTITY(1,1),
    PostID INT FOREIGN KEY REFERENCES Posts(PostID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Content NVARCHAR(MAX) NOT NULL,
    DateCreated DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE Likes (
    LikeID INT PRIMARY KEY IDENTITY(1,1),
    PostID INT FOREIGN KEY REFERENCES Posts(PostID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    DateCreated DATETIME DEFAULT GETDATE()
);
go

CREATE TABLE Friendships (
    FriendshipID INT PRIMARY KEY IDENTITY(1,1),
    UserID1 INT FOREIGN KEY REFERENCES Users(UserID),
    UserID2 INT FOREIGN KEY REFERENCES Users(UserID),
    DateCreated DATETIME DEFAULT GETDATE()
);
go 
CREATE TABLE FriendRequests (
    RequestID INT PRIMARY KEY IDENTITY(1,1),
    SenderID INT FOREIGN KEY REFERENCES Users(UserID),
    ReceiverID INT FOREIGN KEY REFERENCES Users(UserID),
    Status NVARCHAR(50) NOT NULL,
    DateRequested DATETIME DEFAULT GETDATE()
);
go 
CREATE TABLE Follows (
    FollowID INT PRIMARY KEY IDENTITY(1,1),
    FollowerID INT FOREIGN KEY REFERENCES Users(UserID),
    FollowingID INT FOREIGN KEY REFERENCES Users(UserID),
    DateFollowed DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE Notifications (
    NotificationID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Message NVARCHAR(MAX) NOT NULL,
    IsRead BIT DEFAULT 0,
    DateCreated DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE Groups (
    GroupID INT PRIMARY KEY IDENTITY(1,1),
    GroupName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    DateCreated DATETIME DEFAULT GETDATE()
);
go 
CREATE TABLE GroupMembers (
    GroupMemberID INT PRIMARY KEY IDENTITY(1,1),
    GroupID INT FOREIGN KEY REFERENCES Groups(GroupID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    DateJoined DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE GroupPosts (
    GroupPostID INT PRIMARY KEY IDENTITY(1,1),
    GroupID INT FOREIGN KEY REFERENCES Groups(GroupID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Content NVARCHAR(MAX) NOT NULL,
    DateCreated DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE GroupPostLikes (
    GroupPostLikeID INT PRIMARY KEY IDENTITY(1,1),
    GroupPostID INT FOREIGN KEY REFERENCES GroupPosts(GroupPostID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    DateCreated DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE GroupPostComments (
    GroupPostCommentID INT PRIMARY KEY IDENTITY(1,1),
    GroupPostID INT FOREIGN KEY REFERENCES GroupPosts(GroupPostID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Content NVARCHAR(MAX) NOT NULL,
    DateCreated DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE Settings (
    SettingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    SettingName NVARCHAR(100) NOT NULL,
    SettingValue NVARCHAR(255) NOT NULL
);
go 
CREATE TABLE Events (
    EventID INT PRIMARY KEY IDENTITY(1,1),
    EventName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    EventDate DATETIME NOT NULL,
    CreatedByUserID INT FOREIGN KEY REFERENCES Users(UserID),
    DateCreated DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE EventParticipants (
    EventParticipantID INT PRIMARY KEY IDENTITY(1,1),
    EventID INT FOREIGN KEY REFERENCES Events(EventID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    DateJoined DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE Activities (
    ActivityID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    ActivityType NVARCHAR(50) NOT NULL,
    Description NVARCHAR(255),
    DateCreated DATETIME DEFAULT GETDATE()
);
go 
CREATE TABLE GroupMessages (
    GroupMessageID INT PRIMARY KEY IDENTITY(1,1),
    GroupID INT FOREIGN KEY REFERENCES Groups(GroupID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Content NVARCHAR(MAX) NOT NULL,
    DateSent DATETIME DEFAULT GETDATE()
);
go 
CREATE TABLE Interactions (
    InteractionID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    InteractionType NVARCHAR(50) NOT NULL,
    TargetID INT,
    TargetType NVARCHAR(50),
    DateCreated DATETIME DEFAULT GETDATE()
);
go
CREATE TABLE Messages (
    MessageID INT PRIMARY KEY IDENTITY(1,1),
    SenderID INT,
    ReceiverID INT,
    Content TEXT NOT NULL,
    Timestamp DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (SenderID) REFERENCES Users(UserID),
    FOREIGN KEY (ReceiverID) REFERENCES Users(UserID)
);
go 
 

 INSERT INTO Users (UserName, Password, Email, DateOfBirth, ProfilePicture)
VALUES 
('JohnDoe', 'password123', 'john.doe@example.com', '1990-05-14', 'profile1.jpg'),
('JaneSmith', 'password456', 'jane.smith@example.com', '1992-07-21', 'profile2.jpg'),
('AliceJohnson', 'password789', 'alice.johnson@example.com', '1985-09-30', 'profile3.jpg');


