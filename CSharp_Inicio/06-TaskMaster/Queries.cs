using BetterConsoleTables;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("-----Lista de tareas-----");
            //WriteLine("\n{0,-8} {1, 35} {2,-15}","Id","Descripcion","Completado");
            //foreach(var task in Tasks)
            //{
            //    WriteLine(new string('-', 58));
            //    WriteLine("\n{0,-8} {1, 35} {2,-15}", task.Id, task.Description, task.Completed);
            //}
            Table table = new Table("Id", "Descripcion", "Estado");
            foreach(var task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed? "Completada": "");

            }
            table.Config = TableConfiguration.Unicode();
            Write(table.ToString());
            ReadKey();
        }

    }
}
