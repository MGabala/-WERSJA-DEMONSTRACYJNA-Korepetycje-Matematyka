namespace CALENDAR.API.Services
{
    public class CRUDService : IService
    {
        public async Task Run()
        {
            await GetEvents();
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
    }
}
