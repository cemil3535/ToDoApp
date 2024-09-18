﻿namespace ToDoApp.Entites
{
    // Entity -> Veri tablosundaki bir veriye karsilik gelen class
    public class TaskEntity
    {
        public TaskEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? CompletedDate { get; set; }

        public bool IsDone { get; set; }

        public bool IsDeleted { get; set; }

    }
}
