﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Contracts.Configuration
{
	/// <summary>
	/// Defines all possible results of <see cref="IConfigurationRepository.LoadSettings(System.Uri)"/>.
	/// </summary>
	public enum LoadStatus
	{
		/// <summary>
		/// Indicates that an admin password is needed in order to load the settings.
		/// </summary>
		AdminPasswordNeeded = 1,

		/// <summary>
		/// Indicates that a resource does not comply with the required data format.
		/// </summary>
		InvalidData,

		/// <summary>
		/// Indicates that a settings password is needed in order to load the settings.
		/// </summary>
		SettingsPasswordNeeded,

		/// <summary>
		/// The <see cref="Settings.Settings"/> were loaded successfully.
		/// </summary>
		Success
	}
}