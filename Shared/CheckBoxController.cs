using testProject.Data;

namespace testProject.Shared
{
    public class CheckBoxController
    {
        public List<Message> CheckedMessages { get; private set; } = new();

        public void ToggleMessage(Message message)
        {
            if (CheckedMessages.Contains(message))
            {
                CheckedMessages.Remove(message);
            }
            else
            {
                CheckedMessages.Add(message);
            }
        }
    }
}
