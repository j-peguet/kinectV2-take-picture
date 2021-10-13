<h1 align="center">Kinect V2: Take Picture </h1>
<p align="center">
 <img alt="License: MIT" src="https://img.shields.io/badge/license-MIT-yellow.svg" target="_blank" />

 <a href="https://twitter.com/Jules_Peguet">
    <img alt="Twitter: Jules_Peguet" src="https://img.shields.io/twitter/follow/Jules_Peguet.svg?style=social" target="_blank" />
  </a>
</p>
<p align="center">
<img alt="License: MIT" src="kinect-icon.png" target="_blank" />
</p>

> Take pictures with your microsoft Kinect V2 Sensor.

## ⚙️ Prerequisites
<hr>
To run the application, it is necessary to have the Kinect SDK installed.

Download link available here:
https://www.microsoft.com/en-us/download/details.aspx?id=44561

## 📦 Build
<hr>
To build our own .exe app:

* Download the repo dans open it in Visual Studio.
* Switch to <code>Release</code> configuration
* Press <code>F5</code> to build the project
* Create of folder named <code>Kinect</code> in your default Pictures folder

The file <code>KinectV2-Take-Picture.exe</code> is in <code>bin/Release/</code> directory.

## 🚀 Usage
<hr>

You can simply launch application, and the Kinect will take one picture.
```
.\KinectV2-Take-Picture.exe
```

To take several photos, simply set the number of photos you wish to take.
```
.\KinectV2-Take-Picture.exe 5
```

Nb: Each picture will be taken with an interval of 1 second.

## 📂 File location
<hr>
All photos will be saved in your folder <code>Pictures\Kinect\</code>

## 🤝 Contributing
<hr>

Contributions, issues and feature requests are welcome.<br />
Feel free to check [issues page](https://github.com/j-peguet/kinectV2-Take-Picture/issues) if you want to contribute.<br />
[Check the contributing guide](./CONTRIBUTING.md).<br />

## 📝 License
<hr>

Copyright © 2021 [Jules Peguet](https://github.com/j-peguet).<br />
This project is [MIT](https://github.com/j-peguet/kinectV2-Take-Picture/blob/master/LICENSE) licensed.
