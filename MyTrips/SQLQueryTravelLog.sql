USE Master
CREATE DATABASE TripDB
USE TripDB

CREATE TABLE Destination (
Id int identity(1,1) PRIMARY KEY,
Country nvarchar,
Visited bit
)

CREATE TABLE PlaceCity (
Id int identity(1,1) PRIMARY KEY,
Visited bit,
Place nvarchar,
)

CREATE TABLE Trip (
Id int identity(1,1) PRIMARY KEY
)