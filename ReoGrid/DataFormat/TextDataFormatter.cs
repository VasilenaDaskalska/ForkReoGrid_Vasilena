﻿/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * https://reogrid.net/
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * Author: Jing Lu <jingwood at unvell.com>
 *
 * Copyright (c) 2012-2021 Jing Lu <jingwood at unvell.com>
 * Copyright (c) 2012-2016 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using unvell.ReoGrid.Core;
using unvell.ReoGrid.DataFormat;

namespace unvell.ReoGrid.DataFormat
{
	internal class TextDataFormatter : IDataFormatter
	{
		public FormatCellResult FormatCell(Cell cell)
		{
			if (cell.InnerStyle.HAlign == ReoGridHorAlign.General)
			{
				cell.RenderHorAlign = ReoGridRenderHorAlign.Left;
			}

			var text = Convert.ToString(cell.InnerData);
			return new FormatCellResult(text, text);
		}

		public bool PerformTestFormat()
		{
			return false;
		}
	}
}
