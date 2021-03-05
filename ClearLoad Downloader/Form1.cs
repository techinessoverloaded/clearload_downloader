// Decompiled with JetBrains decompiler
// Type: Downloader.Form1
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
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Downloader
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("TextBox2")]
    private TextBox _TextBox2;
    [AccessedThroughProperty("SaveFileDialog1")]
    private SaveFileDialog _SaveFileDialog1;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Button4")]
    private Button _Button4;
    [AccessedThroughProperty("Button5")]
    private Button _Button5;
    [AccessedThroughProperty("button8")]
    private Button _button8;
    [AccessedThroughProperty("Button6")]
    private Button _Button6;
    [AccessedThroughProperty("download")]
    private WebClient _download;

    public Form1() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.Button1 = new Button();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Button2 = new Button();
      this.ProgressBar1 = new ProgressBar();
      this.TextBox1 = new TextBox();
      this.TextBox2 = new TextBox();
      this.SaveFileDialog1 = new SaveFileDialog();
      this.Button3 = new Button();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Button4 = new Button();
      this.Button5 = new Button();
      this.button8 = new Button();
      this.Button6 = new Button();
      this.SuspendLayout();
      Button button1_1 = this.Button1;
      Point point1 = new Point(348, 24);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(84, 23);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Download";
      this.Button1.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(31, 29);
      Point point3 = point1;
      label1_1.Location = point3;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(32, 13);
      Size size3 = size1;
      label1_2.Size = size3;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "URL:";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(31, 72);
      Point point4 = point1;
      label2_1.Location = point4;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(51, 13);
      Size size4 = size1;
      label2_2.Size = size4;
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Save To:";
      Button button2_1 = this.Button2;
      point1 = new Point(348, 66);
      Point point5 = point1;
      button2_1.Location = point5;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(84, 23);
      Size size5 = size1;
      button2_2.Size = size5;
      this.Button2.TabIndex = 4;
      this.Button2.Text = "Browse";
      this.Button2.UseVisualStyleBackColor = true;
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(12, 163);
      Point point6 = point1;
      progressBar1_1.Location = point6;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(451, 29);
      Size size6 = size1;
      progressBar1_2.Size = size6;
      this.ProgressBar1.TabIndex = 5;
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(85, 26);
      Point point7 = point1;
      textBox1_1.Location = point7;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(257, 20);
      Size size7 = size1;
      textBox1_2.Size = size7;
      this.TextBox1.TabIndex = 6;
      TextBox textBox2_1 = this.TextBox2;
      point1 = new Point(85, 69);
      Point point8 = point1;
      textBox2_1.Location = point8;
      this.TextBox2.Name = "TextBox2";
      TextBox textBox2_2 = this.TextBox2;
      size1 = new Size(257, 20);
      Size size8 = size1;
      textBox2_2.Size = size8;
      this.TextBox2.TabIndex = 7;
      this.SaveFileDialog1.Title = "Location to save the file";
      this.Button3.Enabled = false;
      Button button3_1 = this.Button3;
      point1 = new Point(12, 293);
      Point point9 = point1;
      button3_1.Location = point9;
      this.Button3.Name = "Button3";
      Button button3_2 = this.Button3;
      size1 = new Size(451, 23);
      Size size9 = size1;
      button3_2.Size = size9;
      this.Button3.TabIndex = 8;
      this.Button3.Text = "Cancel";
      this.Button3.UseVisualStyleBackColor = true;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label4_1 = this.Label4;
      point1 = new Point(31, 206);
      Point point10 = point1;
      label4_1.Location = point10;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(49, 16);
      Size size10 = size1;
      label4_2.Size = size10;
      this.Label4.TabIndex = 10;
      this.Label4.Text = "Label4";
      this.Label4.Visible = false;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label5_1 = this.Label5;
      point1 = new Point(383, 206);
      Point point11 = point1;
      label5_1.Location = point11;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(49, 16);
      Size size11 = size1;
      label5_2.Size = size11;
      this.Label5.TabIndex = 11;
      this.Label5.Text = "Label5";
      this.Label5.Visible = false;
      this.Button4.Enabled = false;
      Button button4_1 = this.Button4;
      point1 = new Point(12, 264);
      Point point12 = point1;
      button4_1.Location = point12;
      this.Button4.Name = "Button4";
      Button button4_2 = this.Button4;
      size1 = new Size(451, 23);
      Size size12 = size1;
      button4_2.Size = size12;
      this.Button4.TabIndex = 12;
      this.Button4.Text = "New Download";
      this.Button4.UseVisualStyleBackColor = true;
      Button button5_1 = this.Button5;
      point1 = new Point(12, 107);
      Point point13 = point1;
      button5_1.Location = point13;
      this.Button5.Name = "Button5";
      Button button5_2 = this.Button5;
      size1 = new Size(220, 33);
      Size size13 = size1;
      button5_2.Size = size13;
      this.Button5.TabIndex = 15;
      this.Button5.Text = "Add to Queue";
      this.Button5.UseVisualStyleBackColor = true;
      Button button8_1 = this.button8;
      point1 = new Point(238, 107);
      Point point14 = point1;
      button8_1.Location = point14;
      this.button8.Name = "button8";
      Button button8_2 = this.button8;
      size1 = new Size(224, 32);
      Size size14 = size1;
      button8_2.Size = size14;
      this.button8.TabIndex = 16;
      this.button8.Text = "Open Queue";
      this.button8.UseVisualStyleBackColor = true;
      this.Button6.Enabled = false;
      Button button6_1 = this.Button6;
      point1 = new Point(12, 235);
      Point point15 = point1;
      button6_1.Location = point15;
      this.Button6.Name = "Button6";
      Button button6_2 = this.Button6;
      size1 = new Size(451, 23);
      Size size15 = size1;
      button6_2.Size = size15;
      this.Button6.TabIndex = 17;
      this.Button6.Text = "Open File";
      this.Button6.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImageLayout = ImageLayout.None;
      size1 = new Size(474, 334);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button6);
      this.Controls.Add((Control) this.button8);
      this.Controls.Add((Control) this.Button5);
      this.Controls.Add((Control) this.Button4);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.TextBox2);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.ProgressBar1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (Form1);
      this.Text = "ClearLoad Downloader";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button Button1
    {
      get => this._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual Label Label1
    {
      get => this._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Label Label2
    {
      get => this._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Button Button2
    {
      get => this._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._Button2 != null)
          this._Button2.Click -= eventHandler;
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += eventHandler;
      }
    }

    internal virtual ProgressBar ProgressBar1
    {
      get => this._ProgressBar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ProgressBar1 = value;
    }

    internal virtual TextBox TextBox1
    {
      get => this._TextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
    }

    internal virtual TextBox TextBox2
    {
      get => this._TextBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox2 = value;
    }

    internal virtual SaveFileDialog SaveFileDialog1
    {
      get => this._SaveFileDialog1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._SaveFileDialog1 = value;
    }

    internal virtual Button Button3
    {
      get => this._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        if (this._Button3 != null)
          this._Button3.Click -= eventHandler;
        this._Button3 = value;
        if (this._Button3 == null)
          return;
        this._Button3.Click += eventHandler;
      }
    }

    internal virtual Label Label4
    {
      get => this._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal virtual Label Label5
    {
      get => this._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal virtual Button Button4
    {
      get => this._Button4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        if (this._Button4 != null)
          this._Button4.Click -= eventHandler;
        this._Button4 = value;
        if (this._Button4 == null)
          return;
        this._Button4.Click += eventHandler;
      }
    }

    internal virtual Button Button5
    {
      get => this._Button5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        if (this._Button5 != null)
          this._Button5.Click -= eventHandler;
        this._Button5 = value;
        if (this._Button5 == null)
          return;
        this._Button5.Click += eventHandler;
      }
    }

    internal virtual Button button8
    {
      get => this._button8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button8_Click);
        if (this._button8 != null)
          this._button8.Click -= eventHandler;
        this._button8 = value;
        if (this._button8 == null)
          return;
        this._button8.Click += eventHandler;
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

    private void Button2_Click(object sender, EventArgs e)
    {
      this.SaveFileDialog1.Filter = "JPEG Image|*.jpg|Executable|*.exe|RAR Archive|*.rar|Zip Archive|*.zip|MP3 Audio|*.mp3|MP4 Video|*.mp4|ISO File|*.iso|All files(*.*)|(*.*)";
      int num = (int) this.SaveFileDialog1.ShowDialog();
      this.TextBox2.Text = this.SaveFileDialog1.FileName;
    }

    public virtual WebClient download
    {
      get => this._download;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        AsyncCompletedEventHandler completedEventHandler = new AsyncCompletedEventHandler(this.download_DownloadFileCompleted);
        DownloadProgressChangedEventHandler changedEventHandler = new DownloadProgressChangedEventHandler(this.download_DownloadProgressChanged);
        if (this._download != null)
        {
          this._download.DownloadFileCompleted -= completedEventHandler;
          this._download.DownloadProgressChanged -= changedEventHandler;
        }
        this._download = value;
        if (this._download == null)
          return;
        this._download.DownloadFileCompleted += completedEventHandler;
        this._download.DownloadProgressChanged += changedEventHandler;
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.download = new WebClient();
      try
      {
        this.download.DownloadFileAsync(new Uri(this.TextBox1.Text), this.TextBox2.Text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Please insert the URL for download!");
        ProjectData.ClearProjectError();
      }
      if (Operators.CompareString(this.TextBox2.Text, (string) null, false) != 0)
        return;
      int num1 = (int) Interaction.MsgBox((object) "Please select the destination for download!");
    }

    private void download_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
    {
      if (this.ProgressBar1.Value == 100)
      {
        int num = (int) Interaction.MsgBox((object) "Download completed successfully!");
        this.Button6.Enabled = true;
      }
      if (this.ProgressBar1.Value < 1)
        return;
      this.Button3.Enabled = true;
    }

    private void download_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      this.ProgressBar1.Value = e.ProgressPercentage;
      this.Label4.Visible = true;
      this.Label4.Text = "Currently Downloaded : " + Conversions.ToString((double) e.BytesReceived / 1000000.0) + " MB /" + Conversions.ToString((double) e.TotalBytesToReceive / 1000000.0) + " MB";
      this.Label5.Visible = true;
      this.Label5.Text = Conversions.ToString(this.ProgressBar1.Value) + "%";
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      this.download.CancelAsync();
      this.download.Dispose();
      this.ProgressBar1.Value = 0;
      this.Label4.Text = "Currently Downloaded : " + Conversions.ToString(0) + " MB /" + Conversions.ToString(0) + " MB";
      this.Label5.Visible = true;
      this.Label5.Text = Conversions.ToString(0) + "%";
      this.Button4.Enabled = true;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      this.TextBox1.Clear();
      this.TextBox2.Clear();
      this.download.CancelAsync();
      this.download.Dispose();
      this.ProgressBar1.Value = 0;
      this.Label4.Text = "Currently Downloaded : " + Conversions.ToString(0) + " MB /" + Conversions.ToString(0) + " MB";
      this.Label5.Visible = true;
      this.Label5.Text = Conversions.ToString(0) + "%";
      this.Button3.Enabled = false;
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form2.ListBox1.Items.Add((object) this.TextBox1.Text);
      MyProject.Forms.Form2.ListBox2.Items.Add((object) this.TextBox2.Text);
      this.TextBox1.Clear();
      this.TextBox2.Clear();
    }

    private void button8_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.Form2.ShowDialog();
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      if (System.IO.File.Exists(this.TextBox2.Text))
      {
        Process.Start(this.TextBox2.Text);
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Doesn't exist", MsgBoxStyle.Information, (object) "Open");
      }
    }
  }
}
