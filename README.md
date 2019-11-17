# HoloNav

An indoor navigation HoloLens app that utilizes on-board cameras and spatial sensors to perform spatial mapping to help an end-user navigate floor of the Department of Computer Science, University of Colorado, Denver. The floor was previously registered using HoloLens generating a 3D Mesh Map which was used to anchor 10 rooms (labs) on the same map. HoloNav’s UI presents user a list of options to choose a destination. HoloNav can load the anchor in the pre-mapped mesh and has the ability to point a navigational arrow while displaying distance from entered destination. 

### HoloNav Demo [[YouTube]](https://www.youtube.com/watch?v=TjUGAx9mPPo)

## Project Details

This repository contains a generic version of the implementation, project needs to be built before deployment to HoloLens. The following environment has to be setup in order to build the project. 

### Build
#### Requirements
- Microsoft HoloLens 
- Microsoft Visual Studio 2017
- Unity 2017
- HoloToolkit 2017

#### Procedure
1. Open project in Unity 2017.
2. Build project for Microsoft Visual Studio 2017, Microsoft HoloLens and x86 in build settings. 
3. Open the compiled Visual Studio project (HoloLens needs to be paired with your Visual Studio) set to "Solution Configuration: Debug", "Solution Platform: x86" and change it to "Device" (this option will show if you have successfully paired your HoloLens. 
4. Deploy to HoloLens and have fun!

#### Future Work

- Drag and drop 3D scanned floor mesh
- Azure Spatial Anchor Implementations
