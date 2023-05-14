namespace CRUD
{
    partial class frmCRUD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.swTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.txtPass = new MaterialSkin.Controls.MaterialTextBox();
            this.btnConnect = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnMod = new MaterialSkin.Controls.MaterialButton();
            this.btnDel = new MaterialSkin.Controls.MaterialButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // swTheme
            // 
            this.swTheme.AutoSize = true;
            this.swTheme.Depth = 0;
            this.swTheme.Location = new System.Drawing.Point(452, 34);
            this.swTheme.Margin = new System.Windows.Forms.Padding(0);
            this.swTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.swTheme.Name = "swTheme";
            this.swTheme.Ripple = true;
            this.swTheme.Size = new System.Drawing.Size(108, 37);
            this.swTheme.TabIndex = 0;
            this.swTheme.Text = "Oscuro";
            this.swTheme.UseVisualStyleBackColor = true;
            this.swTheme.CheckedChanged += new System.EventHandler(this.swTheme_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(6, 10);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 36);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            this.txtName.UseTallSize = false;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.btnDel);
            this.gbxInfo.Controls.Add(this.btnMod);
            this.gbxInfo.Controls.Add(this.btnAdd);
            this.gbxInfo.Controls.Add(this.txtPass);
            this.gbxInfo.Controls.Add(this.txtName);
            this.gbxInfo.Location = new System.Drawing.Point(6, 175);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(201, 242);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTitle.Location = new System.Drawing.Point(28, 42);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manipulación";
            // 
            // txtPass
            // 
            this.txtPass.AnimateReadOnly = false;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.LeadingIcon = null;
            this.txtPass.Location = new System.Drawing.Point(6, 52);
            this.txtPass.MaxLength = 50;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 36);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "";
            this.txtPass.TrailingIcon = null;
            this.txtPass.UseTallSize = false;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnect.Depth = 0;
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnect.HighEmphasis = true;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(6, 90);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConnect.Size = new System.Drawing.Size(98, 36);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnect.UseAccentColor = false;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(7, 97);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(88, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMod
            // 
            this.btnMod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMod.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMod.Depth = 0;
            this.btnMod.HighEmphasis = true;
            this.btnMod.Icon = null;
            this.btnMod.Location = new System.Drawing.Point(7, 145);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMod.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMod.Name = "btnMod";
            this.btnMod.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMod.Size = new System.Drawing.Size(99, 36);
            this.btnMod.TabIndex = 5;
            this.btnMod.Text = "Modificar";
            this.btnMod.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMod.UseAccentColor = false;
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDel.Depth = 0;
            this.btnDel.HighEmphasis = true;
            this.btnDel.Icon = null;
            this.btnDel.Location = new System.Drawing.Point(6, 193);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDel.Name = "btnDel";
            this.btnDel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDel.Size = new System.Drawing.Size(88, 36);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Eliminar";
            this.btnDel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDel.UseAccentColor = false;
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(225, 175);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(289, 219);
            this.dgvDatos.TabIndex = 4;
            // 
            // frmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.swTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frmCRUD";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Master";
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch swTheme;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private System.Windows.Forms.GroupBox gbxInfo;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialTextBox txtPass;
        private MaterialSkin.Controls.MaterialButton btnConnect;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnMod;
        private MaterialSkin.Controls.MaterialButton btnDel;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}

