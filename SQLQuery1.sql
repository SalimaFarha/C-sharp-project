/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [MID]
      ,[Fname]
      ,[Lname]
      ,[Gender]
      ,[Dob]
      ,[Mobile]
      ,[Email]
      ,[JoinDate]
      ,[Gymtime]
      ,[MembershipTime]
  FROM [gym].[dbo].[NewMember]