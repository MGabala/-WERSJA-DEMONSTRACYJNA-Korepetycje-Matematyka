
using System;

namespace CALENDAR_INTEGRATION // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const string ApiKey_ = "AIzaSyAxriXYldEFvas2zCfdUgXzZCpohez2xd4";
        const string CalendarId = "en.danish#holiday@group.v.calendar.google.com";
        static async Task Main(string[] args)
        {
            var service = new Google.Apis.Calendar.v3.CalendarService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                ApiKey = ApiKey_,
                ApplicationName = "Test"
            });
            var request = service.Events.List(CalendarId);
            request.Fields = "items(summary,start,end)";
            var response = await request.ExecuteAsync();
            foreach(var item in response.Items)
            {
                Console.WriteLine($"Holiday: {item.Summary} start: {item.Start} end: {item.End}");
            }
            Console.ReadLine();
        }
      
    }
}