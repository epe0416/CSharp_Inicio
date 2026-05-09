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
        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---Completar Tarea---");
                WriteLine("Ingrese el id de la tarea que desea marcar como completada: ");
                var id = ReadLine()!;
                Task task = Tasks.Find(t => t.Id == id);
                if(task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontro la tarea con el ID proporcionado");
                    ResetColor();
                    return Tasks;
                }
                task.Completed = true;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea marcada como completada con éxito");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.ToString());
                return Tasks;
            }
        }
        public List<Task> EditTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---Editar Tarea---");
                WriteLine("Ingrese el id para editar la tarea: ");
                var id = ReadLine()!;
                Task task = Tasks.Find(t => t.Id == id);
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontro la tarea con el ID proporcionado");
                    ResetColor();
                    return Tasks;
                }
                WriteLine("Ingrese la descripción de la tarea: ");
                var description = ReadLine();
                task.Description = description;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea modificada con éxito");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.ToString());
                return Tasks;
            }
        }

        public List<Task> RemoveTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---Eliminar Tarea---");
                WriteLine("Ingrese el id de la tarea a Eliminar: ");
                var id = ReadLine()!;
                Task task = Tasks.Find(t => t.Id == id);
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontro la tarea con el ID proporcionado");
                    ResetColor();
                    return Tasks;
                }
                Tasks.Remove(task);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea Eliminada con éxito");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.ToString());
                return Tasks;
            }
        }

        public void TasksByState()
        {
            Clear();
            try
            {
                ResetColor();
                WriteLine("--- Tareas por estado ---");
                WriteLine("1. Completadas");
                WriteLine("2. Pendientes");
                WriteLine("Ingrese la opción de las tareas a mostrar: ");
                string taskState = ReadLine()!;

                if (taskState != "1" && taskState != "2")
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Opción no invalida");
                    ResetColor();
                    return;
                }

                bool completed = taskState == "1";
                List<Task> filteredTask = Tasks.Where(t => t.Completed == completed).ToList();
                if(filteredTask.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontraron tareas con el estado solicitado");
                    ResetColor();
                    return;
                }

                ForegroundColor = completed ? ConsoleColor.Green : ConsoleColor.Red;
                Table table = new Table("Id", "Descripcion", "Estado");
                foreach (var task in filteredTask)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
                }
                table.Config = TableConfiguration.Unicode();
                Write(table.ToString());
                ReadKey();

            }
            catch(Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Ocurrio un error al filtrar las tareas: {ex.Message}");
            }
        }

    }
}
