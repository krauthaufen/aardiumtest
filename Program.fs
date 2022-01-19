open Aardium


Aardium.init()

printfn "version; %s" Aardium.version

Aardium.run {
    url "https://google.com"
}