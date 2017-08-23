﻿/*
 * Copyright (c) 2017 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Contracts.Configuration;

namespace SafeExamBrowser.Browser
{
	public class BrowserApplicationInfo : IApplicationInfo
	{
		public string Name => "Safe Exam Browser";
		public string Tooltip => Name;
		public IIconResource IconResource { get; } = new BrowserIconResource();
	}
}
