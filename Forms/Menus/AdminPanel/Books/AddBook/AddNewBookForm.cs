using ChallengeOneLibraryDAS01.Models;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books.AddBook
{
    public partial class AddNewBookForm : Form
    {
        private Book _newBook;
        private Dictionary<string, string> _formErrorsStack = new Dictionary<string, string>();
        public AddNewBookForm()
        {
            InitializeComponent();

            _newBook = new Book();
            this.BackColor = AppPaletteColors.GetSecondaryBackgroundColor();
            this.panel1.BackColor = AppPaletteColors.GetSecondaryAccentBackgroundColor();
            this.button1.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_formErrorsStack.Count == 0)
            {
                MessageBox.Show("Libro Guardado con éxito");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Falta Validar campos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bookUrlTxtBox_TextChanged(object sender, EventArgs e)
        {
            bookPortraitPictureBx.ImageLocation = bookUrlTxtBox.Text;
        }

        private void handleTitleValidation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorKey = "title";
            try
            {
                this._newBook.Title = bookTitleTxtBox.Text;
                pictureBox1.Image = Properties.Resources.check;
                this.validErrorStack(errorKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox1.Image = Properties.Resources.invalid;
                this._formErrorsStack.Add(errorKey, ex.Message);
            }
        }

        private void handleAuthorValidation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorKey = "author";
            try
            {
                this._newBook.Author = bookAutorTxtBox.Text;
                pictureBox2.Image = Properties.Resources.check;
                this.validErrorStack(errorKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox2.Image = Properties.Resources.invalid;
                this._formErrorsStack.Add(errorKey, ex.Message);
            }
        }

        private void handlePortraitUrlValidation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorKey = "url";
            try
            {
                this._newBook.PortraitUrl = bookUrlTxtBox.Text;
                pictureBox3.Image = Properties.Resources.check;
                this.validErrorStack(errorKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox3.Image = Properties.Resources.invalid;
                this._formErrorsStack.Add(errorKey, ex.Message);
            }
        }

        private void handleEditorialValidation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorKey = "editorial";
            try
            {
                this._newBook.Editorial = txtBoxEditorial.Text;
                pictureBox4.Image = Properties.Resources.check;
                this.validErrorStack(errorKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox4.Image = Properties.Resources.invalid;
                this._formErrorsStack.Add(errorKey, ex.Message);
            }
        }

        private void handleStockValidation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorKey = "stock";
            try
            {
                this._newBook.Stock = Int16.Parse(txtBoxStock.Text);
                pictureBox5.Image = Properties.Resources.check;
                this.validErrorStack(errorKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox5.Image = Properties.Resources.invalid;
                this._formErrorsStack.Add(errorKey, ex.Message);
            }
        }


        private void validErrorStack(string errorKey)
        {
            bool existPrevError = this._formErrorsStack.ContainsKey(errorKey);
            if (!existPrevError)
            {
                return;
            }
            this._formErrorsStack.Remove(errorKey);
        }
    }
}
