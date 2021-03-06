using Newtonsoft.Json;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a voice note.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Voice : File
    {
        /// <summary>
        /// Duration of the audio in seconds as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "duration", Required = Required.Always)]
        public int Duration { get; internal set; }

        /// <summary>
        /// Optional. MIME type of the file as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "mime_type", Required = Required.Default)]
        public string MimeType { get; internal set; }

        /// <summary>
        /// Unique Persistent ID for the file that is the same over different bots
        /// </summary>
        [JsonProperty("file_unique_id", Required = Required.Default)]
        public string FileUniqueId { get; set; }
    }
}
