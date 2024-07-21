using System.Text.Json.Serialization;

namespace ApiProject.Entities;

public class FakePostEntities
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("userId")]
    public int UserId { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("body")]
    public string? Body { get; set; }

}