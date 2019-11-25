module Helpers

open System.Threading

let rec retryFunc times fn = 

    if times > 1 then
        try fn()
        with 
        | _ -> 
            Thread.Sleep(1000)
            retryFunc (times - 1) fn
    else fn()