using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Yolov5Net.Scorer;


namespace InferenceV
{
    public class YoloPredictor
    {
        public YoloPredictor()
        {
            Scorer = new YoloScorer<YoloVModel>("../../../Assets/Weights/best.onnx");
        }
        private Bitmap GetScreenshot()
        {
            Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bm);
            g.CopyFromScreen(0, 0, 0, 0, bm.Size);
            return bm;
        }
        public List<YoloPrediction> GetPredictions()
        {
            //var image = Image.FromFile("../../../Assets/test.png");
            var image = GetScreenshot();
            List<YoloPrediction> predictions = Scorer.Predict(image);
            return predictions;
        }
        readonly YoloScorer<YoloVModel> Scorer;
    }
}
