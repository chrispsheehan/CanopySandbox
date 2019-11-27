module CanopyFunctions

open canopy.classic
open canopy.types
open OpenQA.Selenium
open canopy.configuration
open Helpers


let canopyRetry = 10

let setCanopyVars timeout =

    printfn "Setting canopy vars. Timeout: %f" timeout
    elementTimeout <- timeout
    compareTimeout <- timeout
    pageTimeout <- timeout
    skipAllTestsOnFailure <- true
    autoPinBrowserRightOnLaunch <- false


let startDriver () =
    
    retryFunc canopyRetry (fun () ->
        printfn "Starting driver"
        chromeDir <- System.AppContext.BaseDirectory
        let chromeOptions = Chrome.ChromeOptions()
        chromeOptions.AddArgument("--no-sandbox")
        chromeOptions.AddArgument("--headless")
        chromeOptions.AddArgument("--window-size=1920,1080") 
        chromeOptions.AddArgument("--start-maximized")
        start (ChromeWithOptions(chromeOptions))
        printfn "Driver started")


let quitDriver () =

    quit()