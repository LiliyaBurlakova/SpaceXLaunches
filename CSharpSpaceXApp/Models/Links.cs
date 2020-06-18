using Newtonsoft.Json;
using System;
using System.Text;

namespace CSharpSpaceXApp.Models
{
    public class Links
    {
        [JsonProperty("mission_patch")]
        public Uri MissionPatch { get; set; }

        [JsonProperty("mission_patch_small")]
        public Uri MissionPatchSmall { get; set; }

        [JsonProperty("reddit_campaign")]
        public Uri RedditCampaign { get; set; }

        [JsonProperty("reddit_launch")]
        public Uri RedditLaunch { get; set; }

        [JsonProperty("reddit_recovery")]
        public Uri RedditRecovery { get; set; }

        [JsonProperty("reddit_media")]
        public Uri RedditMedia { get; set; }

        [JsonProperty("presskit")]
        public Uri Presskit { get; set; }

        [JsonProperty("article_link")]
        public Uri ArticleLink { get; set; }

        [JsonProperty("wikipedia")]
        public Uri Wikipedia { get; set; }

        [JsonProperty("video_link")]
        public Uri VideoLink { get; set; }

        [JsonProperty("youtube_id")]
        public Uri YoutubeId { get; set; }

        [JsonProperty("flickr_images")]
        public object[] FlickrImages { get; set; }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (CheckPropertyValue(MissionPatch))
            {
                stringBuilder.Append(String.Format("  - MissionPatch = {0}\n", MissionPatch));
            }

            if (CheckPropertyValue(MissionPatchSmall))
            {
                stringBuilder.Append(String.Format("  - MissionPatchSmall = {0}\n", MissionPatchSmall));
            }

            if (CheckPropertyValue(RedditCampaign))
            {
                stringBuilder.Append(String.Format("  - RedditCampaign = {0}\n", RedditCampaign));
            }

            if (CheckPropertyValue(RedditLaunch))
            {
                stringBuilder.Append(String.Format("  - RedditLaunch = {0}\n", RedditLaunch));
            }

            if (CheckPropertyValue(RedditRecovery))
            {
                stringBuilder.Append(String.Format("  - RedditRecovery = {0}\n", RedditRecovery));
            }

            if (CheckPropertyValue(RedditMedia))
            {
                stringBuilder.Append(String.Format("  - RedditMedia = {0}\n", RedditMedia));
            }

            if (CheckPropertyValue(Presskit))
            {
                stringBuilder.Append(String.Format("  - Presskit = {0}\n", Presskit));
            }

            if (CheckPropertyValue(ArticleLink))
            {
                stringBuilder.Append(String.Format("  - ArticleLink = {0}\n", ArticleLink));
            }

            if (CheckPropertyValue(Wikipedia))
            {
                stringBuilder.Append(String.Format("  - Wikipedia = {0}\n", Wikipedia));
            }

            if (CheckPropertyValue(VideoLink))
            {
                stringBuilder.Append(String.Format("  - VideoLink = {0}\n", VideoLink));
            }

            if (CheckPropertyValue(YoutubeId))
            {
                stringBuilder.Append(String.Format("  - YoutubeId = {0}\n", YoutubeId));
            }

            if (CheckPropertyValue(FlickrImages))
            {
                if (FlickrImages.Length != 0)
                {
                    stringBuilder.Append(String.Format("  - FlickrImages = \n"));
                    foreach (string img in FlickrImages)
                    {
                        stringBuilder.Append(String.Format("{0}\n", img));
                    }
                }
                else
                {
                    stringBuilder.Append(String.Format("  - FlickrImages = not provided\n"));
                }
            }

            return stringBuilder.ToString();
        }


        public bool CheckPropertyValue<T>(T element)
        {

            if (element != null)
            {
                return true;
            }
            return false;
        }
    }
}