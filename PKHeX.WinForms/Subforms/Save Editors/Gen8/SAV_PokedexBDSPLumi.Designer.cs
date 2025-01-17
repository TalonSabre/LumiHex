namespace PKHeX.WinForms
{
    partial class SAV_PokedexBDSPLumi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dexTips = new System.Windows.Forms.ToolTip(components);
            CHK_LangKOR = new System.Windows.Forms.CheckBox();
            CHK_LangSPA = new System.Windows.Forms.CheckBox();
            CHK_LangGER = new System.Windows.Forms.CheckBox();
            CHK_LangITA = new System.Windows.Forms.CheckBox();
            CHK_LangFRE = new System.Windows.Forms.CheckBox();
            CHK_LangJPN = new System.Windows.Forms.CheckBox();
            B_ModifyEntry = new System.Windows.Forms.Button();
            B_Modify = new System.Windows.Forms.Button();
            CHK_LangCHT = new System.Windows.Forms.CheckBox();
            CHK_LangCHS = new System.Windows.Forms.CheckBox();
            B_ModifyForms = new System.Windows.Forms.Button();
            CHK_National = new System.Windows.Forms.CheckBox();
            B_Cancel = new System.Windows.Forms.Button();
            LB_Species = new System.Windows.Forms.ListBox();
            CHK_LangENG = new System.Windows.Forms.CheckBox();
            L_goto = new System.Windows.Forms.Label();
            CB_Species = new System.Windows.Forms.ComboBox();
            B_Save = new System.Windows.Forms.Button();
            GB_Language = new System.Windows.Forms.GroupBox();
            GB_Encountered = new System.Windows.Forms.GroupBox();
            CHK_FS = new System.Windows.Forms.CheckBox();
            CHK_MS = new System.Windows.Forms.CheckBox();
            CHK_F = new System.Windows.Forms.CheckBox();
            CHK_M = new System.Windows.Forms.CheckBox();
            modifyMenu = new System.Windows.Forms.ContextMenuStrip(components);
            mnuSeenNone = new System.Windows.Forms.ToolStripMenuItem();
            mnuSeenAll = new System.Windows.Forms.ToolStripMenuItem();
            mnuCaughtNone = new System.Windows.Forms.ToolStripMenuItem();
            mnuCaughtAll = new System.Windows.Forms.ToolStripMenuItem();
            mnuComplete = new System.Windows.Forms.ToolStripMenuItem();
            CLB_FormRegular = new System.Windows.Forms.CheckedListBox();
            L_FormsSeen = new System.Windows.Forms.Label();
            CLB_FormShiny = new System.Windows.Forms.CheckedListBox();
            L_FormDisplayed = new System.Windows.Forms.Label();
            modifyMenuForms = new System.Windows.Forms.ContextMenuStrip(components);
            mnuFormNone = new System.Windows.Forms.ToolStripMenuItem();
            mnuFormAllRegular = new System.Windows.Forms.ToolStripMenuItem();
            CB_State = new System.Windows.Forms.ComboBox();
            modifyMenuEntry = new System.Windows.Forms.ContextMenuStrip(components);
            mnuClearEntry = new System.Windows.Forms.ToolStripMenuItem();
            mnuMFCurLang = new System.Windows.Forms.ToolStripMenuItem();
            mnuMFAllLang = new System.Windows.Forms.ToolStripMenuItem();
            GB_Language.SuspendLayout();
            GB_Encountered.SuspendLayout();
            modifyMenu.SuspendLayout();
            modifyMenuForms.SuspendLayout();
            modifyMenuEntry.SuspendLayout();
            SuspendLayout();
            // 
            // dexTips
            // 
            dexTips.Popup += dexTips_Popup;
            // 
            // CHK_LangKOR
            // 
            CHK_LangKOR.AutoSize = true;
            CHK_LangKOR.Location = new System.Drawing.Point(7, 113);
            CHK_LangKOR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_LangKOR.Name = "CHK_LangKOR";
            CHK_LangKOR.Size = new System.Drawing.Size(63, 19);
            CHK_LangKOR.TabIndex = 19;
            CHK_LangKOR.Text = "Korean";
            dexTips.SetToolTip(CHK_LangKOR, "Luminescent Platinum only supports English for now!");
            CHK_LangKOR.UseVisualStyleBackColor = true;
            // 
            // CHK_LangSPA
            // 
            CHK_LangSPA.AutoSize = true;
            CHK_LangSPA.Location = new System.Drawing.Point(7, 97);
            CHK_LangSPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_LangSPA.Name = "CHK_LangSPA";
            CHK_LangSPA.Size = new System.Drawing.Size(67, 19);
            CHK_LangSPA.TabIndex = 18;
            CHK_LangSPA.Text = "Spanish";
            dexTips.SetToolTip(CHK_LangSPA, "Luminescent Platinum only supports English for now!");
            CHK_LangSPA.UseVisualStyleBackColor = true;
            // 
            // CHK_LangGER
            // 
            CHK_LangGER.AutoSize = true;
            CHK_LangGER.Location = new System.Drawing.Point(7, 81);
            CHK_LangGER.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_LangGER.Name = "CHK_LangGER";
            CHK_LangGER.Size = new System.Drawing.Size(68, 19);
            CHK_LangGER.TabIndex = 17;
            CHK_LangGER.Text = "German";
            dexTips.SetToolTip(CHK_LangGER, "Luminescent Platinum only supports English for now!");
            CHK_LangGER.UseVisualStyleBackColor = true;
            // 
            // CHK_LangITA
            // 
            CHK_LangITA.AutoSize = true;
            CHK_LangITA.Location = new System.Drawing.Point(7, 64);
            CHK_LangITA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_LangITA.Name = "CHK_LangITA";
            CHK_LangITA.Size = new System.Drawing.Size(58, 19);
            CHK_LangITA.TabIndex = 16;
            CHK_LangITA.Text = "Italian";
            dexTips.SetToolTip(CHK_LangITA, "Luminescent Platinum only supports English for now!");
            CHK_LangITA.UseVisualStyleBackColor = true;
            // 
            // CHK_LangFRE
            // 
            CHK_LangFRE.AutoSize = true;
            CHK_LangFRE.Location = new System.Drawing.Point(7, 49);
            CHK_LangFRE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_LangFRE.Name = "CHK_LangFRE";
            CHK_LangFRE.Size = new System.Drawing.Size(62, 19);
            CHK_LangFRE.TabIndex = 15;
            CHK_LangFRE.Text = "French";
            dexTips.SetToolTip(CHK_LangFRE, "Luminescent Platinum only supports English for now!");
            CHK_LangFRE.UseVisualStyleBackColor = true;
            // 
            // CHK_LangJPN
            // 
            CHK_LangJPN.AutoSize = true;
            CHK_LangJPN.Location = new System.Drawing.Point(7, 16);
            CHK_LangJPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_LangJPN.Name = "CHK_LangJPN";
            CHK_LangJPN.Size = new System.Drawing.Size(73, 19);
            CHK_LangJPN.TabIndex = 13;
            CHK_LangJPN.Text = "Japanese";
            dexTips.SetToolTip(CHK_LangJPN, "Luminescent Platinum only supports English for now!");
            CHK_LangJPN.UseVisualStyleBackColor = true;
            // 
            // B_ModifyEntry
            // 
            B_ModifyEntry.Location = new System.Drawing.Point(174, 14);
            B_ModifyEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            B_ModifyEntry.Name = "B_ModifyEntry";
            B_ModifyEntry.Size = new System.Drawing.Size(134, 23);
            B_ModifyEntry.TabIndex = 23;
            B_ModifyEntry.Text = "Edit Current Entry";
            dexTips.SetToolTip(B_ModifyEntry, "Edit selected Pokemon Seen data");
            B_ModifyEntry.UseVisualStyleBackColor = true;
            B_ModifyEntry.Click += B_ModifyEntry_Click;
            // 
            // B_Modify
            // 
            B_Modify.Location = new System.Drawing.Point(315, 14);
            B_Modify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            B_Modify.Name = "B_Modify";
            B_Modify.Size = new System.Drawing.Size(137, 23);
            B_Modify.TabIndex = 25;
            B_Modify.Text = "Edit All Dex Entries";
            dexTips.SetToolTip(B_Modify, "Edit all Pokemon Seen data");
            B_Modify.UseVisualStyleBackColor = true;
            B_Modify.Click += B_Modify_Click;
            // 
            // CHK_LangCHT
            // 
            CHK_LangCHT.AutoSize = true;
            CHK_LangCHT.Location = new System.Drawing.Point(7, 146);
            CHK_LangCHT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_LangCHT.Name = "CHK_LangCHT";
            CHK_LangCHT.Size = new System.Drawing.Size(74, 19);
            CHK_LangCHT.TabIndex = 21;
            CHK_LangCHT.Text = "ChineseT";
            dexTips.SetToolTip(CHK_LangCHT, "Luminescent Platinum only supports English for now!");
            CHK_LangCHT.UseVisualStyleBackColor = true;
            // 
            // CHK_LangCHS
            // 
            CHK_LangCHS.AutoSize = true;
            CHK_LangCHS.Location = new System.Drawing.Point(7, 129);
            CHK_LangCHS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_LangCHS.Name = "CHK_LangCHS";
            CHK_LangCHS.Size = new System.Drawing.Size(74, 19);
            CHK_LangCHS.TabIndex = 20;
            CHK_LangCHS.Text = "ChineseS";
            dexTips.SetToolTip(CHK_LangCHS, "Luminescent Platinum only supports English for now!");
            CHK_LangCHS.UseVisualStyleBackColor = true;
            // 
            // B_ModifyForms
            // 
            B_ModifyForms.Location = new System.Drawing.Point(462, 14);
            B_ModifyForms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            B_ModifyForms.Name = "B_ModifyForms";
            B_ModifyForms.Size = new System.Drawing.Size(137, 23);
            B_ModifyForms.TabIndex = 40;
            B_ModifyForms.Text = "Edit Form Data";
            dexTips.SetToolTip(B_ModifyForms, "Edit all Forms Seen data");
            B_ModifyForms.UseVisualStyleBackColor = true;
            B_ModifyForms.Click += B_ModifyForms_Click;
            // 
            // CHK_National
            // 
            CHK_National.AutoSize = true;
            CHK_National.Location = new System.Drawing.Point(181, 346);
            CHK_National.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_National.Name = "CHK_National";
            CHK_National.Size = new System.Drawing.Size(120, 19);
            CHK_National.TabIndex = 42;
            CHK_National.Text = "National PokéDex";
            dexTips.SetToolTip(CHK_National, "You are given this from the start In Luminescent Platinum!\r\n");
            CHK_National.UseVisualStyleBackColor = true;
            // 
            // B_Cancel
            // 
            B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            B_Cancel.Location = new System.Drawing.Point(358, 346);
            B_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            B_Cancel.Name = "B_Cancel";
            B_Cancel.Size = new System.Drawing.Size(94, 24);
            B_Cancel.TabIndex = 0;
            B_Cancel.Text = "Cancel";
            B_Cancel.UseVisualStyleBackColor = true;
            B_Cancel.Click += B_Cancel_Click;
            // 
            // LB_Species
            // 
            LB_Species.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            LB_Species.FormattingEnabled = true;
            LB_Species.ItemHeight = 15;
            LB_Species.Location = new System.Drawing.Point(17, 45);
            LB_Species.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            LB_Species.Name = "LB_Species";
            LB_Species.Size = new System.Drawing.Size(151, 319);
            LB_Species.TabIndex = 2;
            LB_Species.SelectedIndexChanged += ChangeLBSpecies;
            // 
            // CHK_LangENG
            // 
            CHK_LangENG.AutoSize = true;
            CHK_LangENG.Location = new System.Drawing.Point(7, 32);
            CHK_LangENG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_LangENG.Name = "CHK_LangENG";
            CHK_LangENG.Size = new System.Drawing.Size(64, 19);
            CHK_LangENG.TabIndex = 14;
            CHK_LangENG.Text = "English";
            CHK_LangENG.UseVisualStyleBackColor = true;
            // 
            // L_goto
            // 
            L_goto.AutoSize = true;
            L_goto.Location = new System.Drawing.Point(11, 18);
            L_goto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_goto.Name = "L_goto";
            L_goto.Size = new System.Drawing.Size(33, 15);
            L_goto.TabIndex = 20;
            L_goto.Text = "Find:";
            // 
            // CB_Species
            // 
            CB_Species.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            CB_Species.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            CB_Species.DropDownWidth = 95;
            CB_Species.FormattingEnabled = true;
            CB_Species.Items.AddRange(new object[] { "0" });
            CB_Species.Location = new System.Drawing.Point(51, 16);
            CB_Species.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CB_Species.Name = "CB_Species";
            CB_Species.Size = new System.Drawing.Size(117, 23);
            CB_Species.TabIndex = 21;
            CB_Species.SelectedIndexChanged += ChangeCBSpecies;
            CB_Species.SelectedValueChanged += ChangeCBSpecies;
            // 
            // B_Save
            // 
            B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            B_Save.Location = new System.Drawing.Point(462, 346);
            B_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            B_Save.Name = "B_Save";
            B_Save.Size = new System.Drawing.Size(138, 24);
            B_Save.TabIndex = 24;
            B_Save.Text = "Save Changes";
            B_Save.UseVisualStyleBackColor = true;
            B_Save.Click += B_Save_Click;
            // 
            // GB_Language
            // 
            GB_Language.Controls.Add(CHK_LangCHT);
            GB_Language.Controls.Add(CHK_LangCHS);
            GB_Language.Controls.Add(CHK_LangKOR);
            GB_Language.Controls.Add(CHK_LangSPA);
            GB_Language.Controls.Add(CHK_LangGER);
            GB_Language.Controls.Add(CHK_LangITA);
            GB_Language.Controls.Add(CHK_LangFRE);
            GB_Language.Controls.Add(CHK_LangENG);
            GB_Language.Controls.Add(CHK_LangJPN);
            GB_Language.Location = new System.Drawing.Point(174, 171);
            GB_Language.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            GB_Language.Name = "GB_Language";
            GB_Language.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            GB_Language.Size = new System.Drawing.Size(134, 170);
            GB_Language.TabIndex = 26;
            GB_Language.TabStop = false;
            GB_Language.Text = "Languages";
            // 
            // GB_Encountered
            // 
            GB_Encountered.Controls.Add(CHK_FS);
            GB_Encountered.Controls.Add(CHK_MS);
            GB_Encountered.Controls.Add(CHK_F);
            GB_Encountered.Controls.Add(CHK_M);
            GB_Encountered.Location = new System.Drawing.Point(174, 74);
            GB_Encountered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            GB_Encountered.Name = "GB_Encountered";
            GB_Encountered.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            GB_Encountered.Size = new System.Drawing.Size(134, 90);
            GB_Encountered.TabIndex = 31;
            GB_Encountered.TabStop = false;
            GB_Encountered.Text = "Seen";
            // 
            // CHK_FS
            // 
            CHK_FS.AutoSize = true;
            CHK_FS.Location = new System.Drawing.Point(7, 64);
            CHK_FS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_FS.Name = "CHK_FS";
            CHK_FS.Size = new System.Drawing.Size(96, 19);
            CHK_FS.TabIndex = 7;
            CHK_FS.Text = "Shiny Female";
            CHK_FS.UseVisualStyleBackColor = true;
            // 
            // CHK_MS
            // 
            CHK_MS.AutoSize = true;
            CHK_MS.Location = new System.Drawing.Point(7, 47);
            CHK_MS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_MS.Name = "CHK_MS";
            CHK_MS.Size = new System.Drawing.Size(84, 19);
            CHK_MS.TabIndex = 6;
            CHK_MS.Text = "Shiny Male";
            CHK_MS.UseVisualStyleBackColor = true;
            // 
            // CHK_F
            // 
            CHK_F.AutoSize = true;
            CHK_F.Location = new System.Drawing.Point(7, 32);
            CHK_F.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_F.Name = "CHK_F";
            CHK_F.Size = new System.Drawing.Size(64, 19);
            CHK_F.TabIndex = 5;
            CHK_F.Text = "Female";
            CHK_F.UseVisualStyleBackColor = true;
            // 
            // CHK_M
            // 
            CHK_M.AutoSize = true;
            CHK_M.Location = new System.Drawing.Point(7, 15);
            CHK_M.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CHK_M.Name = "CHK_M";
            CHK_M.Size = new System.Drawing.Size(52, 19);
            CHK_M.TabIndex = 4;
            CHK_M.Text = "Male";
            CHK_M.UseVisualStyleBackColor = true;
            // 
            // modifyMenu
            // 
            modifyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            modifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuSeenNone, mnuSeenAll, mnuCaughtNone, mnuCaughtAll, mnuComplete });
            modifyMenu.Name = "modifyMenu";
            modifyMenu.Size = new System.Drawing.Size(146, 114);
            // 
            // mnuSeenNone
            // 
            mnuSeenNone.Name = "mnuSeenNone";
            mnuSeenNone.Size = new System.Drawing.Size(145, 22);
            mnuSeenNone.Text = "Clear All";
            mnuSeenNone.ToolTipText = "Clears all Dex entries\r\nSets Seen status for all entries to None";
            mnuSeenNone.Click += ModifyAll;
            // 
            // mnuSeenAll
            // 
            mnuSeenAll.Name = "mnuSeenAll";
            mnuSeenAll.Size = new System.Drawing.Size(145, 22);
            mnuSeenAll.Text = "Seen All";
            mnuSeenAll.ToolTipText = "Sets Seen status for every entry to Seen";
            mnuSeenAll.Click += ModifyAll;
            // 
            // mnuCaughtNone
            // 
            mnuCaughtNone.Name = "mnuCaughtNone";
            mnuCaughtNone.Size = new System.Drawing.Size(145, 22);
            mnuCaughtNone.Text = "Caught None";
            mnuCaughtNone.ToolTipText = "Changes Captured status to Seen for every entry";
            mnuCaughtNone.Click += ModifyAll;
            // 
            // mnuCaughtAll
            // 
            mnuCaughtAll.Name = "mnuCaughtAll";
            mnuCaughtAll.Size = new System.Drawing.Size(145, 22);
            mnuCaughtAll.Text = "Caught All";
            mnuCaughtAll.ToolTipText = "Every entry is set to Captured\r\nComplete Dex\r\n\r\nCTRL+Click to include shiny forms.";
            mnuCaughtAll.Click += ModifyAll;
            // 
            // mnuComplete
            // 
            mnuComplete.Name = "mnuComplete";
            mnuComplete.Size = new System.Drawing.Size(145, 22);
            mnuComplete.Text = "100% Dex";
            mnuComplete.ToolTipText = "Every entry set to Captured in all Languages";
            mnuComplete.Click += ModifyAll;
            // 
            // CLB_FormRegular
            // 
            CLB_FormRegular.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            CLB_FormRegular.FormattingEnabled = true;
            CLB_FormRegular.Location = new System.Drawing.Point(314, 83);
            CLB_FormRegular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CLB_FormRegular.Name = "CLB_FormRegular";
            CLB_FormRegular.Size = new System.Drawing.Size(138, 256);
            CLB_FormRegular.TabIndex = 34;
            // 
            // L_FormsSeen
            // 
            L_FormsSeen.Location = new System.Drawing.Point(314, 57);
            L_FormsSeen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_FormsSeen.Name = "L_FormsSeen";
            L_FormsSeen.Size = new System.Drawing.Size(90, 22);
            L_FormsSeen.TabIndex = 35;
            L_FormsSeen.Text = "Forms:";
            L_FormsSeen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CLB_FormShiny
            // 
            CLB_FormShiny.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            CLB_FormShiny.FormattingEnabled = true;
            CLB_FormShiny.Location = new System.Drawing.Point(461, 83);
            CLB_FormShiny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CLB_FormShiny.Name = "CLB_FormShiny";
            CLB_FormShiny.Size = new System.Drawing.Size(138, 256);
            CLB_FormShiny.TabIndex = 36;
            // 
            // L_FormDisplayed
            // 
            L_FormDisplayed.Location = new System.Drawing.Point(461, 57);
            L_FormDisplayed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_FormDisplayed.Name = "L_FormDisplayed";
            L_FormDisplayed.Size = new System.Drawing.Size(103, 22);
            L_FormDisplayed.TabIndex = 37;
            L_FormDisplayed.Text = "Shiny Forms:";
            L_FormDisplayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modifyMenuForms
            // 
            modifyMenuForms.ImageScalingSize = new System.Drawing.Size(20, 20);
            modifyMenuForms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFormNone, mnuFormAllRegular });
            modifyMenuForms.Name = "modifyMenu";
            modifyMenuForms.Size = new System.Drawing.Size(119, 48);
            // 
            // mnuFormNone
            // 
            mnuFormNone.Name = "mnuFormNone";
            mnuFormNone.Size = new System.Drawing.Size(118, 22);
            mnuFormNone.Text = "Clear All";
            mnuFormNone.ToolTipText = "[BDSP/Lumi]\r\nRemove Form data for: \r\nUnown, Castform, Deoxys, \r\nBurmy, Wormadam, Mothim, \r\nCherrim, Shellos, Gastrodon, \r\nRotom, Giratina, Shaymin, Arceus";
            mnuFormNone.Click += ModifyAllForms;
            // 
            // mnuFormAllRegular
            // 
            mnuFormAllRegular.Name = "mnuFormAllRegular";
            mnuFormAllRegular.Size = new System.Drawing.Size(118, 22);
            mnuFormAllRegular.Text = "Seen All";
            mnuFormAllRegular.ToolTipText = "[BDSP/Lumi]\r\nSet Form data for:\r\nUnown, Castform, Deoxys,\r\nBurmy, Wormadam, Mothim, \r\nCherrim, Shellos, Gastrodon, \r\nRotom, Giratina, Shaymin, Arceus\r\n\r\nCTRL+Click: Set Shiny Form Seen data too";
            mnuFormAllRegular.Click += ModifyAllForms;
            // 
            // CB_State
            // 
            CB_State.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            CB_State.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            CB_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_State.DropDownWidth = 95;
            CB_State.FormattingEnabled = true;
            CB_State.Items.AddRange(new object[] { "None", "Heard Of", "Seen", "Captured" });
            CB_State.Location = new System.Drawing.Point(174, 45);
            CB_State.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CB_State.Name = "CB_State";
            CB_State.Size = new System.Drawing.Size(134, 23);
            CB_State.TabIndex = 39;
            // 
            // modifyMenuEntry
            // 
            modifyMenuEntry.ImageScalingSize = new System.Drawing.Size(20, 20);
            modifyMenuEntry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuClearEntry, mnuMFCurLang, mnuMFAllLang });
            modifyMenuEntry.Name = "modifyMenu";
            modifyMenuEntry.Size = new System.Drawing.Size(191, 70);
            // 
            // mnuClearEntry
            // 
            mnuClearEntry.Name = "mnuClearEntry";
            mnuClearEntry.Size = new System.Drawing.Size(190, 22);
            mnuClearEntry.Text = "Clear Entry";
            mnuClearEntry.ToolTipText = "Remove all Seen data";
            mnuClearEntry.Click += ModifyEntry;
            // 
            // mnuMFCurLang
            // 
            mnuMFCurLang.Name = "mnuMFCurLang";
            mnuMFCurLang.Size = new System.Drawing.Size(190, 22);
            mnuMFCurLang.Text = "Caught Base Form(s)";
            mnuMFCurLang.ToolTipText = "Set Male and Female Seen data in current Language\r\n\r\nCTRL+click: Set Shiny Seen data too";
            mnuMFCurLang.Click += ModifyEntry;
            // 
            // mnuMFAllLang
            // 
            mnuMFAllLang.Name = "mnuMFAllLang";
            mnuMFAllLang.Size = new System.Drawing.Size(190, 22);
            mnuMFAllLang.Text = "Caught All Languages";
            mnuMFAllLang.ToolTipText = "Set Male and Female Seen data in all Languages\r\n\r\nCTRL+click: Set Shiny Seen data too\r\n";
            mnuMFAllLang.Click += ModifyEntry;
            // 
            // SAV_PokedexBDSPLumi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(612, 377);
            Controls.Add(CHK_National);
            Controls.Add(B_ModifyForms);
            Controls.Add(CB_State);
            Controls.Add(L_FormDisplayed);
            Controls.Add(CLB_FormShiny);
            Controls.Add(L_FormsSeen);
            Controls.Add(CLB_FormRegular);
            Controls.Add(GB_Encountered);
            Controls.Add(GB_Language);
            Controls.Add(B_Modify);
            Controls.Add(B_Save);
            Controls.Add(B_ModifyEntry);
            Controls.Add(CB_Species);
            Controls.Add(L_goto);
            Controls.Add(LB_Species);
            Controls.Add(B_Cancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = Properties.Resources.Icon;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SAV_PokedexBDSPLumi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Pokédex Editor";
            GB_Language.ResumeLayout(false);
            GB_Language.PerformLayout();
            GB_Encountered.ResumeLayout(false);
            GB_Encountered.PerformLayout();
            modifyMenu.ResumeLayout(false);
            modifyMenuForms.ResumeLayout(false);
            modifyMenuEntry.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.ListBox LB_Species;
        private System.Windows.Forms.CheckBox CHK_LangKOR;
        private System.Windows.Forms.CheckBox CHK_LangSPA;
        private System.Windows.Forms.CheckBox CHK_LangGER;
        private System.Windows.Forms.CheckBox CHK_LangITA;
        private System.Windows.Forms.CheckBox CHK_LangFRE;
        private System.Windows.Forms.CheckBox CHK_LangENG;
        private System.Windows.Forms.CheckBox CHK_LangJPN;
        private System.Windows.Forms.Label L_goto;
        private System.Windows.Forms.ComboBox CB_Species;
        private System.Windows.Forms.Button B_ModifyEntry;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Modify;
        private System.Windows.Forms.GroupBox GB_Language;
        private System.Windows.Forms.GroupBox GB_Encountered;
        private System.Windows.Forms.CheckBox CHK_FS;
        private System.Windows.Forms.CheckBox CHK_MS;
        private System.Windows.Forms.CheckBox CHK_F;
        private System.Windows.Forms.CheckBox CHK_M;
        private System.Windows.Forms.ContextMenuStrip modifyMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuSeenNone;
        private System.Windows.Forms.ToolStripMenuItem mnuSeenAll;
        private System.Windows.Forms.ToolStripMenuItem mnuCaughtNone;
        private System.Windows.Forms.ToolStripMenuItem mnuCaughtAll;
        private System.Windows.Forms.ToolStripMenuItem mnuComplete;
        private System.Windows.Forms.Label L_FormsSeen;
        private System.Windows.Forms.CheckedListBox CLB_FormRegular;
        private System.Windows.Forms.CheckedListBox CLB_FormShiny;
        private System.Windows.Forms.Label L_FormDisplayed;
        private System.Windows.Forms.ContextMenuStrip modifyMenuForms;
        private System.Windows.Forms.ToolStripMenuItem mnuFormNone;
        private System.Windows.Forms.ToolStripMenuItem mnuFormAllRegular;
        private System.Windows.Forms.CheckBox CHK_LangCHT;
        private System.Windows.Forms.CheckBox CHK_LangCHS;
        private System.Windows.Forms.ComboBox CB_State;
        private System.Windows.Forms.Button B_ModifyForms;
        private System.Windows.Forms.CheckBox CHK_National;
        private System.Windows.Forms.ContextMenuStrip modifyMenuEntry;
        private System.Windows.Forms.ToolStripMenuItem mnuMFCurLang;
        private System.Windows.Forms.ToolStripMenuItem mnuMFAllLang;
        private System.Windows.Forms.ToolTip dexTips;
        private System.Windows.Forms.ToolStripMenuItem mnuClearEntry;
    }
}
