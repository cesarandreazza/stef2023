using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ChatWidgetService.Core;

public static class JsonExtensions
{
    private static readonly JsonSerializerSettings JsonSettings = new() {ContractResolver = new CamelCasePropertyNamesContractResolver()};

    public static string ToJson<TModel>(this TModel model) => JsonConvert.SerializeObject(model, JsonSettings);

    public static TModel ToModel<TModel>(this string json) => JsonConvert.DeserializeObject<TModel>(json, JsonSettings)!;
}
