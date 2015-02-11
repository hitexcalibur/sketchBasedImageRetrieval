using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GraphicalCS
{
    public partial class Form1 : Form
    {
        private string queryImgPath;
        private string imgDatabasePath;
        public Image queryImage;
        //List<FileInfo> fileList;                    
        private int imgCount;                         //total number of images
        private int queryCount;                       
        double[][][] visualFeatureMatrix;             //feature matrix
        double[][] queryImgFeature;                   //query image feature
        IDistance[] visionDis;                        //feature distrance between query image and images in database
        List<imageInfo> fileList;                     //image info
        SortedList<int, string> allKeyWordList;       //keyword list

        /// <summary>
        /// </summary>
        List<double>[] SemanticMatrix;
        ISimilarity[] tempRowSim;                     //temp sorting array
        int iterationRound;

        int flag = 0;

        public Form1()
        {
            InitializeComponent();
            imgCount = 0;
            fileList = new List<imageInfo>();
            this.LVQueryByVision.ItemActivate += new EventHandler(ImgDataView_ItemActivate);
            this.LVQueryByVision.Click += new EventHandler(ImgDataView_Click);
            //////////////////////////////////////////////////////////////////////////////////
            queryCount = 20;                          
            visualFeatureMatrix = new double[4][][];
            queryImgFeature = new double[4][];        //4 type of features
            allKeyWordList = new SortedList<int, string>();
            SemanticMatrix = null;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void ImgDataView_ItemActivate(object sender, System.EventArgs e)
        {
            ListView lv = (ListView)sender;
            int i = Int32.Parse(lv.SelectedItems[0].Tag.ToString());
            string fileNameSelected = fileList[i].fileInformation.FullName;
            Picture_Show(Image.FromFile(fileNameSelected), SelectPicBox);
            //relevantCount++;
        }

        private void ImgDataView_Click(object sender, System.EventArgs e)
        {
            ListView lv = (ListView)sender;
            int i = Int32.Parse(lv.SelectedItems[0].Tag.ToString());
            string fileNameSelected = fileList[i].fileInformation.FullName;
            Picture_Show(Image.FromFile(fileNameSelected), SelectPicBox);
        }

        private void OpenQueryImg_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog queryImg = new OpenFileDialog();
            queryImg.Title = "Please Select the Query Image:";
            queryImg.Filter = "JPEG Files (*.jpg)|*.jpg|Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            if (queryImg.ShowDialog() == DialogResult.OK)
            {
                queryImgPath = queryImg.FileName;
                queryImage = Image.FromFile(queryImgPath);

                Picture_Show(queryImage, QueryPicBox);
                ExQueryPicFeature();

                flag = 1;
            }
        }

        private void ExQueryPicFeature()
        {
            for (int i = 0; i < 4; i++)
            {
                queryImgFeature[i] = null;
            }

            
            queryImgFeature[0] = new double[360];          //color hist
            queryImgFeature[1] = new double[360];          //acc color hist
            queryImgFeature[2] = new double[8];            
            //queryImgFeatur[3] = new double[];            
            //start extract feature
            extractColDig((Bitmap)queryImage, ref queryImgFeature[0], ref queryImgFeature[1]);
            //extractTexCo((Bitmap)queryImage, ref queryImgFeature[2]);

            //StreamWriter SW = File.CreateText("d:\\feature.txt");
            //for (int i = 0; i < 360; i++)
            //{
            //    SW.Write(queryImgFeature[0][i].ToString() + " ");
            //}
            //SW.WriteLine();
            //SW.WriteLine();
            //for (int i = 0; i < 360; i++)
            //{
            //    SW.Write(queryImgFeature[1][i].ToString() + " ");
            //}
            //SW.Close();
        }

        private void OpenDataBase_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dirPath = new FolderBrowserDialog();
            dirPath.Description = "Please Select the Image Database";
            if (dirPath.ShowDialog() == DialogResult.OK)
            {
                imgDatabasePath = dirPath.SelectedPath;
                DatabaseTextBox.Text = imgDatabasePath;
                
                GetDirFileInfo(imgDatabasePath);
                imgCount = fileList.Count;
                if (imgCount < 20) queryCount = imgCount;
                MessageBox.Show("Open Database Success! Please go ahead");
            }
        }

        /// <summary>
        /// Get all the files in the given direcory
        /// </summary>
        /// <param name="directory"></param>
        private void GetDirFileInfo(string directory)
        {
            
            DirectoryInfo dir = new DirectoryInfo(directory);
            FileInfo[] tempListJPG = dir.GetFiles("*.jpg");

            foreach (FileInfo tempFile in tempListJPG)
            {
                string dirName = dir.Name;
                imageInfo tempImageFile = new imageInfo();
                tempImageFile.fileInformation = tempFile;
                if (dirName.Length < 16) tempImageFile.textList.Add(dirName);
                
                fileList.Add(tempImageFile);
                
            }
            foreach (string subDirectory in Directory.GetDirectories(directory))
            {
                GetDirFileInfo(subDirectory);
            }
        }

        private void ExFeature_Click(object sender, EventArgs e)
        {
            if (imgCount == 0)                                           
            {
                MessageBox.Show("Please first open a database");
            }
            else
            {
                
                visualFeatureMatrix[0] = new double[imgCount][];
                visualFeatureMatrix[1] = new double[imgCount][];
                visualFeatureMatrix[2] = new double[imgCount][];
                double[][] tempFeature_0 = visualFeatureMatrix[0];
                double[][] tempFeature_1 = visualFeatureMatrix[1];
                double[][] tempFeature_2 = visualFeatureMatrix[2];
                int tempImageIndex = 0;

                if (File.Exists(imgDatabasePath + "\\Feature0.txt"))
                {
                    tempFeature_0[tempImageIndex] = new double[360];
                    tempFeature_1[tempImageIndex] = new double[360];

                    StreamReader SR1 = File.OpenText(imgDatabasePath + "\\Feature0.txt");
                    StreamReader SR2 = File.OpenText(imgDatabasePath + "\\Feature1.txt");
                    string txtLine;

                    tempImageIndex = 0;
                    while ((txtLine = SR1.ReadLine()) != null)
                    {
                        tempFeature_0[tempImageIndex] = new double[360];
                        string[] num = txtLine.Split(new char[] { ' ' });
                        for (int i = 0; i < 360; i++)
                        {
                            tempFeature_0[tempImageIndex][i] = Convert.ToDouble(num[i]);
                        }
                        tempImageIndex++;
                    }

                    tempImageIndex = 0;
                    while ((txtLine = SR2.ReadLine()) != null)
                    {
                        tempFeature_1[tempImageIndex] = new double[360];
                        string[] num = txtLine.Split(new char[] { ' ' });
                        for (int i = 0; i < 360; i++)
                        {
                            tempFeature_1[tempImageIndex][i] = Convert.ToDouble(num[i]);
                        }
                        tempImageIndex++;
                    }

                    SR1.Close();
                    SR2.Close();
                }
                else
                {
                    StreamWriter sw1 = File.CreateText(imgDatabasePath + "\\Feature0.txt");
                    StreamWriter sw2 = File.CreateText(imgDatabasePath + "\\Feature1.txt");
                    foreach (imageInfo fileImage in fileList)
                    {
                        Bitmap tempImage = (Bitmap)Image.FromFile(fileImage.fileInformation.FullName);
                        tempFeature_0[tempImageIndex] = new double[360];
                        tempFeature_1[tempImageIndex] = new double[360];
                        extractColDig(tempImage, ref tempFeature_0[tempImageIndex], ref tempFeature_1[tempImageIndex]);
                        
                        //tempFeature_2[tempImageIndex] = new double[8];
                        //extractTexCo(tempImage, ref tempFeature_2[tempImageIndex]);

                        for (int i = 0; i < 360; i++)
                        {
                            sw1.Write(tempFeature_0[tempImageIndex][i].ToString() + ' ');
                        }
                        sw1.WriteLine();
                        
                        for (int i = 0; i < 360; i++)
                        {
                            sw2.Write(tempFeature_1[tempImageIndex][i].ToString() + ' ');
                        }
                        sw2.WriteLine();
                        tempImageIndex++;
                    }
                    sw1.Close();
                    sw2.Close();
                }
                MessageBox.Show("Extract Features Success! Please go ahead");
            }

        }

        /// <summary>
        /// </summary>
        /// <param name="tempImage"></param>
        /// <param name="colDig"></param>
        /// <param name="colAccDig"></param>
        public static void extractColDig(Bitmap tempImage, ref double[] colDig, ref double[] colAccDig)
        {
            int height = tempImage.Height;
            int width = tempImage.Width;
            for (int m = 0; m < width; m++)
                for (int n = 0; n < height; n++)
                {
                    Color colPix = tempImage.GetPixel(m, n);
                    double tempHue = colPix.GetHue();
                    int tempIndex = (int)(tempHue);
                    colDig[tempIndex] += 1;
                    for (int p = tempIndex; p < 360; p++)
                        colAccDig[p] += 1;
                }
            double min = height * width;
            double max = 0;
            foreach (double x in colDig)
            {
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
            }
            for (int i = 0; i < 360; i++)
            {
                colDig[i] = (colDig[i] - min) / max;
                
                colAccDig[i] = colAccDig[i] / (height * width);
            }
        }

        //private void extractTexCo(Bitmap tempImage, ref double[] feature)
        //{
        //    int i, j;
        //    double[,] intensity = new double[tempImage.Height, tempImage.Width];
        //    int hei = tempImage.Height;
        //    int wid = tempImage.Width;
        //    
        //    for (i = 0; i < hei; i++)
        //        for (j = 0; j < wid; j++)
        //        {
        //            intensity[i, j] = (int)((tempImage.GetPixel(j, i).R + tempImage.GetPixel(j, i).G + tempImage.GetPixel(j, i).B) / (3 * 4));
        //        }
        //    
        //    int[,] M1 = new int[64, 64];
        //    int[,] M2 = new int[64, 64];
        //    int[,] M3 = new int[64, 64];
        //    int[,] M4 = new int[64, 64];
        //    for (i = 0; i < 64; i++)
        //        for (j = 0; j < 64; j++)
        //        {
        //            M1[i, j] = 0;
        //            M2[i, j] = 0;
        //            M3[i, j] = 0;
        //            M4[i, j] = 0;
        //        }
        //    
        //    for (i = 0; i < hei; i++)
        //        for (j = 0; j < wid; j++)
        //        {
        //            if (i + 1 < hei)
        //                M1[(int)intensity[i, j], (int)intensity[i + 1, j]]++;
        //            if (j + 1 < wid)
        //                M2[(int)intensity[i, j], (int)intensity[i, j + 1]]++;
        //            if ((i + 1 < hei) && (j + 1 < wid))
        //                M3[(int)intensity[i, j], (int)intensity[i + 1, j + 1]]++;
        //            if ((i + 1 < hei) && (j > 0))
        //                M4[(int)intensity[i, j], (int)intensity[i + 1, j - 1]]++;
        //        }
        //    

        //    
        //    int con1, con2, con3, con4;
        //    con1 = con2 = con3 = con4 = 0;

        //    
        //    double asm1, asm2, asm3, asm4;
        //    asm1 = asm2 = asm3 = asm4 = 0.0;

        //    
        //    double ent1, ent2, ent3, ent4;
        //    ent1 = ent2 = ent3 = ent4 = 0.0;

        //    for (i = 0; i < 64; i++)
        //        for (j = 0; j < 64; j++)
        //        {
        //            con1 += (i - j) * (i - j) * M1[i, j];
        //            con2 += (i - j) * (i - j) * M2[i, j];
        //            con3 += (i - j) * (i - j) * M3[i, j];
        //            con4 += (i - j) * (i - j) * M4[i, j];
        //            asm1 += Math.Pow(M1[i, j], 2);
        //            asm2 += Math.Pow(M2[i, j], 2);
        //            asm3 += Math.Pow(M3[i, j], 2);
        //            asm4 += Math.Pow(M4[i, j], 2);

        //            if (M1[i, j] != 0)
        //            {
        //                ent1 -= M1[i, j] * Math.Log10(M1[i, j]);
        //            }
        //            if (M2[i, j] != 0)
        //            {
        //                ent2 -= M2[i, j] * Math.Log10(M2[i, j]);
        //            }
        //            if (M3[i, j] != 0)
        //            {
        //                ent3 -= M3[i, j] * Math.Log10(M3[i, j]);
        //            }
        //            if (M4[i, j] != 0)
        //            {
        //                ent4 -= M4[i, j] * Math.Log10(M4[i, j]);
        //            }
        //        }

        //    
        //    
        //    int[] M1x, M1y, M2x, M2y, M3x, M3y, M4x, M4y;
        //    M1x = new int[64];
        //    M1y = new int[64];
        //    M2x = new int[64];
        //    M2y = new int[64];
        //    M3x = new int[64];
        //    M3y = new int[64];
        //    M4x = new int[64];
        //    M4y = new int[64];
        //    double u1x, det1x, u2x, det2x, u3x, det3x, u4x, det4x;
        //    double u1y, det1y, u2y, det2y, u3y, det3y, u4y, det4y;

        //    double sumx = 0;
        //    double sumy = 0;
        //    det1x = 0;
        //    det1y = 0;

        //    for (i = 0; i < 64; i++)
        //        for (j = 0; j < 64; j++)
        //        {
        //            M1x[i] = 0;
        //            M1y[i] = 0;
        //            M2x[i] = 0;
        //            M2y[i] = 0;
        //            M3x[i] = 0;
        //            M3y[i] = 0;
        //            M4x[i] = 0;
        //            M4y[i] = 0;
        //        }

        //    for (i = 0; i < 64; i++)
        //        for (j = 0; j < 64; j++)
        //        {
        //            M1x[i] += M1[i, j];
        //            M1y[i] += M1[j, i];
        //            M2x[i] += M2[i, j];
        //            M2y[i] += M2[j, i];
        //            M3x[i] += M3[i, j];
        //            M3y[i] += M3[j, i];
        //            M4x[i] += M4[i, j];
        //            M4y[i] += M4[j, i];
        //        }

        //    for (i = 0; i < 64; i++)
        //    {
        //        sumx += M1x[i];
        //        sumy += M1y[i];
        //    }

        //    
        //    u1x = sumx / 64;
        //    u1y = sumy / 64;

        //    for (i = 0; i < 64; i++)
        //    {
        //        det1x += Math.Pow(M1x[i] - u1x, 2);
        //        det1y += Math.Pow(M1y[i] - u1y, 2);
        //    }
        //    
        //    det1x = Math.Sqrt(det1x / 64);
        //    det1y = Math.Sqrt(det1y / 64);

        //    int sum = 0;
        //    for (i = 0; i < 64; i++)
        //        for (j = 0; j < 64; j++)
        //        {
        //            sum += i * j * M1[i, j];
        //        }
        //    double cor1 = (sum - u1x * u1y) / (det1x * det1y);

        //    sumx = 0;
        //    sumy = 0;
        //    det2x = 0;
        //    det2y = 0;

        //    for (i = 0; i < 64; i++)
        //    {
        //        sumx += M2x[i];
        //        sumy += M2y[i];
        //    }

        //    u2x = sumx / 64;
        //    u2y = sumy / 64;

        //    for (i = 0; i < 64; i++)
        //    {
        //        det2x += Math.Pow(M2x[i] - u2x, 2);
        //        det2y += Math.Pow(M2y[i] - u2y, 2);
        //    }

        //    det2x = Math.Sqrt(det2x / 64);
        //    det2y = Math.Sqrt(det2y / 64);

        //    sum = 0;
        //    for (i = 0; i < 64; i++)
        //        for (j = 0; j < 64; j++)
        //        {
        //            sum += i * j * M2[i, j];
        //        }
        //    double cor2 = (sum - u2x * u2y) / (det2x * det2y);

        //    sumx = 0;
        //    sumy = 0;
        //    det3x = 0;
        //    det3y = 0;

        //    for (i = 0; i < 64; i++)
        //    {
        //        sumx += M3x[i];
        //        sumy += M3y[i];
        //    }

        //    u3x = sumx / 64;
        //    u3y = sumy / 64;

        //    for (i = 0; i < 64; i++)
        //    {
        //        det3x += Math.Pow(M3x[i] - u3x, 2);
        //        det3y += Math.Pow(M3y[i] - u3y, 2);
        //    }

        //    det3x = Math.Sqrt(det3x / 64);
        //    det3y = Math.Sqrt(det3y / 64);

        //    sum = 0;
        //    for (i = 0; i < 64; i++)
        //        for (j = 0; j < 64; j++)
        //        {
        //            sum += i * j * M3[i, j];
        //        }
        //    double cor3 = (sum - u3x * u3y) / (det3x * det3y);

        //    sumx = 0;
        //    sumy = 0;
        //    det4x = 0;
        //    det4y = 0;

        //    for (i = 0; i < 64; i++)
        //    {
        //        sumx += M4x[i];
        //        sumy += M4y[i];
        //    }

        //    u4x = sumx / 64;
        //    u4y = sumy / 64;

        //    for (i = 0; i < 64; i++)
        //    {
        //        det4x += Math.Pow(M4x[i] - u4x, 2);
        //        det4y += Math.Pow(M4y[i] - u4y, 2);
        //    }

        //    det4x = Math.Sqrt(det4x / 64);
        //    det4y = Math.Sqrt(det4y / 64);

        //    sum = 0;
        //    for (i = 0; i < 64; i++)
        //        for (j = 0; j < 64; j++)
        //        {
        //            sum += i * j * M4[i, j];
        //        }
        //    double cor4 = (sum - u4x * u4y) / (det4x * det4y);

        //    
        //    feature[0] = (con1 + con2 + con3 + con4) / 4;
        //    sumx = Math.Pow(con1 - feature[0], 2) + Math.Pow(con2 - feature[0], 2) + Math.Pow(con3 - feature[0], 2) + Math.Pow(con4 - feature[0], 2);
        //    feature[1] = Math.Sqrt(sumx / 4);

        //    feature[2] = (asm1 + asm2 + asm3 + asm4) / 4;
        //    sumx = Math.Pow(asm1 - feature[2], 2) + Math.Pow(asm2 - feature[2], 2) + Math.Pow(asm3 - feature[2], 2) + Math.Pow(asm4 - feature[2], 2);
        //    feature[3] = Math.Sqrt(sumx / 4);

        //    feature[4] = (ent1 + ent2 + ent3 + ent4) / 4;
        //    sumx = Math.Pow(ent1 - feature[4], 2) + Math.Pow(ent2 - feature[4], 2) + Math.Pow(ent3 - feature[4], 2) + Math.Pow(ent4 - feature[4], 2);
        //    feature[5] = Math.Sqrt(sumx / 4);

        //    feature[6] = (cor1 + cor2 + cor3 + cor4) / 4;
        //    sumx = Math.Pow(cor1 - feature[6], 2) + Math.Pow(cor2 - feature[6], 2) + Math.Pow(cor3 - feature[6], 2) + Math.Pow(cor4 - feature[6], 2);
        //    feature[7] = Math.Sqrt(sumx / 4);
        //}


        private void DetectOnVision_Click(object sender, EventArgs e)
        {
            if (QueryPicBox.Image == null)
            {
                MessageBox.Show("Please first select a query picture");
            }

            if (flag == 0)
            {
                //queryImage = Image.FromFile("d:\\temp.jpg");
                //SelectPicBox.Image = queryImage;
                ExQueryPicFeature();
            }

            if (visualFeatureMatrix[0] == null)
            {
                MessageBox.Show("Please first extract the visual feature!");
                return;
            }
            
            //relevantCount = 0;
            //NDCG1 = 0;
            //NDCG3 = 0;
            //NDCG5 = 0;
            visionDis = new IDistance[imgCount];
            for (int i = 0; i < imgCount; i++)
            {
                
                visionDis[i].distanceValue = 0;
                visionDis[i].index = i;
                
                visionDis[i].distanceValue += Math.Sqrt(computeErDis(queryImgFeature[0], visualFeatureMatrix[0][i]));
                visionDis[i].distanceValue += Math.Sqrt(computeErDis(queryImgFeature[1], visualFeatureMatrix[1][i]));

                visionDis[i].distanceValue = Math.Sqrt(visionDis[i].distanceValue);
            }
            
            Array.Sort(visionDis);
            
            //First Clear all the items
            LVQueryByVision.Clear();
            QueryByVisionList.Images.Clear();
            QueryByVisionList.ImageSize = new Size(40, 40);
            LVQueryByVision.View = View.LargeIcon;
            //Begin Update
            LVQueryByVision.BeginUpdate();
            //Display all the Images
            ListViewItem tempItem;

            for (int i = 0; i < queryCount; i++)
            {
                QueryByVisionList.Images.Add(Image.FromFile(fileList[visionDis[i].index].fileInformation.FullName));
                tempItem = new ListViewItem();
                tempItem.Text = fileList[visionDis[i].index].fileInformation.Name;
                tempItem.Tag = visionDis[i].index.ToString();
                tempItem.ImageIndex = i;
                this.LVQueryByVision.Items.Add(tempItem);
            }
            LVQueryByVision.LargeImageList = QueryByVisionList;

            LVQueryByVision.EndUpdate();
            //Update End

            //The initialization of the List
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "File Name";
            LVQueryByVision.Columns.Add(ch);
        }

        private void computeWWs(int[] Entity1, int[] Entity2, ref double[] w)
        {
            int La = Entity1[1] - Entity1[0];
            int Ha = Entity1[3] - Entity1[2];
            int Lb = Entity2[1] - Entity2[0];
            int Hb = Entity2[3] - Entity2[2];
            int Lab = Math.Abs(Entity2[1] - Entity1[0]);
            int Hab = Math.Abs(Entity2[3] - Entity1[2]);

            double K11 = 1.0 / La / Ha / Lb / Hb;
            double K10 = 1.0 / Hab / La / Lb;
            double K01 = 1.0 / Lab / Ha / Hb;
            double K00 = 1.0 / Math.Sqrt(La * Ha * Lb * Hb);

            int sum = 0;

            for (int a = Entity1[0]; a <= Entity1[1]; a++)
                for (int b = Entity1[2]; b <= Entity1[3]; b++)
                    for (int c = Entity2[0]; c < Math.Min(a, Entity2[1]); c++)
                        for (int d = Math.Max(b + 1, Entity2[2]); d <= Entity2[3]; d++, sum++) ;
            w[0] = K11 * sum; sum = 0;

            for (int a = Entity1[0]; a <= Entity1[1]; a++)
                for (int b = Entity1[2]; b <= Entity1[3]; b++)
                    for (int d = Math.Max(b + 1, Entity2[2]); d <= Entity2[3]; d++)
                        if (Entity2[0] <= a && Entity2[1] >= a) sum++;
            w[1] = K01 * sum; sum = 0;

            for (int a = Entity1[0]; a <= Entity1[1]; a++)
                for (int b = Entity1[2]; b <= Entity1[3]; b++)
                    for (int c = Math.Max(a + 1, Entity2[0]); c <= Entity2[1]; c++)
                        for (int d = Math.Max(b + 1, Entity2[2]); d <= Entity2[3]; d++, sum++) ;
            w[2] = K11 * sum; sum = 0;

            for (int a = Entity1[0]; a <= Entity1[1]; a++)
                for (int b = Entity1[2]; b <= Entity1[3]; b++)
                    for (int c = Entity2[0]; c < Math.Min(a, Entity2[1]); c++)
                        if (Entity2[2] <= b && Entity2[3] >= b) sum++;
            w[3] = K10 * sum; sum = 0;

            for (int a = Entity1[0]; a <= Entity1[1]; a++)
                for (int b = Entity1[2]; b <= Entity1[3]; b++)
                    if (Entity2[0] <= a && Entity2[1] >= a && Entity2[2] <= b && Entity2[3] >= b) sum++;
            w[4] = K00 * sum; sum = 0;

            for (int a = Entity1[0]; a <= Entity1[1]; a++)
                for (int b = Entity1[2]; b <= Entity1[3]; b++)
                    for (int c = Math.Max(a + 1, Entity2[0]); c <= Entity2[1]; c++)
                        if (Entity2[2] <= b && Entity2[3] >= b) sum++;
            w[5] = K10 * sum; sum = 0;

            for (int a = Entity1[0]; a <= Entity1[1]; a++)
                for (int b = Entity1[2]; b <= Entity1[3]; b++)
                    for (int c = Entity2[0]; c < Math.Min(a, Entity2[1]); c++)
                        for (int d = Entity2[2]; d < Math.Min(b, Entity2[3]); d++, sum++) ;
            w[6] = K11 * sum; sum = 0;

            for (int a = Entity1[0]; a <= Entity1[1]; a++)
                for (int b = Entity1[2]; b <= Entity1[3]; b++)
                    for (int d = Entity2[2]; d < Math.Min(b, Entity2[3]); d++)
                        if (Entity2[0] <= a && Entity2[1] >= a) sum++;
            w[7] = K01 * sum;

            for (int i = 0; i < 9; i++)
                if (w[i] > 1) w[i] = 1;

            w[8] = 1 - w[0] - w[2] - w[6];
        }

        private double computeDs(double[] wq, double[] wd)
        {
            double lambda = 1.0 / 6;
            double dh = Math.Abs((wq[2] + wq[8]) - (wd[2] + wd[8]));
            double dv = Math.Abs((wq[0] + wq[2]) - (wd[0] + wd[2]));
            double dd = Math.Abs((wq[6] + wq[2]) - (wd[6] + wd[2]));
            double dv0 = Math.Abs((wq[3] + wq[5]) - (wd[3] + wd[5]));
            double dh0 = Math.Abs((wq[1] + wq[7]) - (wd[1] + wq[7]));
            double d00 = Math.Abs(wq[4] - wd[4]);
            double Ds = lambda * (dh + dv + dd + dv0 + dh0 + d00);
            return Ds;
        }

        private double computeErDis(double[] vector1, double[] vecotor2)
        {
            double dis = 0;
            int dim = vector1.Length;
            for (int i = 0; i < dim; i++)
            {
                dis += Math.Pow((vector1[i] - vecotor2[i]), 2);
            }
            return dis;
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            MainWindow fm = new MainWindow(this);
            fm.Show();
        }

        
        public void Picture_Show(Image ShowImage, PictureBox PB)
        {
            int x = 0;
            int y = 0;
            int ShowImageW = ShowImage.Width;
            int ShowImageH = ShowImage.Height;
            ShowImageH = (ShowImage.Width * 175) / 188;
            x = 0;
            y = (ShowImage.Height - ShowImageH) / 2;
            Image ImageShow = new Bitmap(188, 175);
            Graphics graphics = Graphics.FromImage(ImageShow);
            graphics.InterpolationMode = InterpolationMode.High;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.Clear(Color.Transparent);
            graphics.DrawImage(ShowImage, new Rectangle(0, 0, 188, 175), new Rectangle(x, y, ShowImageW, ShowImageH), GraphicsUnit.Pixel);

            PB.Image = ImageShow;
        }
    

    }

    /// <summary>
    /// IDistance Structure Definition
    /// </summary>
    public struct IDistance : IComparable<IDistance>
    {
        public double distanceValue;
        public int index;

        public int CompareTo(IDistance other)
        {
            return distanceValue.CompareTo(other.distanceValue);
        }
    }

    public struct ISimilarity : IComparable<ISimilarity>
    {
        public double similarity;
        public int index;

        public int CompareTo(ISimilarity other)
        {
            return similarity.CompareTo(other.similarity);
        }
    };

    public struct IKeywordRank : IComparable<IKeywordRank>
    {
        public double keywordRank;
        public int index;

        public int CompareTo(IKeywordRank other)
        {
            return keywordRank.CompareTo(other.keywordRank);
        }
    };

    public class imageInfo
    {
        public List<string> textList;
        public FileInfo fileInformation;
        public double[] coordinateArray;
        public imageInfo()
        {
            textList = new List<string>();
            fileInformation = null;
            coordinateArray = null;
        }
        public void setCoordinate(SortedList<int, string> allKeyWordList)
        
        {
            
            coordinateArray = new double[allKeyWordList.Count];
            if (textList.Count != 0)
            {
                foreach (string tempKeyword in textList)
                {
                    int tempIndex = allKeyWordList.IndexOfValue(tempKeyword);
                    coordinateArray[tempIndex] += 1;
                    if (coordinateArray[tempIndex] > 1) coordinateArray[tempIndex] = coordinateArray[tempIndex] - 1;
                }
            }

        }
    }

  
}
