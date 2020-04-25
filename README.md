# HoloNav

## Description
An indoor navigation HoloLens app that utilizes onboard cameras and spatial sensors to perform spatial mapping to help an end-user navigate a pre-mapped object. The floor/space needs to be previously registered using HoloLens generating a 3D Mesh Map which may be used to anchor 5 rooms on the same map. It is possible to stitch multiple floors/spaces together. HoloNav’s UI presents the user a list of options to choose a destination from. HoloNav can load the anchor in the pre-mapped space and has the ability to point a navigational arrow while displaying the distance from the entered destination.

A demo of this project can be viewed here: [HoloNav Demo](https://www.youtube.com/watch?v=TjUGAx9mPPo)

## Interaction
The user shall interact with this HoloLens app through voice commands, except during the phase of anchoring. The advantage of voice commands over traditional HoloLens recognizable gestures includes handsfree control along with a more natural UI and almost a zero-learning curve to operate the application. AirTap gestures are implemented to anchor and for precision while anchoring. 

## Documentation
The project is structured as follows:
- Mixed Reality Camera Parent: Contains Mixed Reality Camera, UIControl Script and UI Elements.
- DefaultCursor: The default cursor prefab, used to select anchors and move them around.
- SpatialMapping: Required for calibration of the space.
- Managers: Contains Input Manager, Speech Manager and Anchor Manager.
- Anchors: There are 5 anchors to begin with.

Custom scripts can be found in Scripts directory, these are the only additional scripts that I have created in this project and no other script was changed, hence for proper implementation and functioning I recommend making changes to only files present in "Scripts" directory. 

## Requirements
HoloLens (1st Gen), Visual Studio 2017, Unity 2017.x, HoloToolKit 2017 (note: not MRTK).

## Usage
Repo consists of a Unity project directory. Clone this repo and point Unity to this repo. Unity should import all the assets into a project for you. However, you will still need to set up Unity for HoloLens application development, which you can read about in an article that I wrote: [Configuring Unity for HoloLens Application Development](https://medium.com/@KushalBKusram/configuring-unity-for-hololens-application-development-899f79abb4ec)

