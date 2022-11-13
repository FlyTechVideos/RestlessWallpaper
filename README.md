# RestlessWallpaper

(aka. RestlessWallpaperV1)

This is the RestlessWallpaper project as seen in the YouTube video on the [FlyTech Videos YouTube channel](https://youtube.com/FlyTechVideos).

The "aim" of this project is to animate the wallpaper. In this project, we take all the pictures in a folder and change the wallpaper 20 times a second in order to "simulate" an animation.

As you can probably imagine, this does not work well. In fact, it creates severe lag on the system and makes Explorer crash. **Try at your own risk.**

You might want to also check out [RestlessWallpaperV2](https://github.com/FlyTechVideos/RestlessWallpaperV2), which is slightly better, but not really.

Configurable parameters:

- `Program.cs`, Lines 25-26: Set the directory which contains your desired pictures, as well as the expected file extension.
- `Program.cs`, Lines 32: Set the "frame rate". Default is 20 frames per second, as this is the maximum that I could experimentally run without Explorer crashing _immediately_ (it would still crash after a few seconds).

**Please note:** This software has been created for **demo purposes** and **not for productive use**. As such, it is not polished, written nicely, configurable, or in any way convenient to use. Do what you want with it, at your own risk.