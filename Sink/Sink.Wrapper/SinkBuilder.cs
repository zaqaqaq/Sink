using Sink.Model;

namespace Sink.Wrapper
{
    /// <summary>
    /// Класс построения раковины.
    /// </summary>
    public class SinkBuilder
    {
        /// <summary>
        /// Объект связи с API.
        /// </summary>
        private readonly KompasWrapper _wrapper = new KompasWrapper();

        /// <summary>
        /// Метод для создания раковины.
        /// </summary>
        public void BuildSink(SinkParameter parameters)
        {
            _wrapper.StartKompas();
            _wrapper.CreateDocument();
            _wrapper.SetDetailProperties();
            var widthSink = parameters.WidthSink;
            var lengthSink = parameters.LengthSink;
            var heightSink = parameters.HeightSink;
            var radSink = parameters.RadSink;
            var radTapSink = parameters.RadTapSink;
            var filterSinkX = parameters.FilterSinkX;
            var filterSinkY = parameters.FilterSinkY;
            BuildMainBody(widthSink, lengthSink, heightSink);
            BuildSinkFillets(lengthSink, heightSink);
            BuildHoles(lengthSink, heightSink, radSink, radTapSink, filterSinkX, filterSinkY);
        }

        /// <summary>
        /// Создание основного тела раковины.
        /// </summary>
        /// <param name="widthSink">Ширина раковины.</param>
        /// <param name="lengthSink">Длина раковины.</param>
        /// <param name="heightSink">Высота раковины.</param>
        private void BuildMainBody(double widthSink, double lengthSink,
            double heightSink)
        {
            // Построение внешней части раковины.

            // Координаты отрезков внешнего основания раковины.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            double[,,] externalCaseSegments =
            {
                {
                    { -widthSink / 2 + 40, -lengthSink / 2 },
                    { widthSink / 2 - 40, -lengthSink / 2 }
                },
                {
                    { widthSink / 2, -lengthSink / 2 + 40 },
                    { widthSink / 2, lengthSink / 2 - 40 }
                },
                {
                    { widthSink / 2 - 40, lengthSink / 2 },
                    { -widthSink / 2 + 40, lengthSink / 2 }
                },
                {
                    { -widthSink / 2, lengthSink / 2 - 40 },
                    { -widthSink / 2, -lengthSink / 2 + 40 }
                }
            };

            // Параметры дуг внешнего основания раковины.
            // 0 элемент - центр дуги по X.
            // 1 элемент - центр дуги по Y.
            // 2 элемент - радиус дуги.
            // 3 элемент - координата начала по X.
            // 4 элемент - координата начала по Y.
            // 5 элемент - координата конца по X.
            // 6 элемент - координата конца по Y.
            // 7 элемент - направление дуги.
            double[,] externalCaseArcs =
            {
                {-widthSink / 2 + 40, lengthSink / 2 - 40, 40,
                    -widthSink / 2, lengthSink / 2 - 40,
                    -widthSink / 2 + 40, lengthSink / 2, -1 },
                { widthSink / 2 - 40, lengthSink / 2 - 40, 40,
                    widthSink / 2, lengthSink / 2 - 40,
                    widthSink / 2 - 40, lengthSink / 2, 1},
                { widthSink / 2 - 40, -lengthSink / 2 + 40, 40,
                    widthSink / 2, -lengthSink / 2 + 40,
                    widthSink / 2 - 40, -lengthSink / 2, -1 },
                { -widthSink / 2 + 40, -lengthSink / 2 + 40, 40,
                    -widthSink / 2 + 40, -lengthSink / 2,
                    -widthSink / 2, -lengthSink / 2 + 40, -1 }
            };
            var sketch =
                _wrapper.CreateRoundedRectangle(externalCaseSegments, externalCaseArcs);
            _wrapper.ExtrudeSketch(sketch, heightSink);

            // Построение среднего наружного углубления раковины.

            // Координаты внешнего основания раковины в виде прямоугольника.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            double[,,] externalRectangleSegments =
            {
                {
                    { -widthSink / 2, -lengthSink / 2 },
                    { widthSink / 2, -lengthSink / 2 }
                },
                {
                    { widthSink / 2, -lengthSink / 2 },
                    { widthSink / 2, lengthSink / 2 }
                },
                {
                    { widthSink / 2, lengthSink / 2 },
                    { -widthSink / 2, lengthSink / 2 }
                },
                {
                    { -widthSink / 2, lengthSink / 2 },
                    { -widthSink / 2, -lengthSink / 2 }
                }
            };

            // Координаты отрезков выреза среднего наружного углубления.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            double[,,] middleCaseSegments =
            {
                {
                    { -widthSink / 2 + 50, -lengthSink / 2 + 10 },
                    { widthSink / 2 - 50, -lengthSink / 2 + 10 }
                },
                {
                    { widthSink / 2 - 10, -lengthSink / 2 + 50 },
                    { widthSink / 2 - 10, lengthSink / 2 - 50 }
                },
                {
                    { widthSink / 2 - 50, lengthSink / 2 - 10 },
                    { -widthSink / 2 + 50, lengthSink / 2 - 10 }
                },
                {
                    { -widthSink / 2 + 10, lengthSink / 2 - 50 },
                    { -widthSink / 2 + 10, -lengthSink / 2 + 50 }
                }
            };

            // Параметры дуг выреза среднего наружного углубления.
            // 0 элемент - центр дуги по X.
            // 1 элемент - центр дуги по Y.
            // 2 элемент - радиус дуги.
            // 3 элемент - координата начала по X.
            // 4 элемент - координата начала по Y.
            // 5 элемент - координата конца по X.
            // 6 элемент - координата конца по Y.
            // 7 элемент - направление дуги.
            double[,] middleCaseArcs =
            {
                {-widthSink / 2 + 50, lengthSink / 2 - 50, 40,
                    -widthSink / 2 + 10, lengthSink / 2 - 50,
                    -widthSink / 2 + 50, lengthSink / 2 - 10, -1 },
                { widthSink / 2 - 50, lengthSink / 2 - 50, 40,
                    widthSink / 2 - 10, lengthSink / 2 - 50,
                    widthSink / 2 - 50, lengthSink / 2 - 10, 1 },
                { widthSink / 2 - 50, -lengthSink / 2 + 50, 40,
                    widthSink / 2 - 10, -lengthSink / 2 + 50,
                    widthSink / 2 - 50, -lengthSink / 2 + 10, -1 },
                { -widthSink / 2 + 50, -lengthSink / 2 + 50, 40,
                    -widthSink / 2 + 50, -lengthSink / 2 + 10,
                    -widthSink / 2 + 10, -lengthSink / 2 + 50, -1 }
            };

            // 3D-координата внешней нижней точки раковины. 
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            // 2 элемент - координата по Z.
            double[] bottomSinkCoordinates =
            {
                0, 0, -heightSink
            };
            sketch =
                _wrapper.CreateRectangleWithCutout(bottomSinkCoordinates,
                    externalRectangleSegments,
                middleCaseSegments, middleCaseArcs);
            _wrapper.CutExtrusion(sketch, heightSink - 10);

            // Построение внутреннего наружного углубления раковины.

            // Координаты среднего основания раковины в виде прямоугольника.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            double[,,] middleRectangleSegments =
            {
                {
                    { -widthSink / 2 + 10, -lengthSink / 2 + 10 },
                    { widthSink / 2 - 10, -lengthSink / 2 + 10 }
                },
                {
                    { widthSink / 2 - 10, -lengthSink / 2 + 10 },
                    { widthSink / 2 - 10, lengthSink / 2 - 10 }
                },
                {
                    { widthSink / 2 - 10, lengthSink / 2 - 10 },
                    { -widthSink / 2 + 10, lengthSink / 2 - 10 }
                },
                {
                    { -widthSink / 2 + 10, lengthSink / 2 - 10 },
                    { -widthSink / 2 + 10, -lengthSink / 2 + 10 }
                }
            };

            // Координаты отрезков наружного внутреннего углубления раковины.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            double[,,] innerCaseSegments =
            {
                {
                    { -widthSink / 2 + 90, -lengthSink / 2 + 30 },
                    { widthSink / 2 - 90, -lengthSink / 2 + 30 }
                },
                {
                    { widthSink / 2 - 50, -lengthSink / 2 + 70 },
                    { widthSink / 2 - 50, lengthSink / 2 - 160 }
                },
                {
                    { widthSink / 2 - 90, lengthSink / 2 - 120 },
                    { -widthSink / 2 + 90, lengthSink / 2 - 120 }
                },
                {
                    { -widthSink / 2 + 50, lengthSink / 2 - 160 },
                    { -widthSink / 2 + 50, -lengthSink / 2 + 70 }
                }
            };

            // Параметры дуг наружного внутреннего углубления раковины.
            // 0 элемент - центр дуги по X.
            // 1 элемент - центр дуги по Y.
            // 2 элемент - радиус дуги.
            // 3 элемент - координата начала по X.
            // 4 элемент - координата начала по Y.
            // 5 элемент - координата конца по X.
            // 6 элемент - координата конца по Y.
            // 7 элемент - направление дуги.
            double[,] innerCaseArcs =
            {
                {-widthSink / 2 + 90, lengthSink / 2 - 160, 40,
                    -widthSink / 2 + 50, lengthSink / 2 - 160,
                    -widthSink / 2 + 90, lengthSink / 2 - 120, -1 },
                { widthSink / 2 - 90, lengthSink / 2 - 160, 40,
                    widthSink / 2 - 50, lengthSink / 2 - 160,
                    widthSink / 2 - 90, lengthSink / 2 - 120, 1 },
                { widthSink / 2 - 90, -lengthSink / 2 + 70, 40,
                    widthSink / 2 - 50, -lengthSink / 2 + 70,
                    widthSink / 2 - 90, -lengthSink / 2 + 30, -1 },
                { -widthSink / 2 + 90, -lengthSink / 2 + 70, 40,
                    -widthSink / 2 + 90, -lengthSink / 2 + 30,
                    -widthSink / 2 + 50, -lengthSink / 2 + 70, -1 },
            };
            sketch =
                _wrapper.CreateRectangleWithCutout(bottomSinkCoordinates,
                    middleRectangleSegments,
                innerCaseSegments, innerCaseArcs);
            _wrapper.CutExtrusion(sketch, heightSink - 15);

            // Построение среднего внутреннего углубления раковины.

            sketch =
                _wrapper.CreateRoundedRectangle(middleCaseSegments, middleCaseArcs);
            _wrapper.CutExtrusion(sketch, 10);

            // Построение внутреннего углубления раковины.

            // Координаты отрезков внутреннего углубления раковины.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            double[,,] insideCaseSegments =
            {
                {
                    { -widthSink / 2 + 100, -lengthSink / 2 + 40 },
                    { widthSink / 2 - 100, -lengthSink / 2 + 40 }
                },
                {
                    { widthSink / 2 - 60, -lengthSink / 2 + 80 },
                    { widthSink / 2 - 60, lengthSink / 2 - 170 }
                },
                {
                    { widthSink / 2 - 100, lengthSink / 2 - 130 },
                    { -widthSink / 2 + 100, lengthSink / 2 - 130 }
                },
                {
                    { -widthSink / 2 + 60, lengthSink / 2 - 170 },
                    { -widthSink / 2 + 60 , -lengthSink / 2 + 80 }
                },
            };

            // Параметры дуг внутреннего углубления раковины.
            // 0 элемент - центр дуги по X.
            // 1 элемент - центр дуги по Y.
            // 2 элемент - радиус дуги.
            // 3 элемент - координата начала по X.
            // 4 элемент - координата начала по Y.
            // 5 элемент - координата конца по X.
            // 6 элемент - координата конца по Y.
            // 7 элемент - направление дуги.
            double[,] insideCaseArcs =
            {
                {-widthSink / 2 + 100, lengthSink / 2 - 170, 40,
                    -widthSink / 2 + 60, lengthSink / 2 - 170,
                    -widthSink / 2 + 100, lengthSink / 2 - 130, -1 },
                { widthSink / 2 - 100, lengthSink / 2 - 170, 40,
                    widthSink / 2 - 60, lengthSink / 2 - 170,
                    widthSink / 2 - 100, lengthSink / 2 - 130, 1 },
                { widthSink / 2 - 100, -lengthSink / 2 + 80, 40,
                    widthSink / 2 - 60, -lengthSink / 2 + 80,
                    widthSink / 2 - 100, -lengthSink / 2 + 40, -1 },
                { -widthSink / 2 + 100, -lengthSink / 2 + 80, 40,
                    -widthSink / 2 + 100, -lengthSink / 2 + 40,
                    -widthSink / 2 + 60, -lengthSink / 2 + 80, -1 },
            };
            sketch =
                _wrapper.CreateRoundedRectangle(insideCaseSegments, insideCaseArcs);
            _wrapper.CutExtrusion(sketch, heightSink - 20);
        }

        /// <summary>
        /// Создание скруглений раковины.
        /// </summary>
        /// <param name="lengthSink">Длина раковины.</param>
        /// <param name="heightSink">Высота раковины.</param>
        private void BuildSinkFillets(double lengthSink,
            double heightSink)
        {
            // Скругление низа раковины снаружи.

            // 3D-координата внешней нижней точки раковины.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            // 2 элемент - координата по Z.
            double[] bottomSinkCoordinates =
            {
                0, 0, -heightSink
            };
            _wrapper.CreateFillet(bottomSinkCoordinates, 40);

            // Скругление низа раковины изнутри.

            // 3D-координата внутренней нижней точки раковины.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            // 2 элемент - координата по Z.
            double[] insideSinkCoordinates =
            {
                0, 0, -heightSink + 20
            };
            _wrapper.CreateFillet(insideSinkCoordinates, 40);

            // Скругление углубления раковины.

            // 3D - координата грани углубления раковины.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            // 2 элемент - координата по Z.
            double[] innerRimCoordinates =
            {
                0, lengthSink/2 - 130, -heightSink / 2
            };
            _wrapper.CreateFillet(innerRimCoordinates, 10);
        }

        /// <summary>
        /// Построение отверстий раковины.
        /// </summary>
        /// <param name="lengthSink">Длина раковины.</param>
        /// <param name="heightSink">Высота раковины.</param>
        /// <param name="radSink">Диаметр отверстия слива.</param>
        /// <param name="radTapSink">Диаметр отверстия под кран.</param> 
        /// <param name="filterSinkX">Координата X отверстия под фильтр.</param>
        /// <param name="filterSinkY">Координата Y отверстия под фильтр.</param>
        private void BuildHoles(double lengthSink, double heightSink,
            double radSink, double radTapSink, double filterSinkX, double filterSinkY)
        {
            // Создание отверстия под кран.

            // Центр окружности крана.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            double[] tapCenter =
            {
                0, lengthSink/2 - 60
            };
            var sketch =
                _wrapper.CreateCircle(tapCenter, radTapSink / 2);
            _wrapper.CutExtrusion(sketch, heightSink);

            // Создание отверстия под фильтр.

            // Центр окружности крана.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            double[] filterCenter =
            {
                filterSinkX, filterSinkY
            };
            sketch =
                _wrapper.CreateCircle(filterCenter, 10);
            _wrapper.CutExtrusion(sketch, heightSink);

            // Создание отверстия под слив.

            // Центр окружности слива.
            // 0 элемент - координата по X.
            // 1 элемент - координата по Y.
            double[] drainCenter =
            {
                0, -20
            };
            sketch =
                _wrapper.CreateCircle(drainCenter, radSink / 2);
            _wrapper.CutExtrusion(sketch, heightSink);
        }
    }
}