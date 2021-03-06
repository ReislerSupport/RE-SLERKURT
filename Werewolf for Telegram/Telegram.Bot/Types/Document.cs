using Newtonsoft.Json;
using Telegram.Bot.Converters;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a general file (as opposed to photos and audio files).
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Document : File
    {
        /// <summary>
        /// Document thumbnail as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "thumb", Required = Required.Default)]
        [JsonConverter(typeof(PhotoSizeConverter))]
        public PhotoSize Thumb { get; internal set; }

        /// <summary>
        /// Optional. Original filename as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "file_name", Required = Required.Default)]
        public string FileName { get; internal set; }

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
