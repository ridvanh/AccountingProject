using Business.Operations;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class Form1 : Form
    {
        List<TextBox> loadAccountTextBoxes;
        List<TextBox> loadTransactionTextBoxes;
        List<TextBox> addAccTextBoxes;
        List<TextBox> paymentTextBoxes;
        List<string> loadAccTexts;
        List<string> addAccTexts;
        List<string> loadTransactionTexts;
        List<string> paymentTexts;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTextLists();
        }

        #region AdditionalUIMethods
        private void InitializeTextLists()
        {
            loadAccountTextBoxes = new List<TextBox>()
            {
                loadAccTextBox1, loadAccTextBox2, loadAccTextBox3, loadAccTextBox4, loadAccTextBox5, loadAccTextBox6, loadAccTextBox7
            };

            loadTransactionTextBoxes = new List<TextBox>()
            {
                trTextBox1, trTextBox2, trTextBox3, trTextBox4, trTextBox5, trTextBox6, trTextBox7, trTextBox8, trTextBox9
            };

            addAccTextBoxes = new List<TextBox>() 
            {
                addCustomerNoTBox, addBranchNoTBox
            };

            paymentTextBoxes = new List<TextBox>() 
            {
                paymentTextBox1, paymentTextBox2
            };

            loadAccTexts = new List<string>() 
            { 
                loadAccTextBox1.Text, loadAccTextBox2.Text, loadAccTextBox3.Text, loadAccTextBox4.Text, loadAccTextBox5.Text, loadAccTextBox6.Text, loadAccTextBox7.Text 
            };
            
            addAccTexts = new List<string>() 
            { 
                addCustomerNoTBox.Text, addBranchNoTBox.Text
            };
            
            loadTransactionTexts = new List<string>() 
            { 
                trTextBox1.Text, trTextBox2.Text, trTextBox3.Text, trTextBox4.Text, trTextBox5.Text, trTextBox6.Text, trTextBox7.Text, trTextBox8.Text, trTextBox9.Text
            };
            
            paymentTexts = new List<string>() 
            { 
                paymentTextBox1.Text, paymentTextBox2.Text 
            };
        }

        private void FillTextboxes(DataGridViewRow row, List<TextBox> textBoxes)
        {
            for (int i = 0; i < row.Cells.Count; i++)
            {
                textBoxes[i].Text = row.Cells[i].Value.ToString();
            }
        }

        private void EmptyTextBoxes(List<TextBox> textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }

        private void LoadAccountData()
        {
            accDataGrid.DataSource = AccountOperations.GetAccounts(accComboBox.SelectedIndex);
            EmptyTextBoxes(loadAccountTextBoxes);
        }

        private void EmptyAccountDataGrid()
        {
            accDataGrid.DataSource = null;
            accComboBox.ResetText();
        }

        private void LoadTransactionData()
        {
            transactionDataGrid.DataSource = TransactionOperations.GetTransactions(transactionComboBox.SelectedIndex, saveTypeComboBox.SelectedIndex);
            EmptyTextBoxes(loadTransactionTextBoxes);
        }

        private void EmptyTransactionDataGrid()
        {
            transactionDataGrid.DataSource = null;
            transactionComboBox.ResetText();
        }
        #endregion

        private void accDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillTextboxes(accDataGrid.SelectedRows[0], loadAccountTextBoxes);
        }

        private void transactionDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillTextboxes(transactionDataGrid.SelectedRows[0], loadTransactionTextBoxes);
        }

        private void accComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAccountData();
        }

        private void transactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactionData();
        }

        private void saveTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactionData();
        }

        private void accUpdateBtn_Click(object sender, EventArgs e)
        {
            switch (AccountOperations.UpdateAccountControl(loadAccTexts))
            {
                case 2:
                    MessageBox.Show("Güncelleme işlemi için önce kayıtlı bir hesap seçiniz!");
                    break;
                case 3:
                    MessageBox.Show("Ek NO kısmı boş bırakılamaz!");
                    break;
                case 4:
                    MessageBox.Show("Hesap Türü kısmı boş bırakılamaz!");
                    break;
                case 5:
                    MessageBox.Show("Hesap Açıklaması kısmı boş bırakılamaz!");
                    break;
                default:
                    AccountOperations.UpdateAccount(loadAccTexts);
                    LoadAccountData();
                    MessageBox.Show("İşlem başarıyla tamamlandı.");
                    break;
            }
        }

        private void accDeleteBtn_Click(object sender, EventArgs e)
        {
            switch (AccountOperations.DeleteAccountControl(loadAccTexts))
            {
                case 2:
                    MessageBox.Show("Silmek için önce bir hesap seçiniz!");
                    break;
                case 3:
                    MessageBox.Show("Şirket hesapları uygulama üzerinden silinemez!");
                    break;
                default:
                    AccountOperations.DeleteAccount(loadAccTexts);
                    LoadAccountData();
                    MessageBox.Show("İşlem başarıyla tamamlandı");
                    break;
            }
        }

        private void accAddBtn_Click(object sender, EventArgs e)
        {
            switch (AccountOperations.AddAccountControl(addAccTexts[0], addAccTexts[1], addAccComboBox.SelectedItem ?? ""))
            {
                case 2:
                    MessageBox.Show("Lütfen sıfırdan büyük bir müşteri numarası giriniz!");
                    break;
                case 3:
                    MessageBox.Show("Lütfen sıfırdan büyük bir şube numarası giriniz!");
                    break;
                case 4:
                    MessageBox.Show("Lütfen bir hesap türü seçiniz!");
                    break;
                default:
                    AccountOperations.AddAccount(addAccTexts, addAccComboBox.SelectedIndex, addAccComboBox.SelectedItem.ToString());

                    EmptyTextBoxes(addAccTextBoxes);
                    EmptyTextBoxes(loadAccountTextBoxes);
                    addAccComboBox.ResetText();
                    EmptyAccountDataGrid();

                    MessageBox.Show("İşlem başarıyla tamamlandı.");
                    break;
            }
        }

        private void transactionUpdateBtn_Click(object sender, EventArgs e)
        {
            switch (TransactionOperations.UpdateTransactionControl(loadTransactionTexts))
            {
                case 2:
                    MessageBox.Show("Güncelleme işlemi için önce kayıtlı bir muhasebe kaydı seçiniz!");
                    break;
                case 3:
                    MessageBox.Show("İşlemi Yapan kısmı boş bırakılamaz!");
                    break;
                case 4:
                    MessageBox.Show("Kayıt Durumu kısmı boş bırakılamaz!");
                    break;
                default:
                    TransactionOperations.UpdateTransaction(loadTransactionTexts);
                    LoadTransactionData();
                    MessageBox.Show("İşlem başarıyla tamamlandı");
                    break;
            }
        }

        private void transactionDeleteBtn_Click(object sender, EventArgs e)
        {
            switch (TransactionOperations.DeleteTransactionControl(loadTransactionTexts))
            {
                case 2:
                    MessageBox.Show("Silmek için önce bir muhasebe kaydı seçiniz!");
                    break;
                default:
                    TransactionOperations.DeleteTransaction(loadTransactionTexts);
                    LoadTransactionData();
                    MessageBox.Show("İşlem başarıyla tamamlandı.");
                    break;
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            switch (TransactionOperations.GeneralPaymentControl(Int32.Parse(paymentTexts[1]), paymentComboBox.SelectedItem ?? "", Int32.Parse(paymentTexts[0])))
            {
                case 2:
                    MessageBox.Show("Lütfen sıfırdan büyük bir tutar giriniz!");
                    break;
                case 3:
                    MessageBox.Show("Lütfen bir işlem tipi seçiniz!");
                    break;
                case 4:
                    MessageBox.Show("Lütfen sistemde var olan bir hesap numarası yazınız!");
                    break;
                default:
                    switch (paymentComboBox.SelectedIndex)
                    {
                        case 0:
                            switch (TransactionOperations.DepositSalaryControl(paymentTexts[0]))
                            {
                                case 2:
                                    MessageBox.Show("Çalışan olmayan hesaba maaş ödemesi yapılamaz!");
                                    break;
                                default:
                                    TransactionOperations.DepositSalary(paymentTexts);
                                    LoadTransactionData();
                                    MessageBox.Show("İşlem başarıyla tamamlandı.");
                                    break;
                            }
                            break;
                        case 1:
                            switch (TransactionOperations.DepositCarSaleControl(paymentTexts[0], brandComboBox.SelectedItem ?? ""))
                            {
                                case 3:
                                    MessageBox.Show("Lütfen bir araç markası seçiniz!");
                                    break;
                                case 2:
                                    MessageBox.Show("Bu işlem şirket hesabıyla yapılamaz!");
                                    break;
                                default:
                                    TransactionOperations.DepositCarSale(paymentTexts, brandComboBox.SelectedItem.ToString());
                                    LoadTransactionData();
                                    MessageBox.Show("İşlem başarıyla tamamlandı.");
                                    break;
                            }
                            break;
                        case 2:
                            switch (TransactionOperations.DepositServicePaymentControl(paymentTexts[0]))
                            {
                                case 2:
                                    MessageBox.Show("Bu işlem şirket hesabıyla yapılamaz!");
                                    break;
                                default:
                                    TransactionOperations.DepositServicePayment(paymentTexts);
                                    LoadTransactionData();
                                    MessageBox.Show("İşlem başarıyla tamamlandı.");
                                    break;
                            }
                            break;
                        case 3:
                            TransactionOperations.DepositOtherPayment(paymentTexts);
                            LoadTransactionData();
                            MessageBox.Show("İşlem başarıyla tamamlandı.");
                            break;
                        default:
                            break;
                    }

                    EmptyTextBoxes(paymentTextBoxes);
                    EmptyTransactionDataGrid();
                    EmptyAccountDataGrid();

                    paymentComboBox.ResetText();
                    brandComboBox.ResetText();
                    break;
            }
        }

        private void paymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (paymentComboBox.SelectedIndex)
            {
                case 0:
                    accNoLabel.Text = "Alacak Hesap NO";
                    brandComboBox.Visible = false;
                    brandLabel.Visible = false;
                    break;
                case 1:
                    accNoLabel.Text = "Borçlu Hesap NO";
                    brandComboBox.Visible = true;
                    brandLabel.Visible = true;
                    break;
                case 2:
                    accNoLabel.Text = "Borçlu Hesap NO";
                    brandComboBox.Visible = false;
                    brandLabel.Visible = false;
                    break;
                case 3:
                    accNoLabel.Text = "Hesap NO";
                    brandComboBox.Visible = false;
                    brandLabel.Visible = false;
                    break;
                default:
                    break;
            }
        }

        #region TextBoxChanges
        private void addCustomerNoTBox_TextChanged(object sender, EventArgs e)
        {
            addAccTexts[0] = addCustomerNoTBox.Text;
        }

        private void addBranchNoTBox_TextChanged(object sender, EventArgs e)
        {
            addAccTexts[1] = addBranchNoTBox.Text;
        }

        private void loadAccTextBox1_TextChanged(object sender, EventArgs e)
        {
            loadAccTexts[0] = loadAccTextBox1.Text;
        }

        private void loadAccTextBox2_TextChanged(object sender, EventArgs e)
        {
            loadAccTexts[1] = loadAccTextBox2.Text;
        }

        private void loadAccTextBox3_TextChanged(object sender, EventArgs e)
        {
            loadAccTexts[2] = loadAccTextBox3.Text;
        }

        private void loadAccTextBox4_TextChanged(object sender, EventArgs e)
        {
            loadAccTexts[3] = loadAccTextBox4.Text;
        }

        private void loadAccTextBox5_TextChanged(object sender, EventArgs e)
        {
            loadAccTexts[4] = loadAccTextBox5.Text;
        }

        private void loadAccTextBox6_TextChanged(object sender, EventArgs e)
        {
            loadAccTexts[5] = loadAccTextBox6.Text;
        }

        private void loadAccTextBox7_TextChanged(object sender, EventArgs e)
        {
            loadAccTexts[6] = loadAccTextBox7.Text;
        }

        private void paymentTextBox1_TextChanged(object sender, EventArgs e)
        {
            paymentTexts[0] = paymentTextBox1.Text;
        }

        private void paymentTextBox2_TextChanged(object sender, EventArgs e)
        {
            paymentTexts[1] = paymentTextBox2.Text;
        }

        private void trTextBox1_TextChanged(object sender, EventArgs e)
        {
            loadTransactionTexts[0] = trTextBox1.Text;
        }

        private void trTextBox2_TextChanged(object sender, EventArgs e)
        {
            loadTransactionTexts[1] = trTextBox2.Text;
        }

        private void trTextBox3_TextChanged(object sender, EventArgs e)
        {
            loadTransactionTexts[2] = trTextBox3.Text;
        }

        private void trTextBox4_TextChanged(object sender, EventArgs e)
        {
            loadTransactionTexts[3] = trTextBox4.Text;
        }

        private void trTextBox5_TextChanged(object sender, EventArgs e)
        {
            loadTransactionTexts[4] = trTextBox5.Text;
        }

        private void trTextBox6_TextChanged(object sender, EventArgs e)
        {
            loadTransactionTexts[5] = trTextBox6.Text;
        }

        private void trTextBox7_TextChanged(object sender, EventArgs e)
        {
            loadTransactionTexts[6] = trTextBox7.Text;
        }

        private void trTextBox8_TextChanged(object sender, EventArgs e)
        {
            loadTransactionTexts[7] = trTextBox8.Text;
        }

        private void trTextBox9_TextChanged(object sender, EventArgs e)
        {
            loadTransactionTexts[8] = trTextBox9.Text;
        }
        #endregion
        
    }
}

