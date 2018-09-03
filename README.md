# StopWatch

## Description

This an exercise question from onle course:

Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console.
We should also be able to use a stopwatch multiple times. So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
start time). So the class should throw an InvalidOperationException if its started twice. 

## How To Use

1. Type Ctrl + F5 to run the console app
2. Enter "START" (case-insensitive) to start the clock

![Start](https://raw.githubusercontent.com/jeffreychen2016/StopWatch/master/imgs/start_clock.PNG)

3. Enter "STOP" (case-insensitive) to stop the clock

![Start](https://raw.githubusercontent.com/jeffreychen2016/StopWatch/master/imgs/stop_clock.PNG)

4. The duration will be displayed after the clock is displayed, and you the clock can be re-used.

![Start](https://raw.githubusercontent.com/jeffreychen2016/StopWatch/master/imgs/result_repeat.PNG)
