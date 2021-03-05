// Decompiled with JetBrains decompiler
// Type: Downloader.Form2
// Assembly: Downloader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB94EAB6-C9A9-4A4F-9FDA-81A0C74F9286
// Assembly location: C:\Program Files (x86)\ClearLoad Downloader\ClearLoad Downloader.exe

using Downloader.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Downloader
{
  [DesignerGenerated]
  public class Form2 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("ListBox1")]
    private ListBox _ListBox1;
    [AccessedThroughProperty("ListBox2")]
    private ListBox _ListBox2;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Button7")]
    private Button _Button7;
    [AccessedThroughProperty("Button6")]
    private Button _Button6;

    public Form2() => this.InitializeComponent();

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.ListBox1 = new ListBox();
      this.ListBox2 = new ListBox();
      this.Label6 = new Label();
      this.Label7 = new Label();
      this.Button7 = new Button();
      this.Button6 = new Button();
      this.SuspendLayout();
      this.ListBox1.BackColor = SystemColors.Info;
      this.ListBox1.FormattingEnabled = true;
      ListBox listBox1_1 = this.ListBox1;
      Point point1 = new Point(4, 41);
      Point point2 = point1;
      listBox1_1.Location = point2;
      this.ListBox1.Name = "ListBox1";
      ListBox listBox1_2 = this.ListBox1;
      Size size1 = new Size(291, 251);
      Size size2 = size1;
      listBox1_2.Size = size2;
      this.ListBox1.TabIndex = 14;
      this.ListBox1.Tag = (object) "";
      this.ListBox2.BackColor = SystemColors.AppWorkspace;
      this.ListBox2.FormattingEnabled = true;
      ListBox listBox2_1 = this.ListBox2;
      point1 = new Point(301, 41);
      Point point3 = point1;
      listBox2_1.Location = point3;
      this.ListBox2.Name = "ListBox2";
      ListBox listBox2_2 = this.ListBox2;
      size1 = new Size(295, 251);
      Size size3 = size1;
      listBox2_2.Size = size3;
      this.ListBox2.TabIndex = 15;
      this.ListBox2.UseTabStops = false;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label6_1 = this.Label6;
      point1 = new Point(1, 9);
      Point point4 = point1;
      label6_1.Location = point4;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(35, 16);
      Size size4 = size1;
      label6_2.Size = size4;
      this.Label6.TabIndex = 18;
      this.Label6.Text = "URL";
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label7_1 = this.Label7;
      point1 = new Point(298, 9);
      Point point5 = point1;
      label7_1.Location = point5;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(130, 16);
      Size size5 = size1;
      label7_2.Size = size5;
      this.Label7.TabIndex = 19;
      this.Label7.Text = "Destination selected";
      Button button7_1 = this.Button7;
      point1 = new Point(301, 298);
      Point point6 = point1;
      button7_1.Location = point6;
      this.Button7.Name = "Button7";
      Button button7_2 = this.Button7;
      size1 = new Size(295, 41);
      Size size6 = size1;
      button7_2.Size = size6;
      this.Button7.TabIndex = 22;
      this.Button7.Text = "Add location to selected download";
      this.Button7.UseVisualStyleBackColor = true;
      Button button6_1 = this.Button6;
      point1 = new Point(4, 298);
      Point point7 = point1;
      button6_1.Location = point7;
      this.Button6.Name = "Button6";
      Button button6_2 = this.Button6;
      size1 = new Size(291, 41);
      Size size7 = size1;
      button6_2.Size = size7;
      this.Button6.TabIndex = 21;
      this.Button6.Text = "Add to download";
      this.Button6.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(601, 356);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button7);
      this.Controls.Add((Control) this.Button6);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.ListBox2);
      this.Controls.Add((Control) this.ListBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (Form2);
      this.Text = "Download Queue";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual ListBox ListBox1
    {
      get => this._ListBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ListBox1 = value;
    }

    internal virtual ListBox ListBox2
    {
      get => this._ListBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ListBox2 = value;
    }

    internal virtual Label Label6
    {
      get => this._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    internal virtual Label Label7
    {
      get => this._Label7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal virtual Button Button7
    {
      get => this._Button7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button7_Click);
        if (this._Button7 != null)
          this._Button7.Click -= eventHandler;
        this._Button7 = value;
        if (this._Button7 == null)
          return;
        this._Button7.Click += eventHandler;
      }
    }

    internal virtual Button Button6
    {
      get => this._Button6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button6_Click);
        if (this._Button6 != null)
          this._Button6.Click -= eventHandler;
        this._Button6 = value;
        if (this._Button6 == null)
          return;
        this._Button6.Click += eventHandler;
      }
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form1.TextBox1.Text = MyProject.Forms.Form1.TextBox1.Text + ", " + this.ListBox1.Text;
      if (Operators.CompareString(Strings.Mid(MyProject.Forms.Form1.TextBox1.Text, 1, 1), ",", false) != 0)
        return;
      MyProject.Forms.Form1.TextBox1.Text = Strings.Mid(MyProject.Forms.Form1.TextBox1.Text, 2);
    }

    private void Button7_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form1.TextBox2.Text = MyProject.Forms.Form1.TextBox2.Text + ", " + this.ListBox2.Text;
      if (Operators.CompareString(Strings.Mid(MyProject.Forms.Form1.TextBox2.Text, 1, 1), ",", false) != 0)
        return;
      MyProject.Forms.Form1.TextBox2.Text = Strings.Mid(MyProject.Forms.Form1.TextBox2.Text, 2);
    }
  }
}
