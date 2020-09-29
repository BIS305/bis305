using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace vbArrays
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            _btnStart = new Button();
            _btnStart.Click += new EventHandler(btnStart_Click);
            lstOutput = new ListBox();
            _btnObjectArray = new Button();
            _btnObjectArray.Click += new EventHandler(btnObjectArray_Click);
            MenuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            _mnuClear = new ToolStripMenuItem();
            _mnuClear.Click += new EventHandler(mnuClear_Click);
            _mnuExit = new ToolStripMenuItem();
            _mnuExit.Click += new EventHandler(mnuExit_Click);
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            _btnStart.Location = new Point(23, 71);
            _btnStart.Name = "_btnStart";
            _btnStart.Size = new Size(75, 23);
            _btnStart.TabIndex = 0;
            _btnStart.Text = "Start";
            _btnStart.UseVisualStyleBackColor = true;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(23, 109);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(231, 238);
            lstOutput.TabIndex = 1;
            // 
            // btnObjectArray
            // 
            _btnObjectArray.Location = new Point(172, 70);
            _btnObjectArray.Name = "_btnObjectArray";
            _btnObjectArray.Size = new Size(75, 23);
            _btnObjectArray.TabIndex = 2;
            _btnObjectArray.Text = "Object Array";
            _btnObjectArray.UseVisualStyleBackColor = true;
            // 
            // MenuStrip1
            // 
            MenuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(284, 24);
            MenuStrip1.TabIndex = 3;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _mnuClear, _mnuExit });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(37, 20);
            FileToolStripMenuItem.Text = "&File";
            // 
            // mnuClear
            // 
            _mnuClear.Name = "_mnuClear";
            _mnuClear.Size = new Size(180, 22);
            _mnuClear.Text = "&Clear";
            // 
            // mnuExit
            // 
            _mnuExit.Name = "_mnuExit";
            _mnuExit.Size = new Size(180, 22);
            _mnuExit.Text = "E&xit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 360);
            Controls.Add(_btnObjectArray);
            Controls.Add(lstOutput);
            Controls.Add(_btnStart);
            Controls.Add(MenuStrip1);
            MainMenuStrip = MenuStrip1;
            Name = "Form1";
            Text = "Arrays";
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button _btnStart;

        internal Button btnStart
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnStart;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnStart != null)
                {
                    _btnStart.Click -= btnStart_Click;
                }

                _btnStart = value;
                if (_btnStart != null)
                {
                    _btnStart.Click += btnStart_Click;
                }
            }
        }

        internal ListBox lstOutput;
        private Button _btnObjectArray;

        internal Button btnObjectArray
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnObjectArray;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnObjectArray != null)
                {
                    _btnObjectArray.Click -= btnObjectArray_Click;
                }

                _btnObjectArray = value;
                if (_btnObjectArray != null)
                {
                    _btnObjectArray.Click += btnObjectArray_Click;
                }
            }
        }

        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem _mnuClear;

        internal ToolStripMenuItem mnuClear
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _mnuClear;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mnuClear != null)
                {
                    _mnuClear.Click -= mnuClear_Click;
                }

                _mnuClear = value;
                if (_mnuClear != null)
                {
                    _mnuClear.Click += mnuClear_Click;
                }
            }
        }

        private ToolStripMenuItem _mnuExit;

        internal ToolStripMenuItem mnuExit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _mnuExit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mnuExit != null)
                {
                    _mnuExit.Click -= mnuExit_Click;
                }

                _mnuExit = value;
                if (_mnuExit != null)
                {
                    _mnuExit.Click += mnuExit_Click;
                }
            }
        }
    }
}