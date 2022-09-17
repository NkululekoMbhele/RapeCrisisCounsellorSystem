CREATE TABLE [dbo].[Schedule] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [AvailableDate] DATETIME2 (7) NOT NULL,
    [startTime]     DATETIME2 (7) NOT NULL,
    [endTime]       DATETIME2 (7) NOT NULL,
    [CounsellorId]  INT           NOT NULL,
    CONSTRAINT [PK_Schedule] PRIMARY KEY NONCLUSTERED ([ID]),
    CONSTRAINT [FK_Schedule_Counsellor_CounsellorId] FOREIGN KEY ([CounsellorId]) REFERENCES [Counsellor] ([CounsellorId]) 
);



