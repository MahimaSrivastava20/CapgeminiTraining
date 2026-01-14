using System;
using System.Collections.Generic;
using System.Linq;

namespace AutonomousRobot.AI
{
    public class SensorReading
    {
        public int SensorId { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
        public DateTime Timestamp { get; set; }
        public double Confidence { get; set; }
    }

    public enum RobotAction{Stop,SlowDown,Reroute,Continue}
    public class DecisionEngine
    {


        //------------------TASK 1-----------
        public static List<SensorReading> GetRecentReadings(List<SensorReading> sensorHistory, DateTime fromTime)
        {
            return sensorHistory.Where(r => r.Timestamp >= fromTime).ToList();
        }

        //-------------TASK 2------------------
        public static bool IsBatteryCritical(List<SensorReading> readings)
        {
            return readings.Any(r => r.Type == "Battery" && r.Value < 20);
        }


        //-----------------TASK 3-------------------
        public static double GetNearestObstacleDistance(List<SensorReading> readings)
        {
            return readings.Where(r => r.Type == "Distance").Select(r => r.Value).DefaultIfEmpty(double.MaxValue).Min();
        }

        //----------------TASK 4----------------
        public static bool IsTemperatureSafe(List<SensorReading> readings)
        {
            return readings.Where(r => r.Type == "Temperature").All(r => r.Value < 90);
        }


        //-------------TASK 5--------------
        public static double GetAverageVibration(List<SensorReading> readings)
        {
            return readings.Where(r => r.Type == "Vibration").Select(r => r.Value).DefaultIfEmpty(0).Average();
        }


        //--------------TASK 6------------------
        public static Dictionary<string, double> CalculateSensorHealth(List<SensorReading> sensorHistory)
        {
            return sensorHistory.GroupBy(r => r.Type).ToDictionary(g => g.Key, g => g.Average(r => r.Confidence));
        }


        //-------------TASK 7---------------
        public static List<string> DetectFaultySensors(List<SensorReading> sensorHistory)
        {
            return sensorHistory.GroupBy(r => r.Type)
                .Where(g => g.Count(r => r.Confidence < 0.4) > 2)
                .Select(g => g.Key)
                .ToList();
        }

        //--------------TASK 8-------------------
        public static bool IsBatteryDrainingFast(List<SensorReading> sensorHistory)
        {
            var batteryValues = sensorHistory
                .Where(r => r.Type == "Battery")
                .OrderBy(r => r.Timestamp)
                .Select(r => r.Value)
                .ToList();

            return batteryValues.Zip(batteryValues.Skip(1), (a, b) => b < a)
                                .All(x => x);
        }

        //----------------TASK 9-------------------
        public static double GetWeightedDistance(List<SensorReading> readings)
        {
            var distanceReadings = readings.Where(r => r.Type == "Distance");

            double weightedSum = distanceReadings.Sum(r => r.Value * r.Confidence);
            double totalConfidence = distanceReadings.Sum(r => r.Confidence);

            if (totalConfidence == 0)
                return double.MaxValue;

            return weightedSum / totalConfidence;
        }

        //--------------TASK 10-----------------
        public static RobotAction DecideRobotAction(List<SensorReading> recentReadings, List<SensorReading> sensorHistory)
        {
            if (recentReadings.Any(r => r.Type == "Battery" && r.Value < 20))
                return RobotAction.Stop;

            if (IsBatteryDrainingFast(sensorHistory))
                return RobotAction.Stop;

            if (GetNearestObstacleDistance(recentReadings) < 1.0)
                return RobotAction.Reroute;

            if (recentReadings.Any(r => r.Type == "Temperature" && r.Value >= 90))
                return RobotAction.SlowDown;

            return RobotAction.Continue;
        }
    }
}
