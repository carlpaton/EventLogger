# EventLogger

1. Clone the solution and build it

2. Run console application as administrator `C:\Dev\EventLogger\EventLogger\bin\DebugEventLogger.exe`
3. Provide your `EventLogName`

4. View it under `Event Viewer` -> `Applications and Services`



# EventLoggerHoe

Add a reference to `EventLoggerHoe.dll` and then use as follows 

#### VB.NET

`Imports EventLoggerHoe`

`Dim we As New WriteEntry("eventlogname", 0)`
`we.Log(data & " " & someId & " database1")`

#### C#

`using EventLoggerHoe`

`var we = new WriteEntry("eventlogname", 0);`
`we.Log(data + " " + someId + " database1")`