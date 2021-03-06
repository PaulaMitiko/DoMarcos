﻿namespace ProjetoBoletimAlunos.Telas.TelasAdministrador
{
    partial class form_MenuAdministrador
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
            this.btn_GerenciarAlunos = new System.Windows.Forms.Button();
            this.btn_GerenciarMaterias = new System.Windows.Forms.Button();
            this.btn_GerenciarCursos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VoltarMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GerenciarAlunos
            // 
            this.btn_GerenciarAlunos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_GerenciarAlunos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GerenciarAlunos.Location = new System.Drawing.Point(186, 103);
            this.btn_GerenciarAlunos.Name = "btn_GerenciarAlunos";
            this.btn_GerenciarAlunos.Size = new System.Drawing.Size(364, 48);
            this.btn_GerenciarAlunos.TabIndex = 0;
            this.btn_GerenciarAlunos.Text = "Gerenciar Alunos";
            this.btn_GerenciarAlunos.UseVisualStyleBackColor = false;
            // 
            // btn_GerenciarMaterias
            // 
            this.btn_GerenciarMaterias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_GerenciarMaterias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GerenciarMaterias.Location = new System.Drawing.Point(186, 189);
            this.btn_GerenciarMaterias.Name = "btn_GerenciarMaterias";
            this.btn_GerenciarMaterias.Size = new System.Drawing.Size(364, 48);
            this.btn_GerenciarMaterias.TabIndex = 0;
            this.btn_GerenciarMaterias.Text = "Gerenciar Matérias";
            this.btn_GerenciarMaterias.UseVisualStyleBackColor = false;
            // 
            // btn_GerenciarCursos
            // 
            this.btn_GerenciarCursos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_GerenciarCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GerenciarCursos.Location = new System.Drawing.Point(186, 275);
            this.btn_GerenciarCursos.Name = "btn_GerenciarCursos";
            this.btn_GerenciarCursos.Size = new System.Drawing.Size(364, 48);
            this.btn_GerenciarCursos.TabIndex = 0;
            this.btn_GerenciarCursos.Text = "Gerenciar Cursos";
            this.btn_GerenciarCursos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olá Administrador, escolha uma das opções de gerenciamento:";
            // 
            // btn_VoltarMenuPrincipal
            // 
            this.btn_VoltarMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_VoltarMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VoltarMenuPrincipal.Location = new System.Drawing.Point(465, 379);
            this.btn_VoltarMenuPrincipal.Name = "btn_VoltarMenuPrincipal";
            this.btn_VoltarMenuPrincipal.Size = new System.Drawing.Size(269, 45);
            this.btn_VoltarMenuPrincipal.TabIndex = 0;
            this.btn_VoltarMenuPrincipal.Text = "Voltar ao menu principal";
            this.btn_VoltarMenuPrincipal.UseVisualStyleBackColor = false;
            // 
            // form_MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.btn_VoltarMenuPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GerenciarCursos);
            this.Controls.Add(this.btn_GerenciarMaterias);
            this.Controls.Add(this.btn_GerenciarAlunos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "form_MenuAdministrador";
            this.Text = "Menu Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GerenciarAlunos;
        private System.Windows.Forms.Button btn_GerenciarMaterias;
        private System.Windows.Forms.Button btn_GerenciarCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VoltarMenuPrincipal;
    }
}