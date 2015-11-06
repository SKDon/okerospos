namespace OBS.Pos.UI.Products.Components
{
    partial class ProductSelector
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
            this.categorySelList = new OBS.Pos.UI.Products.Components.CategorySelector();
            this.SuspendLayout();
            // 
            // categorySelList
            // 
            this.categorySelList.Location = new System.Drawing.Point(28, 25);
            this.categorySelList.Name = "categorySelList";
            this.categorySelList.Size = new System.Drawing.Size(150, 150);
            this.categorySelList.TabIndex = 0;
            // 
            // ProductSelector
            // 
            this.Controls.Add(this.categorySelList);
            this.Name = "ProductSelector";
            this.Size = new System.Drawing.Size(388, 336);
            this.ResumeLayout(false);

        }

        #endregion

        private CategorySelector categorySelList;
    }
}
