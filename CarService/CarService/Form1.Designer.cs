
namespace CarService
{
    partial class FormCarService
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
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxCurrentCar = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCurrentBreaking = new System.Windows.Forms.RichTextBox();
            this.buttonFix = new System.Windows.Forms.Button();
            this.buttonBuyDetails = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.checkedListBoxAvailableDetails = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxAvailableModels = new System.Windows.Forms.CheckedListBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.Location = new System.Drawing.Point(13, 13);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(207, 420);
            this.listBoxDetails.TabIndex = 0;
            this.listBoxDetails.SelectedIndexChanged += new System.EventHandler(this.listBoxDetails_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущий автомобиль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Текущая поломка";
            // 
            // richTextBoxCurrentCar
            // 
            this.richTextBoxCurrentCar.Location = new System.Drawing.Point(227, 30);
            this.richTextBoxCurrentCar.Name = "richTextBoxCurrentCar";
            this.richTextBoxCurrentCar.Size = new System.Drawing.Size(189, 62);
            this.richTextBoxCurrentCar.TabIndex = 3;
            this.richTextBoxCurrentCar.Text = "";
            // 
            // richTextBoxCurrentBreaking
            // 
            this.richTextBoxCurrentBreaking.Location = new System.Drawing.Point(226, 111);
            this.richTextBoxCurrentBreaking.Name = "richTextBoxCurrentBreaking";
            this.richTextBoxCurrentBreaking.Size = new System.Drawing.Size(189, 62);
            this.richTextBoxCurrentBreaking.TabIndex = 3;
            this.richTextBoxCurrentBreaking.Text = "";
            // 
            // buttonFix
            // 
            this.buttonFix.Location = new System.Drawing.Point(226, 180);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(117, 23);
            this.buttonFix.TabIndex = 4;
            this.buttonFix.Text = "Чинить";
            this.buttonFix.UseVisualStyleBackColor = true;
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // buttonBuyDetails
            // 
            this.buttonBuyDetails.Location = new System.Drawing.Point(226, 210);
            this.buttonBuyDetails.Name = "buttonBuyDetails";
            this.buttonBuyDetails.Size = new System.Drawing.Size(117, 23);
            this.buttonBuyDetails.TabIndex = 5;
            this.buttonBuyDetails.Text = "Купить детали";
            this.buttonBuyDetails.UseVisualStyleBackColor = true;
            this.buttonBuyDetails.Click += new System.EventHandler(this.buttonBuyDetails_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Балланс:";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Location = new System.Drawing.Point(547, 12);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(13, 13);
            this.labelCash.TabIndex = 7;
            this.labelCash.Text = "0";
            // 
            // checkedListBoxAvailableDetails
            // 
            this.checkedListBoxAvailableDetails.FormattingEnabled = true;
            this.checkedListBoxAvailableDetails.Location = new System.Drawing.Point(345, 239);
            this.checkedListBoxAvailableDetails.Name = "checkedListBoxAvailableDetails";
            this.checkedListBoxAvailableDetails.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxAvailableDetails.TabIndex = 8;
            this.checkedListBoxAvailableDetails.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAvailableDetails_SelectedIndexChanged);
            // 
            // checkedListBoxAvailableModels
            // 
            this.checkedListBoxAvailableModels.FormattingEnabled = true;
            this.checkedListBoxAvailableModels.Location = new System.Drawing.Point(226, 239);
            this.checkedListBoxAvailableModels.Name = "checkedListBoxAvailableModels";
            this.checkedListBoxAvailableModels.Size = new System.Drawing.Size(113, 94);
            this.checkedListBoxAvailableModels.TabIndex = 9;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(227, 340);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormCarService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkedListBoxAvailableModels);
            this.Controls.Add(this.checkedListBoxAvailableDetails);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBuyDetails);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.richTextBoxCurrentBreaking);
            this.Controls.Add(this.richTextBoxCurrentCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDetails);
            this.Name = "FormCarService";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCarService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxCurrentCar;
        private System.Windows.Forms.RichTextBox richTextBoxCurrentBreaking;
        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.Button buttonBuyDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.CheckedListBox checkedListBoxAvailableDetails;
        private System.Windows.Forms.CheckedListBox checkedListBoxAvailableModels;
        private System.Windows.Forms.Button buttonOk;
    }
}

