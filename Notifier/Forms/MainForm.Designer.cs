namespace Notifier
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMessage = new System.Windows.Forms.RichTextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.checkedListBoxGroups = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxPhones = new System.Windows.Forms.CheckedListBox();
            this.Главная = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButtonCreatePhone = new System.Windows.Forms.RadioButton();
            this.radioButtonCreateGroup = new System.Windows.Forms.RadioButton();
            this.radioButtonCreateChannel = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDeleteChannel = new System.Windows.Forms.Button();
            this.buttonAddChannel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChannelId = new System.Windows.Forms.TextBox();
            this.textBoxChannelName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelMessage = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxChannel = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Главная.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(6, 35);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(419, 280);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.Text = "";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(713, 267);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(119, 34);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // checkedListBoxGroups
            // 
            this.checkedListBoxGroups.FormattingEnabled = true;
            this.checkedListBoxGroups.Location = new System.Drawing.Point(6, 28);
            this.checkedListBoxGroups.Name = "checkedListBoxGroups";
            this.checkedListBoxGroups.Size = new System.Drawing.Size(114, 94);
            this.checkedListBoxGroups.TabIndex = 5;
            // 
            // checkedListBoxPhones
            // 
            this.checkedListBoxPhones.FormattingEnabled = true;
            this.checkedListBoxPhones.Location = new System.Drawing.Point(6, 28);
            this.checkedListBoxPhones.Name = "checkedListBoxPhones";
            this.checkedListBoxPhones.Size = new System.Drawing.Size(114, 94);
            this.checkedListBoxPhones.TabIndex = 6;
            // 
            // Главная
            // 
            this.Главная.Controls.Add(this.tabPage2);
            this.Главная.Controls.Add(this.tabPage1);
            this.Главная.Location = new System.Drawing.Point(3, 1);
            this.Главная.Name = "Главная";
            this.Главная.SelectedIndex = 0;
            this.Главная.Size = new System.Drawing.Size(848, 355);
            this.Главная.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.buttonDeleteChannel);
            this.tabPage1.Controls.Add(this.buttonAddChannel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxChannelId);
            this.tabPage1.Controls.Add(this.textBoxChannelName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreatePhone
            // 
            this.radioButtonCreatePhone.AutoSize = true;
            this.radioButtonCreatePhone.Location = new System.Drawing.Point(6, 77);
            this.radioButtonCreatePhone.Name = "radioButtonCreatePhone";
            this.radioButtonCreatePhone.Size = new System.Drawing.Size(70, 17);
            this.radioButtonCreatePhone.TabIndex = 10;
            this.radioButtonCreatePhone.TabStop = true;
            this.radioButtonCreatePhone.Text = "Телефон";
            this.radioButtonCreatePhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreateGroup
            // 
            this.radioButtonCreateGroup.AutoSize = true;
            this.radioButtonCreateGroup.Location = new System.Drawing.Point(6, 50);
            this.radioButtonCreateGroup.Name = "radioButtonCreateGroup";
            this.radioButtonCreateGroup.Size = new System.Drawing.Size(60, 17);
            this.radioButtonCreateGroup.TabIndex = 9;
            this.radioButtonCreateGroup.TabStop = true;
            this.radioButtonCreateGroup.Text = "Группа";
            this.radioButtonCreateGroup.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreateChannel
            // 
            this.radioButtonCreateChannel.AutoSize = true;
            this.radioButtonCreateChannel.Location = new System.Drawing.Point(6, 25);
            this.radioButtonCreateChannel.Name = "radioButtonCreateChannel";
            this.radioButtonCreateChannel.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCreateChannel.TabIndex = 8;
            this.radioButtonCreateChannel.TabStop = true;
            this.radioButtonCreateChannel.Text = "Канал";
            this.radioButtonCreateChannel.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 9);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(345, 320);
            this.dataGridView.TabIndex = 7;
            // 
            // buttonDeleteChannel
            // 
            this.buttonDeleteChannel.Location = new System.Drawing.Point(487, 127);
            this.buttonDeleteChannel.Name = "buttonDeleteChannel";
            this.buttonDeleteChannel.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteChannel.TabIndex = 5;
            this.buttonDeleteChannel.Text = "Удалить";
            this.buttonDeleteChannel.UseVisualStyleBackColor = true;
            this.buttonDeleteChannel.Click += new System.EventHandler(this.ButtonDeleteChannel_Click);
            // 
            // buttonAddChannel
            // 
            this.buttonAddChannel.Location = new System.Drawing.Point(380, 127);
            this.buttonAddChannel.Name = "buttonAddChannel";
            this.buttonAddChannel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddChannel.TabIndex = 4;
            this.buttonAddChannel.Text = "Добавить";
            this.buttonAddChannel.UseVisualStyleBackColor = true;
            this.buttonAddChannel.Click += new System.EventHandler(this.ButtonAddChannel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id чата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // textBoxChannelId
            // 
            this.textBoxChannelId.Location = new System.Drawing.Point(380, 90);
            this.textBoxChannelId.Name = "textBoxChannelId";
            this.textBoxChannelId.Size = new System.Drawing.Size(182, 20);
            this.textBoxChannelId.TabIndex = 1;
            // 
            // textBoxChannelName
            // 
            this.textBoxChannelName.Location = new System.Drawing.Point(380, 37);
            this.textBoxChannelName.Name = "textBoxChannelName";
            this.textBoxChannelName.Size = new System.Drawing.Size(182, 20);
            this.textBoxChannelName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelMessage);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.buttonSend);
            this.tabPage2.Controls.Add(this.textBoxMessage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Главная";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(7, 7);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(109, 13);
            this.labelMessage.TabIndex = 9;
            this.labelMessage.Text = "Введите сообщение";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBoxChannel);
            this.groupBox3.Location = new System.Drawing.Point(707, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 142);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Каналы";
            // 
            // checkedListBoxChannel
            // 
            this.checkedListBoxChannel.FormattingEnabled = true;
            this.checkedListBoxChannel.Location = new System.Drawing.Point(6, 28);
            this.checkedListBoxChannel.Name = "checkedListBoxChannel";
            this.checkedListBoxChannel.Size = new System.Drawing.Size(114, 94);
            this.checkedListBoxChannel.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBoxPhones);
            this.groupBox2.Location = new System.Drawing.Point(573, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 142);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Телефоны";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxGroups);
            this.groupBox1.Location = new System.Drawing.Point(441, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 142);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Группы";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonCreatePhone);
            this.groupBox4.Controls.Add(this.radioButtonCreateChannel);
            this.groupBox4.Controls.Add(this.radioButtonCreateGroup);
            this.groupBox4.Location = new System.Drawing.Point(636, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(122, 100);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тип получателя";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 361);
            this.Controls.Add(this.Главная);
            this.Name = "MainForm";
            this.Text = "Notifier";
            this.Главная.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.CheckedListBox checkedListBoxGroups;
        private System.Windows.Forms.CheckedListBox checkedListBoxPhones;
        private System.Windows.Forms.TabControl Главная;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBoxChannel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxChannelId;
        private System.Windows.Forms.TextBox textBoxChannelName;
        private System.Windows.Forms.Button buttonAddChannel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDeleteChannel;
        private System.Windows.Forms.RadioButton radioButtonCreatePhone;
        private System.Windows.Forms.RadioButton radioButtonCreateGroup;
        private System.Windows.Forms.RadioButton radioButtonCreateChannel;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

