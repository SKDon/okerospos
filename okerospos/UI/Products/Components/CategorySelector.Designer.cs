namespace OBS.Pos.UI.Products.Components
{
    partial class CategorySelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorySelector));
            this.categoryList = new System.Windows.Forms.TreeView();
            this.CategoryImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // categoryList
            // 
            this.categoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryList.FullRowSelect = true;
            this.categoryList.HotTracking = true;
            this.categoryList.ImageIndex = 0;
            this.categoryList.ImageList = this.CategoryImages;
            this.categoryList.Location = new System.Drawing.Point(0, 0);
            this.categoryList.Name = "categoryList";
            this.categoryList.SelectedImageIndex = 0;
            this.categoryList.Size = new System.Drawing.Size(271, 281);
            this.categoryList.TabIndex = 0;
            // 
            // CategoryImages
            // 
            this.CategoryImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CategoryImages.ImageStream")));
            this.CategoryImages.TransparentColor = System.Drawing.Color.Transparent;
            this.CategoryImages.Images.SetKeyName(0, "Parent");
            // 
            // CategorySelector
            // 
            this.Controls.Add(this.categoryList);
            this.Name = "CategorySelector";
            this.Size = new System.Drawing.Size(271, 281);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView categoryList;
        private System.Windows.Forms.ImageList CategoryImages;

    }
}
