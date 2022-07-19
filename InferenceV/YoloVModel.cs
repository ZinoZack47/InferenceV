using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models.Abstract;

namespace InferenceV
{
 
    internal class YoloVModel : YoloModel
    {
        public override int Width { get; set; } = 1280;


        public override int Height { get; set; } = 1280;


        public override int Depth { get; set; } = 3;


        public override int Dimensions { get; set; } = 7;


        public override int[] Strides { get; set; } = new int[4] { 8, 16, 32, 64 };


        public override int[][][] Anchors { get; set; } = new int[4][][]
        {
            new int[3][]
            {
                new int[2] { 7, 8 },
                new int[2] { 13, 17 },
                new int[2] { 19, 30 }
            },
            new int[3][]
            {
                new int[2] { 33, 43 },
                new int[2] { 24, 65 },
                new int[2] { 34, 74 }
            },
            new int[3][]
            {
                new int[2] { 44, 125 },
                new int[2] { 66, 98 },
                new int[2] { 68, 167 }
            },
            new int[3][]
            {
                new int[2] { 101, 238 },
                new int[2] { 124, 334 },
                new int[2] { 228, 471 }
            }
        };


        public override int[] Shapes { get; set; } = new int[4] { 160, 80, 40, 20 };


        public override float Confidence { get; set; } = 0.2f;


        public override float MulConfidence { get; set; } = 0.25f;


        public override float Overlap { get; set; } = 0.45f;


        public override string[] Outputs { get; set; } = new string[1] { "output" };


        public override List<YoloLabel> Labels { get; set; } = new List<YoloLabel>
        {
            new YoloLabel
            {
                Id = 0,
                Name = "Enemy",
                Color = Color.Purple
            },
            new YoloLabel
            {
                Id = 1,
                Name = "Head",
                Color = Color.Red
            },
        };

        public override bool UseDetect { get; set; } = true;

    }
}
