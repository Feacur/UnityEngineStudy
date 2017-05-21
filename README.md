# Summary
Test assignment on Unity, UI and programming stuff

Reference: WoT hangar scene

Up to the point it has been like 20 hours of pure busy time. Not bad, I believe. Besides this project turned out to be extremely instrumental for my current job. Really, you need sometimes sit back, put down your busy work for a while and do some R&D.

And yet another 4 hours in addition.

# How to work with this stuff
### Build the project and asset bundles using these
* See "Assets/Plugins/Custom/Editor/AssetBundlesBuilder.cs"
* See "Assets/Plugins/Custom/Editor/ProjectBuilder.cs"

### Your changes won't automatically get into asset bundles in editor
### Be sure you've built asset bundles before play mode
### Probably you want to rebuild asset bundles if you've updated Unity version
### Probably you want to rebuild asset bundles if you've changed some code assemblies

### Also you can define EMULATE_ASSET_BUNDLES_IN_EDIT_MODE
* See "Assets/Plugins/Custom/Util/StreamingData.cs"
* But there is an issue with lighting

# Current state
* Plugins: Rider, VSCode, YamlDotNet, also custom utilities
* Assets: Hangar UI, Hangar, tanks, prefabs, yaml configs
* Asset bundles: non-automatic, build is required before play mode
* Build scripts: for asset bundles and for the project
* Data IO: load by url, load from asset bundles, persistent data
* One level deep nested prefabs emulation using scene files and actual prefabs
* Initial API commentaries
* User data is changable and savable
* Sketched tanks
* Sketched hangar

# To do
* Script fly around camera
* Loader splash screen to hide async loading from user
* Rective UI changes, probably? This is more of a clean code feature.
