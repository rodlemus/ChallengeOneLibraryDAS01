using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books.UpdateBook
{
    public partial class UpdateBookPropertiesDialog : Form
    {
        private IDatabase<Book> _booksDatabase;
        private string _bookProperty;
        private Book _book;
        public UpdateBookPropertiesDialog(IDatabase<Book> database, string bookProperty, ref Book book)
        {
            InitializeComponent();
            this._booksDatabase = database;
            this._bookProperty = bookProperty;
            this._book = book;
            this.initInputsByProperty();

            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.groupBox1.BackColor = AppPaletteColors.GetSecondaryBackgroundColor();
        }

        private void initInputsByProperty()
        {
            //Si la propiedad a modificar es de texto o date hacemos visible el input segun sea el caso

            bool isDateType = this._bookProperty == "date";
            if (isDateType)
            {
                this.dateTimePicker1.Visible = true;
                this.textBox1.Visible = false;
            }
            else
            {
                this.textBox1.Visible = true;
                this.dateTimePicker1.Visible = false;
            }

            //Configuramos el label en base a la propiedad seleccionada
            //Le añadimos el valor previo para una mejor experiencia de usuario
            switch (this._bookProperty)
            {
                case "title":
                    this.label1.Text = "Título:";
                    this.textBox1.Text = this._book.Title;
                    break;
                case "author":
                    this.label1.Text = "Autor:";
                    this.textBox1.Text = this._book.Author;
                    break;
                case "editorial":
                    this.label1.Text = "Editorial:";
                    this.textBox1.Text = this._book.Editorial;
                    break;
                case "url":
                    this.label1.Text = "Url de Portada:";
                    this.textBox1.Text = this._book.PortraitUrl;
                    break;
                case "date":
                    this.label1.Text = "Fecha de Publicación: ";
                    this.dateTimePicker1.Value = this._book.PublicationDate;
                    break;
                case "stock":
                    this.label1.Text = "# Stock:";
                    this.textBox1.Text = this._book.Stock.ToString()
                        ;
                    break;
            }
        }

        private void handleConfirmUpdateEvent(object sender, EventArgs e)
        {
            try
            {
                //En base a la propiedad que estamos actualizando asi le asignamos el valor de texto o del dateTimepicker
                switch (this._bookProperty)
                {
                    case "title":
                        this._book.Title = this.textBox1.Text;
                        break;
                    case "author":
                        this._book.Author = this.textBox1.Text;
                        break;
                    case "editorial":
                        this._book.Editorial = this.textBox1.Text;
                        break;
                    case "url":
                        this._book.PortraitUrl = this.textBox1.Text;
                        break;
                    case "date":
                        this._book.PublicationDate = this.dateTimePicker1.Value;
                        break;
                    case "stock":
                        this._book.Stock = Int16.Parse(this.textBox1.Text);
                        break;
                }

                // despues que ya modificamos la referencia solo la guardamos
                this._booksDatabase.UpdateById(this._book, this._book.Id);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
