using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            return String.Format("MissionPatch = {0}\n" +
                "MissionPatchSmall = {1}\n" +
                "RedditCampaign = {2}\n" +
                "RedditLaunch = {3}\n" +
                "RedditRecovery = {4}\n" +
                "RedditMedia = {5}\n" +
                "Presskit = {6}\n" +
                "ArticleLink = {7}\n" +
                "Wikipedia = {8}\n" +
                "VideoLink = {9}\n" +
                "YoutubeId = {10}\n" +
                "FlickrImages = {11}", 
                MissionPatch, MissionPatchSmall, RedditCampaign, RedditLaunch, RedditRecovery, RedditMedia, 
                Presskit, ArticleLink, Wikipedia, VideoLink, YoutubeId, FlickrImages);
        }
    }
}