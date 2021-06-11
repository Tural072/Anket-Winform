
namespace Anket_Winform
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
            this.nameTxtbx = new System.Windows.Forms.TextBox();
            this.surenameTxtbx = new System.Windows.Forms.TextBox();
            this.fatherNameTxtbx = new System.Windows.Forms.TextBox();
            this.adressTxtbx = new System.Windows.Forms.TextBox();
            this.ageTxtbx = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.userInfoLbl = new System.Windows.Forms.GroupBox();
            this.dateofbirthdayLbl = new System.Windows.Forms.Label();
            this.placeOfBirthdayLbl = new System.Windows.Forms.Label();
            this.placeofbirthTxtbox = new System.Windows.Forms.TextBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.adressLbl = new System.Windows.Forms.Label();
            this.fathersNameLbl = new System.Windows.Forms.Label();
            this.surenameLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.foreginLanguageGrpbx = new System.Windows.Forms.GroupBox();
            this.germanChkbx = new System.Windows.Forms.CheckBox();
            this.englishChkbx = new System.Windows.Forms.CheckBox();
            this.russianChkbx = new System.Windows.Forms.CheckBox();
            this.turkishChkbx = new System.Windows.Forms.CheckBox();
            this.genderGrpbx = new System.Windows.Forms.GroupBox();
            this.femaleRadiobtn = new System.Windows.Forms.RadioButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maritalStatusGrpbx = new System.Windows.Forms.GroupBox();
            this.marriedRadiobtn = new System.Windows.Forms.RadioButton();
            this.singleRadiobtn = new System.Windows.Forms.RadioButton();
            this.jsonTxtbx = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.userInfoLbl.SuspendLayout();
            this.foreginLanguageGrpbx.SuspendLayout();
            this.genderGrpbx.SuspendLayout();
            this.maritalStatusGrpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTxtbx
            // 
            this.nameTxtbx.Location = new System.Drawing.Point(8, 54);
            this.nameTxtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxtbx.Name = "nameTxtbx";
            this.nameTxtbx.Size = new System.Drawing.Size(259, 30);
            this.nameTxtbx.TabIndex = 0;
            // 
            // surenameTxtbx
            // 
            this.surenameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surenameTxtbx.Location = new System.Drawing.Point(8, 117);
            this.surenameTxtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surenameTxtbx.Name = "surenameTxtbx";
            this.surenameTxtbx.Size = new System.Drawing.Size(259, 30);
            this.surenameTxtbx.TabIndex = 1;
            // 
            // fatherNameTxtbx
            // 
            this.fatherNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatherNameTxtbx.Location = new System.Drawing.Point(8, 185);
            this.fatherNameTxtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fatherNameTxtbx.Name = "fatherNameTxtbx";
            this.fatherNameTxtbx.Size = new System.Drawing.Size(259, 30);
            this.fatherNameTxtbx.TabIndex = 2;
            // 
            // adressTxtbx
            // 
            this.adressTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressTxtbx.Location = new System.Drawing.Point(8, 254);
            this.adressTxtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adressTxtbx.Name = "adressTxtbx";
            this.adressTxtbx.Size = new System.Drawing.Size(259, 30);
            this.adressTxtbx.TabIndex = 3;
            // 
            // ageTxtbx
            // 
            this.ageTxtbx.Location = new System.Drawing.Point(8, 320);
            this.ageTxtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ageTxtbx.Name = "ageTxtbx";
            this.ageTxtbx.Size = new System.Drawing.Size(259, 30);
            this.ageTxtbx.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 455);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 30);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // userInfoLbl
            // 
            this.userInfoLbl.Controls.Add(this.dateofbirthdayLbl);
            this.userInfoLbl.Controls.Add(this.placeOfBirthdayLbl);
            this.userInfoLbl.Controls.Add(this.placeofbirthTxtbox);
            this.userInfoLbl.Controls.Add(this.ageLbl);
            this.userInfoLbl.Controls.Add(this.dateTimePicker1);
            this.userInfoLbl.Controls.Add(this.adressLbl);
            this.userInfoLbl.Controls.Add(this.fathersNameLbl);
            this.userInfoLbl.Controls.Add(this.surenameLbl);
            this.userInfoLbl.Controls.Add(this.ageTxtbx);
            this.userInfoLbl.Controls.Add(this.nameLbl);
            this.userInfoLbl.Controls.Add(this.nameTxtbx);
            this.userInfoLbl.Controls.Add(this.adressTxtbx);
            this.userInfoLbl.Controls.Add(this.surenameTxtbx);
            this.userInfoLbl.Controls.Add(this.fatherNameTxtbx);
            this.userInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userInfoLbl.Location = new System.Drawing.Point(16, 15);
            this.userInfoLbl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userInfoLbl.Name = "userInfoLbl";
            this.userInfoLbl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userInfoLbl.Size = new System.Drawing.Size(287, 508);
            this.userInfoLbl.TabIndex = 6;
            this.userInfoLbl.TabStop = false;
            this.userInfoLbl.Text = "User Info";
            // 
            // dateofbirthdayLbl
            // 
            this.dateofbirthdayLbl.AutoSize = true;
            this.dateofbirthdayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateofbirthdayLbl.Location = new System.Drawing.Point(8, 432);
            this.dateofbirthdayLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateofbirthdayLbl.Name = "dateofbirthdayLbl";
            this.dateofbirthdayLbl.Size = new System.Drawing.Size(128, 20);
            this.dateofbirthdayLbl.TabIndex = 16;
            this.dateofbirthdayLbl.Text = "Date of birthday";
            // 
            // placeOfBirthdayLbl
            // 
            this.placeOfBirthdayLbl.AutoSize = true;
            this.placeOfBirthdayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeOfBirthdayLbl.Location = new System.Drawing.Point(8, 362);
            this.placeOfBirthdayLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeOfBirthdayLbl.Name = "placeOfBirthdayLbl";
            this.placeOfBirthdayLbl.Size = new System.Drawing.Size(108, 20);
            this.placeOfBirthdayLbl.TabIndex = 15;
            this.placeOfBirthdayLbl.Text = "Place of birth";
            // 
            // placeofbirthTxtbox
            // 
            this.placeofbirthTxtbox.Location = new System.Drawing.Point(8, 385);
            this.placeofbirthTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.placeofbirthTxtbox.Name = "placeofbirthTxtbox";
            this.placeofbirthTxtbox.Size = new System.Drawing.Size(259, 30);
            this.placeofbirthTxtbox.TabIndex = 14;
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLbl.Location = new System.Drawing.Point(8, 297);
            this.ageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(38, 20);
            this.ageLbl.TabIndex = 13;
            this.ageLbl.Text = "Age";
            // 
            // adressLbl
            // 
            this.adressLbl.AutoSize = true;
            this.adressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressLbl.Location = new System.Drawing.Point(8, 230);
            this.adressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressLbl.Name = "adressLbl";
            this.adressLbl.Size = new System.Drawing.Size(62, 20);
            this.adressLbl.TabIndex = 12;
            this.adressLbl.Text = "Adress";
            // 
            // fathersNameLbl
            // 
            this.fathersNameLbl.AutoSize = true;
            this.fathersNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fathersNameLbl.Location = new System.Drawing.Point(8, 161);
            this.fathersNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fathersNameLbl.Name = "fathersNameLbl";
            this.fathersNameLbl.Size = new System.Drawing.Size(116, 20);
            this.fathersNameLbl.TabIndex = 11;
            this.fathersNameLbl.Text = "Father\'s name";
            // 
            // surenameLbl
            // 
            this.surenameLbl.AutoSize = true;
            this.surenameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surenameLbl.Location = new System.Drawing.Point(8, 94);
            this.surenameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surenameLbl.Name = "surenameLbl";
            this.surenameLbl.Size = new System.Drawing.Size(85, 20);
            this.surenameLbl.TabIndex = 10;
            this.surenameLbl.Text = "Surename";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(8, 31);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(53, 20);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.Text = "Name";
            // 
            // foreginLanguageGrpbx
            // 
            this.foreginLanguageGrpbx.Controls.Add(this.germanChkbx);
            this.foreginLanguageGrpbx.Controls.Add(this.englishChkbx);
            this.foreginLanguageGrpbx.Controls.Add(this.russianChkbx);
            this.foreginLanguageGrpbx.Controls.Add(this.turkishChkbx);
            this.foreginLanguageGrpbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foreginLanguageGrpbx.Location = new System.Drawing.Point(355, 268);
            this.foreginLanguageGrpbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foreginLanguageGrpbx.Name = "foreginLanguageGrpbx";
            this.foreginLanguageGrpbx.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foreginLanguageGrpbx.Size = new System.Drawing.Size(208, 148);
            this.foreginLanguageGrpbx.TabIndex = 7;
            this.foreginLanguageGrpbx.TabStop = false;
            this.foreginLanguageGrpbx.Text = "Foreign Language ";
            // 
            // germanChkbx
            // 
            this.germanChkbx.AutoSize = true;
            this.germanChkbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.germanChkbx.Location = new System.Drawing.Point(8, 118);
            this.germanChkbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.germanChkbx.Name = "germanChkbx";
            this.germanChkbx.Size = new System.Drawing.Size(91, 24);
            this.germanChkbx.TabIndex = 12;
            this.germanChkbx.Text = "German";
            this.germanChkbx.UseVisualStyleBackColor = true;
            // 
            // englishChkbx
            // 
            this.englishChkbx.AutoSize = true;
            this.englishChkbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.englishChkbx.Location = new System.Drawing.Point(8, 31);
            this.englishChkbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.englishChkbx.Name = "englishChkbx";
            this.englishChkbx.Size = new System.Drawing.Size(86, 24);
            this.englishChkbx.TabIndex = 9;
            this.englishChkbx.Text = "English";
            this.englishChkbx.UseVisualStyleBackColor = true;
            // 
            // russianChkbx
            // 
            this.russianChkbx.AutoSize = true;
            this.russianChkbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.russianChkbx.Location = new System.Drawing.Point(8, 59);
            this.russianChkbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.russianChkbx.Name = "russianChkbx";
            this.russianChkbx.Size = new System.Drawing.Size(92, 24);
            this.russianChkbx.TabIndex = 10;
            this.russianChkbx.Text = "Russian";
            this.russianChkbx.UseVisualStyleBackColor = true;
            // 
            // turkishChkbx
            // 
            this.turkishChkbx.AutoSize = true;
            this.turkishChkbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.turkishChkbx.Location = new System.Drawing.Point(8, 90);
            this.turkishChkbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.turkishChkbx.Name = "turkishChkbx";
            this.turkishChkbx.Size = new System.Drawing.Size(86, 24);
            this.turkishChkbx.TabIndex = 11;
            this.turkishChkbx.Text = "Turkish";
            this.turkishChkbx.UseVisualStyleBackColor = true;
            // 
            // genderGrpbx
            // 
            this.genderGrpbx.Controls.Add(this.femaleRadiobtn);
            this.genderGrpbx.Controls.Add(this.maleRadioBtn);
            this.genderGrpbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderGrpbx.Location = new System.Drawing.Point(355, 15);
            this.genderGrpbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderGrpbx.Name = "genderGrpbx";
            this.genderGrpbx.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderGrpbx.Size = new System.Drawing.Size(208, 98);
            this.genderGrpbx.TabIndex = 8;
            this.genderGrpbx.TabStop = false;
            this.genderGrpbx.Text = "Gender";
            // 
            // femaleRadiobtn
            // 
            this.femaleRadiobtn.AutoSize = true;
            this.femaleRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleRadiobtn.Location = new System.Drawing.Point(8, 62);
            this.femaleRadiobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.femaleRadiobtn.Name = "femaleRadiobtn";
            this.femaleRadiobtn.Size = new System.Drawing.Size(85, 24);
            this.femaleRadiobtn.TabIndex = 10;
            this.femaleRadiobtn.TabStop = true;
            this.femaleRadiobtn.Text = "Female";
            this.femaleRadiobtn.UseVisualStyleBackColor = true;
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleRadioBtn.Location = new System.Drawing.Point(8, 30);
            this.maleRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(66, 24);
            this.maleRadioBtn.TabIndex = 9;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maritalStatusGrpbx
            // 
            this.maritalStatusGrpbx.Controls.Add(this.marriedRadiobtn);
            this.maritalStatusGrpbx.Controls.Add(this.singleRadiobtn);
            this.maritalStatusGrpbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maritalStatusGrpbx.Location = new System.Drawing.Point(355, 138);
            this.maritalStatusGrpbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maritalStatusGrpbx.Name = "maritalStatusGrpbx";
            this.maritalStatusGrpbx.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maritalStatusGrpbx.Size = new System.Drawing.Size(208, 94);
            this.maritalStatusGrpbx.TabIndex = 11;
            this.maritalStatusGrpbx.TabStop = false;
            this.maritalStatusGrpbx.Text = "Marital Status";
            // 
            // marriedRadiobtn
            // 
            this.marriedRadiobtn.AutoSize = true;
            this.marriedRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marriedRadiobtn.Location = new System.Drawing.Point(8, 63);
            this.marriedRadiobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.marriedRadiobtn.Name = "marriedRadiobtn";
            this.marriedRadiobtn.Size = new System.Drawing.Size(87, 24);
            this.marriedRadiobtn.TabIndex = 10;
            this.marriedRadiobtn.TabStop = true;
            this.marriedRadiobtn.Text = "Married";
            this.marriedRadiobtn.UseVisualStyleBackColor = true;
            // 
            // singleRadiobtn
            // 
            this.singleRadiobtn.AutoSize = true;
            this.singleRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singleRadiobtn.Location = new System.Drawing.Point(8, 30);
            this.singleRadiobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.singleRadiobtn.Name = "singleRadiobtn";
            this.singleRadiobtn.Size = new System.Drawing.Size(76, 24);
            this.singleRadiobtn.TabIndex = 9;
            this.singleRadiobtn.TabStop = true;
            this.singleRadiobtn.Text = "Single";
            this.singleRadiobtn.UseVisualStyleBackColor = true;
            // 
            // jsonTxtbx
            // 
            this.jsonTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jsonTxtbx.Location = new System.Drawing.Point(355, 434);
            this.jsonTxtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jsonTxtbx.Name = "jsonTxtbx";
            this.jsonTxtbx.Size = new System.Drawing.Size(207, 30);
            this.jsonTxtbx.TabIndex = 12;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(355, 475);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(208, 48);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(579, 538);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.jsonTxtbx);
            this.Controls.Add(this.maritalStatusGrpbx);
            this.Controls.Add(this.genderGrpbx);
            this.Controls.Add(this.foreginLanguageGrpbx);
            this.Controls.Add(this.userInfoLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Anket";
            this.userInfoLbl.ResumeLayout(false);
            this.userInfoLbl.PerformLayout();
            this.foreginLanguageGrpbx.ResumeLayout(false);
            this.foreginLanguageGrpbx.PerformLayout();
            this.genderGrpbx.ResumeLayout(false);
            this.genderGrpbx.PerformLayout();
            this.maritalStatusGrpbx.ResumeLayout(false);
            this.maritalStatusGrpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtbx;
        private System.Windows.Forms.TextBox surenameTxtbx;
        private System.Windows.Forms.TextBox fatherNameTxtbx;
        private System.Windows.Forms.TextBox adressTxtbx;
        private System.Windows.Forms.TextBox ageTxtbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox userInfoLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.GroupBox foreginLanguageGrpbx;
        private System.Windows.Forms.GroupBox genderGrpbx;
        private System.Windows.Forms.Label adressLbl;
        private System.Windows.Forms.Label fathersNameLbl;
        private System.Windows.Forms.Label surenameLbl;
        private System.Windows.Forms.Label placeOfBirthdayLbl;
        private System.Windows.Forms.TextBox placeofbirthTxtbox;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label dateofbirthdayLbl;
        private System.Windows.Forms.CheckBox germanChkbx;
        private System.Windows.Forms.CheckBox turkishChkbx;
        private System.Windows.Forms.CheckBox russianChkbx;
        private System.Windows.Forms.CheckBox englishChkbx;
        private System.Windows.Forms.RadioButton femaleRadiobtn;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.GroupBox maritalStatusGrpbx;
        private System.Windows.Forms.RadioButton marriedRadiobtn;
        private System.Windows.Forms.RadioButton singleRadiobtn;
        private System.Windows.Forms.TextBox jsonTxtbx;
        private System.Windows.Forms.Button saveBtn;
    }
}

