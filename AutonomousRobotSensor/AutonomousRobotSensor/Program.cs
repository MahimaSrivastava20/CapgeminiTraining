// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace AutonomousRobot.AI
{
    class Program
    {
        static void Main()
        {
            List<SensorReading> sensorHistory = new List<SensorReading>
            {
                new SensorReading { SensorId = 1, Type = "Distance", Value = 0.8, Confidence = 0.9, Timestamp = DateTime.Now.AddSeconds(-9) },
                new SensorReading { SensorId = 2, Type = "Battery", Value = 18, Confidence = 0.8, Timestamp = DateTime.Now.AddSeconds(-8) },
                new SensorReading { SensorId = 3, Type = "Temperature", Value = 92, Confidence = 0.7, Timestamp = DateTime.Now.AddSeconds(-7) },
                new SensorReading { SensorId = 4, Type = "Vibration", Value = 8.2, Confidence = 0.6, Timestamp = DateTime.Now.AddSeconds(-6) },
                new SensorReading { SensorId = 5, Type = "Battery", Value = 75, Confidence = 0.9, Timestamp = DateTime.Now.AddSeconds(-5) },
                new SensorReading { SensorId = 6, Type = "Distance", Value = 2.5, Confidence = 0.5, Timestamp = DateTime.Now.AddSeconds(-4) }
            };

            DateTime fromTime = DateTime.Now.AddSeconds(-10);

            var recentReadings = DecisionEngine.GetRecentReadings(sensorHistory, fromTime);
            var batteryCritical = DecisionEngine.IsBatteryCritical(recentReadings);
            var nearestDistance = DecisionEngine.GetNearestObstacleDistance(recentReadings);
            var temperatureSafe = DecisionEngine.IsTemperatureSafe(recentReadings);
            var averageVibration = DecisionEngine.GetAverageVibration(recentReadings);
            var sensorHealth = DecisionEngine.CalculateSensorHealth(sensorHistory);
            var faultySensors = DecisionEngine.DetectFaultySensors(sensorHistory);
            var batteryDrain = DecisionEngine.IsBatteryDrainingFast(sensorHistory);
            var weightedDistance = DecisionEngine.GetWeightedDistance(recentReadings);
            var action = DecisionEngine.DecideRobotAction(recentReadings, sensorHistory);

            Console.WriteLine("Robot Action: " + action);
        }
    }
}
