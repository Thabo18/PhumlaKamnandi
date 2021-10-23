CREATE TABLE [dbo].[Reservation]
(
	[ReservationNo] INT NOT NULL PRIMARY KEY,
	[ArrivalDate] DATE NULL,
	[DepartureDate] DATE  NULL,
	[NoOfRooms] INT NULL,
	[RateUsed] MONEY NULL,
	[ExtraCharges] MONEY NULL,
	[Total] MONEY NULL, 
    
     

);
