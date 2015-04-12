using DomainlModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainlModel.Helpers;
using DomainlModel.Delegates;
using DomainlModel.Extensions;


namespace MyBank2
{
    public partial class Form1 : Form
    {
        public event AccountAddedEventHandler AccountAdded;
        private bool errorOccured { get; set; }
        private string errorMessage { get; set; }      
 
        private ITransactionProccesor transactionProccesor;  

        public Form1()
        {
            InitializeComponent();
            cmbunit.DataSource = Enum.GetValues(typeof(UnitOfTime));
            cmbTransactionType.DataSource = Enum.GetValues(typeof(TransactionType));
            FillAccountlist();
            AccountAdded += LogAccountAdded;
            errorOccured = false;
            transactionProccesor = TransactionProccesor.GetTransactionProccesor();
        }

        /// <summary>
        /// Fill the listBox with some testing accounts
        /// </summary>
        private void FillAccountlist()
        {
            TimePeriod tP = new TimePeriod();
            tP.Period = 120;
            tP.Unit = UnitOfTime.Month;
            InterestRate iR = new InterestRate();

            if (tP.Period > 100)
                iR.Percent = 2;
            else
                iR.Percent = 3;
            iR.Unit = tP.Unit;

            CurrencyAmount limit = new CurrencyAmount();
            limit.Amount = 300000;
            limit.Currency = "$";
            int transactionAccountId = AcountHelper.GenerateAccountId();
            ITransactionAccount ta = new TransactionAccount(transactionAccountId, 
                AcountHelper.GenerateAccountNumber<ITransactionAccount>(transactionAccountId), "$", limit);
            
            lbAccounts.Items.Add(ta);
            int depositAccountId = AcountHelper.GenerateAccountId();
            IDepositAccount a = new DepositAccount(depositAccountId, AcountHelper.GenerateAccountNumber<IDepositAccount>(depositAccountId),"$", tP, iR, DateTime.Now,DateTime.Now, ta);
            
            lbAccounts.Items.Add(a);
            Console.WriteLine("Transaction and Deposit account are created");
            
        }

        #region Account creation
        private void btnCreateDepositAcc_Click(object sender, EventArgs e)
        {
            try
            {
                CreateAccount<IDepositAccount>();
            }
            catch (UserInterfaceException ex)
            {
                ExceptionLogger.LogException(ex);
                MessageBox.Show(ex.friendlyMessage);
            }
           
        }
        /// <summary>
        /// Generic method for creating account 
        /// </summary>
        /// <typeparam name="IAccount"></typeparam>
        private void CreateAccount<IAccount>()
        {
            CurrencyAmount limit = new CurrencyAmount();

            try
            {
                string[] limitValue = txtLimit.Text.ToString().Split(' ');
                limit.Amount = decimal.Parse(limitValue[0]);
                limit.Currency = limitValue[1];
           
            }
            catch (Exception e)
            {
                throw new UserInterfaceException("Please insert limit in folowing example format: ' 300 MKD '", e);
            }
            
            if (typeof(IAccount) == typeof(IDepositAccount))
            {
                
                TimePeriod tP = new TimePeriod();

                IDepositAccount a;
                
                tP.Period = int.Parse(txtPeriod.Text);
                tP.Unit = (UnitOfTime)cmbunit.SelectedValue;
                InterestRate iR = new InterestRate();

                /// some random logic
                if (tP.Period > 100)
                    iR.Percent = 2;
                else
                    iR.Percent = 3;
                iR.Unit = tP.Unit;

                

                int transactionAccountId = AcountHelper.GenerateAccountId();
                ITransactionAccount ta = new TransactionAccount(transactionAccountId, AcountHelper.GenerateAccountNumber<ITransactionAccount>(transactionAccountId), txtCurrency.Text, limit);

                lbAccounts.Items.Add(ta);
                int depositAccountId = AcountHelper.GenerateAccountId();

                try
                {
                    a = new DepositAccount(depositAccountId, AcountHelper.GenerateAccountNumber<IDepositAccount>(depositAccountId), txtCurrency.Text, tP, iR, DateTime.Now, dtmPickerEnd.Value, ta);
                }
                catch (Exception e)
                {
                    throw new UserInterfaceException("Please fill all the fields with required informations", e);
                }
                
                lbAccounts.Items.Add(a);
                AccountAdded(a);
                Console.WriteLine("Transaction and Deposit account are created");
            }
            else if (typeof(IAccount) == typeof(ITransactionAccount))
            {
                
                int id = AcountHelper.GenerateAccountId();
                ITransactionAccount ta = new TransactionAccount(id, AcountHelper.GenerateAccountNumber<ITransactionAccount>(id), txtCurrency.Text, limit);
                AccountAdded(ta);
                lbAccounts.Items.Add(ta);
                Console.WriteLine("Transaction account is created");
            }
            else if (typeof(IAccount) == typeof(ILoanAccount))
            {

                TimePeriod tP = new TimePeriod();
                tP.Period = int.Parse(txtPeriod.Text);
                tP.Unit = (UnitOfTime)cmbunit.SelectedValue;
                InterestRate iR = new InterestRate();
                ILoanAccount a;

                /// some random logic
                if (tP.Period > 100)
                    iR.Percent = 2;
                else
                    iR.Percent = 3;
                iR.Unit = tP.Unit;

                

                int transactionAccountId = AcountHelper.GenerateAccountId();
                ITransactionAccount ta = new TransactionAccount(transactionAccountId, AcountHelper.GenerateAccountNumber<ITransactionAccount>(transactionAccountId), txtCurrency.Text, limit);


                lbAccounts.Items.Add(ta);
                int loanAccountId = AcountHelper.GenerateAccountId();

                try
                {
                     a = new LoanAccount(loanAccountId, AcountHelper.GenerateAccountNumber<ILoanAccount>(loanAccountId), txtCurrency.Text, tP, iR, DateTime.Now, dtmPickerEnd.Value, ta);
                }
                catch (Exception e)
                {
                    throw new UserInterfaceException("Please fill all the fields with required informations", e);
                }
                
                
                    
                lbAccounts.Items.Add(a);
                AccountAdded(a);
                Console.WriteLine("Loan and Transaction account are created");
            }
        }
        private void btnCreateTransAcc_Click(object sender, EventArgs e)
        {

            try
            {
                CreateAccount<ITransactionAccount>();
            }
            catch (UserInterfaceException ex)
            {
                ExceptionLogger.LogException(ex);
                MessageBox.Show(ex.friendlyMessage);
            }
            
        }
        /// <summary>
        /// Button Create Loan account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                CreateAccount<ILoanAccount>();
            }
            catch (UserInterfaceException ex)
            {
                ExceptionLogger.LogException(ex);
                MessageBox.Show(ex.friendlyMessage);
            }
            
        }
        #endregion

        #region Transactions

        /// <summary>
        /// Method for making the transaction from the input parametars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            try
            {
              MakeTransaction(); 
            }
            catch (BuisnessLogicException ex)
            {
                ExceptionLogger.LogException(ex.exception);
                MessageBox.Show(ex.exception.Message);
            }
            catch (UserInterfaceException ex)
            {
                ExceptionLogger.LogException(ex.exception);
                MessageBox.Show(ex.friendlyMessage);
            }
            catch (Exception ex)
            {
                ExceptionLogger.LogException(ex.InnerException);
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void MakeTransaction()
        {
            IAccount acountFrom = null;
            IAccount acountTo = null;

            

            //tells if the transaction type is Transfer
            bool flag_Transfer = false;
            String[] insertedAmount;
            string accountNumberTo;
            string accountNumberFrom;
            CurrencyAmount amount = new CurrencyAmount();

            #region Take user input

            try
            {

                if (cmbTransactionType.SelectedItem.ToString().Trim() == "Transfer")
                    flag_Transfer = true;

                insertedAmount = t_txtAmount.Text.ToString().Split(' ');
                amount.Amount = decimal.Parse(insertedAmount[0]);
                amount.Currency = insertedAmount[1];
                accountNumberFrom = t_txtAccountFrom.Text.ToString().Trim();

                if (flag_Transfer)
                {
                    accountNumberTo = t_txtAccountTo.Text.ToString().Trim();
                    acountTo = findAccount(accountNumberTo);
                    if (acountTo == null)
                        return;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new UserInterfaceException("Please insert amount in folowing example format: ' 300 MKD '",ex);
            }
            catch (NullReferenceException ex)
            {
                throw new UserInterfaceException("Please make sure that all the fields are filled with information", ex);
            }
            catch (FormatException ex)
            {
                throw new UserInterfaceException("Please insert amount in the folowing example format: ' 300 MKD '", ex);
            }
            catch (Exception ex)
            {
                throw new UserInterfaceException("Please restart the application or wait for some seconds", ex);
            }
            #endregion


            acountFrom = findAccount(accountNumberFrom);

            if (acountFrom == null)
                return;

            try
            {
                txtTransactionResult.Text =
           transactionProccesor.transactionProcces(acountFrom, acountTo, (TransactionType)cmbTransactionType.SelectedValue, amount).ToString();
            }

            catch (CurrencyMissmatchException ex)
            {
                throw new BuisnessLogicException(ex);
            }
            catch (LimitOverreachedException ex)
            {
                throw new BuisnessLogicException(ex);
            }
            catch (ApplicationException ex)
            {
                throw new BuisnessLogicException(ex);
            }

            boxBalance.Text = acountFrom.Balance.Amount.ToString() + " " + acountFrom.Balance.Currency;
            
            ///use of indexer for transaction accounts
            if (transactionProccesor[transactionProccesor.TransactionCount-1] != null)
                lbTransactions.Items.Add(transactionProccesor.LastTransaction);

            updateBalanceLog();
            transactionProccesor.feeCharged = false;
        }

        private void updateBalanceLog()
        {
            if (transactionProccesor.balanceChangedCheck() != null)
                lbLog.Items.Add(transactionProccesor.balanceChangedCheck());
            if (lbLog.Items.Count > 0)
                lbLog.Items[0] = lbLog.Items[lbLog.Items.Count - 1];
        }

        /// <summary>
        /// Method for finding specific acount in the listBox by its Account Number
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        private IAccount findAccount(string accountNumber)
        {
            foreach (IAccount account in lbAccounts.Items)
            {
                if (account.Number == accountNumber)
                    return account;
            }
            return null;
        }
        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            t_txtAccountFrom.Text = "";
            t_txtAccountTo.Text = "";
            t_txtAmount.Text = "";

            if (cmbTransactionType.SelectedItem.ToString().Trim() == "Transfer")
            {
                t_txtAccountFrom.ReadOnly = false;
                t_txtAccountTo.ReadOnly = false;
                t_txtAmount.ReadOnly = false;
            }
            else if (cmbTransactionType.SelectedItem.ToString().Trim() == "Credit" ||
                cmbTransactionType.SelectedItem.ToString().Trim() == "Debit"
                )
            {
                t_txtAccountFrom.ReadOnly = false;
                t_txtAccountTo.ReadOnly = true;
                t_txtAmount.ReadOnly = false;
            }
            else
            {
                t_txtAccountFrom.ReadOnly = true;
                t_txtAccountTo.ReadOnly = true;
                t_txtAmount.ReadOnly = true;
            }
        }

        #endregion
        /// <summary>
        /// Method that create multiple account based on the 'type'
        /// </summary>
        /// <param name="type">Bitwise operation using flaged enumeration for type of account</param>
        private  void CreateAccounts(CreateAccountType type){


                if ((type & CreateAccountType.DepositAccoiunt) == CreateAccountType.DepositAccoiunt)
                    CreateAccount<IDepositAccount>();
                if((type & CreateAccountType.LoanAccount) == CreateAccountType.LoanAccount)
                    CreateAccount<ILoanAccount>();
                if((type & CreateAccountType.TransactionAccount) == CreateAccountType.TransactionAccount)
                    CreateAccount<ITransactionAccount>();
        }



        private void lbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAccounts.SelectedIndex != -1)
            {
                IAccount selectedAccount = lbAccounts.SelectedItem as IAccount;
                Type accountType = selectedAccount.GetType();

                if(!t_txtAccountFrom.ReadOnly)
                t_txtAccountFrom.Text = selectedAccount.Number.ToString();

                boxID.Text = selectedAccount.ID.ToString();
                boxBalance.Text = selectedAccount.Balance.Amount.ToString() + " " + selectedAccount.Currency;
                 
                if (accountType == typeof(TransactionAccount))
                {
                    boxLimit.Text = (selectedAccount as ITransactionAccount).Limit.Amount.ToString() + " " +
                    (selectedAccount as ITransactionAccount).Limit.Currency.ToString();
                    boxStartDate.Text = "";
                    boxEndDate.Text = "";
                    boxTransactionNumber.Text = "";
                }
                else if (accountType == typeof(DepositAccount))
                {
                    IDepositAccount acc = selectedAccount as IDepositAccount;

                    boxLimit.Text = "";
                    

                    boxStartDate.Text = acc.StartDate.ToString();
                    boxEndDate.Text = acc.EndDate.ToString();
                    boxTransactionNumber.Text = acc.TransactionAccount.Number;
                    
                   
                }

            }
            
        }

        /// <summary>
        /// Logs when some account is added
        /// </summary>
        /// <param name="account"></param>
        private void LogAccountAdded(IAccount account)
        {
            string entry = String.Format("New {0} was created on {1} ", account.ToString(), DateTime.Now.ToShortDateString());
            lbLog.Items.Add(entry);
            lbLog.Items[0] = lbLog.Items[lbLog.Items.Count-1];
        }
        /// <summary>
        /// Creatin multiple accounts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAll_Click(object sender, EventArgs e)
        {
            try
            {
                CreateAccounts(CreateAccountType.All);
            }
            catch (UserInterfaceException ex)
            {
                ExceptionLogger.LogException(ex);
                MessageBox.Show(ex.friendlyMessage);
            }
            
           
        }

        /// <summary>
        /// Method that will charge fee from the accounts included in the last transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargeTransactionFee_Click(object sender, EventArgs e)
        {
            //cheks if the fee is charged
            if (transactionProccesor.feeCharged)
                return;

            double fee = 0;
            TransactionLogEntry lastEntry = transactionProccesor.LastTransaction;
            if (lastEntry.Accounts[0].Currency == "MKD")
                fee = 15;
            else
                fee = 0.4;

            CurrencyAmount amount = new CurrencyAmount();
            amount.Amount = (decimal)fee;
            amount.Currency = lastEntry.Accounts[0].Currency;
            transactionProccesor.ChargeProcessingFee(amount, lastEntry.Accounts);
            
            updateBalanceLog();
            
        }

        

        
    }
}
