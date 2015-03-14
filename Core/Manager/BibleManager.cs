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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using PraiseBase.Presenter.Model.Bible;
using PraiseBase.Presenter.Persistence.ZefaniaXML;

namespace PraiseBase.Presenter.Manager
{
    /// <summary>
    ///     Holds a list of all songs and provides
    ///     searching in the songlist
    /// </summary>
    public class BibleManager
    {
        public enum BiblePassageSearchStatus
        {
            Ongoing,
            Found,
            NotFound
        }

        private readonly string _bibleDirectory;

        /// <summary>
        ///     The constructor
        /// </summary>
        public BibleManager(String bibleDirectory)
        {
            _bibleDirectory = bibleDirectory;
        }

        /// <summary>
        ///     List of all availabe songs
        /// </summary>
        public Dictionary<string, BibleItem> BibleList { get; protected set; }

        /// <summary>
        ///     Gets or sets the current song object
        /// </summary>
        public BibleItem CurrentBible { get; set; }

        public List<string> GetBibleFiles()
        {
            var di = new DirectoryInfo(_bibleDirectory);
            if (!di.Exists)
            {
                di.Create();
            }
            var rgFiles = di.GetFiles("*.xml");
            return rgFiles.Select(fi => fi.FullName).ToList();
        }

        public void LoadBibleInfo()
        {
            BibleList = new Dictionary<string, BibleItem>();
            foreach (var file in GetBibleFiles())
            {
                var rdr = new XMLBibleReader();
                try
                {
                    var bi = new BibleItem
                    {
                        Bible = rdr.LoadMeta(file),
                        Filename = file
                    };
                    BibleList.Add(bi.Bible.Identifier ?? bi.Filename, bi);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void LoadBibleData(string key)
        {
            var rdr = new XMLBibleReader();
            try
            {
                rdr.LoadContent(BibleList[key].Filename, BibleList[key].Bible);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private List<BibleBook> SearchBookCandiates(Bible bible, string needle)
        {
            var bkCandidates = new List<BibleBook>();
            foreach (var bk in bible.Books)
            {
                if (needle.Length <= bk.Name.Length && needle == bk.Name.ToLower().Substring(0, needle.Length))
                {
                    bkCandidates.Add(bk);
                }
            }
            return bkCandidates;
        }

        public BiblePassageSearchResult SearchPassage(Bible bible, string needle)
        {
            var result = new BiblePassageSearchResult
            {
                Status = BiblePassageSearchStatus.Ongoing,
                Passage = new BiblePassage()
            };

            // Book only
            var match = Regex.Match(needle, @"^(.*[a-z])$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                var bkCandidates = SearchBookCandiates(bible, match.Groups[1].Value);
                if (bkCandidates.Count == 1)
                {
                    result.Passage.Book = bkCandidates[0];
                    result.Status = BiblePassageSearchStatus.Found;
                }
                else if (bkCandidates.Count == 0)
                {
                    result.Status = BiblePassageSearchStatus.NotFound;
                }
                return result;
            }

            // Book and chapter
            match = Regex.Match(needle, @"^(.*[a-z]) ([0-9]+)$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                var bkCandidates = SearchBookCandiates(bible, match.Groups[1].Value);
                if (bkCandidates.Count == 1)
                {
                    result.Passage.Book = bkCandidates[0];

                    var chapterNumber = int.Parse(match.Groups[2].Value);
                    if (chapterNumber > 0 && chapterNumber <= result.Passage.Book.Chapters.Count)
                    {
                        result.Passage.Chapter = result.Passage.Book.Chapters[chapterNumber - 1];
                        result.Status = BiblePassageSearchStatus.Found;
                    }
                    else
                    {
                        result.Status = BiblePassageSearchStatus.NotFound;
                    }
                }
                else if (bkCandidates.Count == 0)
                {
                    result.Status = BiblePassageSearchStatus.NotFound;
                }
                return result;
            }

            // Book and chapter and verse
            match = Regex.Match(needle, @"^(.*[a-z]) ([0-9]+),([0-9]+)$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                var bkCandidates = SearchBookCandiates(bible, match.Groups[1].Value);
                if (bkCandidates.Count == 1)
                {
                    result.Passage.Book = bkCandidates[0];

                    var chapterNumber = int.Parse(match.Groups[2].Value);
                    if (chapterNumber > 0 && chapterNumber <= result.Passage.Book.Chapters.Count)
                    {
                        result.Passage.Chapter = result.Passage.Book.Chapters[chapterNumber - 1];

                        var verseNumber = int.Parse(match.Groups[3].Value);
                        if (verseNumber > 0 && verseNumber <= result.Passage.Chapter.Verses.Count)
                        {
                            result.Passage.Verse = result.Passage.Chapter.Verses[verseNumber - 1];
                            result.Status = BiblePassageSearchStatus.Found;
                        }
                        else
                        {
                            result.Status = BiblePassageSearchStatus.NotFound;
                        }
                    }
                    else
                    {
                        result.Status = BiblePassageSearchStatus.NotFound;
                    }
                }
                else if (bkCandidates.Count == 0)
                {
                    result.Status = BiblePassageSearchStatus.NotFound;
                }
                return result;
            }

            return result;
        }

        /// <summary>
        ///     Song item structure
        /// </summary>
        public struct BibleItem
        {
            public Bible Bible { get; set; }
            public string Filename { get; set; }

            public override string ToString()
            {
                return Bible.Title;
            }
        }

        public struct BiblePassageSearchResult
        {
            public BiblePassage Passage { get; set; }
            public BiblePassageSearchStatus Status { get; set; }
        }

        public class BiblePassage
        {
            public BibleBook Book { get; set; }
            public BibleChapter Chapter { get; set; }
            public BibleVerse Verse { get; set; }
        }
    }
}