using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderExplorer
{
    public partial class ElementViewerHeader : UserControl
    {

        public const int SizeHeight = 21;
        //public event MouseEventHandler MouseUp { get; private set; }

        //public event MouseEventHandler MouseDown { get; private set; }

        public string text
        {
            get
            {
                switch (metaDataElement)
                {
                    //0
                    case MetaDataElement.Name:
                        return "Nom";

                    //1
                    case MetaDataElement.Size:
                        return "Taille";

                    //2
                    case MetaDataElement.ItemType:
                        return "Type";

                    //3
                    case MetaDataElement.LastWriteTime:
                        return "Modifié le";

                    //4
                    case MetaDataElement.CreationTime:
                        return "Date de création";

                    //5
                    case MetaDataElement.LastAccessTime:
                        return "Date d’accès";

                    //6
                    case MetaDataElement.Attribute:
                        return "Attributs";

                    //7
                    case MetaDataElement.OfflineStatus:
                        return "État hors connexion";

                    //8
                    case MetaDataElement.Availability:
                        return "Disponibilité";

                    //9
                    case MetaDataElement.IdentifiedType:
                        return "Type identifié";

                    //10
                    case MetaDataElement.Owner:
                        return "Propriétaire";

                    //11
                    case MetaDataElement.Kind:
                        return "Sorte";

                    //12
                    case MetaDataElement.DateTaken:
                        return "Prise de vue";

                    //13
                    case MetaDataElement.ContributingArtists:
                        return "Interprètes ayant participé";

                    //14
                    case MetaDataElement.Album:
                        return "Album";

                    //15
                    case MetaDataElement.Year:
                        return "Année";

                    //16
                    case MetaDataElement.Genre:
                        return "Genre";

                    //17
                    case MetaDataElement.Conductors:
                        return "Chefs d’orchestre";

                    //18
                    case MetaDataElement.Tags:
                        return "Mots clés";

                    //19
                    case MetaDataElement.Rating:
                        return "Notation";

                    //20
                    case MetaDataElement.Authors:
                        return "Auteurs";

                    //21
                    case MetaDataElement.Title:
                        return "Titre";

                    //22
                    case MetaDataElement.Subject:
                        return "Onjet";

                    //23
                    case MetaDataElement.Categories:
                        return "Catégories";

                    //24
                    case MetaDataElement.Comments:
                        return "Commentaires";

                    //25
                    case MetaDataElement.Copyright:
                        return "Copyright";

                    //26
                    case MetaDataElement.TrackNumber:
                        return "N°";

                    //27
                    case MetaDataElement.Duration:
                        return "Durée";

                    //28
                    case MetaDataElement.BitRate:
                        return "Débit binaire";

                    //29
                    case MetaDataElement.Protected:
                        return "Protégé";

                    //30
                    case MetaDataElement.CameraModel:
                        return "Modèle d'appareil photo";

                    //31
                    case MetaDataElement.Dimensions:
                        return "Dimensions";

                    //32
                    case MetaDataElement.CameraMaker:
                        return "Marque appareil photo";

                    //33
                    case MetaDataElement.Company:
                        return "Entreprise";

                    //34
                    case MetaDataElement.FileDescription:
                        return "Description du fichier";

                    default:
                        return "_";
                }
            }
        }

        public Cursor rightCursor
        {
            get => rightDrag_panel.Cursor;

            set => rightDrag_panel.Cursor = value;
        }

        public Cursor leftCursor
        {
            get => leftDrag_panel.Cursor;

            set => leftDrag_panel.Cursor = value;
        }

        private MetaDataElement _metaDataElement;
        public MetaDataElement metaDataElement
        {
            get => _metaDataElement;

            set 
            {
                _metaDataElement = value;
                header_button.Text = text;
            }
        }
        public SortDirection sortDirection { get; set; } = SortDirection.None;

        public ElementViewerHeader()
        {
            InitializeComponent();
        }

        public ElementViewerHeader(MetaDataElement metaDataElement) : this()
        {
            this.metaDataElement = metaDataElement;
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, SizeHeight, specified);
        }

        private void header_button_Click(object sender, EventArgs e)
        {
            sortDirection = Enums.NextSortDirection(sortDirection);
        }
    }
}
