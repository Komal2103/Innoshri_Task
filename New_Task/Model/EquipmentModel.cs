using System;
using System.Text.Json;
using New_Task.Model;

namespace New_Task.Model
{
	public class EquipmentModel
	{
		public string equipmentId { get; set; }

        public string name { get; set; }

        public string status { get; set; }

        public List<ReadingsModel> readings { get; set; }


    }
    public class ReadingsModel
    {
        public string timestamp { get; set; }
        public int temperature { get; set; }

    }

}

var result = await JsonSerialize.deserialize<EquipmentModel>();
var avg = 0;
int count = 0;
foreach (var read in result.readings)
{
    avg = avg + read.temperature;
    Console.WriteLine(read.timestamp);
    //Console.WriteLine(read.temperature);
}
avg = avg / count;
Console.WriteLine(avg);

public async EquipmentModel GetEquipmentModelAsync(string equipmentId, string api)
{
    try
    {
        EquipmentModel equipmentModelReaponse = new EquipmentModel();
        HttpClient httpClient = new HttpClient;
        var url = $"{api}/equipment?equipmentId={Uri.EscapeDataString(equipmentId)}";

        var response = await httpClient.GetAsync(request, "https:api/equipment/?equipmentId");
        if(response.IsStatusCode)
        {
            equipmentModelReaponse = await JsonSerializer.Deserialize<EquipmentModel>(response);
            return equipmentModelReaponse;
        }
        else if (response.Message)
        {

        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}


