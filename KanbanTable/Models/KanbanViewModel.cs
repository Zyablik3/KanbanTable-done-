using KanbanTable.Entities;
namespace KanbanTable.Models
{
    public class KanbanViewModel
    {
        public List<StatusTask> Statuses { get; set; }
        public List<TaskKanban> Tasks { get; set; }
        public List<ProjectKanban> Projects { get; set; }
        public List<Customer> Orders { get; set; }
    }
}
