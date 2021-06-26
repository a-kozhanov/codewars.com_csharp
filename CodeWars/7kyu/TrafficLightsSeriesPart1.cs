/*
https://www.codewars.com/kata/59653de51f13e49374000145/csharp

7 kyu
Traffic Lights Series - Part 1

Traffic Lights Series - Part 1
In this series we are going to model traffic lights. 
In part 1 we will just model the interface and the logic encapsulated within the traffic light itself. 
In later parts we will go into more detail and look at the light control unit.

The Interface
The interface will have read-only three properties which indicate the on/off state for each of the lightss. 
There will be one boolean property for each lightindicating whether the light is on or off. The properties are called:

Red
Amber
Green.
The interface will also include a single method which will be used to instruct the traffic light to change the on/off states of it's lights. 
The state is an enum and has the following options:

Standby
Red
RedAmber
Green
Amber
The traffic light will alway start at Standby state when it is initialised.

When should the lights be lit?
The lights should only be lit for the following states:

The Red light should be lit if the traffic lights is in the following states; Standby, Red, and RedAmber.
The Amber light should be lit if the traffic lights is in the following states; RedAmber, and Amber.
The Green light should be lit if the traffic lights is in the following states; Green only.
The Tests
Make the following tests pass...

GivenTrafficLight_ThenInterfaceIsImplemented
GivenTrafficLight_WhenInstatiated_ThenRedLightIsOn_AndOthersAreOff
GivenInstatiatedTrafficLight_WhenSetToAmberState_ThenAmberLightIsOn_AndOtherLightsAreOff
GivenInstatiatedTrafficLight_WhenSetToGreenState_ThenGreenLightIsOn_AndGreenIsOff
GivenInstatiatedTrafficLight_WhenSetToRedAmberState_ThenRedLightAndAmberLightIsOn_AndGreenIsOff
GivenInstatiatedTrafficLight_WhenSetToRedState_ThenRedLightLightIsOn_AndOthersAreOff
What's next?
In Part 2 we will look at adding a Traffic Light Controller
*/

namespace CodeWars
{
    public interface ITrafficLight
    {
        /// <summary>
        /// Gets a state indicating if the amber light is on
        /// </summary>
        bool IsAmberOn { get; }

        /// <summary>
        /// Gets a state indicating if the green light is on
        /// </summary>
        bool IsGreenOn { get; }

        /// <summary>
        /// Gets a state indicating if the red light is on
        /// </summary>
        bool IsRedOn { get; }

        /// <summary>
        /// Sets the state of the traffic light
        /// </summary>
        /// <param name="state">
        /// Indicates which state the <see cref="TrafficLight"/> should be switched to.
        /// </param>
        void Set(State state);
    }

    public enum State
    {
        Standby = 0,
        Red = 1,
        RedAmber = 2,
        Green = 3,
        Amber = 4
    }

    /// <summary>
    /// Defines the expected members of a traffic light
    /// </summary>
    public class TrafficLightsSeriesPart1 : ITrafficLight
    {
        public bool IsAmberOn => state == State.RedAmber || state == State.Amber;
        public bool IsGreenOn => state == State.Green;
        public bool IsRedOn => state == State.Standby || state == State.Red || state == State.RedAmber;

        public void Set(State state)
        {
            this.state = state;
        }

        private State state = State.Standby;

        // /// <summary>
        // /// Gets a state indicating if the amber light is on
        // /// </summary>
        // public bool IsAmberOn => throw new NotImplementedException();
        //
        // /// <summary>
        // /// Gets a state indicating if the green light is on
        // /// </summary>
        // public bool IsGreenOn => throw new NotImplementedException();
        //
        // /// <summary>
        // /// Gets a state indicating if the red light is on
        // /// </summary>
        // public bool IsRedOn => throw new NotImplementedException();
        //
        // /// <summary>
        // /// Sets the state of the traffic light
        // /// </summary>
        // /// <param name="state">
        // /// Indicates which state the <see cref="TrafficLight"/> should be switched to.
        // /// </param>
        // public void Set(State state)
        // {
        //     throw new NotImplementedException();
        // }
    }
}