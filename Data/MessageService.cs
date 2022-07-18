namespace testProject.Data
{
    public class MessageService
    {
        private AppDBContext _dbContext;

        public MessageService(AppDBContext db)
        {
            _dbContext = db;
        }

        public async Task<List<Message>> GetMessagesAsync()
        {
            return _dbContext.Messages.ToList();
        }

        public async Task<Message> DeleteMessageAsync(Message message)
        {
            _dbContext.Messages.Remove(message);
            await _dbContext.SaveChangesAsync();

            return message;
        }
    }
}
