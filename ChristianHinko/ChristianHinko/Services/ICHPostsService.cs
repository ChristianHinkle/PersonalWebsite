using ChristianHinko.Classes;

namespace ChristianHinko.Services
{
    /// <summary>
    /// Implement this and give a list of post infos to use.
    /// </summary>
    public interface ICHPostInfoService
    {
        public List<CHPostInfo> PostInfos { get; init; }

        public List<CHPostInfo> PostInfosIncludingNonDisplayed { get; init; }
    }
}
