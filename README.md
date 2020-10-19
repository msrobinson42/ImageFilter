# ImageFilter

Created during first 4-week sprint of CIS 293 Advanced Technologies. I had a partner named Leila Sheikhattar for this project.

My goal was to explore bitmap manipulation and image processing. This is a field that I'm intimately familiar with, given my time at South Dakota State University as a Graphic Design major. I knew how to manipulate the software, but never understood image processing on a low level.

I wanted to create a full bodied application that was extensible and maintainable. I was learning about design patterns and the SOLID principles; this was a great opportunity to put into practice what I had learned. I wanted to architect the layout of the software in order to allow Leila to implement the functionality with minimal effort/confusion. It proved harder than I thought, but I'm happy with the solution that I eventually came to.

I wanted to end with an application that would be able to do light image manipulations. I ended up including the following:
* Blur/Sharpen
* Pixellate
* Hue/Tint
* Alpha/Opacity
* Change Background Color
* Apply Brightness/Contrast
* Detect Edges
* Apply premade filters to an image
* Rotate/Flip
* Replace Color
* Rounded corners
* Change Saturation
* Add a Vignette

## Application Architecture

Please ask for a powerpoint that will outline design decisions more explicitly, or explore commit history for previous versions.

The short of it was that I initially implemented a Command Pattern-esque solution, so that each manipulation of the image would be encapsulated in a single object. I would create an interface, ICommand, with Execute and Unexecute members. I could hold a Stack<ICommand> inside of the view, and due to the interface I had a built-in do/undo functionality. This was a more immutable solution, as each Command/image would essentially be separate.

As I expanded the application, the library for manipulations quickly became bloated with implementations of factory patterns for creating ICommand concretions, as well as Facade objects to simplify the Dependency Injection for Leila. The attempt to create loosely coupled code was creating a class explosion that became more difficult to manage than it seemed worth.

As I explored solutions, and asked different developers for advice, I settled on a State Machine, which existed in the library (which was good, as my other 'state' based Stack<ICommand> existed in the form view), and held the current and previous iterations of the image. Then I would have extension methods to the State Machine class be the driving force behind the image processing manipulations.
 
Finally, a Singleton was used as a wrapper to our external library (which was heavily mutation driven) to interact with for all image manipulations.
 
## Image Processing Algorithms

I briefly explored using Lockbits and int* pointers to directly manipulate the RGBA encoded byte array in memory, but it proved too inconvenient and difficult to implement within the given deadline. We settled on an external library called ImageProcessor, which allowed implementations of fairly complicated manipulations simply and seamlessly.

## ImageFilterLibrary

A class library that holds the Image State as well as the Singleton for the image manipulations. Extension methods simply call the ImageProcesser.cs wrapper.

A state machine does not necessarily need to explicitly be used for Image types, so I endeavored to create a Generic DisposableStateMachine.cs, which could have been used instead of ImageEditorState. I felt as though the overengineering was not necessary and chose to use the ImaageEditorState.cs as it provided a more simple interface for my partner to use.

Resources.cs holds specific implementations of the external libraries Filter, PhotoFilter, and Flip implementations, so I can pass those into the dynamic dialogs.

## ImageFilterWinForms

Although I wanted to create an additional WPF view to explore XAML, my time ran short due to the restructuring of the application. There are still some cool decisions to note within the WinForms view, however:

* Use of an Action to hold previous extension method call within frmMain.cs
* Use of parameters passed into InputTextDialog to create dynamic dialog forms at runtime.
 * Only 4 dialogs are needed to encompass functionality for all 17 manipulations
* Use of a null-conditional operator for the RepeatClick functionality.

## Finally

To improve the application, there are likely ways to make the code less mutable. For example:
* Make the Lists in the Resources.cs ReadOnlyCollections instead
* Instead of mutating a "current image" memory location in the ImageEditorState.cs, I could instead return Stack<Image>.First();
* Implement some asynchronous functionality for when calculations take an abnormally long time (such as Gaussian Blur/Sharpen)

**Zach Robinson*
