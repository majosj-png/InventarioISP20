
namespace Desktop.Models
{
    // ResponseMistral myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Choice
    {
        public int index { get; set; }
        public string finish_reason { get; set; }
        public Message message { get; set; }
    }

    public class Message
    {
        public string role { get; set; }
        public object tool_calls { get; set; }
        public string content { get; set; }
    }

    public class PromptTokensDetails
    {
        public int cached_tokens { get; set; }
    }

    public class ResponseMistral
    {
        public string id { get; set; }
        public int created { get; set; }
        public string model { get; set; }
        public Usage usage2 { get; set; }
        public string @object { get; set; }
        public List<Choice> choices { get; set; }
    }

    public class Usage2
    {
        public int prompt_tokens { get; set; }
        public int total_tokens { get; set; }
        public int completion_tokens { get; set; }
        public PromptTokensDetails prompt_tokens_details { get; set; }
        public string service_tier { get; set; }
    }

}
