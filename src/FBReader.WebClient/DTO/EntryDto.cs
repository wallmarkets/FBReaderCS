/*
 * Author: CactusSoft (http://cactussoft.biz/), 2013
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA
 * 02110-1301, USA.
 */

using System.Xml.Serialization;

namespace FBReader.WebClient.DTO
{
    public class EntryDto
    {
        [XmlElement("title")]
        public TitleValueDto Title { get; set; }

        [XmlElement("link")]
        public LinkDto[] Links { get; set; }

        [XmlElement("updated")]
        public string Updated { get; set; }

        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("content")]
        public ContentDto Content { get; set; }

        [XmlElement("author")]
        public AuthorDto Author { get; set; }
    }
}