﻿namespace KadirSandalyeWinProject.UserControls.Controls.Navigators
{
    partial class InsUptNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsUptNavigator));
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Buttons.Append.ImageIndex = 6;
            this.controlNavigator1.Buttons.CancelEdit.Visible = false;
            this.controlNavigator1.Buttons.Edit.Visible = false;
            this.controlNavigator1.Buttons.EndEdit.Visible = false;
            this.controlNavigator1.Buttons.First.ImageIndex = 0;
            this.controlNavigator1.Buttons.ImageList = this.imageCollection;
            this.controlNavigator1.Buttons.Last.ImageIndex = 5;
            this.controlNavigator1.Buttons.Next.ImageIndex = 3;
            this.controlNavigator1.Buttons.NextPage.Visible = false;
            this.controlNavigator1.Buttons.Prev.ImageIndex = 2;
            this.controlNavigator1.Buttons.PrevPage.Visible = false;
            this.controlNavigator1.Buttons.Remove.ImageIndex = 7;
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.Size = new System.Drawing.Size(500, 24);
            this.controlNavigator1.TabIndex = 0;
            this.controlNavigator1.Text = "controlNavigator1";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("first_16x16.png", "office2013/arrows/first_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/first_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "first_16x16.png");
            this.imageCollection.InsertGalleryImage("doubleprev_16x16.png", "office2013/arrows/doubleprev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/doubleprev_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "doubleprev_16x16.png");
            this.imageCollection.InsertGalleryImage("prev_16x16.png", "office2013/arrows/prev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/prev_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "prev_16x16.png");
            this.imageCollection.InsertGalleryImage("next_16x16.png", "office2013/arrows/next_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/next_16x16.png"), 3);
            this.imageCollection.Images.SetKeyName(3, "next_16x16.png");
            this.imageCollection.InsertGalleryImage("doublenext_16x16.png", "office2013/arrows/doublenext_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/doublenext_16x16.png"), 4);
            this.imageCollection.Images.SetKeyName(4, "doublenext_16x16.png");
            this.imageCollection.InsertGalleryImage("last_16x16.png", "office2013/arrows/last_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/last_16x16.png"), 5);
            this.imageCollection.Images.SetKeyName(5, "last_16x16.png");
            this.imageCollection.InsertImage(global::KadirSandalyeWinProject.Properties.Resources.addfile_16x161, "addfile_16x161", typeof(global::KadirSandalyeWinProject.Properties.Resources), 6);
            this.imageCollection.Images.SetKeyName(6, "addfile_16x161");
            this.imageCollection.InsertImage(global::KadirSandalyeWinProject.Properties.Resources.deletelist2_16x16, "deletelist2_16x16", typeof(global::KadirSandalyeWinProject.Properties.Resources), 7);
            this.imageCollection.Images.SetKeyName(7, "deletelist2_16x16");
            // 
            // InsUptNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlNavigator1);
            this.Name = "InsUptNavigator";
            this.Size = new System.Drawing.Size(500, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
