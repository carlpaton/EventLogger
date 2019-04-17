# For a VB.NET project logging can be added with 

Imports EventLoggerHoe

Dim we As New WriteEntry("eventlogname", 0)
we.Log(data & " " & someId & " database1")
