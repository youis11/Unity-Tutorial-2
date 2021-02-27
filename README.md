# Version of the games

Sheep Rescue v.1.0
King's Quest v.1.0

## Description

### Sheep Rescue

Shoot hay in order to rescue sheeps and get the highest score possible, if you miss 3 sheeps you lose. This is part of a tutorial, I do not own the visuals of the game.

Even if I knew how to do pretty much everything, this tutorial helped me:

  - Remember that I need to delete things of a list not just destroy the gameObjects.

  - Know that you can cache a Script by equaling a public static Instance to "this".

  - With the next following line you can loop an enum without using IFs.: 
  ```csharp 
  selectedIndex %= Enum.GetValues(typeof(HayMachineColor)).Length; 
  ```
### King’s Quest

When King’s Quest I was released in 1984, its key selling point was the use of non-static screens which responded dynamically to player input. For instance, the player could move the character in realtime. This is part of a tutorial, I do not own the visuals of the game.

This tutorial helped me:

  - Learn what is a RequiredComponent.

  - Sorting 2D Sprites.

  - Parsing Commands.

  - Add interactable objects.

## Links

Lluis Moreu: https://github.com/youis11 

Github repository: https://github.com/youis11/Unity-Tutorial-2

Tutorial: https://www.raywenderlich.com/4180875-introduction-to-unity-scripting-part-2

## Controls Sheep Rescue:

- ESC (Go to Main Menu).

### Player: 

- A (to go left).
- D (to go right).
- SPACE (to shoot).

## Controls King's Quest:

- Type something to interact with objects.

### Player: 

- ARROW KEYS (to move without holding, press the same key to stop).