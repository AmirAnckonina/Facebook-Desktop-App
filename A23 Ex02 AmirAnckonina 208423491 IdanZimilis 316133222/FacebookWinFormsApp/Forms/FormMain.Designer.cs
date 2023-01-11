namespace FacebookWinFormsApp
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be FBAppGUId; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label captionLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label messageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.postLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.postDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.testBoxLoggedInUser = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.educationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.homeTownLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homeTownFreindsTab = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.friendsTab = new System.Windows.Forms.TabPage();
            this.friendsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.albumsTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.albumsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupsTab = new System.Windows.Forms.TabPage();
            this.groupLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.postsTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.captionLabel1 = new System.Windows.Forms.Label();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.likedPagesTab = new System.Windows.Forms.TabPage();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.likedPagesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hometownFriendsTab = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchPostsByDateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.postsByDateListBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelhomeTown = new System.Windows.Forms.Label();
            this.fetchHomwtownFriendsButton = new System.Windows.Forms.Button();
            this.hometownFriendFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fbLogoPictureBox = new System.Windows.Forms.PictureBox();
            captionLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDTOBindingSource)).BeginInit();
            this.infoGroupBox.SuspendLayout();
            this.homeTownFreindsTab.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.friendsTab.SuspendLayout();
            this.albumsTab.SuspendLayout();
            this.groupsTab.SuspendLayout();
            this.postsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.likedPagesTab.SuspendLayout();
            this.hometownFriendsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fbLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Location = new System.Drawing.Point(3, 27);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new System.Drawing.Size(60, 17);
            captionLabel.TabIndex = 0;
            captionLabel.Text = "Caption:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(3, 57);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(97, 17);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(3, 78);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(69, 17);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(5, 684);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(217, 52);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // postButton
            // 
            this.postButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postButton.Location = new System.Drawing.Point(339, 50);
            this.postButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(135, 30);
            this.postButton.TabIndex = 53;
            this.postButton.Text = "Post Status";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(32, 220);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(191, 164);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 54;
            this.profilePictureBox.TabStop = false;
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postLabel.Location = new System.Drawing.Point(17, 9);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(118, 24);
            this.postLabel.TabIndex = 56;
            this.postLabel.Text = "Post Status:";
            // 
            // postTextBox
            // 
            this.postTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postTextBox.Location = new System.Drawing.Point(21, 50);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(317, 28);
            this.postTextBox.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Facebook Desktop Application";
            // 
            // postsListBox
            // 
            this.postsListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.postsListBox.DataSource = this.postDTOBindingSource;
            this.postsListBox.DisplayMember = "Message";
            this.postsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.HorizontalScrollbar = true;
            this.postsListBox.ItemHeight = 20;
            this.postsListBox.Location = new System.Drawing.Point(21, 240);
            this.postsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.ScrollAlwaysVisible = true;
            this.postsListBox.Size = new System.Drawing.Size(826, 404);
            this.postsListBox.TabIndex = 59;
            // 
            // postDTOBindingSource
            // 
            this.postDTOBindingSource.DataSource = typeof(FBServiceLogic.DTOs.PostDTO);
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(5, 651);
            this.rememberMeCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(159, 28);
            this.rememberMeCheckBox.TabIndex = 60;
            this.rememberMeCheckBox.Text = "Remember me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            this.rememberMeCheckBox.CheckedChanged += new System.EventHandler(this.rememberMeCheckBox_CheckedChanged);
            // 
            // testBoxLoggedInUser
            // 
            this.testBoxLoggedInUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.testBoxLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.testBoxLoggedInUser.Location = new System.Drawing.Point(5, 12);
            this.testBoxLoggedInUser.Margin = new System.Windows.Forms.Padding(4);
            this.testBoxLoggedInUser.Name = "testBoxLoggedInUser";
            this.testBoxLoggedInUser.Size = new System.Drawing.Size(244, 23);
            this.testBoxLoggedInUser.TabIndex = 61;
            this.testBoxLoggedInUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.infoLabel.Location = new System.Drawing.Point(5, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(92, 24);
            this.infoLabel.TabIndex = 62;
            this.infoLabel.Text = "My Profile";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.educationLabel);
            this.infoGroupBox.Controls.Add(this.label6);
            this.infoGroupBox.Controls.Add(this.statusLabel);
            this.infoGroupBox.Controls.Add(this.homeTownLabel);
            this.infoGroupBox.Controls.Add(this.birthdayLabel);
            this.infoGroupBox.Controls.Add(this.genderLabel);
            this.infoGroupBox.Controls.Add(this.label5);
            this.infoGroupBox.Controls.Add(this.label4);
            this.infoGroupBox.Controls.Add(this.label3);
            this.infoGroupBox.Controls.Add(this.label2);
            this.infoGroupBox.Controls.Add(this.infoLabel);
            this.infoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.infoGroupBox.Location = new System.Drawing.Point(35, 73);
            this.infoGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoGroupBox.Size = new System.Drawing.Size(781, 210);
            this.infoGroupBox.TabIndex = 63;
            this.infoGroupBox.TabStop = false;
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Location = new System.Drawing.Point(481, 92);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(27, 20);
            this.educationLabel.TabIndex = 73;
            this.educationLabel.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Education";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(171, 139);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(27, 20);
            this.statusLabel.TabIndex = 71;
            this.statusLabel.Text = "---";
            // 
            // homeTownLabel
            // 
            this.homeTownLabel.AutoSize = true;
            this.homeTownLabel.Location = new System.Drawing.Point(481, 42);
            this.homeTownLabel.Name = "homeTownLabel";
            this.homeTownLabel.Size = new System.Drawing.Size(27, 20);
            this.homeTownLabel.TabIndex = 70;
            this.homeTownLabel.Text = "---";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(171, 92);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(27, 20);
            this.birthdayLabel.TabIndex = 69;
            this.birthdayLabel.Text = "---";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(171, 42);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(27, 20);
            this.genderLabel.TabIndex = 68;
            this.genderLabel.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "HomeTown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Gender";
            // 
            // homeTownFreindsTab
            // 
            this.homeTownFreindsTab.Controls.Add(this.homeTab);
            this.homeTownFreindsTab.Controls.Add(this.friendsTab);
            this.homeTownFreindsTab.Controls.Add(this.albumsTab);
            this.homeTownFreindsTab.Controls.Add(this.groupsTab);
            this.homeTownFreindsTab.Controls.Add(this.postsTab);
            this.homeTownFreindsTab.Controls.Add(this.likedPagesTab);
            this.homeTownFreindsTab.Controls.Add(this.hometownFriendsTab);
            this.homeTownFreindsTab.Controls.Add(this.tabPage1);
            this.homeTownFreindsTab.Location = new System.Drawing.Point(257, 12);
            this.homeTownFreindsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeTownFreindsTab.Name = "homeTownFreindsTab";
            this.homeTownFreindsTab.SelectedIndex = 0;
            this.homeTownFreindsTab.Size = new System.Drawing.Size(851, 729);
            this.homeTownFreindsTab.TabIndex = 65;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.label1);
            this.homeTab.Controls.Add(this.infoGroupBox);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(843, 700);
            this.homeTab.TabIndex = 6;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // friendsTab
            // 
            this.friendsTab.Controls.Add(this.friendsFlowLayoutPanel);
            this.friendsTab.Location = new System.Drawing.Point(4, 25);
            this.friendsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsTab.Name = "friendsTab";
            this.friendsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsTab.Size = new System.Drawing.Size(843, 700);
            this.friendsTab.TabIndex = 1;
            this.friendsTab.Text = "Friends";
            this.friendsTab.UseVisualStyleBackColor = true;
            // 
            // friendsFlowLayoutPanel
            // 
            this.friendsFlowLayoutPanel.AutoScroll = true;
            this.friendsFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.friendsFlowLayoutPanel.Location = new System.Drawing.Point(15, 20);
            this.friendsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsFlowLayoutPanel.Name = "friendsFlowLayoutPanel";
            this.friendsFlowLayoutPanel.Size = new System.Drawing.Size(813, 639);
            this.friendsFlowLayoutPanel.TabIndex = 66;
            // 
            // albumsTab
            // 
            this.albumsTab.Controls.Add(this.label8);
            this.albumsTab.Controls.Add(this.albumsLayoutPanel);
            this.albumsTab.Location = new System.Drawing.Point(4, 25);
            this.albumsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.albumsTab.Name = "albumsTab";
            this.albumsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.albumsTab.Size = new System.Drawing.Size(843, 700);
            this.albumsTab.TabIndex = 0;
            this.albumsTab.Text = "Albums";
            this.albumsTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(375, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Albums";
            // 
            // albumsLayoutPanel
            // 
            this.albumsLayoutPanel.AutoScroll = true;
            this.albumsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.albumsLayoutPanel.Location = new System.Drawing.Point(16, 58);
            this.albumsLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.albumsLayoutPanel.Name = "albumsLayoutPanel";
            this.albumsLayoutPanel.Size = new System.Drawing.Size(807, 620);
            this.albumsLayoutPanel.TabIndex = 65;
            // 
            // groupsTab
            // 
            this.groupsTab.Controls.Add(this.groupLayoutPanel);
            this.groupsTab.Controls.Add(this.label9);
            this.groupsTab.Location = new System.Drawing.Point(4, 25);
            this.groupsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupsTab.Name = "groupsTab";
            this.groupsTab.Size = new System.Drawing.Size(843, 700);
            this.groupsTab.TabIndex = 2;
            this.groupsTab.Text = "Groups";
            this.groupsTab.UseVisualStyleBackColor = true;
            // 
            // groupLayoutPanel
            // 
            this.groupLayoutPanel.AutoScroll = true;
            this.groupLayoutPanel.Location = new System.Drawing.Point(28, 89);
            this.groupLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupLayoutPanel.Name = "groupLayoutPanel";
            this.groupLayoutPanel.Size = new System.Drawing.Size(791, 577);
            this.groupLayoutPanel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(383, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Groups";
            // 
            // postsTab
            // 
            this.postsTab.AutoScroll = true;
            this.postsTab.Controls.Add(this.panel1);
            this.postsTab.Controls.Add(this.clearButton);
            this.postsTab.Controls.Add(this.statusTextBox);
            this.postsTab.Controls.Add(this.postLabel);
            this.postsTab.Controls.Add(this.postTextBox);
            this.postsTab.Controls.Add(this.postButton);
            this.postsTab.Controls.Add(this.postsListBox);
            this.postsTab.Location = new System.Drawing.Point(4, 25);
            this.postsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postsTab.Name = "postsTab";
            this.postsTab.Size = new System.Drawing.Size(843, 700);
            this.postsTab.TabIndex = 3;
            this.postsTab.Text = "Posts";
            this.postsTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(captionLabel);
            this.panel1.Controls.Add(this.captionLabel1);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageLabel1);
            this.panel1.Location = new System.Drawing.Point(21, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 139);
            this.panel1.TabIndex = 62;
            // 
            // captionLabel1
            // 
            this.captionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postDTOBindingSource, "Caption", true));
            this.captionLabel1.Location = new System.Drawing.Point(106, 27);
            this.captionLabel1.Name = "captionLabel1";
            this.captionLabel1.Size = new System.Drawing.Size(200, 23);
            this.captionLabel1.TabIndex = 1;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postDTOBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(106, 53);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // messageLabel1
            // 
            this.messageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postDTOBindingSource, "Message", true));
            this.messageLabel1.Location = new System.Drawing.Point(106, 78);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(200, 23);
            this.messageLabel1.TabIndex = 5;
            this.messageLabel1.Text = "\r\n";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(741, 15);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 28);
            this.clearButton.TabIndex = 61;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.statusTextBox.Location = new System.Drawing.Point(480, 50);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.statusTextBox.Size = new System.Drawing.Size(340, 29);
            this.statusTextBox.TabIndex = 60;
            this.statusTextBox.Text = "My Status...";
            // 
            // likedPagesTab
            // 
            this.likedPagesTab.Controls.Add(this.labelLikedPages);
            this.likedPagesTab.Controls.Add(this.likedPagesFlowLayoutPanel);
            this.likedPagesTab.Location = new System.Drawing.Point(4, 25);
            this.likedPagesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.likedPagesTab.Name = "likedPagesTab";
            this.likedPagesTab.Size = new System.Drawing.Size(843, 700);
            this.likedPagesTab.TabIndex = 4;
            this.likedPagesTab.Text = "Liked Pages";
            this.likedPagesTab.UseVisualStyleBackColor = true;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikedPages.Location = new System.Drawing.Point(356, 5);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(113, 24);
            this.labelLikedPages.TabIndex = 67;
            this.labelLikedPages.Text = "Liked Pages";
            // 
            // likedPagesFlowLayoutPanel
            // 
            this.likedPagesFlowLayoutPanel.AutoScroll = true;
            this.likedPagesFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.likedPagesFlowLayoutPanel.Location = new System.Drawing.Point(15, 38);
            this.likedPagesFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.likedPagesFlowLayoutPanel.Name = "likedPagesFlowLayoutPanel";
            this.likedPagesFlowLayoutPanel.Size = new System.Drawing.Size(813, 620);
            this.likedPagesFlowLayoutPanel.TabIndex = 66;
            // 
            // hometownFriendsTab
            // 
            this.hometownFriendsTab.AutoScroll = true;
            this.hometownFriendsTab.Controls.Add(this.dateTimePicker1);
            this.hometownFriendsTab.Controls.Add(this.searchPostsByDateButton);
            this.hometownFriendsTab.Controls.Add(this.label7);
            this.hometownFriendsTab.Controls.Add(this.postsByDateListBox);
            this.hometownFriendsTab.Location = new System.Drawing.Point(4, 25);
            this.hometownFriendsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hometownFriendsTab.Name = "hometownFriendsTab";
            this.hometownFriendsTab.Size = new System.Drawing.Size(843, 700);
            this.hometownFriendsTab.TabIndex = 7;
            this.hometownFriendsTab.Text = "Search Post";
            this.hometownFriendsTab.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // searchPostsByDateButton
            // 
            this.searchPostsByDateButton.Location = new System.Drawing.Point(587, 34);
            this.searchPostsByDateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchPostsByDateButton.Name = "searchPostsByDateButton";
            this.searchPostsByDateButton.Size = new System.Drawing.Size(75, 23);
            this.searchPostsByDateButton.TabIndex = 2;
            this.searchPostsByDateButton.Text = "Search";
            this.searchPostsByDateButton.UseVisualStyleBackColor = true;
            this.searchPostsByDateButton.Click += new System.EventHandler(this.searchPostsByDateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(36, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Show Posts By Date";
            // 
            // postsByDateListBox
            // 
            this.postsByDateListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.postsByDateListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postsByDateListBox.FormattingEnabled = true;
            this.postsByDateListBox.HorizontalScrollbar = true;
            this.postsByDateListBox.ItemHeight = 20;
            this.postsByDateListBox.Location = new System.Drawing.Point(40, 71);
            this.postsByDateListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postsByDateListBox.Name = "postsByDateListBox";
            this.postsByDateListBox.ScrollAlwaysVisible = true;
            this.postsByDateListBox.Size = new System.Drawing.Size(620, 584);
            this.postsByDateListBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelhomeTown);
            this.tabPage1.Controls.Add(this.fetchHomwtownFriendsButton);
            this.tabPage1.Controls.Add(this.hometownFriendFlowPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(843, 700);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "HomeTown Friends";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelhomeTown
            // 
            this.labelhomeTown.AutoSize = true;
            this.labelhomeTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelhomeTown.Location = new System.Drawing.Point(371, 55);
            this.labelhomeTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelhomeTown.Name = "labelhomeTown";
            this.labelhomeTown.Size = new System.Drawing.Size(89, 20);
            this.labelhomeTown.TabIndex = 2;
            this.labelhomeTown.Text = "Hometown";
            // 
            // fetchHomwtownFriendsButton
            // 
            this.fetchHomwtownFriendsButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fetchHomwtownFriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fetchHomwtownFriendsButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fetchHomwtownFriendsButton.Location = new System.Drawing.Point(17, 23);
            this.fetchHomwtownFriendsButton.Margin = new System.Windows.Forms.Padding(4);
            this.fetchHomwtownFriendsButton.Name = "fetchHomwtownFriendsButton";
            this.fetchHomwtownFriendsButton.Size = new System.Drawing.Size(808, 28);
            this.fetchHomwtownFriendsButton.TabIndex = 1;
            this.fetchHomwtownFriendsButton.Text = "Fetch Hometown Friends";
            this.fetchHomwtownFriendsButton.UseVisualStyleBackColor = false;
            this.fetchHomwtownFriendsButton.Click += new System.EventHandler(this.fetchHomwtownFriendsButton_Click);
            // 
            // hometownFriendFlowPanel
            // 
            this.hometownFriendFlowPanel.AutoScroll = true;
            this.hometownFriendFlowPanel.Location = new System.Drawing.Point(17, 96);
            this.hometownFriendFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.hometownFriendFlowPanel.Name = "hometownFriendFlowPanel";
            this.hometownFriendFlowPanel.Size = new System.Drawing.Size(808, 581);
            this.hometownFriendFlowPanel.TabIndex = 0;
            // 
            // fbLogoPictureBox
            // 
            this.fbLogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fbLogoPictureBox.BackgroundImage")));
            this.fbLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbLogoPictureBox.Location = new System.Drawing.Point(32, 44);
            this.fbLogoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.fbLogoPictureBox.Name = "fbLogoPictureBox";
            this.fbLogoPictureBox.Size = new System.Drawing.Size(191, 159);
            this.fbLogoPictureBox.TabIndex = 66;
            this.fbLogoPictureBox.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 753);
            this.Controls.Add(this.fbLogoPictureBox);
            this.Controls.Add(this.homeTownFreindsTab);
            this.Controls.Add(this.testBoxLoggedInUser);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.buttonLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDTOBindingSource)).EndInit();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.homeTownFreindsTab.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.friendsTab.ResumeLayout(false);
            this.albumsTab.ResumeLayout(false);
            this.albumsTab.PerformLayout();
            this.groupsTab.ResumeLayout(false);
            this.groupsTab.PerformLayout();
            this.postsTab.ResumeLayout(false);
            this.postsTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.likedPagesTab.ResumeLayout(false);
            this.likedPagesTab.PerformLayout();
            this.hometownFriendsTab.ResumeLayout(false);
            this.hometownFriendsTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fbLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.TextBox testBoxLoggedInUser;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label homeTownLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl homeTownFreindsTab;
        private System.Windows.Forms.TabPage albumsTab;
        private System.Windows.Forms.TabPage friendsTab;
        private System.Windows.Forms.TabPage groupsTab;
        private System.Windows.Forms.TabPage postsTab;
        private System.Windows.Forms.TabPage likedPagesTab;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage hometownFriendsTab;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button searchPostsByDateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox postsByDateListBox;
        private System.Windows.Forms.FlowLayoutPanel albumsLayoutPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox fbLogoPictureBox;
        private System.Windows.Forms.FlowLayoutPanel groupLayoutPanel;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.FlowLayoutPanel likedPagesFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel friendsFlowLayoutPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel hometownFriendFlowPanel;
        private System.Windows.Forms.Button fetchHomwtownFriendsButton;
        private System.Windows.Forms.Label labelhomeTown;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource postDTOBindingSource;
        private System.Windows.Forms.Label captionLabel1;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.Label messageLabel1;
    }
}