﻿namespace AAVD
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.LOGO_CISNE = new System.Windows.Forms.PictureBox();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.BTN_OPCIONES = new System.Windows.Forms.PictureBox();
            this.PanelContenedorFondo = new System.Windows.Forms.Panel();
            this.BTN_Ingresar = new MAD.Clases.Buttons();
            this.BTN_Reportes = new MAD.Clases.Buttons();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO_CISNE)).BeginInit();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_OPCIONES)).BeginInit();
            this.PanelContenedorFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.panelContenedor.Location = new System.Drawing.Point(495, 83);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(644, 593);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.PanelMenu.Controls.Add(this.LOGO_CISNE);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(70, 700);
            this.PanelMenu.TabIndex = 2;
            // 
            // LOGO_CISNE
            // 
            this.LOGO_CISNE.Image = global::MAD.Properties.Resources.Logis;
            this.LOGO_CISNE.Location = new System.Drawing.Point(12, 8);
            this.LOGO_CISNE.Name = "LOGO_CISNE";
            this.LOGO_CISNE.Size = new System.Drawing.Size(50, 50);
            this.LOGO_CISNE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO_CISNE.TabIndex = 0;
            this.LOGO_CISNE.TabStop = false;
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.PanelBarraTitulo.Controls.Add(this.BTN_OPCIONES);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(70, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1230, 50);
            this.PanelBarraTitulo.TabIndex = 3;
            this.PanelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBarraTitulo_Paint);
            // 
            // BTN_OPCIONES
            // 
            this.BTN_OPCIONES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_OPCIONES.Image = global::MAD.Properties.Resources.FondisAzul;
            this.BTN_OPCIONES.InitialImage = global::MAD.Properties.Resources.FondisAzul;
            this.BTN_OPCIONES.Location = new System.Drawing.Point(10, 8);
            this.BTN_OPCIONES.Name = "BTN_OPCIONES";
            this.BTN_OPCIONES.Size = new System.Drawing.Size(35, 35);
            this.BTN_OPCIONES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_OPCIONES.TabIndex = 0;
            this.BTN_OPCIONES.TabStop = false;
            this.BTN_OPCIONES.WaitOnLoad = true;
            this.BTN_OPCIONES.Click += new System.EventHandler(this.BTN_OPCIONES_Click);
            // 
            // PanelContenedorFondo
            // 
            this.PanelContenedorFondo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelContenedorFondo.Controls.Add(this.BTN_Ingresar);
            this.PanelContenedorFondo.Controls.Add(this.BTN_Reportes);
            this.PanelContenedorFondo.Controls.Add(this.panelContenedor);
            this.PanelContenedorFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorFondo.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedorFondo.Name = "PanelContenedorFondo";
            this.PanelContenedorFondo.Size = new System.Drawing.Size(1300, 700);
            this.PanelContenedorFondo.TabIndex = 4;
            this.PanelContenedorFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedorFondo_Paint);
            // 
            // BTN_Ingresar
            // 
            this.BTN_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.BTN_Ingresar.FlatAppearance.BorderSize = 0;
            this.BTN_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ingresar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Ingresar.Location = new System.Drawing.Point(1145, 590);
            this.BTN_Ingresar.Name = "BTN_Ingresar";
            this.BTN_Ingresar.Size = new System.Drawing.Size(150, 40);
            this.BTN_Ingresar.TabIndex = 6;
            this.BTN_Ingresar.Text = "Ingresar";
            this.BTN_Ingresar.UseVisualStyleBackColor = false;
            // 
            // BTN_Reportes
            // 
            this.BTN_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(172)))), ((int)(((byte)(183)))));
            this.BTN_Reportes.FlatAppearance.BorderSize = 0;
            this.BTN_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reportes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Reportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Reportes.Location = new System.Drawing.Point(1145, 636);
            this.BTN_Reportes.Name = "BTN_Reportes";
            this.BTN_Reportes.Size = new System.Drawing.Size(150, 40);
            this.BTN_Reportes.TabIndex = 5;
            this.BTN_Reportes.Text = "Reportes";
            this.BTN_Reportes.UseVisualStyleBackColor = false;
            this.BTN_Reportes.Click += new System.EventHandler(this.BTN_Reportes_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PanelBarraTitulo);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelContenedorFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaInicio";
            this.Text = "PantallaInicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LOGO_CISNE)).EndInit();
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_OPCIONES)).EndInit();
            this.PanelContenedorFondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.Panel PanelContenedorFondo;
        private System.Windows.Forms.PictureBox LOGO_CISNE;
        private System.Windows.Forms.PictureBox BTN_OPCIONES;
        private MAD.Clases.Buttons BTN_Reportes;
        private MAD.Clases.Buttons BTN_Ingresar;
    }
}