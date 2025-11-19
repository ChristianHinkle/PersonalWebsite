using ChristianHinko.Classes;
using ChristianHinko.Shared.Components.Posts;

namespace ChristianHinko.Services
{
    /// <summary>
    /// Central container of post infos.
    /// </summary>
    public class CHPostInfoService : ICHPostInfoService
    {
        public List<CHPostInfo> PostInfos { get; init; }

        public List<CHPostInfo> PostInfosIncludingNonDisplayed { get; init; }

        public CHPostInfoService()
        {
            PostInfosIncludingNonDisplayed = new List<CHPostInfo>()
            {
                new CHPostInfo()
                {
                    Title = "Trig Functions Make So Much Sense!",
                    Subtitle = "Visualize and understand the circular functions.",
                    Date = new DateTime(2023, 02, 04),
                    ImageSrc = "/_content/ChristianHinko/images/TrigFunctionsMakeSoMuchSense.png",
                    Slug = "trig-functions-make-so-much-sense",
                    Component = typeof(TrigFunctionsMakeSoMuchSense)
                },
                new CHPostInfo()
                {
                    Title = "Get Faster Unreal Engine Build Times!",
                    Subtitle = "Use UBT BuildConfiguration to optimize build times.",
                    Date = new DateTime(2023, 07, 05),
                    ImageSrc = "/_content/ChristianHinko/images/GetFasterUnrealEngineBuildTimes.png",
                    Slug = "get-faster-unreal-engine-build-times",
                    Component = typeof(GetFasterUnrealEngineBuildTimes)
                },
                new CHPostInfo()
                {
                    Title = "Play DDR At Home!",
                    Subtitle = "Run your DanceDanceRevolution arcade game on your PC.",
                    Date = new DateTime(2025, 01, 08),
                    ImageSrc = "/_content/ChristianHinko/images/PlayDdrAtHome.png",
                    Slug = "play-ddr-at-home",
                    Component = typeof(PlayDdrAtHome)
                },
                new CHPostInfo()
                {
                    Title = "Play DDR At Home!",
                    Subtitle = "Run your DanceDanceRevolution arcade game on your PC.",
                    Date = new DateTime(2025, 01, 08),
                    ImageSrc = "/_content/ChristianHinko/images/PlayDdrAtHome.png",
                    Slug = "play-ddr-at-home-easy-mode",
                    Component = typeof(PlayDdrAtHomeEasyMode),
                    IsDisplayed = false
                }
            };

            // Sort the post infos by date.
            PostInfosIncludingNonDisplayed.Sort((a, b) => a.Date.CompareTo(b.Date));

            // Initialize the displayed post infos by copying all of the post infos and filtering them based on their "IsDisplayed" bool.
            PostInfos = new(PostInfosIncludingNonDisplayed);
            PostInfos.RemoveAll(item => !item.IsDisplayed);
        }
    }
}
