using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftLogik.Applications.HotelSuite.Business;
using System.Drawing;
using WeifenLuo.WinFormsUI;

namespace SoftLogik.Applications.RoomMate.Rooms
{
    class RoomCatalog : Panel
    {
        const int ROOM_BUTTON_WIDTH = 92;
        private SoftLogik.Win.UI.VisualTabControl tbcMain;
        private System.ComponentModel.IContainer components;
        private TabPage tabPage2;
        const int ROOM_BUTTON_HEIGHT = 64;
        private Dictionary<string, frmRoomViewer> viewedRooms = new Dictionary<string, frmRoomViewer>();

        public RoomCatalog()
        {
            InitializeComponent();
        }


        private void CreateRoomMenu(KryptonButton menuParent)
        {
            try
            {
                var roomMenu = new KryptonContextMenu();
                var roomMenuItems = new KryptonContextMenuItems();

                var roomViewMenu = new KryptonContextMenuItem("View");
                roomViewMenu.ImageTransparentColor = System.Drawing.Color.Empty;
                roomViewMenu.Click += OnViewRoom;
                roomViewMenu.Tag = menuParent.Tag;

                var roomSeparator001 = new KryptonContextMenuSeparator();

                var roomCleanMenu = new KryptonContextMenuItem("Mark As Clean");
                roomCleanMenu.ImageTransparentColor = System.Drawing.Color.Empty;
                roomCleanMenu.Click += OnCleanRoom;
                roomCleanMenu.Tag = menuParent.Tag;
                //Attach menu items to context menu
                roomMenu.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
                roomMenuItems});
                roomMenuItems.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[]
                                                {
                                                    roomViewMenu, roomSeparator001, roomCleanMenu
                                                });
                menuParent.KryptonContextMenu = roomMenu;
            }
            catch (Exception)
            {

            }

        }

        #region Menu event overrides
        protected void OnViewRoom(object sender, EventArgs e)
        {
            var selectedRoom = GetRoomFromEvent(sender);
            if (selectedRoom != null)
            {
                Rooms.frmRoomViewer roomViewer = null;
                var viewedRoomId = string.Format("RM{0}", selectedRoom.Roomid);
                if (!viewedRooms.Keys.Contains(viewedRoomId))
                {
                    roomViewer = new Rooms.frmRoomViewer();
                    var parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        var mdiParent = parentForm.MdiParent as frmMain;
                        if (mdiParent != null)
                        {
                            roomViewer.MdiParent = mdiParent;
                            roomViewer.DockPanel = mdiParent.ActiveDockPanel;
                            roomViewer.DockState = DockState.DockRight;
                        }
                    }

                    roomViewer.ActiveRoom = selectedRoom;
                    viewedRooms.Add(viewedRoomId, roomViewer);
                }
                else
                    roomViewer = viewedRooms[viewedRoomId];

                roomViewer.ShowRoom(selectedRoom);
            }

        }
        protected void OnCleanRoom(object sender, EventArgs e)
        {
            var selectedRoom = GetRoomFromEvent(sender);
            if (selectedRoom != null)
            {
                Rooms.frmRoomViewer roomViewer = null;
                var viewedRoomId = string.Format("RM{0}", selectedRoom.Roomid);
                if (!viewedRooms.Keys.Contains(viewedRoomId))
                {
                    roomViewer = new Rooms.frmRoomViewer();
                    var parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        var mdiParent = parentForm.MdiParent as frmMain;
                        if (mdiParent != null)
                        {
                            roomViewer.MdiParent = mdiParent;
                            roomViewer.DockPanel = mdiParent.ActiveDockPanel;
                            roomViewer.DockState = DockState.Float;
                        }
                    }

                    roomViewer.ActiveRoom = selectedRoom;
                    viewedRooms.Add(viewedRoomId, roomViewer);
                }
                else
                    roomViewer = viewedRooms[viewedRoomId];

                roomViewer.ShowRoom(selectedRoom);
            }

        }

        #endregion

        private Room GetRoomFromEvent(object sender)
        {
            var selectedButton = sender as KryptonContextMenuItem;
            if (selectedButton != null)
            {
                return selectedButton.Tag as Room;
            }
            return null;
        }


        #region Render Room View
        private void LoadRooms(TabPage roomTypeTab)
        {
            try
            {

                long TypeID = ((RoomType)roomTypeTab.Tag).Typeid;
                KryptonPanel roomOutlinePane = new KryptonPanel();
                TableLayoutPanel roomLayoutPane = new TableLayoutPanel();

                RoomCollection mRoomColl = new RoomCollection();
                if (TypeID > -1)
                    mRoomColl.Where(Room.TypeidColumn.ColumnName, TypeID).Load();
                else
                    mRoomColl.Load();

                roomLayoutPane.RowCount = mRoomColl.Count >= 26 ? mRoomColl.Count - 1 : 25;
                roomLayoutPane.ColumnCount = 12;
                roomLayoutPane.Size = new Size(ROOM_BUTTON_WIDTH * roomLayoutPane.RowCount + 3, ROOM_BUTTON_HEIGHT * roomLayoutPane.ColumnCount + 3);

                int currRowIndex = 0; int currColIndex = 0;
                roomLayoutPane.SuspendLayout();
                foreach (Room room in mRoomColl)
                {
                    var roomButton = new KryptonButton
                    {
                        Name = ("RM" + room.Roomid),
                        Size = new Size(ROOM_BUTTON_WIDTH, ROOM_BUTTON_HEIGHT),
                        Text =
                            (room.Name.Trim().ToLowerInvariant().StartsWith("room")
                                 ? room.Name
                                 : "Room " + room.Name),
                        Tag = room
                    };

                    CreateRoomMenu(roomButton);
                    roomLayoutPane.Controls.Add(roomButton);
                    roomLayoutPane.SetRow(roomButton, currRowIndex);
                    roomLayoutPane.SetColumn(roomButton, currColIndex);

                    if (currColIndex == roomLayoutPane.ColumnCount)
                    {
                        currRowIndex++;
                        currColIndex = 0;
                    }
                    else
                    {
                        currColIndex++;
                    }
                }
                roomLayoutPane.ResumeLayout();
                roomLayoutPane.BackColor = Color.Transparent;
                roomOutlinePane.Dock = DockStyle.Fill;
                roomOutlinePane.Controls.Add(roomLayoutPane);
                roomTypeTab.Controls.Add(roomOutlinePane); //Add to Current Tab
            }
            catch (Exception ex) { }
        }

        public void LoadRoomCatalog()
        {
            var mTypeColl = new RoomTypeCollection();
            mTypeColl.Load();
            tbcMain.TabPages.Clear();
            foreach (var roomType in mTypeColl)
            {
                var tabRoomType = new TabPage(roomType.Name);
                tabRoomType.Tag = roomType;
                LoadRooms(tabRoomType);
                tbcMain.TabPages.Add(tabRoomType);
            }
        }
        #endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbcMain = new SoftLogik.Win.UI.VisualTabControl(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.HotTrack = true;
            this.tbcMain.ItemSize = new System.Drawing.Size(0, 15);
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Multiline = true;
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.Padding = new System.Drawing.Point(9, 0);
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(825, 487);
            this.tbcMain.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 19);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tbcMain.ResumeLayout(false);
            this.ResumeLayout(false);

            this.Controls.Add(this.tbcMain);
        }
    }

}
