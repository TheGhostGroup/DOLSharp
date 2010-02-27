/*
 * DAWN OF LIGHT - The first free open source DAoC server emulator
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 *
 */
using System;

using DOL.Database;
using DOL.Database.Attributes;

namespace DOL.Database
{
	/// <summary>
	/// Stores battleground info
	/// </summary>
	[DataTable(TableName = "Battleground")]
	public class Battleground : DataObject
	{
		private ushort m_region;
		private byte m_minLevel;
		private byte m_maxLevel;
		private byte m_maxRealmLevel;

		private static bool m_autoSave = false;

		/// <summary>
		/// Auto save this table
		/// </summary>
		override public bool AutoSave
		{
			get
			{
				return m_autoSave;
			}
			set
			{
				m_autoSave = value;
			}
		}

		/// <summary>
		/// Battleground region ID
		/// </summary>
		[DataElement(AllowDbNull = false)]
		public ushort RegionID
		{
			get
			{
				return m_region;
			}
			set
			{
				Dirty = true;
				m_region = value;
			}
		}

		/// <summary>
		/// The minimum level allowed in the battleground
		/// </summary>
		[DataElement(AllowDbNull = false)]
		public byte MinLevel
		{
			get
			{
				return m_minLevel;
			}
			set
			{
				Dirty = true;
				m_minLevel = value;
			}
		}

		/// <summary>
		/// The maximum level allowed in the battleground
		/// </summary>
		[DataElement(AllowDbNull = false)]
		public byte MaxLevel
		{
			get
			{
				return m_maxLevel;
			}
			set
			{
				Dirty = true;
				m_maxLevel = value;
			}
		}

		/// <summary>
		/// The maximum realm level allowed in the battleground
		/// </summary>
		[DataElement(AllowDbNull = false)]
		public byte MaxRealmLevel
		{
			get
			{
				return m_maxRealmLevel;
			}
			set
			{
				Dirty = true;
				m_maxRealmLevel = value;
			}
		}
	}
}