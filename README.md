# Upscale Sampling Rendering Demo

Upscale Sampling Rendering is old school but common trick for low end devices, not only for mobiles but also PC. Since many low-end devices have very high resolution but GPU power is still low, Pixel processing is still heavy.
If you want to keep high quality look&feel for low-en devices, one of simplest way is reducing resolution. You may simply implement as using Screen.SetResolution(). But, users easily can recognize that is is low resolution because entire rendering results are low resolution. This demo's key trick is that the overlay UI is full resolution.

## Implementation

Steps are :
1. generate a low resolution render target (aka RenderTexture).
2. render 3D scenes into the render target.
3. upscale render the render target into current backbuffer.
4. render overlay UIs.

Since UIs are full resolution, users can be confused that it is full resolution (may be?). of-course, hardcore users can recognize but the others can not recognize. Anyway, It still show better quality than Screen.SetResolution().


## Cases

See screenshots below. the device is Huawei Honor. GPU is Mali450MP but resolution is 720p.

1.0 scale (full) resolution : 5FPS (200ms)
![image](https://github.com/ozlael/UpsamplingRenderingDemo/blob/master/Doc/scale_1_0.jpeg)

0.75 scale resolution : 7FPS (143ms)
![image](https://github.com/ozlael/UpsamplingRenderingDemo/blob/master/Doc/scale_0_75.jpeg)

0.5 scale (half) resolution : 14FPS (71ms)
![image](https://github.com/ozlael/UpsamplingRenderingDemo/blob/master/Doc/scale_0_5.jpeg)


## Acknowledgments

* Please note that you have to make sure that your game's bottleneck is GPU boundary especially Pixel Shading. If your game is CPU boundary bottleneck, this approch is meaningless.
* Since 3D rendered results are a little bit blurry, Some games use sharpen filter during upscale rendering. This sample demo has not. It is up to you. Keep in mind that Sharpen filtering needs smome more Pixel Shader power. 
* If you have questions, ask me via Social Media.
 * Facebook : [ozlael.oz](https://www.facebook.com/ozlael.oz)
 * Twitter : [@ozlael](https://twitter.com/ozlael)
