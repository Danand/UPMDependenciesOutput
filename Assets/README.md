# UPMDependenciesOutput
[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/danand/UPMDependenciesOutput/blob/master/LICENSE.md)

Simply outputs all UPM dependencies to editor console.

## How to install

### From remote repository
Add in `Packages/manifest.json` to `dependencies`:
```javascript
"com.danand.upmdepsout": "https://github.com/Danand/UPMDependenciesOutput.git#0.1.0-package-unity",
```

### From local path
<details>
	<summary>From local repository</summary>
	
	"com.danand.upmdepsout": "file:///D/repos/UPMDependenciesOutput/.git#0.1.0-package-unity",
</details>

<details>
	<summary>From local working copy</summary>
	
	"com.danand.upmdepsout": "file:D:/repos/UPMDependenciesOutput/Assets",
</details>

<details>
	<summary>What is the difference?</summary>
	<p>
		Local repository is resolved just like normal Git repository with optionally specified revision.<br />
		Local working copy is being copied "as is" into dependent project, without running any Git process.
	</p>
</details>

Don't forget to reference **UPMDependenciesOutput** via Assemly Definitions.

## How to use
```csharp
Just click in Unity editor `Window -> Package Manager -> Print all dependencies` and check the console tab out.
```
<details>
	<summary>Example output</summary>
    
```
com.unity.collab-proxy@1.2.16
com.unity.ide.rider@1.1.4
---- com.unity.test-framework@1.1.1
com.unity.ide.vscode@1.2.0
com.unity.test-framework@1.1.13
---- com.unity.ext.nunit@1.0.0
---- com.unity.modules.imgui@1.0.0
---- com.unity.modules.jsonserialize@1.0.0
com.unity.textmeshpro@2.0.1
---- com.unity.ugui@1.0.0
com.unity.timeline@1.2.14
com.unity.ugui@1.0.0
---- com.unity.modules.ui@1.0.0
com.unity.modules.ai@1.0.0
com.unity.modules.androidjni@1.0.0
com.unity.modules.animation@1.0.0
com.unity.modules.assetbundle@1.0.0
com.unity.modules.audio@1.0.0
com.unity.modules.cloth@1.0.0
---- com.unity.modules.physics@1.0.0
com.unity.modules.director@1.0.0
---- com.unity.modules.audio@1.0.0
---- com.unity.modules.animation@1.0.0
com.unity.modules.imageconversion@1.0.0
com.unity.modules.imgui@1.0.0
com.unity.modules.jsonserialize@1.0.0
com.unity.modules.particlesystem@1.0.0
com.unity.modules.physics@1.0.0
com.unity.modules.physics2d@1.0.0
com.unity.modules.screencapture@1.0.0
---- com.unity.modules.imageconversion@1.0.0
com.unity.modules.terrain@1.0.0
com.unity.modules.terrainphysics@1.0.0
---- com.unity.modules.physics@1.0.0
---- com.unity.modules.terrain@1.0.0
com.unity.modules.tilemap@1.0.0
---- com.unity.modules.physics2d@1.0.0
com.unity.modules.ui@1.0.0
com.unity.modules.uielements@1.0.0
---- com.unity.modules.imgui@1.0.0
---- com.unity.modules.jsonserialize@1.0.0
com.unity.modules.umbra@1.0.0
com.unity.modules.unityanalytics@1.0.0
---- com.unity.modules.unitywebrequest@1.0.0
---- com.unity.modules.jsonserialize@1.0.0
com.unity.modules.unitywebrequest@1.0.0
com.unity.modules.unitywebrequestassetbundle@1.0.0
---- com.unity.modules.assetbundle@1.0.0
---- com.unity.modules.unitywebrequest@1.0.0
com.unity.modules.unitywebrequestaudio@1.0.0
---- com.unity.modules.unitywebrequest@1.0.0
---- com.unity.modules.audio@1.0.0
com.unity.modules.unitywebrequesttexture@1.0.0
---- com.unity.modules.unitywebrequest@1.0.0
---- com.unity.modules.imageconversion@1.0.0
com.unity.modules.unitywebrequestwww@1.0.0
---- com.unity.modules.unitywebrequest@1.0.0
---- com.unity.modules.unitywebrequestassetbundle@1.0.0
---- com.unity.modules.unitywebrequestaudio@1.0.0
---- com.unity.modules.audio@1.0.0
---- com.unity.modules.assetbundle@1.0.0
---- com.unity.modules.imageconversion@1.0.0
com.unity.modules.vehicles@1.0.0
---- com.unity.modules.physics@1.0.0
com.unity.modules.video@1.0.0
---- com.unity.modules.audio@1.0.0
---- com.unity.modules.ui@1.0.0
---- com.unity.modules.unitywebrequest@1.0.0
com.unity.modules.vr@1.0.0
---- com.unity.modules.jsonserialize@1.0.0
---- com.unity.modules.physics@1.0.0
---- com.unity.modules.xr@1.0.0
com.unity.modules.wind@1.0.0
com.unity.modules.xr@1.0.0
---- com.unity.modules.physics@1.0.0
---- com.unity.modules.jsonserialize@1.0.0
---- com.unity.modules.subsystems@1.0.0
```
</details>