using System;
using New_Task.Model;

namespace New_Task.Model
{
	public class BuildingModel
	{
		public List<Floors> FloorsModel { get; set; }
	}
    public class Floors
    {
        public List<Rooms> RoomsModel { get; set; }
    }
    public class Rooms
    {
        public List<Sensors> SensorsModel { get; set; }
    }
    public class Sensors
    {
        public string SensorId { get; set; }
        public string SensorName { get; set; }
        public string SensorType{ get; set; }
    }
}

FloorsModel floorModel = new FloorsModel();

foreach (var floor in floorModel.FloorsModel)
{ 
    foreach (var room in floor.SensorsModel)
    {
        foreach (var sensor in room.SensorsModel)
        {
            Console.WriteLine(sensor.SensorId);
            Console.WriteLine(sensor.SensorName);
            Console.WriteLine(sensor.SensorType);
        }
    }
}

