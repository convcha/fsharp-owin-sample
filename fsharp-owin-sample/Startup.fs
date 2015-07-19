module Startup

open System
open global.Owin

    type Startup() =
    
        member this.Configuration(app:IAppBuilder) =

            let os = "<h1>OWIN on " + Environment.OSVersion.ToString() + "</h1>"
            app.Run(fun c -> c.Response.WriteAsync(os))