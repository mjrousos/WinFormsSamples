using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Hosting;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSample
{
    public partial class Form1 : Form
    {
        private const string SettingsFileName = "settings.bin";

        public Form1()
        {
            InitializeComponent();

            LoadSettings();
            PopulateDataGrid();
            StyleDataGrid();
            CreateMenu();
        }

        private void CreateMenu()
        {
            var menu = new MainMenu();
            var clearSettingsMenumitem = new MenuItem("Clear settings", new EventHandler(ClearSettings))
            {
                Text = "Clear settings"
            };

            var rotatePicMenuItem = new MenuItem("Rotate picture", new EventHandler(RotatePicutre))
            {
                Text = "Rotate picture"
            };


            var exitMenuItem = new MenuItem("Exit", new EventHandler(Exit))
            {
                Text = "Exit"
            };
            
            menu.MenuItems.Add(clearSettingsMenumitem);
            menu.MenuItems.Add(rotatePicMenuItem);
            menu.MenuItems.Add(exitMenuItem);

            Menu = menu;
        }

        private void RotatePicutre(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void ClearSettings(object sender, EventArgs e)
        {
            imagePath = null;
            pictureBox1.Image = null;
            txtUserName.Text = string.Empty;

            SaveSettings();
        }

        private void Exit(object sender, EventArgs e) => Application.Exit();

        private void toolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            string imageName = null;
            switch (e.Button.Name)
            {
                case "tbtnCat":
                    imageName = "cat.jpg";
                    break;
                case "tbtnDog":
                    imageName = "dog.jpg";
                    break;
                case "tbtnExit":
                    Application.Exit();
                    break;
                default:
                    throw new InvalidOperationException("Invalid button clicked");
            };
            imagePath = $"SimpleSample.Images.{imageName}";
            if (imageName != null)
            {
                using (var stream = GetType().Assembly.GetManifestResourceStream(imagePath))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }

            SaveSettings();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateUserName_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void LoadSettings()
        {
            var directory = Path.GetDirectoryName(GetType().Assembly.Location);
            var settingsPath = Path.Combine(directory, SettingsFileName);
            if (File.Exists(settingsPath))
            {
                try
                {
                    var formatter = new BinaryFormatter();
                    using (var stream = File.OpenRead(settingsPath))
                    {
                        var settings = (AppSettings)formatter.Deserialize(stream);
                        txtUserName.Text = settings.UserName;
                        imagePath = settings.ImageResourcePath;
                        if (imagePath != null)
                        {
                            using (var imageStream = GetType().Assembly.GetManifestResourceStream(imagePath))
                            {
                                pictureBox1.Image = Image.FromStream(imageStream);
                            }
                        }
                    }
                }
                catch
                {
                    // TODO: Log invalid settings file
                }
            }
        }

        private void SaveSettings()
        {
            var settings = new AppSettings
            {
                ImageResourcePath = imagePath,
                UserName = txtUserName.Text
            };

            var formatter = new BinaryFormatter();
            var directory = Path.GetDirectoryName(GetType().Assembly.Location);
            using (var stream = File.OpenWrite(Path.Combine(directory, SettingsFileName)))
            {
                formatter.Serialize(stream, settings);
            }
        }

        private void PopulateDataGrid()
        {
            var dataSet = new DataSet();
            var dataTable = new DataTable("Environment");
            var nameColumn = new DataColumn("Name", typeof(string));
            var valueColumn = new DataColumn("Value", typeof(string));
            dataTable.Columns.Add(nameColumn);
            dataTable.Columns.Add(valueColumn);
            dataSet.Tables.Add(dataTable);

            var row1 = dataTable.NewRow();
            row1["Name"] = "Machine name";
            row1["Value"] = Environment.MachineName;
            dataTable.Rows.Add(row1);

            var row2 = dataTable.NewRow();
            row2["Name"] = "OS Version";
            row2["Value"] = Environment.OSVersion;
            dataTable.Rows.Add(row2);

            dataGrid.SetDataBinding(dataSet, "Environment");
        }

        private void StyleDataGrid()
        {
            var tableStyle = new DataGridTableStyle();
            tableStyle.MappingName = "Environment";
            tableStyle.AlternatingBackColor = Color.Yellow;

            var nameColumnStyle = new DataGridTextBoxColumn();
            nameColumnStyle.MappingName = "Name";
            nameColumnStyle.HeaderText = "Name";
            nameColumnStyle.Width = 90;
            tableStyle.GridColumnStyles.Add(nameColumnStyle);

            var valueColumnStyle = new DataGridTextBoxColumn();
            valueColumnStyle.MappingName = "Value";
            valueColumnStyle.HeaderText = "Value";
            valueColumnStyle.Width = 180;
            tableStyle.GridColumnStyles.Add(valueColumnStyle);

            dataGrid.TableStyles.Add(tableStyle);
        }
    }
}
