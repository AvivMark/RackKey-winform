using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackKeyV07
{
    public enum DecorationType
    {
        Door = 0,
        TV = 1,
        Chair = 2,
        Computer = 3,
        Table = 4
    }                           
    

    public class DecorationHelper
    {
        private Dictionary<DecorationType, Image> _map;
        public DecorationHelper()
        {
            _map = new Dictionary<DecorationType, Image>()
                       {
                           {DecorationType.Door, Properties.Resources.Door},
                           {DecorationType.Chair, Properties.Resources.Chair},
                           {DecorationType.Computer, Properties.Resources.Computer},
                           {DecorationType.Table, Properties.Resources.Table},
                           {DecorationType.TV, Properties.Resources.TV},
                       };

        }

        public Image GetImageForType(DecorationType type)
        {
            return _map[type];
        }
    }

    public class AngleHelper
    {
        private Dictionary<int,RotateFlipType> _map;
        public AngleHelper()
        {
            _map = new Dictionary<int, RotateFlipType>()
                       {
                           {0,RotateFlipType.RotateNoneFlipNone},
                           {90,RotateFlipType.Rotate90FlipNone},
                           {180,RotateFlipType.Rotate180FlipNone},
                           {270,RotateFlipType.Rotate270FlipNone},
                       };

        }

        public RotateFlipType GetRotate(int angle)
        {
            return _map[angle];
        }
    }

    public class Decoration
    {
        public int angle;
        public AngleHelper RotateAngle = new AngleHelper();

        public DecorationHelper typeHelper = new DecorationHelper();
        public PictureBox picture;
        public DecorationType type;
        public int id;
        public static int sumDecorations = 0;
        public Decoration(DecorationType Dectype,Point p,Size s,int angle)
        {
            sumDecorations++;
            picture = new PictureBox();
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Size = s;
            picture.Location = p;
            this.angle = angle;
            this.type = Dectype;            
            picture.Image = typeHelper.GetImageForType(Dectype);
            this.SetAngle(angle);


        }
        public void RotateRight()
        {
            if (angle == 0)
            {
                angle = 270;
            }
            else
            {
                if (angle == 270)
                {
                    angle = 180;
                }
                else
                {
                    if (angle == 180)
                    {
                        angle = 90;
                    }
                    else
                    {
                        if (angle == 90)
                        {
                            angle = 0;
                        }
                    }
                }
            }                        
            Bitmap bitmap = new Bitmap(picture.Image);
            bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            picture.Image = bitmap;
            if (angle == 360)
            {
                angle = 0;
            }
        }

        public void RotateLeft()
        {
            if (angle == 0)
            {
                angle = 90;
            }
            else
            {
                if (angle == 90)
                {
                    angle = 180;
                }
                else
                {
                    if (angle == 180)
                    {
                        angle = 270;
                    }
                    else
                    {
                        if (angle == 270)
                        {
                            angle = 0;
                        }
                    }
                }
            }
            Bitmap bitmap = new Bitmap(picture.Image);
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picture.Image = bitmap;
            if (angle == 360)
            {
                angle = 0;
            }
        }
        public void SetAngle(int RotationAngle)
        {
            angle = RotationAngle;
            RotateFlipType rotateFlip = RotateAngle.GetRotate(angle);
            picture.Image.RotateFlip(rotateFlip);
        }
        public Decoration(DecorationType type):
            this(type,new Point(500,500), new Size(100,100),0)
        {

        }

    }
}
