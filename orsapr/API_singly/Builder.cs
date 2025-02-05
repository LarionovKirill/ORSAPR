﻿using System;
using System.Collections.Generic;
using KompasAPI7;
using Logic;

namespace API_singly
{
    /// <summary>
    /// Класс для построения табурета
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Объект обертки для работы с API
        /// </summary>
        private Wrapper _wrapper;

        /// <summary>
        /// Конструктор класса Builder, инициализирует обертку
        /// </summary>
        public Builder()
        {
            _wrapper = new Wrapper();
        }

        /// <summary>
        /// Метод для построения табурета с заданными параметрами,
        /// типом сиденья и ножек
        /// </summary>
        /// <param name="parameters">Параметры табурета</param>
        /// <param name="seatType">Тип сиденья</param>
        /// <param name="legType">Тип ножек</param>
        public void Build(Parameters parameters)
        {
            if (!_wrapper.IsKompasOpened())
            {
                _wrapper.OpenCad();
            }

            IPart7 part = _wrapper.CreatePart();
            BuildSeat(part, parameters);
            BuildLegs(part, parameters);
        }

        /// <summary>
        /// Метод для построения сиденья табурета
        /// </summary>
        /// <param name="part">Часть табурета, к которой добавляется 
        /// сиденье</param>
        /// <param name="parameters">Параметры конструкции</param>
        /// <param name="type">Тип сиденья</param>
        private void BuildSeat(IPart7 part, Parameters parameters)
        {
            ISketch sketch = _wrapper.CreateSketch(part, "Эскиз: сидушка");
            switch (parameters.SeatType)
            {
                case SeatTypes.SquareSeat:
                {
                    _wrapper.CreateRectangle(
                        sketch, 
                        0, 
                        0, 
                        parameters.SeatWidth, 
                        parameters.SeatLength);
                    break;
                }
                case SeatTypes.RoundSeat:
                {
                    _wrapper.CreateCircle(
                        sketch,
                        0, 
                        0, 
                        parameters.SeatWidth);
                    break;
                }
            }

            _wrapper.ExtrudeSketch(
                sketch, 
                parameters.SeatThickness, 
                "Сидушка", 
                false);
        }

        /// <summary>
        /// Вычисление координат для построение ножек.
        /// </summary>
        /// <param name="parameters">Параметры для построения.</param>
        /// <returns>Список координат ножек.</returns>
        private List<Tuple<int, int>> CalculateCoordinates(Parameters parameters)
        {
            if (parameters.SeatType == SeatTypes.SquareSeat)
            {
                return new List<Tuple<int, int>>
                {
                    new Tuple<int, int>(0, 0),
                    new Tuple<int, int>(
                    parameters.SeatWidth - parameters.LegWidth,
                        0),
                    new Tuple<int, int>(
                    0,
                    parameters.SeatLength - parameters.LegWidth),
                    new Tuple<int, int>(
                    parameters.SeatWidth - parameters.LegWidth,
                    parameters.SeatLength - parameters.LegWidth)
                };
            }

            return new List<Tuple<int, int>>
            {
                new Tuple<int, int>(
                    -parameters.SeatWidth / 2,
                    -parameters.LegWidth / 2),
                new Tuple<int, int>(
                   -parameters.LegWidth / 2,
                   -parameters.SeatLength / 2),
                new Tuple<int, int>(
                    parameters.SeatWidth / 2 - parameters.LegWidth,
                    -parameters.LegWidth / 2),
                new Tuple<int, int>(
                    -parameters.LegWidth / 2 ,
                    parameters.SeatLength / 2 - parameters.LegWidth)
            };
        }

        /// <summary>
        /// Метод для построения ножек табурета
        /// </summary>
        /// <param name="part">Часть табурета, к которой добавляются ножки</param>
        /// <param name="parameters">Параметры конструкции</param>
        private void BuildLegs(IPart7 part, Parameters parameters)
        {
            int legNumber = 0;
            legNumber++;
            ISketch legSketch = _wrapper.CreateSketch(
                part, 
                "Эскиз: Ножка " + legNumber);

            var coordinates = CalculateCoordinates(parameters);

            foreach (var point in coordinates)
            {
                switch (parameters.LegsType)
                {
                    case LegTypes.SquareLeg:
                    {
                        _wrapper.CreateRectangle(
                            legSketch,
                            point.Item1,
                            point.Item2,
                            parameters.LegWidth,
                            parameters.LegWidth);
                        break;
                    }
                    case LegTypes.RoundLeg:
                    {
                        _wrapper.CreateCircle(
                            legSketch,
                            point.Item1 + parameters.LegWidth / 2,
                            point.Item2 + parameters.LegWidth / 2,
                            parameters.LegWidth);
                        break;
                    }
                }
                _wrapper.ExtrudeSketch(
                    legSketch,
                    -parameters.LegLength,
                    "Элемент выдавливания: Ножка " + legNumber,
                    false);
            }
        }
    }
}
