namespace MyBank2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateTransAcc = new System.Windows.Forms.Button();
            this.btnCreateDepositAcc = new System.Windows.Forms.Button();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmPickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbunit = new System.Windows.Forms.ComboBox();
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateAll = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChargeTransactionFee = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.t_txtAmount = new System.Windows.Forms.TextBox();
            this.t_txtAccountTo = new System.Windows.Forms.TextBox();
            this.t_txtAccountFrom = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTransactionResult = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTransactions = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gBoxSpecificDetails = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.boxTransactionNumber = new System.Windows.Forms.TextBox();
            this.boxEndDate = new System.Windows.Forms.TextBox();
            this.boxStartDate = new System.Windows.Forms.TextBox();
            this.boxLimit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gBoxSpecificDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateTransAcc
            // 
            this.btnCreateTransAcc.Location = new System.Drawing.Point(188, 148);
            this.btnCreateTransAcc.Name = "btnCreateTransAcc";
            this.btnCreateTransAcc.Size = new System.Drawing.Size(158, 23);
            this.btnCreateTransAcc.TabIndex = 0;
            this.btnCreateTransAcc.Text = "Create Transaction Account ";
            this.btnCreateTransAcc.UseVisualStyleBackColor = true;
            this.btnCreateTransAcc.Click += new System.EventHandler(this.btnCreateTransAcc_Click);
            // 
            // btnCreateDepositAcc
            // 
            this.btnCreateDepositAcc.Location = new System.Drawing.Point(23, 148);
            this.btnCreateDepositAcc.Name = "btnCreateDepositAcc";
            this.btnCreateDepositAcc.Size = new System.Drawing.Size(155, 23);
            this.btnCreateDepositAcc.TabIndex = 1;
            this.btnCreateDepositAcc.Text = "Create Deposiot Account";
            this.btnCreateDepositAcc.UseVisualStyleBackColor = true;
            this.btnCreateDepositAcc.Click += new System.EventHandler(this.btnCreateDepositAcc_Click);
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(94, 108);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Limit:";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(94, 27);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Period:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "End date:";
            // 
            // dtmPickerEnd
            // 
            this.dtmPickerEnd.Location = new System.Drawing.Point(94, 68);
            this.dtmPickerEnd.Name = "dtmPickerEnd";
            this.dtmPickerEnd.Size = new System.Drawing.Size(181, 20);
            this.dtmPickerEnd.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Unit:";
            // 
            // cmbunit
            // 
            this.cmbunit.FormattingEnabled = true;
            this.cmbunit.Location = new System.Drawing.Point(94, 47);
            this.cmbunit.Name = "cmbunit";
            this.cmbunit.Size = new System.Drawing.Size(100, 21);
            this.cmbunit.TabIndex = 19;
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.Location = new System.Drawing.Point(0, 45);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(93, 186);
            this.lbAccounts.TabIndex = 43;
            this.lbAccounts.SelectedIndexChanged += new System.EventHandler(this.lbAccounts_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateAll);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCurrency);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnCreateDepositAcc);
            this.groupBox1.Controls.Add(this.txtLimit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbunit);
            this.groupBox1.Controls.Add(this.btnCreateTransAcc);
            this.groupBox1.Controls.Add(this.txtPeriod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtmPickerEnd);
            this.groupBox1.Location = new System.Drawing.Point(363, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 228);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Creation";
            // 
            // btnCreateAll
            // 
            this.btnCreateAll.Location = new System.Drawing.Point(188, 186);
            this.btnCreateAll.Name = "btnCreateAll";
            this.btnCreateAll.Size = new System.Drawing.Size(158, 23);
            this.btnCreateAll.TabIndex = 80;
            this.btnCreateAll.Text = "Create All";
            this.btnCreateAll.UseVisualStyleBackColor = true;
            this.btnCreateAll.Click += new System.EventHandler(this.btnCreateAll_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "Balance curency";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(94, 88);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(126, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "ex: 300 MKD";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(89, 212);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Balance Currency";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label21.Location = new System.Drawing.Point(232, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Limit, Balance currency";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Create Loan Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lbLog);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lbTransactions);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 247);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 13);
            this.label23.TabIndex = 58;
            this.label23.Text = "Transactional Log";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 225);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Log: ";
            // 
            // lbLog
            // 
            this.lbLog.ForeColor = System.Drawing.Color.Red;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(34, 223);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(678, 17);
            this.lbLog.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChargeTransactionFee);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.t_txtAmount);
            this.panel1.Controls.Add(this.t_txtAccountTo);
            this.panel1.Controls.Add(this.t_txtAccountFrom);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtTransactionResult);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnMakeTransaction);
            this.panel1.Controls.Add(this.cmbTransactionType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(432, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 192);
            this.panel1.TabIndex = 55;
            // 
            // btnChargeTransactionFee
            // 
            this.btnChargeTransactionFee.Location = new System.Drawing.Point(35, 166);
            this.btnChargeTransactionFee.Name = "btnChargeTransactionFee";
            this.btnChargeTransactionFee.Size = new System.Drawing.Size(219, 23);
            this.btnChargeTransactionFee.TabIndex = 77;
            this.btnChargeTransactionFee.Text = "Charge Transaction Fee";
            this.btnChargeTransactionFee.UseVisualStyleBackColor = true;
            this.btnChargeTransactionFee.Click += new System.EventHandler(this.btnChargeTransactionFee_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label18.Location = new System.Drawing.Point(185, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 76;
            this.label18.Text = "ex: 300 MKD";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(98, 77);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(46, 13);
            this.Amount.TabIndex = 75;
            this.Amount.Text = "Amount:";
            // 
            // t_txtAmount
            // 
            this.t_txtAmount.Location = new System.Drawing.Point(155, 74);
            this.t_txtAmount.Name = "t_txtAmount";
            this.t_txtAmount.ReadOnly = true;
            this.t_txtAmount.Size = new System.Drawing.Size(100, 20);
            this.t_txtAmount.TabIndex = 74;
            // 
            // t_txtAccountTo
            // 
            this.t_txtAccountTo.Location = new System.Drawing.Point(155, 54);
            this.t_txtAccountTo.Name = "t_txtAccountTo";
            this.t_txtAccountTo.ReadOnly = true;
            this.t_txtAccountTo.Size = new System.Drawing.Size(100, 20);
            this.t_txtAccountTo.TabIndex = 73;
            // 
            // t_txtAccountFrom
            // 
            this.t_txtAccountFrom.Location = new System.Drawing.Point(155, 34);
            this.t_txtAccountFrom.Name = "t_txtAccountFrom";
            this.t_txtAccountFrom.ReadOnly = true;
            this.t_txtAccountFrom.Size = new System.Drawing.Size(100, 20);
            this.t_txtAccountFrom.TabIndex = 72;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 71;
            this.label17.Text = "Account To Number:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "Account From Number:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(61, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 69;
            // 
            // txtTransactionResult
            // 
            this.txtTransactionResult.Location = new System.Drawing.Point(154, 144);
            this.txtTransactionResult.Name = "txtTransactionResult";
            this.txtTransactionResult.ReadOnly = true;
            this.txtTransactionResult.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionResult.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Transaction Type:";
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(35, 119);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(219, 23);
            this.btnMakeTransaction.TabIndex = 64;
            this.btnMakeTransaction.Text = "Make Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Location = new System.Drawing.Point(155, 9);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(100, 21);
            this.cmbTransactionType.TabIndex = 67;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Transaction result: ";
            // 
            // lbTransactions
            // 
            this.lbTransactions.FormattingEnabled = true;
            this.lbTransactions.Location = new System.Drawing.Point(7, 38);
            this.lbTransactions.Name = "lbTransactions";
            this.lbTransactions.Size = new System.Drawing.Size(419, 173);
            this.lbTransactions.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lbAccounts);
            this.groupBox3.Location = new System.Drawing.Point(8, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 236);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Accounts";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Account Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gBoxSpecificDetails);
            this.groupBox4.Controls.Add(this.boxBalance);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.boxID);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(99, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 218);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account details";
            // 
            // gBoxSpecificDetails
            // 
            this.gBoxSpecificDetails.Controls.Add(this.label19);
            this.gBoxSpecificDetails.Controls.Add(this.boxTransactionNumber);
            this.gBoxSpecificDetails.Controls.Add(this.boxEndDate);
            this.gBoxSpecificDetails.Controls.Add(this.boxStartDate);
            this.gBoxSpecificDetails.Controls.Add(this.boxLimit);
            this.gBoxSpecificDetails.Controls.Add(this.label12);
            this.gBoxSpecificDetails.Controls.Add(this.label11);
            this.gBoxSpecificDetails.Controls.Add(this.label9);
            this.gBoxSpecificDetails.Location = new System.Drawing.Point(0, 98);
            this.gBoxSpecificDetails.Name = "gBoxSpecificDetails";
            this.gBoxSpecificDetails.Size = new System.Drawing.Size(231, 120);
            this.gBoxSpecificDetails.TabIndex = 53;
            this.gBoxSpecificDetails.TabStop = false;
            this.gBoxSpecificDetails.Text = "Specific Details";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(0, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "Transaction Acc No.";
            // 
            // boxTransactionNumber
            // 
            this.boxTransactionNumber.Location = new System.Drawing.Point(107, 83);
            this.boxTransactionNumber.Name = "boxTransactionNumber";
            this.boxTransactionNumber.ReadOnly = true;
            this.boxTransactionNumber.Size = new System.Drawing.Size(114, 20);
            this.boxTransactionNumber.TabIndex = 56;
            // 
            // boxEndDate
            // 
            this.boxEndDate.Location = new System.Drawing.Point(107, 63);
            this.boxEndDate.Name = "boxEndDate";
            this.boxEndDate.ReadOnly = true;
            this.boxEndDate.Size = new System.Drawing.Size(114, 20);
            this.boxEndDate.TabIndex = 54;
            // 
            // boxStartDate
            // 
            this.boxStartDate.Location = new System.Drawing.Point(107, 43);
            this.boxStartDate.Name = "boxStartDate";
            this.boxStartDate.ReadOnly = true;
            this.boxStartDate.Size = new System.Drawing.Size(114, 20);
            this.boxStartDate.TabIndex = 55;
            // 
            // boxLimit
            // 
            this.boxLimit.Location = new System.Drawing.Point(107, 23);
            this.boxLimit.Name = "boxLimit";
            this.boxLimit.ReadOnly = true;
            this.boxLimit.Size = new System.Drawing.Size(114, 20);
            this.boxLimit.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "End date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Start date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Limit amount:";
            // 
            // boxBalance
            // 
            this.boxBalance.Location = new System.Drawing.Point(107, 56);
            this.boxBalance.Name = "boxBalance";
            this.boxBalance.ReadOnly = true;
            this.boxBalance.Size = new System.Drawing.Size(115, 20);
            this.boxBalance.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Balance:";
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(107, 36);
            this.boxID.Name = "boxID";
            this.boxID.ReadOnly = true;
            this.boxID.Size = new System.Drawing.Size(115, 20);
            this.boxID.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Account ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gBoxSpecificDetails.ResumeLayout(false);
            this.gBoxSpecificDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransAcc;
        private System.Windows.Forms.Button btnCreateDepositAcc;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmPickerEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbunit;
        private System.Windows.Forms.ListBox lbAccounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox boxBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gBoxSpecificDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxEndDate;
        private System.Windows.Forms.TextBox boxStartDate;
        private System.Windows.Forms.TextBox boxLimit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbTransactions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox t_txtAmount;
        private System.Windows.Forms.TextBox t_txtAccountTo;
        private System.Windows.Forms.TextBox t_txtAccountFrom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTransactionResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox boxTransactionNumber;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnCreateAll;
        private System.Windows.Forms.Button btnChargeTransactionFee;
    }
}

