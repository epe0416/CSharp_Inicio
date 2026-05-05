using BetterConsoleTables;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("-----Lista de tareas-----");
            Table table = new Table("Id", "Descripcion", "Estado");
            foreach(var task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed? "Completada": "");

            }
            table.Config = TableConfiguration.Unicode();
            Write(table.ToString());
            ReadKey();
        }
        public List<Task> AddTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---Añadir Tarea---");
                WriteLine("Ingrese la descripción de la tarea: ");
                var description = ReadLine()!;
                Task newTask = new Task(Utils.GenerateId(), description);
                Tasks.Add(newTask);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea añadida con éxito");
                ResetColor();
                return Tasks;
            }
            catch(Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.ToString());
                return Tasks;
            }
        }

    }
}
