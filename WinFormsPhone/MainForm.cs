using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using PhoneDB.Modals;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab5
{
    public partial class MainForm : Form
    {
        private int current;
        private PhoneContext? dbContext;
        public MainForm()
        {
            InitializeComponent();
            current = 0;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            AddButton.Visible = false;
            this.dbContext = new PhoneContext();
            if (dbContext != null)
            {
                this.dbContext.Phonebooks.Load();
                var phone = dbContext.Phonebooks
                .OrderBy(b => b.Id)
                    .First();
                LastNameTextBox.Text = phone.Lastname;
                NameTextBox.Text = phone.Name;
                PatronymicTextBox.Text = phone.Patronymic;
                StreetTextBox.Text = phone.Street;
                HouseNumericUpDown.Value = phone.House;
                FlatNumericUpDown.Value = phone.House;
                PhoneMaskedTextBox.Text = phone.Phone;
            }
        }
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            AddButton.Visible = false;

            LastNameTextBox.Enabled = false;
            NameTextBox.Enabled = false;
            PatronymicTextBox.Enabled = false;
            StreetTextBox.Enabled = false;
            HouseNumericUpDown.Enabled = false;
            FlatNumericUpDown.Enabled = false;
            PhoneMaskedTextBox.Enabled = false;
            if (dbContext != null)
            {
                var phone = dbContext.Phonebooks
              .OrderBy(b => b.Id)
                    .ToArray();
                if (current == 0)
                {
                    MessageBox.Show("Предыдущей записи не существует!");
                }
                else
                {
                    current--;
                    LastNameTextBox.Text = phone[current].Lastname;
                    NameTextBox.Text = phone[current].Name;
                    PatronymicTextBox.Text = phone[current].Patronymic;
                    StreetTextBox.Text = phone[current].Street;
                    HouseNumericUpDown.Value = phone[current].House;
                    FlatNumericUpDown.Value = phone[current].House;
                    PhoneMaskedTextBox.Text = phone[current].Phone;
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AddButton.Visible = false;

            LastNameTextBox.Enabled = false;
            NameTextBox.Enabled = false;
            PatronymicTextBox.Enabled = false;
            StreetTextBox.Enabled = false;
            HouseNumericUpDown.Enabled = false;
            FlatNumericUpDown.Enabled = false;
            PhoneMaskedTextBox.Enabled = false;
            if (dbContext != null)
            {
                var phone = dbContext.Phonebooks
                    .OrderBy(b => b.Id)
                    .ToArray();
                if (current + 1 == phone.Length)
                {
                    MessageBox.Show("Следующей записи не существует!");
                }
                else
                {
                    current++;
                    LastNameTextBox.Text = phone[current].Lastname;
                    NameTextBox.Text = phone[current].Name;
                    PatronymicTextBox.Text = phone[current].Patronymic;
                    StreetTextBox.Text = phone[current].Street;
                    HouseNumericUpDown.Value = phone[current].House;
                    FlatNumericUpDown.Value = phone[current].House;
                    PhoneMaskedTextBox.Text = phone[current].Phone;
                }
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddButton.Visible = true;

            LastNameTextBox.Clear();
            NameTextBox.Clear();
            PatronymicTextBox.Clear();
            StreetTextBox.Clear();
            HouseNumericUpDown.Value = 1;
            FlatNumericUpDown.Value = 1;
            PhoneMaskedTextBox.Clear();

            LastNameTextBox.Enabled = true;
            NameTextBox.Enabled = true;
            PatronymicTextBox.Enabled = true;
            StreetTextBox.Enabled = true;
            HouseNumericUpDown.Enabled = true;
            FlatNumericUpDown.Enabled = true;
            PhoneMaskedTextBox.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int _id = -1;
            if (dbContext != null)
            {
                var phon = dbContext.Phonebooks
                    .OrderBy(b => b.Id)
                    .ToArray();
                _id = phon.Length;
            }
            else
            {
                _id = 0;
            }
                // для добавления новой записи в БД, сначала создадим объект модели
                object phone = new Phonebook
            {
                Id = _id,
                Lastname = LastNameTextBox.Text,
                Name = NameTextBox.Text,
                Patronymic = PatronymicTextBox.Text,
                Street = StreetTextBox.Text,
                House = HouseNumericUpDown.Value,
                Flat = FlatNumericUpDown.Value,
                Phone = PhoneMaskedTextBox.Text
            };

            // добавим в БД
            dbContext.Add(phone);
            // сохраним изменения
            dbContext.SaveChanges();
            MessageBox.Show("Данные пользователя добавлены");
        }
    }
}
