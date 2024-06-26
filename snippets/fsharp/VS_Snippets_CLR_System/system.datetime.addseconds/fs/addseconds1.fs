﻿// <Snippet1>
open System

let dateFormat = "MM/dd/yyyy hh:mm:ss"
let date1 = DateTime(2014, 9, 8, 16, 0, 0)
printfn $"Original date: {date1.ToString dateFormat} ({date1.Ticks:N0} ticks)\n"

let date2 = date1.AddSeconds 30
printfn $"Second date:   {date2.ToString dateFormat} ({date2.Ticks:N0} ticks)"
printfn $"Difference between dates: {date2 - date1} ({date2.Ticks - date1.Ticks:N0} ticks)\n"

// Add 1 day's worth of seconds (60 secs. * 60 mins * 24 hrs.
let date3 = date1.AddSeconds(60. * 60. * 24.)
printfn $"Third date:    {date3.ToString dateFormat} ({date3.Ticks:N0} ticks)" 
printfn $"Difference between dates: {date3 - date1} ({date3.Ticks - date1.Ticks:N0} ticks)"

// The example displays the following output:
//    Original date: 09/08/2014 04:00:00 (635,457,888,000,000,000 ticks)
//
//    Second date:   09/08/2014 04:00:30 (635,457,888,300,000,000 ticks)
//    Difference between dates: 00:00:30 (300,000,000 ticks)
//
//    Third date:    09/09/2014 04:00:00 (635,458,752,000,000,000 ticks)
//    Difference between dates: 1.00:00:00 (864,000,000,000 ticks)
// </Snippet1>