﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kompas6Constants3D;
using Kompas6API5;
using KompasAPI7;
using System.Drawing;

namespace Sink.Wrapper
{
    public class KompasSketch
    {
        /// <summary>
        /// 2D документ.
        /// </summary>
        private ksDocument2D _document2D;

        /// <summary>
        /// Определенный эскиз.
        /// </summary>
        private readonly ksSketchDefinition _sketchDefinition;

        /// <summary>
        /// Возвращает эскиз.
        /// </summary>
        public ksEntity Sketch
        {
            get;
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="part"></param>
        /// <param name="n">1 - ZY; 2 - ZX; 3 - XY -> Плоскости.</param>
        public KompasSketch(ksPart part, int n)
        {
            ksEntity plane;
            if (n == 1)
            {
                plane = (ksEntity)part.GetDefaultEntity((int)Obj3dType.o3d_planeYOZ);
            }
            else if (n == 2)
            {
                plane = (ksEntity)part.GetDefaultEntity((int)Obj3dType.o3d_planeXOZ);

            }
            else
            {
                plane = (ksEntity)part.GetDefaultEntity((int)Obj3dType.o3d_planeXOY);
            }
            Sketch = (ksEntity)part.NewEntity((int)Obj3dType.o3d_sketch);
            _sketchDefinition = (ksSketchDefinition)Sketch.GetDefinition();
            _sketchDefinition.SetPlane(plane);
            Sketch.Create();
            _document2D = (ksDocument2D)_sketchDefinition.BeginEdit();
        }

        /// <summary>
        /// Метод для прекращения редактирования.
        /// </summary>
        public void EndEdit()
        {
            _sketchDefinition.EndEdit();
        }

        /// <summary>
        /// Создание прямоугольника по двум точкам.
        /// </summary>
        /// <param name="point1"> Первая точка на плоскости</param>
        /// <param name="point2"> Вторая точка на плоскости</param>
        public void CreateTwoPointRectangle(PointF point1, PointF point2)
        {
            _document2D.ksLineSeg(point1.X, -point1.Y, point2.X, -point1.Y, 1);
            _document2D.ksLineSeg(point2.X, -point1.Y, point2.X, -point2.Y, 1);
            _document2D.ksLineSeg(point1.X, -point2.Y, point2.X, -point2.Y, 1);
            _document2D.ksLineSeg(point1.X, -point1.Y, point1.X, -point2.Y, 1);
        }
    }
}
