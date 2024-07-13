namespace KanbanTable.Entities
{
    public class TaskKanban
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public int? ProjectId { get; set; }

        public ProjectKanban? Project { get; set; }

        public int? StatusId { get; set; }

        public StatusTask? Status { get; set; }

        
    }
}
