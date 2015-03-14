﻿/*
 *   PraiseBase Presenter
 *   The open source lyrics and image projection software for churches
 *
 *   http://praisebase.org
 *
 *   This program is free software; you can redistribute it and/or
 *   modify it under the terms of the GNU General Public License
 *   as published by the Free Software Foundation; either version 2
 *   of the License, or (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program; if not, write to the Free Software
 *   Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 *
 */

namespace PraiseBase.Presenter.Model.Song
{
    /// <summary>
    ///     Most songs come from some sort of collection of songs, be it a book or a
    ///     folder of some sort. It may be useful to track where the song comes from
    /// </summary>
    public class SongBook
    {
        /// <summary>
        ///     The name of a song book
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The index of the song
        /// </summary>
        public string Entry { get; set; }

        protected bool Equals(SongBook other)
        {
            return string.Equals(Name, other.Name) && string.Equals(Entry, other.Entry);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((SongBook) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0)*397) ^ (Entry != null ? Entry.GetHashCode() : 0);
            }
        }
    }
}