namespace MauiAppMarkiMashin
{
    internal class DataBase
    {
        private List<Group> Groups { get; set; } = new List<Group>();
        private List<Student> Students { get; set; } = new List<Student>();

        public DataBase()
        {
            Zapolnenie();
        }

        private static DataBase instance;

        public static DataBase getInstance()
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }

        public void Zapolnenie()
        {
            Groups.Add(new Group { Number = "1135", Students = GetAllStudents()});
            Students = new List<Student>
            {
                new Student { Id = 0, FIO = "Сапогов Бездельник Роблоксеевич", Address = "где-то на Баляйке", BirthDay = new DateOnly(2001, 1, 1) , IsBoy = true},
                new Student { Id = 1, FIO = "Тимофеева Яна Члене", Address = "точно на отчестве", BirthDay = new DateOnly(2006, 1, 1), IsBoy = false },
                new Student { Id = 2, FIO = "Зяблицкий Говилку Заебалович", Address = "под Киевом", BirthDay = new DateOnly(2005, 9, 11), IsBoy = true }
            };
        }
        public List<Student> GetAllStudents()
        {
            
        }

        
    }
}
