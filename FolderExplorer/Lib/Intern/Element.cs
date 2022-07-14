using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using Shell32;
using System.Diagnostics;

namespace FolderExplorer
{
    public class Element
    {
        #region propriété normal

        //0
        public string name
        {
            get
            {
                if (isFile && _elementInfo.Name.Contains("."))
                { return _elementInfo.Name.Replace(_elementInfo.Extension, ""); }
                //dossier ou fichier sans non
                return _elementInfo.Name;
            }

            set => fullName = value + "." + extension;
        }

        //1
        public long size
        {
            get
            {
                if (isFile)
                { return ((FileInfo)_elementInfo).Length; }
                else
                {
                    //utiliser un thread pour la taille du dossier
                    return -1;
                }
            }
        }

        //2
        public string itemType { get; private set; }

        //3
        public DateTime lastWriteTime
        {
            get => _elementInfo.LastWriteTime;

            set => _elementInfo.LastWriteTime = value; 
        }

        //4
        public DateTime creationTime
        {
            get => _elementInfo.CreationTime;

            set => _elementInfo.CreationTime = value;
        }

        //5
        public DateTime lastAccessTime
        {
            get => _elementInfo.LastAccessTime; 

            set => _elementInfo.LastAccessTime = value;
        }

        //6
        public FileAttributes attribute
        {
            get => _elementInfo.Attributes;

            set => _elementInfo.Attributes = value;
        }

        //7
        public BoolTripleValue offlineStatus { get; private set; }

        //8
        public BoolTripleValue availability { get; private set; }


        //9
        public string identifiedType { get; private set; }

        //10
        public string owner
        {
            get
            {
                try
                {
                    if (isFile)
                    { return File.GetAccessControl(fullPath).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString(); }
                    return Directory.GetAccessControl(fullPath).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
                }
                catch
                {
                    return "";
                }
            }
        }

        //11
        public string kind { get; private set; }

        //12
        public string dateTaken { get; private set; }

        //13
        public string contributingArtists { get; private set; }

        //14
        public string album { get; private set; }

        //15
        public int year { get; private set; }

        //16
        public string genre { get; private set; }

        //17
        public string conductors { get; private set; }

        //18
        public string tags { get; private set; }

        //19
        public int rating { get; private set; }

        //20
        public string authors { get; private set; }

        //21
        public string title { get; private set; }

        //22
        public string subject { get; private set; }

        //23
        public string categories { get; private set; }

        //24
        public string comments { get; private set; }

        //25
        public string copyright { get; private set; }

        //26
        public int trackNumber { get; private set; }

        //27
        public TimeSpan duration { get; private set; }

        //28
        public int bitRate { get; private set; }

        //29
        public BoolTripleValue @protected { get; private set; }

        //30
        public string cameraModel { get; private set; }

        //31
        public Size dimensions { get; private set; }

        //32
        public string cameraMarker { get; private set; }

        //33
        public string company { get; private set; }

        //34
        public string fileDescription { get; private set; }

        #endregion


        #region mes propriétés

        public int sizeOnDisk { get; private set; }

        public string path { get; private set; }

        public string fullPath { get; private set; }

        public string fullName
        {
            get => _elementInfo.Name; 

            set
            {
                if (isFile)
                { File.Move(fullName, value); }
                else
                { Directory.Move(fullName, value); }
            }
        }

        public string extension
        {
            get => isFile ? _elementInfo.Extension.Replace(".", "") : "";

            set
            {
                if (isFile)
                { File.Move(_elementInfo.Name, _elementInfo.Name.Replace(extension, value)); }
            }
        }

        public TypeElement typeElement { get; private set; }

        private readonly FileSystemInfo _elementInfo;

        public bool isFile { get; private set; }

        public Bitmap icon { get; private set; }


        #endregion

        public Element(string fullPath, bool isFile)
        {
            this.fullPath = fullPath;
            this.isFile = isFile;

            if (this.isFile)
            {
                _elementInfo = new FileInfo(this.fullPath);
                typeElement = GetType();
            }
            else
            { _elementInfo = new DirectoryInfo(this.fullPath); }

            //récupération des en-têtes des données
            List<string> arrHeaders = new List<string>();

            Shell shell = new Shell();
            Folder objFolder = shell.NameSpace(Path.GetDirectoryName(this.fullPath));
            FolderItem folderItem = objFolder.ParseName(Path.GetFileName(this.fullPath));

            for (short i = 0; i < 35; i++)
            {
                string header = objFolder.GetDetailsOf(null, i);
                if (header == "")
                { break; }
                arrHeaders.Add(header);
            }

            //récupéartion des données lié aux en-têtes
            int val_int;

            //2
            itemType = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.ItemType);

            //7
            offlineStatus = Enums.ToBoolTripleValue(objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.OfflineStatus));

            //8
            availability = Enums.ToBoolTripleValue(objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Availability));

            //9
            identifiedType = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.IdentifiedType);

            //11
            kind = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Kind);

            //12
            dateTaken = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.DateTaken);

            //13
            contributingArtists = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.ContributingArtists);

            //14
            album = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Album);

            //15
            year = int.TryParse(objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Year), out val_int) ? val_int : -1;

            //16
            genre = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Genre);

            //17
            conductors = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Conductors);

            //18
            tags = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Tags);

            //19
            rating = int.TryParse(objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Rating), out val_int) ? val_int : -1;

            //20
            authors = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Authors);

            //21
            title = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Title);

            //22
            subject = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Subject);

            //23
            categories = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Categories);

            //24
            comments = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Comments);

            //25
            copyright = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Copyright);

            //26
            trackNumber = int.TryParse(objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.TrackNumber), out val_int) ? val_int : -1;

            //27
            string[] duration_arr = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Duration).Split(':');
            duration = duration_arr.Length == 3 ? new TimeSpan(int.Parse(duration_arr[0]), int.Parse(duration_arr[1]), int.Parse(duration_arr[1])) : new TimeSpan(0, 0, 0);

            //28
            bitRate = int.TryParse(objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.BitRate), out val_int) ? val_int : -1;

            //29
            @protected = Enums.ToBoolTripleValue(objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Protected));

            //30
            cameraModel = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.CameraModel);

            //31
            if (this.typeElement == TypeElement.Image)
            {
                Image image = new Bitmap(this.fullPath);
                dimensions = new Size(image.Width, image.Height);
            }
            else
            {
                dimensions = new Size(0, 0);
            }

            //32
            cameraMarker = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.CameraMaker);

            //33
            company = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.Company);

            //34
            fileDescription = objFolder.GetDetailsOf(folderItem, (int)MetaDataElement.FileDescription);

            path = this.fullPath.Replace("/" + fullName, "");
        }

        public object GetValue(MetaDataElement metaDataElement)
        {
            switch (metaDataElement)
            {
                //0
                case MetaDataElement.Name:
                    return name;

                //1
                case MetaDataElement.Size:
                    return size;

                //2
                case MetaDataElement.ItemType:
                    return itemType;

                //3
                case MetaDataElement.LastWriteTime:
                    return lastWriteTime;

                //4
                case MetaDataElement.CreationTime:
                    return creationTime;

                //5
                case MetaDataElement.LastAccessTime:
                    return lastAccessTime;

                //6
                case MetaDataElement.Attribute:
                    return attribute;

                //7
                case MetaDataElement.OfflineStatus:
                    return offlineStatus;

                //8
                case MetaDataElement.Availability:
                    return availability;

                //9
                case MetaDataElement.IdentifiedType:
                    return identifiedType;

                //10
                case MetaDataElement.Owner:
                    return owner;

                //11
                case MetaDataElement.Kind:
                    return kind;

                //12
                case MetaDataElement.DateTaken:
                    return dateTaken;

                //13
                case MetaDataElement.ContributingArtists:
                    return contributingArtists;

                //14
                case MetaDataElement.Album:
                    return album;

                //15
                case MetaDataElement.Year:
                    return year;

                //16
                case MetaDataElement.Genre:
                    return genre;

                //17
                case MetaDataElement.Conductors:
                    return conductors;

                //18
                case MetaDataElement.Tags:
                    return tags;

                //19
                case MetaDataElement.Rating:
                    return rating;

                //20
                case MetaDataElement.Authors:
                    return authors;

                //21
                case MetaDataElement.Title:
                    return title;

                //22
                case MetaDataElement.Subject:
                    return subject;

                //23
                case MetaDataElement.Categories:
                    return categories;

                //24
                case MetaDataElement.Comments:
                    return comments;

                //25
                case MetaDataElement.Copyright:
                    return copyright;

                //26
                case MetaDataElement.TrackNumber:
                    return trackNumber;

                //27
                case MetaDataElement.Duration:
                    return duration;

                //28
                case MetaDataElement.BitRate:
                    return bitRate;

                //29
                case MetaDataElement.Protected:
                    return @protected;

                //30
                case MetaDataElement.CameraModel:
                    return cameraModel;

                //31
                case MetaDataElement.Dimensions:
                    return dimensions;

                //32
                case MetaDataElement.CameraMaker:
                    return cameraMarker;

                //33
                case MetaDataElement.Company:
                    return company;

                //34
                case MetaDataElement.FileDescription:
                    return fileDescription;

                default:
                    return null;
            }
        }


        public override string ToString()
        {
            return $"Path = '{path}', Name = '{name}', Extension '{extension}', IsFile = '{isFile}'";
        }

        public bool IsImage()
        { return GetType() == TypeElement.Image; }


        public bool IsMusic()
        { return GetType() == TypeElement.Music; }


        public bool IsVideo()
        { return GetType() == TypeElement.Video; }


        public new TypeElement GetType()
        {
            if(!isFile)
            { return TypeElement.Folder; }

            if (!File.Exists(FolderExplorer_form.ExtensionJson))
            {
                MessageBox.Show($"Impossible de trouver le fichier à cette position = '{FolderExplorer_form.ExtensionJson}'");
                return TypeElement.OtherFile;
            }

            JObject o1 = JObject.Parse(File.ReadAllText(FolderExplorer_form.ExtensionJson));

            foreach (JProperty jProperty in o1.Properties())
            {
                object[] dataRow = jProperty.Value.ToArray();
                for (int i = 0; i < dataRow.Length; i++)
                {
                    if (dataRow[i].ToString().ToLower() == extension.ToLower())
                    {
                        return Enums.ToTypeElement(jProperty.Name);
                    }
                }
            }

            return TypeElement.OtherFile;
        }

        public void Open(ElementViewer ev)
        {
            if(!isFile)
            {
                ev.LoadPath(fullPath);
            }
            else
            {
                //exectuer fichier avec le programme associé
                Process.Start(fullPath);
            }
        }


        #region static

        public static Element[] GetElements(string path)
        {
            path = path.Replace('\\', '/');
            List<Element> result = new List<Element>();
            result.AddRange(GetFolders(path));
            result.AddRange(GetFiles(path));

            return result.ToArray();
        }

        public static Element[] GetFolders(string path)
        {
            path = path.Replace('\\', '/');
            string[] folders = Directory.GetDirectories(path);
            
            Element[] result = new Element[folders.Length];

            for(int i = 0; i < folders.Length; i++)
            {
                folders[i] = folders[i].Replace('\\', '/');

                result[i] = new Element(folders[i], false);
            }

            return result;
        }

        public static Element[] GetFiles(string path)
        {
            path = path.Replace('\\', '/');
            string[] files = Directory.GetFiles(path);

            Element[] result = new Element[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Replace('\\', '/');

                result[i] = new Element(files[i], true);
            }

            return result;
        }
        #endregion 
    }
}

/*
        0	Nom: fichier.txt
       1	Taille: 0 octet(s)
       2	Type d’élément: Fichier TXT
       3	Modifié le: 02/07/2022 18:13
       4	Date de création: 02/07/2022 18:13
       5	Date d’accès: 02/07/2022 18:13
       6	Attributs: A
       7	État hors connexion: 
       8	Disponibilité: 
       9	Type identifié: Texte
       10	Propriétaire: DEKSTOP-8NQ309K\victo
       11	Sorte: Document
       12	Prise de vue: 
       13	Interprètes ayant participé: 
       14	Album: 
       15	Année: 
       16	Genre: 
       17	Chefs d’orchestre: 
       18	Mots clés: 
       19	Notation: Non classé
       20	Auteurs: 
       21	Titre: 
       22	Objet: 
       23	Catégories: 
       24	Commentaires: 
       25	Copyright: 
       26	N°: 
       27	Durée: 
       28	Débit binaire: 
       29	Protégé: 
       30	Modèle d'appareil photo: 
       31	Dimensions: 
       32	Marque appareil photo: 
       33	Entreprise: 
       34	Description du fichier: 
       35	Mots-clés des formes de base: 
       36	Mots-clés des formes de base: 
        */