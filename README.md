# Horizon-Calculator

This is a MVC application for doing some earth-curvature calculations. 

In the Front End, there are three input fields. 
   * Entering a value for "Observer Height" will return the geographical distance to the Horizon.
   * Also Entering a value for "Object Height" will return if the Object is visible
   * Also Entering a value for "Distance Between Observer And Object" will return how much of the object is visible, if at all.

The calculations assume no refraction, and the formulas were derived by myself.

The controller receives the height of the observer and object as well as the geographical distance between them from the front end. It then creates a new Calculations object, which derives all the other properties (i.e. vertical drop, horizon geographical distance, and so forth) from just these. The object is then returned to the front end which displays the information.
