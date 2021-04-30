﻿using System.Windows.Controls;

namespace NiceMeter.ViewModels
{
    public interface IUnit
    {
        /// <summary>
        /// Use the internal Converter object to convert to a TextBlock object
        /// </summary>
        /// <returns></returns>
        TextBlock Convert();
    }
}
