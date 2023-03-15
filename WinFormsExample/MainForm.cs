using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using EOSDigital.API;
using EOSDigital.SDK;
using MessageBox = System.Windows.Forms.MessageBox;
using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;
using WhiteBalance = EOSDigital.API.WhiteBalancevalues;

namespace WinFormsExample
{
    public partial class MainForm : Form
    {
        #region Variables

        CanonAPI APIHandler;
        Camera MainCamera;
        CameraValue[] AvList;
        CameraValue[] TvList;
        CameraValue[] ISOList;
        CameraValue[] WhitebalanceList;
        List<Camera> CamList;
        bool IsInit = false;
        Bitmap Evf_Bmp;
        int LVBw, LVBh, w, h;
        float LVBratio, LVration;

        int ErrCount;
        object ErrLock = new object();
        object LvLock = new object();

        private int xUp, yUp, xDown, yDown;
        private System.Drawing.Rectangle rectCropArea;


        private Matrix transform = new Matrix();
        private float m_dZoomscale = 1.0f;
        public const float s_dScrollValue = 0.1f;

        //SerialPort port = new SerialPort("COM8", 9600, Parity.None, 8, StopBits.One);

        #endregion

        public MainForm()
        {
            try
            {
                InitializeComponent();
                APIHandler = new CanonAPI();
                APIHandler.CameraAdded += APIHandler_CameraAdded;
                ErrorHandler.SevereErrorHappened += ErrorHandler_SevereErrorHappened;
                ErrorHandler.NonSevereErrorHappened += ErrorHandler_NonSevereErrorHappened;
                SavePathTextBox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "RemotePhoto");
                SaveFolderBrowser.Description = "Save Images To...";
                LiveViewPicBox.Paint += LiveViewPicBox_Paint;
                LVBw = LiveViewPicBox.Width;
                LVBh = LiveViewPicBox.Height;
                RefreshCamera();
                IsInit = true;
                //port.ReadTimeout = -1;
                //port.Open();
                //port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            }
            catch (DllNotFoundException) { ReportError("Canon DLLs not found!", true); }
            catch (Exception ex) { ReportError(ex.Message, true); }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                IsInit = false;
                MainCamera?.Dispose();
                APIHandler?.Dispose();
                //port.Close();
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }


        #region API Events

        private void APIHandler_CameraAdded(CanonAPI sender)
        {
            try { Invoke((Action)delegate { RefreshCamera(); }); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void MainCamera_StateChanged(Camera sender, StateEventID eventID, int parameter)
        {
            try { if (eventID == StateEventID.Shutdown && IsInit) { Invoke((Action)delegate { CloseSession(); }); } }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }
        
        private void MainCamera_ProgressChanged(object sender, int progress)
        {
            try { Invoke((Action)delegate { MainProgressBar.Value = progress; }); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void MainCamera_LiveViewUpdated(Camera sender, Stream img)
        {
            try
            {
                lock (LvLock)
                {
                    Evf_Bmp?.Dispose();
                    Evf_Bmp = new Bitmap(img);
                }
                LiveViewPicBox.Invalidate();
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void MainCamera_DownloadReady(Camera sender, DownloadInfo Info)
        {
            try
            {
                string dir = null;
                Invoke((Action)delegate { dir = SavePathTextBox.Text; });
                sender.DownloadFile(Info, dir);
                Invoke((Action)delegate { MainProgressBar.Value = 0; });
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void ErrorHandler_NonSevereErrorHappened(object sender, ErrorCode ex)
        {
            ReportError($"SDK Error code: {ex} ({((int)ex).ToString("X")})", false);
        }

        private void ErrorHandler_SevereErrorHappened(object sender, Exception ex)
        {
            ReportError(ex.Message, true);
        }

        #endregion

        #region Session

        private void SessionButton_Click(object sender, EventArgs e)
        {
            if (MainCamera?.SessionOpen == true) CloseSession();
            else OpenSession();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try { RefreshCamera(); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #endregion

        #region Settings

        private void TakePhotoButton_Click(object sender, EventArgs e)
        {
            string paths = @"f:\404\" + idtxt.Text;
            string subPath = @"f:\404\" + idtxt.Text + "/" + remarktxt.Text;

            Directory.CreateDirectory(paths);
            Directory.CreateDirectory(subPath);
            for (int i = 0; i < 2; i++)
            {
                //if ((string)TvCoBox.SelectedItem == "Bulb") MainCamera.TakePhotoBulbAsync((int)BulbUpDo.Value);
                MainCamera.TakePhotoShutterAsync();
                Thread.Sleep(2000);
            }
                //  MainCamera.DownloadFiles(subPath, MainCamera.GetAllImages());
        }

        private void RecordVideoButton_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            if (serialPort1.IsOpen)
                serialPort1.Close();
            serialPort1.Open();
            string cmd = string.Concat("R,", "1,", "900");

            string paths = @"f:\404\" + idtxt.Text;
            string subPath = @"f:\404\" + idtxt.Text + "/" + remarktxt.Text;

            Directory.CreateDirectory(paths);
            Directory.CreateDirectory(subPath);
            for (int i = 0; i < 10; i++)
            {
                serialPort1.Write(cmd);
                MainCamera.TakePhotoShutterAsync();
                Thread.Sleep(2000);
            }
            serialPort1.Close();

           // MainCamera.DownloadFiles(paths, MainCamera.GetAllImages());
            //try
            //{
            //    Recording state = (Recording)MainCamera.GetInt32Setting(PropertyID.Record);
            //    if (state != Recording.On)
            //    {
            //        MainCamera.StartFilming(true);
            //        RecordVideoButton.Text = "Stop Video";
            //    }
            //    else
            //    {
            //        bool save = STComputerRdButton.Checked || STBothRdButton.Checked;
            //        MainCamera.StopFilming(save);
            //        RecordVideoButton.Text = "Record Video";
            //    }
            //}
            //catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(SavePathTextBox.Text)) SaveFolderBrowser.SelectedPath = SavePathTextBox.Text;
                if (SaveFolderBrowser.ShowDialog() == DialogResult.OK)
                {
                    SavePathTextBox.Text = SaveFolderBrowser.SelectedPath;
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void AvCoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (AvCoBox.SelectedIndex < 0) return;
                MainCamera.SetSetting(PropertyID.Av, AvValues.GetValue((string)AvCoBox.SelectedItem).IntValue);
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void TvCoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TvCoBox.SelectedIndex < 0) return;

                MainCamera.SetSetting(PropertyID.Tv, TvValues.GetValue((string)TvCoBox.SelectedItem).IntValue);
                BulbUpDo.Enabled = (string)TvCoBox.SelectedItem == "Bulb";
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void ISOCoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ISOCoBox.SelectedIndex < 0) return;
                MainCamera.SetSetting(PropertyID.ISO, ISOValues.GetValue((string)ISOCoBox.SelectedItem).IntValue);
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void VIScombox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (VIScombox.SelectedIndex < 0) return;

                MainCamera.SetSetting(PropertyID.WhiteBalance, WhiteBalance.GetValue((string)VIScombox.SelectedItem).IntValue);
                BulbUpDo.Enabled = (string)VIScombox.SelectedItem == "Bulb";
            }
            catch (Exception ex) { ReportError(ex.Message, false); } 
            
            //try
            //{
            //    if (VIScombox.SelectedIndex < 0) return;
            //    MainCamera.SetSetting(PropertyID.WhiteBalance, WhiteBalance.GetValue((string)VIScombox.SelectedItem).ValueType);
            //}
            //catch (Exception ex) { ReportError(ex.Message, false); }
        }


        private void KcoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (KcoBox.SelectedIndex < 0) return;
            //    MainCamera.SetSetting(PropertyID.K, Color.GetValue((string)KcoBox.SelectedItem).IntValue);
            //}
            //catch (Exception ex) { ReportError(ex.Message, false); }
        }


        private void SaveToRdButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (IsInit)
                {
                    if (STCameraRdButton.Checked)
                    {
                        MainCamera.SetSetting(PropertyID.SaveTo, (int)SaveTo.Camera);
                        BrowseButton.Enabled = false;
                        SavePathTextBox.Enabled = false;
                    }
                    else
                    {
                        if (STComputerRdButton.Checked) MainCamera.SetSetting(PropertyID.SaveTo, (int)SaveTo.Host);
                        else if (STBothRdButton.Checked) MainCamera.SetSetting(PropertyID.SaveTo, (int)SaveTo.Both);

                        MainCamera.SetCapacity(4096, int.MaxValue);
                        BrowseButton.Enabled = true;
                        SavePathTextBox.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #endregion

        #region Live view

        private void LiveViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainCamera.IsLiveViewOn) { MainCamera.StartLiveView(); LiveViewButton.Text = "  "; }
                else { MainCamera.StopLiveView(); LiveViewButton.Text = "Start LV"; }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

       
        private void LiveViewPicBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Transform = transform;

            if (MainCamera == null || !MainCamera.SessionOpen) return;

            if (!MainCamera.IsLiveViewOn) e.Graphics.Clear(BackColor);
            else
            {
                lock (LvLock)
                {
                    if (Evf_Bmp != null)
                    {
                        LVBratio = LVBw / (float)LVBh;
                        LVration = Evf_Bmp.Width / (float)Evf_Bmp.Height;
                        if (LVBratio < LVration)
                        {
                            w = LVBw;
                            h = (int)(LVBw / LVration);
                        }
                        else
                        {
                            w = (int)(LVBh * LVration);
                            h = LVBh;
                        }
                        e.Graphics.DrawImage(Evf_Bmp, 0, 0, w, h);
                    }
                }
            }
        }

        private void FocusNear3Button_Click(object sender, EventArgs e)
        {
            try { MainCamera.SendCommand(CameraCommand.DriveLensEvf, (int)DriveLens.Near3); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusNear2Button_Click(object sender, EventArgs e)
        {
            try { MainCamera.SendCommand(CameraCommand.DriveLensEvf, (int)DriveLens.Near2); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusNear1Button_Click(object sender, EventArgs e)
        {
            try { MainCamera.SendCommand(CameraCommand.DriveLensEvf, (int)DriveLens.Near1); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusFar1Button_Click(object sender, EventArgs e)
        {
            try { MainCamera.SendCommand(CameraCommand.DriveLensEvf, (int)DriveLens.Far1); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusFar2Button_Click(object sender, EventArgs e)
        {
            try { MainCamera.SendCommand(CameraCommand.DriveLensEvf, (int)DriveLens.Far2); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }


        private void FocusFar3Button_Click(object sender, EventArgs e)
        {
            try { MainCamera.SendCommand(CameraCommand.DriveLensEvf, (int)DriveLens.Far3); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #endregion

        #region Subroutines

        private void CloseSession()
        {
            MainCamera.CloseSession();
            AvCoBox.Items.Clear();
            TvCoBox.Items.Clear();
            ISOCoBox.Items.Clear();
            VIScombox.Items.Clear();
            SettingsGroupBox.Enabled = false;
            SessionButton.Text = "Open Session";
            SessionLabel.Text = "No open session";
            LiveViewButton.Text = " ";
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            xUp = e.X;
            yUp = e.Y;
            Rectangle rec = new Rectangle(xDown, yDown, Math.Abs(xUp - xDown), Math.Abs(yUp - yDown));
            using (Pen pen = new Pen(Color.DarkRed, 5))
            {

                LiveViewPicBox.CreateGraphics().DrawRectangle(pen, rec);

            }
            rectCropArea = rec;
          
            Bitmap bmp = new Bitmap(LiveViewPicBox.Width, LiveViewPicBox.Height);
            Rectangle rec1 = new Rectangle(0, 0, LiveViewPicBox.Width, LiveViewPicBox.Height);

            LiveViewPicBox.DrawToBitmap(bmp, rec1);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Transform = transform;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LiveViewPicBox.Invalidate();

            xDown = e.X;
            yDown = e.Y;
        }

        

        private void button16_Click(object sender, EventArgs e)
        {
            //general
            Form1 fm1 = new Form1() { TopLevel = false, TopMost = true };
            fm1.FormBorderStyle = FormBorderStyle.None;
            panel4.Hide();
            panel1.Hide();
            panel2.Controls.Add(fm1);
            fm1.Show();
           

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //general
            File_name Fname = new File_name() { TopLevel = false, TopMost = true };
            Fname.FormBorderStyle = FormBorderStyle.None;
            panel4.Hide();
            panel1.Hide();
            panel2.Controls.Add(Fname);
            Fname.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //camera
           // panel2.Refresh();
            panel4.Show();
            panel1.Show();
        }
        private void Depthchbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Depthchbox.Checked)
            {
                try { MainCamera.SendCommand(CameraCommand.Evf_DepthOfFieldPreview, (int)DepthOfField.DepthOfField_ON); }
                catch (Exception ex) { ReportError(ex.Message, false); }
            }
            else
            {
                try { MainCamera.SendCommand(CameraCommand.Evf_DepthOfFieldPreview, (int)DepthOfField.DepthOfField_OFF); }
                catch (Exception ex) { ReportError(ex.Message, false); }
            }
            //if (Depthchbox.Checked)
            //{
            //    try { MainCamera.SendCommand(CameraCommand.DriveLensEvf, (int)DriveLens.Far3); }
            //    catch (Exception ex) { ReportError(ex.Message, false); }
            //}
            //else
            //{
            //    try { MainCamera.SendCommand(CameraCommand.DriveLensEvf, (int)DriveLens.Near3); }
            //    catch (Exception ex) { ReportError(ex.Message, false); }

            //}
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                LVBw = LiveViewPicBox.Width;
                LVBh = LiveViewPicBox.Height;
                LiveViewPicBox.Invalidate();
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void LiveViewPicBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta <= 0)
                {
                    //set minimum size to zoom
                    if (LiveViewPicBox.Width < 30)
                        return;
                }
                else
                {
                    //set maximum size to zoom
                    if (LiveViewPicBox.Width > 2000)
                        return;
                }
                LiveViewPicBox.Width += Convert.ToInt32(LiveViewPicBox.Width * e.Delta / 1000);
                LiveViewPicBox.Height += Convert.ToInt32(LiveViewPicBox.Height * e.Delta / 1000);
                //   LiveViewPicBox.AutoScrollOffset = true;
            }
        }
        public static Image RotateImg(Image img, float rotationAngle)
        {
            
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics gfx = Graphics.FromImage(img);
            gfx.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
            gfx.RotateTransform(rotationAngle);
            gfx.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(img, new Point(0, 0));
            gfx.Dispose();
            return img;
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.Write(indata);
        }

        private void lblleft45_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            string a = serialPort1.ReadExisting();
            string cmd = string.Concat("l,", "45,", "9000");
            serialPort1.Write(cmd);
            SerialPort sp = new SerialPort();
            sp.PortName = "COM8";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Close();

        }


        private void lblright45_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            string a = serialPort1.ReadExisting();
            string cmd = string.Concat("r,", "45,", "9000");
            serialPort1.Write(cmd);
            SerialPort sp = new SerialPort();
            sp.PortName = "COM8";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Close();

        }

        private void lblleft90_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            string a = serialPort1.ReadExisting();
            string cmd = string.Concat("l,", "90,", "9000");
            serialPort1.Write(cmd);
            SerialPort sp = new SerialPort();
            sp.PortName = "COM8";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Close();
        }

        private void lblright90_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            string a = serialPort1.ReadExisting();
            string cmd = string.Concat("r,", "90,", "9000");
            serialPort1.Write(cmd);
            SerialPort sp = new SerialPort();
            sp.PortName = "COM8";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Close();

        }

        private void lbl180_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            string a = serialPort1.ReadExisting();
            string cmd = string.Concat("r,", "180,", "9000");
            serialPort1.Write(cmd);
            SerialPort sp = new SerialPort();
            sp.PortName = "COM8";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Close();

        }

        private void lbl360_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            string a = serialPort1.ReadExisting();
            string cmd = string.Concat("r,", "360,", "9000");
            serialPort1.Write(cmd);
            SerialPort sp = new SerialPort();
            sp.PortName = "COM8";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            string a = serialPort1.ReadExisting();
            string str = textBox1.Text;
            string cmd = string.Concat("l,", str, ",9000");
            serialPort1.Write(cmd);
            SerialPort sp = new SerialPort();
            sp.PortName = "COM8";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            string a = serialPort1.ReadExisting();
            string str = textBox1.Text;
            string cmd = string.Concat("r,", str, ",9000");
            serialPort1.Write(cmd);
            SerialPort sp = new SerialPort();
            sp.PortName = "COM8";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);
            //Response.Write(b);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
               
                LiveViewPicBox.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;
            }
        }

        private void squarebtn_Click(object sender, EventArgs e)
        {
            LiveViewPicBox.Refresh();
            Pen pen = new Pen(Color.OrangeRed, 2);
            Graphics g = LiveViewPicBox.CreateGraphics();
            g.DrawRectangle(pen, 350, 270, 150, 150);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Preview newForm = new Preview();
            newForm.ShowDialog();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            File_name newForm = new File_name();
            newForm.ShowDialog();
        }

        private void dotsquarebtn_Click(object sender, EventArgs e)
        {
          LiveViewPicBox.Refresh();
            Pen blackPen = new Pen(Color.LimeGreen, 3);
            Pen pen = new Pen(Color.OrangeRed, 2);
            Graphics g = LiveViewPicBox.CreateGraphics();
            g.DrawRectangle(pen, 350, 270, 150, 150);
            g.DrawLine(blackPen, 426, 345, 422, 345);
        }

        private void horizontalsquarebtn_Click(object sender, EventArgs e)
        {
            LiveViewPicBox.Refresh();
            Pen blackPen = new Pen(Color.LimeGreen, 1);
            Pen pen = new Pen(Color.OrangeRed, 2);
            Graphics g = LiveViewPicBox.CreateGraphics();
            g.DrawRectangle(pen, 350, 270, 150, 150);
            g.DrawLine(blackPen, 500, 345, 350, 345);
        }

        private void verticalsquarebtn_Click(object sender, EventArgs e)
        {
            LiveViewPicBox.Refresh();
            Pen blackPen = new Pen(Color.LimeGreen,1);
            Pen pen = new Pen(Color.OrangeRed, 2);
            Graphics g = LiveViewPicBox.CreateGraphics();
            g.DrawRectangle(pen, 350, 270, 150, 150);
            g.DrawLine(blackPen, 425, 420, 425, 270);
        }

        private void plusesquarebtn_Click(object sender, EventArgs e)
        {
         LiveViewPicBox.Refresh();
            Pen blackPen = new Pen(Color.LimeGreen, 1);
            Pen pen = new Pen(Color.OrangeRed, 2);
            Graphics g = LiveViewPicBox.CreateGraphics();
            g.DrawRectangle(pen, 350, 270, 150, 150);
            g.DrawLine(blackPen, 425, 420, 425, 270);
            g.DrawLine(blackPen, 500, 345, 350, 345);
        }

        private void plusebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(crpsetting.Text))
            {
               int count = 0;
                crpsetting.Text = count.ToString();
            }
            else
            {
                int count = Convert.ToInt16(crpsetting.Text);
                ++count;
                crpsetting.Text = count.ToString();
            }
        }

        private void subtractbtn_Click(object sender, EventArgs e)
        {
            if (crpsetting.Text == "0" || string.IsNullOrEmpty(crpsetting.Text))
            {
                //do nothing
            }
            else
            {
                int count = Convert.ToInt16(crpsetting.Text);
                --count;
                crpsetting.Text = count.ToString();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label8.Text = trackBar1.Value.ToString();
        }

        private void UPcrpbtn_Click(object sender, EventArgs e)
        {
           LiveViewPicBox.Top -= 1;

        }

        private void downcrpbtn_Click(object sender, EventArgs e)
        {
            LiveViewPicBox.Top += 1;
        }

        private void leftcrpbtn_Click(object sender, EventArgs e)
        {
            LiveViewPicBox.Left -= 1;
        }

        private void rightcrbtn_Click(object sender, EventArgs e)
        {
            LiveViewPicBox.Left += 1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            LiveViewPicBox.Top -= 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void RefreshCamera()
        {
            CameraListBox.Items.Clear();
            CamList = APIHandler.GetCameraList();
            foreach (Camera cam in CamList) CameraListBox.Items.Add(cam.DeviceName);
            if (MainCamera?.SessionOpen == true) CameraListBox.SelectedIndex = CamList.FindIndex(t => t.ID == MainCamera.ID);
            else if (CamList.Count > 0) CameraListBox.SelectedIndex = 0;
        }
       

        public void startLiveView()
        {
            MainCamera.StartLiveView();
            Image img = LiveViewPicBox.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipY);
             LiveViewPicBox.Image = img;
           
        }
        private void OpenSession()
        {
            if (CameraListBox.SelectedIndex >= 0)
            {
                MainCamera = CamList[CameraListBox.SelectedIndex];
                MainCamera.OpenSession();
                MainCamera.LiveViewUpdated += MainCamera_LiveViewUpdated;
                MainCamera.ProgressChanged += MainCamera_ProgressChanged;
                MainCamera.StateChanged += MainCamera_StateChanged;
                MainCamera.DownloadReady += MainCamera_DownloadReady;

                SessionButton.Text = " ";
                SessionLabel.Text = MainCamera.DeviceName;
                AvList = MainCamera.GetSettingsList(PropertyID.Av);
                TvList = MainCamera.GetSettingsList(PropertyID.Tv);
                ISOList = MainCamera.GetSettingsList(PropertyID.ISO);
                WhitebalanceList = MainCamera.GetSettingsList(PropertyID.WhiteBalance);
                foreach (var Av in AvList) AvCoBox.Items.Add(Av.StringValue);
                foreach (var Tv in TvList) TvCoBox.Items.Add(Tv.StringValue);
                foreach (var ISO in ISOList) ISOCoBox.Items.Add(ISO.StringValue);
                foreach (var Whitebalance in WhitebalanceList) VIScombox.Items.Add(Whitebalance.StringValue);
                AvCoBox.SelectedIndex = AvCoBox.Items.IndexOf(AvValues.GetValue(MainCamera.GetInt32Setting(PropertyID.Av)).StringValue);
                TvCoBox.SelectedIndex = TvCoBox.Items.IndexOf(TvValues.GetValue(MainCamera.GetInt32Setting(PropertyID.Tv)).StringValue);
                ISOCoBox.SelectedIndex = ISOCoBox.Items.IndexOf(ISOValues.GetValue(MainCamera.GetInt32Setting(PropertyID.ISO)).StringValue);
                VIScombox.SelectedIndex = VIScombox.Items.IndexOf(WhiteBalance.GetValue(MainCamera.GetInt32Setting(PropertyID.WhiteBalance)).StringValue);
                SettingsGroupBox.Enabled = true;
            }
        }

        private void ReportError(string message, bool lockdown)
        {
            int errc; 
            lock (ErrLock) { errc = ++ErrCount; }

            if (lockdown) EnableUI(false);

            if (errc < 0) MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (errc == 0) MessageBox.Show("Many errors happened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            lock (ErrLock) { ErrCount--; }
        }
         
        private void EnableUI(bool enable)
        {
            if (InvokeRequired) Invoke((Action)delegate { EnableUI(enable); });
            else
            {
                SettingsGroupBox.Enabled = enable;
            }
        }

        #endregion    
        protected override void OnMouseWheel(MouseEventArgs mea)
        {
            LiveViewPicBox.Focus();
            if (LiveViewPicBox.Focused == true && mea.Delta != 0)
            {
                // Map the Form-centric mouse location to the PictureBox client coordinate system
                Point pictureBoxPoint = LiveViewPicBox.PointToClient(this.PointToScreen(mea.Location));
                ZoomScroll(pictureBoxPoint, mea.Delta > 0);
            }
        }
        private void ZoomScroll(Point location, bool zoomIn)
        {
            // Figure out what the new scale will be. Ensure the scale factor remains between
            // 1% and 1000%
            float newScale = Math.Min(Math.Max(m_dZoomscale + (zoomIn ? s_dScrollValue : -s_dScrollValue), 0.1f), 10);

            if (newScale != m_dZoomscale)
            {
                float adjust = newScale / m_dZoomscale;
                m_dZoomscale = newScale;

                // Translate mouse point to origin
                transform.Translate(-location.X, -location.Y, MatrixOrder.Append);

                // Scale view
                transform.Scale(adjust, adjust, MatrixOrder.Append);

                // Translate origin back to original mouse point.
                transform.Translate(location.X, location.Y, MatrixOrder.Append);

                LiveViewPicBox.Invalidate();
            }
        }
    }
}
