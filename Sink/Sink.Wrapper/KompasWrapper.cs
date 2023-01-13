using System;
using Kompas6Constants3D;
using Kompas6API5;
using System.Runtime.InteropServices;

namespace Sink.Wrapper
{
    //TODO: RSDN
    public class KompasWrapper
    {
        /// <summary>
        /// Объект Компас API.
        /// </summary>
        private KompasObject _kompas;

        /// <summary>
        /// Деталь.
        /// </summary>
        private ksPart _part;

        /// <summary>
        /// Документ-модель.
        /// </summary>
        private ksDocument3D _document;

        /// <summary>
        /// Запуск Компас-3D.
        /// </summary>
        public void StartKompas()
        {
            try
            {
                if (_kompas != null)
                {
                    _kompas.Visible = true;
                    _kompas.ActivateControllerAPI();
                }
                if (_kompas != null) return;
                var kompasType = Type.GetTypeFromProgID("KOMPAS.Application.5");
                _kompas = (KompasObject)Activator.CreateInstance(kompasType);
                StartKompas();
                if (_kompas == null)
                {
                    throw new Exception("Не удается открыть Компас-3D.");
                }
            }
            catch (COMException)
            {
                _kompas = null;
                StartKompas();
            }
        }

        /// <summary>
        /// Создание документа в Компас-3D.
        /// </summary>
        public void CreateDocument()
        {
            try
            {
                _document = (ksDocument3D)_kompas.Document3D();
                _document.Create();
                _document = (ksDocument3D)_kompas.ActiveDocument3D();
            }
            catch
            {
                throw new ArgumentException("Не удается построить деталь");
            }
        }

        /// <summary>
        /// Установка свойств детали.
        /// </summary>
        public void SetDetailProperties()
        {
            _part = (ksPart)_document.GetPart((short)Part_Type.pTop_Part);
            _part.name = "Sink";
            _part.Update();
        }

        /// <summary>
        /// Создание скругленного прямоугольника.
        /// </summary>
        /// <param name="segments">Координаты отрезков.</param>
        /// <param name="arcs">Параметры дуги.</param>
        /// <returns>Сформированный эскиз.</returns>
        public ksEntity CreateRoundedRectangle(double[,,] segments, double[,] arcs)
        {
            ksEntity sketch = _part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition definition = sketch.GetDefinition();
            ksEntity plane = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            definition.SetPlane(plane);
            sketch.Create();
            ksDocument2D sketchEdit = definition.BeginEdit();
            for (var i = 0; i < segments.GetLength(0); i++)
            {
                sketchEdit.ksLineSeg(segments[i, 0, 0], segments[i, 0, 1],
                    segments[i, 1, 0], segments[i, 1, 1], 1);
                sketchEdit.ksArcByPoint(arcs[i, 0], arcs[i, 1], arcs[i, 2],
                    arcs[i, 3], arcs[i, 4], arcs[i, 5], arcs[i, 6],
                    (short)arcs[i, 7], 1);
            }

            definition.EndEdit();
            return sketch;
        }

        /// <summary>
        /// Создание прямоугольника с вырезом.
        /// </summary>
        /// <param name="coordinates">3D-координата плоскости.</param>
        /// <param name="segments">Координаты прямоугольника.</param>
        /// <param name="cutoutSegments">Координаты отрезков выреза.</param>
        /// <param name="cutoutArcs">Параметры дуг выреза.</param>
        /// <returns>Сформированный эскиз.</returns>
        public ksEntity CreateRectangleWithCutout(double[] coordinates, double[,,] segments,
            double[,,] cutoutSegments, double[,] cutoutArcs)
        {
            ksEntity sketch = _part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition definition = sketch.GetDefinition();
            ksEntityCollection collection = _part.EntityCollection((short)Obj3dType.o3d_face);
            collection.SelectByPoint(coordinates[0], coordinates[1], coordinates[2]);
            ksEntity plane = collection.First();
            definition.SetPlane(plane);
            sketch.Create();
            ksDocument2D sketchEdit = definition.BeginEdit();
            for (var i = 0; i < segments.GetLength(0); i++)
            {
                sketchEdit.ksLineSeg(segments[i, 0, 0], segments[i, 0, 1],
                    segments[i, 1, 0], segments[i, 1, 1], 1);
                sketchEdit.ksLineSeg(cutoutSegments[i, 0, 0], cutoutSegments[i, 0, 1],
                    cutoutSegments[i, 1, 0], cutoutSegments[i, 1, 1], 1);
                sketchEdit.ksArcByPoint(cutoutArcs[i, 0], cutoutArcs[i, 1],
                    cutoutArcs[i, 2],
                    cutoutArcs[i, 3], cutoutArcs[i, 4],
                    cutoutArcs[i, 5], cutoutArcs[i, 6],
                    (short)cutoutArcs[i, 7], 1);
            }

            definition.EndEdit();
            return sketch;
        }

        /// <summary>
        /// Создание окружности.
        /// </summary>
        /// <param name="center">Координата центра окружности.</param>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Сформированный эскиз.</returns>
        public ksEntity CreateCircle(double[] center, double radius)
        {
            ksEntity sketch = _part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition definition = sketch.GetDefinition();
            ksEntity plane = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            definition.SetPlane(plane);
            sketch.Create();
            ksDocument2D sketchEdit = definition.BeginEdit();
            sketchEdit.ksCircle(center[0], center[1], radius, 1);
            definition.EndEdit();
            return sketch;
        }

        /// <summary>
        /// Создание скругление плоскости.
        /// </summary>
        /// <param name="coordinates">3D-координата плоскости.</param>
        /// <param name="radius">Радиус скругления.</param>
        public void CreateFillet(double[] coordinates, double radius)
        {
            ksEntity sketch = _part.NewEntity((short)Obj3dType.o3d_fillet);
            ksFilletDefinition definition = sketch.GetDefinition();
            definition.radius = radius;
            definition.tangent = true;
            ksEntityCollection array = definition.array();
            ksEntityCollection collection =
                _part.EntityCollection((short)Obj3dType.o3d_face);
            collection.SelectByPoint(coordinates[0], coordinates[1], coordinates[2]);
            ksEntity face = collection.First();
            array.Add(face);
            sketch.Create();
        }

        /// <summary>
        /// Выдавливание эскиза на определенное расстояние.
        /// </summary>
        /// <param name="sketch">Эскиз.</param>
        /// <param name="height">Высота выдавливания.</param>
        public void ExtrudeSketch(ksEntity sketch, double height)
        {
            ksEntity entity =
                (ksEntity)_part.NewEntity((short)Obj3dType.o3d_baseExtrusion);
            ksBaseExtrusionDefinition definition =
                (ksBaseExtrusionDefinition)entity.GetDefinition();
            definition.directionType = (short)Direction_Type.dtReverse;
            definition.SetSideParam(false, (short)End_Type.etBlind, height);
            definition.SetSketch(sketch);
            entity.Create();
        }

        /// <summary>
        /// Вырезание выдавливанием по эскизу.
        /// </summary>
        /// <param name="sketch">Эскиз.</param>
        /// <param name="height">Высота выдавливания.</param>
        public void CutExtrusion(ksEntity sketch, double height)
        {
            ksEntity entity =
                (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition definition =
                (ksCutExtrusionDefinition)entity.GetDefinition();
            definition.directionType = (short)Direction_Type.dtNormal;
            definition.SetSideParam(true, (short)End_Type.etBlind, height);
            definition.SetSketch(sketch);
            entity.Create();
        }
    }
}