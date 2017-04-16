using System;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{

    public partial class Main_Form : System.Windows.Forms.Form
    {

        public Main_Form()
        {
            InitializeComponent();
            // Инициализация элементов при первой загрузке формы
            //Активируем все чекбоксы со списком обрабатываемых таблиц
            for (int i = 0; i <= CheckedListBox_Tables.Items.Count - 1; i++)
                CheckedListBox_Tables.SetItemChecked(i, true);
        }
        //Добавляем схему в список
        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (ListBox_Schemes.Items.Contains(TextBox_Scheme.Text) == false)
                ListBox_Schemes.Items.Add(TextBox_Scheme.Text); 
            else
                MessageBox.Show("Данная схема уже присутствует в списке"); 
        }
        //Удаляем схему из списка
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            ListBox_Schemes.Items.Remove(ListBox_Schemes.SelectedItem);
            if (ListBox_Schemes.SelectedItem == null)// ?
                Button_Delete.Enabled = false;
        }
        //Удаляем все схемы из списка
        private void Button_Delete_All_Click(object sender, EventArgs e)
        {
            ListBox_Schemes.Items.Clear();
        }
        //Активируем кнопку Удалить
        private void ListBox_Schemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)ListBox_Schemes.SelectedItem != "")
            Button_Delete.Enabled = true;
        }
        //Экспорт схем в файл
        private void Export_Click(object sender, EventArgs e)
        {
            //Получаем полное имя файла;
            string schemes_txt = Directory.GetCurrentDirectory() + @"\schemes.txt";
            //Получаем полное имя файла;
            using (StreamWriter outputFile = new StreamWriter(schemes_txt, true))
            {
                foreach (Object Item in ListBox_Schemes.Items)
                    outputFile.WriteLine((string)Item);
            }
        }
        //Импорт схем из файла
        private void Import_Click(object sender, EventArgs e)
        {
            String filename = Directory.GetCurrentDirectory() + @"\schemes.txt";
            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\schemes.txt");
            ListBox_Schemes.Items.Clear();
            ListBox_Schemes.Items.AddRange(lines);
        }


    private void Work_Macro_Click(object sender, EventArgs e)
    {
        //Проверяем существование базы данных в текущем каталоге
        String db_filename = Directory.GetCurrentDirectory() + @"\db.accdb";
        if (File.Exists(Directory.GetCurrentDirectory() + @"\db.accdb") == false)
        {
            //Создание каталога ADOX
            ADOX.Catalog adoxCat = new ADOX.Catalog();
            //Создание базы данных
            adoxCat.Create("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + @"\db.accdb" + ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Password=");
            //Закрытие соединения
            adoxCat.ActiveConnection.close();
        }
        //Создаем интерфейс Access.Application
        Microsoft.Office.Interop.Access.Application oAccess = new Microsoft.Office.Interop.Access.Application();
        oAccess.Application.Visible = true;
        //Открываем БД
        oAccess.OpenCurrentDatabase(Directory.GetCurrentDirectory() + @"\db.accdb", false);

        //Создаем ссылку класса VBProject на текущий объект БД
        Microsoft.Vbe.Interop.VBProject project = oAccess.VBE.VBProjects.Item(1);
        //Создаем ссылку класса VBComponent на созданный модуль БД
        Microsoft.Vbe.Interop.VBComponent module = project.VBComponents.Add(Microsoft.Vbe.Interop.vbext_ComponentType.vbext_ct_StdModule);




        //Вставляем текст в модуль
        module.CodeModule.AddFromString(Properties.Resources.Macro);

        //Сохранение макроса
        oAccess.DoCmd.Save(Microsoft.Office.Interop.Access.AcObjectType.acModule, module.Name.ToString());

        //Присваеваем список схем и выбранных таблиц
        string[] Schemas = new string[ListBox_Schemes.Items.Count];
        string[] Tables = new string[CheckedListBox_Tables.CheckedItems.Count];
        //Цикл по схемам
        int i = 0;
        foreach (Object Схема in ListBox_Schemes.Items)
        {
            Schemas[i] = (string)Схема;
            i++;
        }
        i = 0;
        //Цикл по таблицам
        foreach (Object Таблица in CheckedListBox_Tables.CheckedItems)
        {
             Tables[i] = (string)Таблица;
             i++;
        }
        //Запуск функции "export" в созданном модуле VBA
        oAccess.Run("export", Schemas, Tables, Server.Text, Port.Text, Uid.Text, Pwd.Text);
        //Закрытие модуля VBA
        oAccess.DoCmd.Close(Microsoft.Office.Interop.Access.AcObjectType.acModule, module.Name.ToString(), Microsoft.Office.Interop.Access.AcCloseSave.acSaveYes);
        //Удаление модуля VBA
        oAccess.DoCmd.DeleteObject(Microsoft.Office.Interop.Access.AcObjectType.acModule, module.Name.ToString());

        //Выход из приложения ACCESS без сохранения изменений
        oAccess.DoCmd.Quit(Microsoft.Office.Interop.Access.AcQuitOption.acQuitSaveNone);
        //Освободить объект oAccess
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oAccess);
        oAccess = null; 


        }

        private void Verify_Click(object sender, EventArgs e)
        {

        }
    }
}
