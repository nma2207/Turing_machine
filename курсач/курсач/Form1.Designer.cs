namespace курсач
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.newABC = new System.Windows.Forms.TextBox();
            this.label_task = new System.Windows.Forms.Label();
            this.add_tape = new System.Windows.Forms.Button();
            this.abc = new System.Windows.Forms.Label();
            this.task = new System.Windows.Forms.TextBox();
            this.tape_panel = new System.Windows.Forms.Panel();
            this.delete_tape = new System.Windows.Forms.Button();
            this.count_tape = new System.Windows.Forms.Label();
            this.tape_count = new System.Windows.Forms.TextBox();
            this.but_tape_count = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пахайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДругуюЛентуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьЛентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_abc = new System.Windows.Forms.Panel();
            this.Protocol = new System.Windows.Forms.DataGridView();
            this.start_condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_value0 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.new_value0 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.direction0 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.new_condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            this.panel_abc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Protocol)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(241, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "обновить алфавит";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newABC
            // 
            this.newABC.Location = new System.Drawing.Point(308, 0);
            this.newABC.Name = "newABC";
            this.newABC.Size = new System.Drawing.Size(295, 22);
            this.newABC.TabIndex = 4;
            this.newABC.Text = "01";
            // 
            // label_task
            // 
            this.label_task.AutoSize = true;
            this.label_task.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_task.Location = new System.Drawing.Point(12, 37);
            this.label_task.Name = "label_task";
            this.label_task.Size = new System.Drawing.Size(147, 20);
            this.label_task.TabIndex = 30;
            this.label_task.Text = "поставленная задача: ";
            this.label_task.UseCompatibleTextRendering = true;
            // 
            // add_tape
            // 
            this.add_tape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_tape.Location = new System.Drawing.Point(374, 28);
            this.add_tape.Name = "add_tape";
            this.add_tape.Size = new System.Drawing.Size(126, 44);
            this.add_tape.TabIndex = 6;
            this.add_tape.Text = "добавить ленту";
            this.add_tape.UseVisualStyleBackColor = true;
            this.add_tape.Click += new System.EventHandler(this.butto_Click);
            // 
            // abc
            // 
            this.abc.AutoSize = true;
            this.abc.Location = new System.Drawing.Point(238, 0);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(70, 17);
            this.abc.TabIndex = 15;
            this.abc.Text = "Алфавит:";
            // 
            // task
            // 
            this.task.Location = new System.Drawing.Point(12, 60);
            this.task.Multiline = true;
            this.task.Name = "task";
            this.task.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.task.Size = new System.Drawing.Size(898, 72);
            this.task.TabIndex = 16;
            this.task.TextChanged += new System.EventHandler(this.task_TextChanged);
            this.task.MouseUp += new System.Windows.Forms.MouseEventHandler(this.task_MouseUp);
            // 
            // tape_panel
            // 
            this.tape_panel.AutoScroll = true;
            this.tape_panel.BackColor = System.Drawing.SystemColors.Control;
            this.tape_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tape_panel.Location = new System.Drawing.Point(12, 138);
            this.tape_panel.Name = "tape_panel";
            this.tape_panel.Size = new System.Drawing.Size(1510, 254);
            this.tape_panel.TabIndex = 17;
            // 
            // delete_tape
            // 
            this.delete_tape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_tape.Location = new System.Drawing.Point(506, 28);
            this.delete_tape.Name = "delete_tape";
            this.delete_tape.Size = new System.Drawing.Size(100, 44);
            this.delete_tape.TabIndex = 18;
            this.delete_tape.Text = "убрать ленту";
            this.delete_tape.UseVisualStyleBackColor = true;
            this.delete_tape.Click += new System.EventHandler(this.button2_Click);
            // 
            // count_tape
            // 
            this.count_tape.AutoSize = true;
            this.count_tape.Location = new System.Drawing.Point(3, 0);
            this.count_tape.Name = "count_tape";
            this.count_tape.Size = new System.Drawing.Size(123, 17);
            this.count_tape.TabIndex = 20;
            this.count_tape.Text = "количество лент:";
            // 
            // tape_count
            // 
            this.tape_count.Location = new System.Drawing.Point(135, 0);
            this.tape_count.Name = "tape_count";
            this.tape_count.Size = new System.Drawing.Size(100, 22);
            this.tape_count.TabIndex = 21;
            this.tape_count.Text = "1";
            this.tape_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tape_count.TextChanged += new System.EventHandler(this.tape_count_TextChanged);
            // 
            // but_tape_count
            // 
            this.but_tape_count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_tape_count.Location = new System.Drawing.Point(3, 28);
            this.but_tape_count.Name = "but_tape_count";
            this.but_tape_count.Size = new System.Drawing.Size(232, 44);
            this.but_tape_count.TabIndex = 22;
            this.but_tape_count.Text = "изменить количество лент";
            this.but_tape_count.UseVisualStyleBackColor = true;
            this.but_tape_count.Click += new System.EventHandler(this.but_tape_count_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.пахайToolStripMenuItem,
            this.лентаToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.инструкцияToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1534, 28);
            this.Menu.TabIndex = 31;
            this.Menu.Text = "главное меню";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // пахайToolStripMenuItem
            // 
            this.пахайToolStripMenuItem.Name = "пахайToolStripMenuItem";
            this.пахайToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.пахайToolStripMenuItem.Text = "Пуск";
            this.пахайToolStripMenuItem.Click += new System.EventHandler(this.пахайToolStripMenuItem_Click);
            // 
            // лентаToolStripMenuItem
            // 
            this.лентаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДругуюЛентуToolStripMenuItem,
            this.очиститьЛентыToolStripMenuItem});
            this.лентаToolStripMenuItem.Name = "лентаToolStripMenuItem";
            this.лентаToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.лентаToolStripMenuItem.Text = "Лента";
            this.лентаToolStripMenuItem.Click += new System.EventHandler(this.лентаToolStripMenuItem_Click);
            // 
            // загрузитьДругуюЛентуToolStripMenuItem
            // 
            this.загрузитьДругуюЛентуToolStripMenuItem.Name = "загрузитьДругуюЛентуToolStripMenuItem";
            this.загрузитьДругуюЛентуToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.загрузитьДругуюЛентуToolStripMenuItem.Text = "Загрузить другую ленту";
            this.загрузитьДругуюЛентуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДругуюЛентуToolStripMenuItem_Click);
            // 
            // очиститьЛентыToolStripMenuItem
            // 
            this.очиститьЛентыToolStripMenuItem.Name = "очиститьЛентыToolStripMenuItem";
            this.очиститьЛентыToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.очиститьЛентыToolStripMenuItem.Text = "Очистить ленты";
            this.очиститьЛентыToolStripMenuItem.Click += new System.EventHandler(this.очиститьЛентыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.инструкцияToolStripMenuItem.Text = "Инструкция";
            this.инструкцияToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // panel_abc
            // 
            this.panel_abc.Controls.Add(this.delete_tape);
            this.panel_abc.Controls.Add(this.button1);
            this.panel_abc.Controls.Add(this.add_tape);
            this.panel_abc.Controls.Add(this.but_tape_count);
            this.panel_abc.Controls.Add(this.count_tape);
            this.panel_abc.Controls.Add(this.newABC);
            this.panel_abc.Controls.Add(this.abc);
            this.panel_abc.Controls.Add(this.tape_count);
            this.panel_abc.Location = new System.Drawing.Point(916, 60);
            this.panel_abc.Name = "panel_abc";
            this.panel_abc.Size = new System.Drawing.Size(606, 72);
            this.panel_abc.TabIndex = 33;
            // 
            // Protocol
            // 
            this.Protocol.BackgroundColor = System.Drawing.Color.White;
            this.Protocol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Protocol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.start_condition,
            this.start_value0,
            this.new_value0,
            this.direction0,
            this.new_condition});
            this.Protocol.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Protocol.Location = new System.Drawing.Point(12, 398);
            this.Protocol.Name = "Protocol";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.Protocol.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Protocol.RowTemplate.Height = 24;
            this.Protocol.Size = new System.Drawing.Size(1078, 266);
            this.Protocol.TabIndex = 34;
            this.Protocol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Protocol_CellContentClick);
            // 
            // start_condition
            // 
            this.start_condition.HeaderText = "начальное состояние";
            this.start_condition.Name = "start_condition";
            // 
            // start_value0
            // 
            this.start_value0.HeaderText = "значение на 1 ленте";
            this.start_value0.Name = "start_value0";
            // 
            // new_value0
            // 
            this.new_value0.HeaderText = "новое значение";
            this.new_value0.Name = "new_value0";
            // 
            // direction0
            // 
            this.direction0.HeaderText = "направление головки";
            this.direction0.Items.AddRange(new object[] {
            "->",
            "<-",
            "*"});
            this.direction0.Name = "direction0";
            // 
            // new_condition
            // 
            this.new_condition.HeaderText = "новое состояние";
            this.new_condition.Name = "new_condition";
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(1097, 398);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(425, 266);
            this.comments.TabIndex = 35;
            this.comments.Text = "комментарии: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1534, 753);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.Protocol);
            this.Controls.Add(this.panel_abc);
            this.Controls.Add(this.tape_panel);
            this.Controls.Add(this.task);
            this.Controls.Add(this.label_task);
            this.Controls.Add(this.Menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "курсач";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel_abc.ResumeLayout(false);
            this.panel_abc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Protocol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newABC;
        private System.Windows.Forms.Label label_task;
        private System.Windows.Forms.Button add_tape;
        private System.Windows.Forms.Label abc;
        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.Panel tape_panel;
        private System.Windows.Forms.Button delete_tape;
        private System.Windows.Forms.Label count_tape;
        private System.Windows.Forms.TextBox tape_count;
        private System.Windows.Forms.Button but_tape_count;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;


        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panel_abc;
        private System.Windows.Forms.DataGridView Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_condition;
        private System.Windows.Forms.DataGridViewComboBoxColumn start_value0;
        private System.Windows.Forms.DataGridViewComboBoxColumn new_value0;
        private System.Windows.Forms.DataGridViewComboBoxColumn direction0;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_condition;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пахайToolStripMenuItem;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.ToolStripMenuItem лентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДругуюЛентуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьЛентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
        
    }
}

