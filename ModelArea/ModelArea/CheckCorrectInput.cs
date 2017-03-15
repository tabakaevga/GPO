﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    /// <summary>
    /// Статический класс, проверяющий корректность ввода входящих величин согласно требованиям к логике программы
    /// </summary>
    static class CheckCorrectInput
    {
        /// <summary>
        /// Метод, проверяющий корректность ввода вещественных чисел для сторон фигуры/радиуса окружности
        /// </summary>
        /// <param name="inputValue"> Входящая величина (сторона, радиус) </param>
        public static void CheckDouble(double inputValue)
        {
            if (double.IsNaN(inputValue) || double.IsInfinity(inputValue))
            {
                throw new ArgumentException($"Введенные данные - не вещественное число.");
            }
            if (inputValue <= 0)
            {
                throw new ArgumentOutOfRangeException($"Значение стороны/радиуса не может быть меньше либо равно 0");
            }
        }
    }
}
