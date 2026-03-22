
CREATE DATABASE EventDb;
USE EventDb;

CREATE TABLE UserInfo (
    email varchar(50) PRIMARY KEY,
    username varchar(50) NOT NULL,
    Role VARCHAR(20) NOT NULL,
    Password VARCHAR(20) NOT NULL
    );

CREATE TABLE EventDetails (
    EventId INT PRIMARY KEY,
    EventName VARCHAR(50) NOT NULL,
    EventCategory VARCHAR(50) NOT NULL,
    EventDate DATETIME NOT NULL,
    Description VARCHAR(255),
    Status VARCHAR(20) CHECK (Status IN ('Active','In-Active'))
);

CREATE TABLE SpeakersDetails (
    SpeakerId INT PRIMARY KEY,
    SpeakerName VARCHAR(50) NOT NULL
);

CREATE TABLE SessionInfo (
    SessionId INT PRIMARY KEY,
    EventId INT NOT NULL,
    SessionTitle VARCHAR(50) NOT NULL,
    SpeakerId INT NOT NULL,
    Description VARCHAR(255),
    SessionStart DATETIME NOT NULL,
    SessionEnd DATETIME NOT NULL,
    SessionUrl VARCHAR(255),

    FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
    FOREIGN KEY (SpeakerId) REFERENCES SpeakersDetails(SpeakerId)
);

CREATE TABLE ParticipantEventDetails (
    Id INT PRIMARY KEY,
    ParticipantEmailId VARCHAR(50) NOT NULL,
    EventId INT NOT NULL,
    SessionId INT NOT NULL,
    IsAttended BIT,

    FOREIGN KEY (ParticipantEmailId) REFERENCES UserInfo(email),
    FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
    FOREIGN KEY (SessionId) REFERENCES SessionInfo(SessionId)
);


