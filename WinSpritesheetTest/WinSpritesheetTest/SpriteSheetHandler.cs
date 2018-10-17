using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinSpritesheetTest
{
   
    class SpriteSheetHandler
    {

        //w: 32px h: 65px
    
      static  Bitmap sheet;
       static int fWidth, fHeight;
      static  int framesPerRow, framesPerCol;
      static  int nextFrame;
        static int endFrame;
        static int row;
        public Bitmap curState;
        public Bitmap flipedState;
        static int startF;
        public SpriteSheetHandler(string path, int width, int height)
        {
            sheet = new Bitmap(path);
            fWidth = width;
            fHeight = height;
            framesPerRow = sheet.Width / fWidth;
            framesPerCol = sheet.Height / fHeight;
            curState = new Bitmap(path);
        }

        public void InitialiseSprite(int frameSpeed, int startingFrame, int currentEndFrame, int curRow)
        {
            startF = startingFrame;
            nextFrame = startingFrame ;
            endFrame = currentEndFrame;
            row = curRow;
        }

        public void playSprite(bool fliped)
        {
            


            if (nextFrame<=endFrame)
            {

           
                    Rectangle cloneRect = new Rectangle(nextFrame  * fWidth,row * fHeight, fWidth, fHeight);
                    System.Drawing.Imaging.PixelFormat pFormat = sheet.PixelFormat;
                     curState = sheet.Clone(cloneRect, pFormat);
                nextFrame+=1;
                if (fliped)
                {
                    curState.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    flipedState = curState;
                }
                //System.Threading.Thread.Sleep(1000);
            }
            else
            {
                nextFrame = startF;
                commitmergeissuetest();
            }
            }
        public void commitmergeissuetest()
        {
            Environment.Exit(1);



        }
        }
    }