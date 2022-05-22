
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using System.Security.Cryptography.X509Certificates;

namespace CALENDAR.API.Services
{
    public class CRUDService : IService
    {
        private string serviceAccountEmail = "matgab9606@gmail.com";

        public async Task Run()
        {
            // await GetEvents();
            await TesT();
        }
        private async Task GetEvents()
        {
            const string ApiKey_ = "AIzaSyAxriXYldEFvas2zCfdUgXzZCpohez2xd4";
            const string CalendarId = "l8nhrpi19ggdojn97e0o1s6npc@group.calendar.google.com";
            var service = new Google.Apis.Calendar.v3.CalendarService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                ApiKey = ApiKey_,
                ApplicationName = "Test"
            });
            var request = service.Events.List(CalendarId);
            request.Fields = "items(summary,start,end)";
            var response = await request.ExecuteAsync();
            foreach (var item in response.Items)
            {
                Console.WriteLine($"Title: {item.Summary} start: {item.Start} end: {item.End}+\n");
            }
        }
        private async Task TesT()
        {
            string[] scopes = new string[] { CalendarService.Scope.Calendar };
            GoogleCredential credential;
            using (var stream = new FileStream("A:\\Users\\sam_sepi0l\\Downloads\\test.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                                 .CreateScoped(scopes);
            }

            // Create the Calendar service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Calendar Authentication Sample",
            });
        }
    }
}
