namespace KanbanTable.Entities
{
    public class ProjectKanban
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public Customer? Order { get; set; }
        public int? OrderId { get; set; }
    }
}
