public class DataService
{
    public List<Destinations> GetDestinations()
    {
        var destinations = new List<Destinations>
        {
            new Destinations { Name = "Eco Resort", Description = "Experience sustainable living in a stunning eco-resort.", Location = "Tropical Paradise" },
            new Destinations { Name = "Wilderness Retreat", Description = "Get closer to nature in this secluded wilderness retreat.", Location = "Mountain Range" },
            new Destinations { Name = "Ocean Sanctuary", Description = "Dive into the vibrant marine life at this ocean sanctuary.", Location = "Coastal Haven" }
        };

        return destinations;
    }

    public List<Activities> GetActivities()
    {
        var activities = new List<Activities>
        {
            new Activities { Name = "Hiking Adventure", Description = "Embark on a thrilling hike through lush green trails.", Location = "Mountain Range" },
            new Activities { Name = "Kayaking Expedition", Description = "Paddle through scenic waterways and explore hidden gems.", Location = "Riverside" },
            new Activities { Name = "Wildlife Safari", Description = "Encounter diverse wildlife on an exciting safari adventure.", Location = "National Park" }
        };

        return activities;
    }
}
