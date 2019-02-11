# GGJEGE19

You can watch our game video on youtube. 

<a href="http://www.youtube.com/watch?feature=player_embedded&v=OGpvQaH86es
" target="_blank"><img src="http://img.youtube.com/vi/OGpvQaH86es/0.jpg" 
alt="GGJ 2019 CatClaw" width="240" height="180" border="10" /></a>

## What Did I Do This Year

My main job in team was creating cat characters and animating them. Secondary job of mine was helping main programmers in final phase of game development, integration. You can find what I do in this repository.

### What Does This Repository Includes

##### Menu Scene

* Animated Camera Opening
* Scene Loading with Button OnClicks
* Idle Character Animation

##### Intro & Outro Slideshows

* Basic Animated slideshow of PNGs
* A trigger object template that loads Game Scene or Credits Scene

```C#
public string SceneName;

private void OnEnable(){
    SceneManager.LoadScene(SceneName, Mode.Single);
}
```

##### Credits Scene

* A sliding text is controlled with a script
* SlidingTextController will trigger Jumping Character animation, otherwise Idle Animation plays
* Finally, Application Quits.  