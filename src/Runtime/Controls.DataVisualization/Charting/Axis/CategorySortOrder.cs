﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

#if MIGRATION
namespace System.Windows.Controls.DataVisualization.Charting
#else
namespace Windows.UI.Xaml.Controls.DataVisualization.Charting
#endif
{
    /// <summary>
    /// The sort order to use when sorting categories.
    /// </summary>
    public enum CategorySortOrder
    {
        /// <summary>
        /// No sort order.
        /// </summary>
        None,

        /// <summary>
        /// Ascending sort order.
        /// </summary>
        Ascending,

        /// <summary>
        /// Descending sort order.
        /// </summary>
        Descending
    }
}