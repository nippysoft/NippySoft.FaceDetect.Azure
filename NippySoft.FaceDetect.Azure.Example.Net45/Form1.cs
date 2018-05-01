using NippySoft.FaceDetect.Azure.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NippySoft.FaceDetect.Azure.Core.Entities.ServerApiAzure;

namespace NippySoft.FaceDetect.Azure.Example.Net45
{
    public partial class Form1 : Form
    {
        bool IsBusy = false;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (IsBusy)
                return;

            if (dialogOpen.ShowDialog() == DialogResult.OK)
            {
                dataFaces.Rows.Clear();
                IsBusy = true;
                btnSelectImage.Text = "Loading...";
                pictureUsed.ImageLocation = dialogOpen.FileName;

                using (FaceDetect faceDetect = new FaceDetect(LocationServerApiAzure.EastUS))
                {
                    faceDetect.SuscriptionKey = "Api Azure Key";
                    ResponseFaceDetect responseFaceDetect = await faceDetect.GetFacesFromImageInDisk(dialogOpen.FileName);

                    if (responseFaceDetect.IsSuccess)
                        foreach (var face in responseFaceDetect.Faces)
                            dataFaces.Rows.Add(face.faceAttributes.gender, face.faceAttributes.age);
                    else
                        MessageBox.Show(responseFaceDetect.Error.Message);
                }

                btnSelectImage.Text = "Select Image";
                IsBusy = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
