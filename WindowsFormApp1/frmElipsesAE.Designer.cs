
namespace WindowsFormsApp1
{ 

    partial class frmElipsesAE
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
        this.components = new System.ComponentModel.Container();
        this.TrazosComboBox = new System.Windows.Forms.ComboBox();
        this.SemiejeMayorTextBox = new System.Windows.Forms.TextBox();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnOK = new System.Windows.Forms.Button();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        this.label1 = new System.Windows.Forms.Label();
        this.SemiejeMenorTextBox = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        this.SuspendLayout();
        // 
        // TrazosComboBox
        // 
        this.TrazosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.TrazosComboBox.FormattingEnabled = true;
        this.TrazosComboBox.Location = new System.Drawing.Point(128, 81);
        this.TrazosComboBox.Name = "TrazosComboBox";
        this.TrazosComboBox.Size = new System.Drawing.Size(279, 21);
        this.TrazosComboBox.TabIndex = 58;
        // 
        // SemiejeMayorTextBox
        // 
        this.SemiejeMayorTextBox.Location = new System.Drawing.Point(128, 29);
        this.SemiejeMayorTextBox.MaxLength = 50;
        this.SemiejeMayorTextBox.Name = "SemiejeMayorTextBox";
        this.SemiejeMayorTextBox.Size = new System.Drawing.Size(279, 20);
        this.SemiejeMayorTextBox.TabIndex = 53;
        // 
        // btnCancelar
        // 
        this.btnCancelar.Location = new System.Drawing.Point(319, 184);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(88, 61);
        this.btnCancelar.TabIndex = 55;
        this.btnCancelar.Text = "Cancelar";
        this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.btnCancelar.UseVisualStyleBackColor = true;
        // 
        // btnOK
        // 
        this.btnOK.Location = new System.Drawing.Point(25, 184);
        this.btnOK.Name = "btnOK";
        this.btnOK.Size = new System.Drawing.Size(84, 61);
        this.btnOK.TabIndex = 54;
        this.btnOK.Text = "OK";
        this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.btnOK.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(29, 81);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(37, 13);
        this.label4.TabIndex = 57;
        this.label4.Text = "Trazo:";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(27, 32);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(79, 13);
        this.label5.TabIndex = 56;
        this.label5.Text = "Semieje Mayor:";
        // 
        // errorProvider1
        // 
        this.errorProvider1.ContainerControl = this;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(27, 58);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(80, 13);
        this.label1.TabIndex = 56;
        this.label1.Text = "Semieje Menor:";
        // 
        // SemiejeMenorTextBox
        // 
        this.SemiejeMenorTextBox.Location = new System.Drawing.Point(128, 55);
        this.SemiejeMenorTextBox.MaxLength = 50;
        this.SemiejeMenorTextBox.Name = "SemiejeMenorTextBox";
        this.SemiejeMenorTextBox.Size = new System.Drawing.Size(279, 20);
        this.SemiejeMenorTextBox.TabIndex = 53;
        // 
        // frmOrtoedrosAE
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(446, 262);
        this.Controls.Add(this.TrazosComboBox);
        this.Controls.Add(this.SemiejeMenorTextBox);
        this.Controls.Add(this.SemiejeMayorTextBox);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnOK);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label5);
        this.Name = "frmOrtoedrosAE";
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox TrazosComboBox;
    private System.Windows.Forms.TextBox SemiejeMayorTextBox;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.TextBox SemiejeMenorTextBox;
    private System.Windows.Forms.Label label1;
}
}

