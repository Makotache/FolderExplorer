using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer
{
    public class Enums
    {
        public static readonly TypeElement[] AllTypeElements = Enum.GetValues(typeof(TypeElement)).Cast<TypeElement>().ToArray();

        public static BoolTripleValue ToBoolTripleValue(string value)
        {
            if (value.ToLower() == BoolTripleValue.True.ToString().ToLower())
            {
                return BoolTripleValue.True;
            }
            else if (value.ToLower() == BoolTripleValue.False.ToString().ToLower())
            {
                return BoolTripleValue.False;
            }
            else
            {
                return BoolTripleValue.Undefined;
            }
        }

        public static TypeElement ToTypeElement(string type)
        {
            string str_end = type.Substring(1);

            return AllTypeElements.Where(te => te.ToString() == type[0].ToString().ToUpper() + str_end).First();
        }

        public static SortDirection NextSortDirection(SortDirection currentSortDirection)
        {
            if (currentSortDirection == SortDirection.Ascending)
            {
                return SortDirection.Descending;
            }
            else if (currentSortDirection == SortDirection.Descending)
            {
                return SortDirection.None;
            }
            else //None
            { 
                return SortDirection.Ascending;
            }
        }
    }

    public enum BoolTripleValue
    {
        True,
        False,
        Undefined
    }

    public enum TypeElement
    {
        Folder,
        OtherFile,
        Image,
        Music,
        Video
    }

    public enum MetaDataElement
    {
        Name = 0,
        Size,
        ItemType,
        LastWriteTime,
        CreationTime,
        LastAccessTime,
        Attribute,
        OfflineStatus,
        Availability,
        IdentifiedType,
        Owner,
        Kind,
        DateTaken,
        ContributingArtists,
        Album,
        Year,
        Genre,
        Conductors,
        Tags,
        Rating,
        Authors,
        Title,
        Subject,
        Categories,
        Comments,
        Copyright,
        TrackNumber,
        Duration,
        BitRate,
        Protected,
        CameraModel,
        Dimensions,
        CameraMaker,
        Company,
        FileDescription
    }

    public enum SortDirection
    {
        Ascending,
        Descending,
        None
    }
}
