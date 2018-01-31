namespace TodoMvc.Todos {
    public class TodoItem {
        public long id { get; }
        public string title { get; }
        public string content { get; }

        public TodoItem(long id, string title, string content) {
            this.id = id;
            this.title = title;
            this.content = content;
        }
    }    
}