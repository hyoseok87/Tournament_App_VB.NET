<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnHome = New MaterialSkin.Controls.MaterialButton()
        btnTournamentInfo = New MaterialSkin.Controls.MaterialButton()
        btnCT = New MaterialSkin.Controls.MaterialButton()
        btnAboutme = New MaterialSkin.Controls.MaterialButton()
        btnTeamInfo = New MaterialSkin.Controls.MaterialButton()
        pnlHintergrund = New Panel()
        lblWillkommen1 = New Label()
        lblWillkommen2 = New Label()
        lblWillkommen3 = New Label()
        pnlTeamInfo = New Panel()
        btnRest = New MaterialSkin.Controls.MaterialButton()
        pbTeamDelete = New PictureBox()
        pbTeamAdd = New PictureBox()
        lbTeamList = New ListBox()
        btnTeamDelete = New MaterialSkin.Controls.MaterialButton()
        btnTeamAdd = New MaterialSkin.Controls.MaterialButton()
        txtTeamName = New TextBox()
        pnlCreateTournament = New Panel()
        btnConfigureDouble = New MaterialSkin.Controls.MaterialButton()
        pbTournament2 = New PictureBox()
        pbTournament1 = New PictureBox()
        lbTeamListFinal = New ListBox()
        btnConfigureSingle = New MaterialSkin.Controls.MaterialButton()
        btnResult = New MaterialSkin.Controls.MaterialButton()
        pnlTournamentInfo = New Panel()
        dgvTournament = New DataGridView()
        pnlResult = New Panel()
        lbSieger = New Label()
        pbTrophaee = New PictureBox()
        pnlAboutMe = New Panel()
        lbEmailAdresse = New Label()
        lbEmail = New Label()
        lbFP2340 = New Label()
        lbLehrgang = New Label()
        lbName = New Label()
        lbgegebeneName = New Label()
        lbAboutMe = New Label()
        btnLoadXML = New MaterialSkin.Controls.MaterialButton()
        pnlLoadedData = New Panel()
        dgvLoadedData = New DataGridView()
        btnLoserBracket = New MaterialSkin.Controls.MaterialButton()
        pnlTeamInfo.SuspendLayout()
        CType(pbTeamDelete, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbTeamAdd, ComponentModel.ISupportInitialize).BeginInit()
        pnlCreateTournament.SuspendLayout()
        CType(pbTournament2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbTournament1, ComponentModel.ISupportInitialize).BeginInit()
        pnlTournamentInfo.SuspendLayout()
        CType(dgvTournament, ComponentModel.ISupportInitialize).BeginInit()
        pnlResult.SuspendLayout()
        CType(pbTrophaee, ComponentModel.ISupportInitialize).BeginInit()
        pnlAboutMe.SuspendLayout()
        pnlLoadedData.SuspendLayout()
        CType(dgvLoadedData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnHome
        ' 
        btnHome.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnHome.Depth = 0
        btnHome.Font = New Font("Pretendard Black", 9F, FontStyle.Bold)
        btnHome.HighEmphasis = True
        btnHome.Icon = Nothing
        btnHome.Location = New Point(7, 81)
        btnHome.Margin = New Padding(4, 6, 4, 6)
        btnHome.MouseState = MaterialSkin.MouseState.HOVER
        btnHome.Name = "btnHome"
        btnHome.NoAccentTextColor = Color.Empty
        btnHome.Size = New Size(64, 36)
        btnHome.TabIndex = 0
        btnHome.Text = "Home"
        btnHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnHome.UseAccentColor = False
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnTournamentInfo
        ' 
        btnTournamentInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnTournamentInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnTournamentInfo.Depth = 0
        btnTournamentInfo.Font = New Font("Pretendard Black", 9F, FontStyle.Bold)
        btnTournamentInfo.HighEmphasis = True
        btnTournamentInfo.Icon = Nothing
        btnTournamentInfo.Location = New Point(495, 81)
        btnTournamentInfo.Margin = New Padding(4, 6, 4, 6)
        btnTournamentInfo.MouseState = MaterialSkin.MouseState.HOVER
        btnTournamentInfo.Name = "btnTournamentInfo"
        btnTournamentInfo.NoAccentTextColor = Color.Empty
        btnTournamentInfo.Size = New Size(223, 36)
        btnTournamentInfo.TabIndex = 1
        btnTournamentInfo.Text = "Tournament Information"
        btnTournamentInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnTournamentInfo.UseAccentColor = False
        btnTournamentInfo.UseVisualStyleBackColor = True
        ' 
        ' btnCT
        ' 
        btnCT.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnCT.Depth = 0
        btnCT.Font = New Font("Pretendard Black", 9F, FontStyle.Bold)
        btnCT.HighEmphasis = True
        btnCT.Icon = Nothing
        btnCT.Location = New Point(281, 81)
        btnCT.Margin = New Padding(4, 6, 4, 6)
        btnCT.MouseState = MaterialSkin.MouseState.HOVER
        btnCT.Name = "btnCT"
        btnCT.NoAccentTextColor = Color.Empty
        btnCT.Size = New Size(191, 36)
        btnCT.TabIndex = 2
        btnCT.Text = "Create a Tournament"
        btnCT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnCT.UseAccentColor = False
        btnCT.UseVisualStyleBackColor = True
        ' 
        ' btnAboutme
        ' 
        btnAboutme.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAboutme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAboutme.Depth = 0
        btnAboutme.Font = New Font("Pretendard Black", 9F, FontStyle.Bold)
        btnAboutme.HighEmphasis = True
        btnAboutme.Icon = Nothing
        btnAboutme.Location = New Point(971, 81)
        btnAboutme.Margin = New Padding(4, 6, 4, 6)
        btnAboutme.MouseState = MaterialSkin.MouseState.HOVER
        btnAboutme.Name = "btnAboutme"
        btnAboutme.NoAccentTextColor = Color.Empty
        btnAboutme.Size = New Size(94, 36)
        btnAboutme.TabIndex = 3
        btnAboutme.Text = "About Me"
        btnAboutme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnAboutme.UseAccentColor = False
        btnAboutme.UseVisualStyleBackColor = True
        ' 
        ' btnTeamInfo
        ' 
        btnTeamInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnTeamInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnTeamInfo.Depth = 0
        btnTeamInfo.Font = New Font("Pretendard Black", 9F, FontStyle.Bold)
        btnTeamInfo.HighEmphasis = True
        btnTeamInfo.Icon = Nothing
        btnTeamInfo.Location = New Point(94, 81)
        btnTeamInfo.Margin = New Padding(4, 6, 4, 6)
        btnTeamInfo.MouseState = MaterialSkin.MouseState.HOVER
        btnTeamInfo.Name = "btnTeamInfo"
        btnTeamInfo.NoAccentTextColor = Color.Empty
        btnTeamInfo.Size = New Size(164, 36)
        btnTeamInfo.TabIndex = 5
        btnTeamInfo.Text = "Team Information"
        btnTeamInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnTeamInfo.UseAccentColor = False
        btnTeamInfo.UseVisualStyleBackColor = True
        ' 
        ' pnlHintergrund
        ' 
        pnlHintergrund.BackgroundImage = CType(resources.GetObject("pnlHintergrund.BackgroundImage"), Image)
        pnlHintergrund.BackgroundImageLayout = ImageLayout.Zoom
        pnlHintergrund.Location = New Point(82, 152)
        pnlHintergrund.Name = "pnlHintergrund"
        pnlHintergrund.Size = New Size(300, 300)
        pnlHintergrund.TabIndex = 6
        ' 
        ' lblWillkommen1
        ' 
        lblWillkommen1.AutoSize = True
        lblWillkommen1.BackColor = SystemColors.Control
        lblWillkommen1.Font = New Font("Monotype Corsiva", 24F, FontStyle.Bold Or FontStyle.Italic)
        lblWillkommen1.Location = New Point(526, 210)
        lblWillkommen1.Name = "lblWillkommen1"
        lblWillkommen1.Size = New Size(172, 39)
        lblWillkommen1.TabIndex = 7
        lblWillkommen1.Text = "Willkommen"
        ' 
        ' lblWillkommen2
        ' 
        lblWillkommen2.AutoSize = True
        lblWillkommen2.BackColor = SystemColors.Control
        lblWillkommen2.Font = New Font("Monotype Corsiva", 24F, FontStyle.Bold Or FontStyle.Italic)
        lblWillkommen2.Location = New Point(526, 282)
        lblWillkommen2.Name = "lblWillkommen2"
        lblWillkommen2.Size = New Size(260, 39)
        lblWillkommen2.TabIndex = 8
        lblWillkommen2.Text = "Unsere Tournament"
        ' 
        ' lblWillkommen3
        ' 
        lblWillkommen3.AutoSize = True
        lblWillkommen3.BackColor = SystemColors.Control
        lblWillkommen3.Font = New Font("Monotype Corsiva", 24F, FontStyle.Bold Or FontStyle.Italic)
        lblWillkommen3.Location = New Point(526, 354)
        lblWillkommen3.Name = "lblWillkommen3"
        lblWillkommen3.Size = New Size(219, 39)
        lblWillkommen3.TabIndex = 9
        lblWillkommen3.Text = "Verwaltungsapp"
        ' 
        ' pnlTeamInfo
        ' 
        pnlTeamInfo.AutoScroll = True
        pnlTeamInfo.Controls.Add(btnRest)
        pnlTeamInfo.Controls.Add(pbTeamDelete)
        pnlTeamInfo.Controls.Add(pbTeamAdd)
        pnlTeamInfo.Controls.Add(lbTeamList)
        pnlTeamInfo.Controls.Add(btnTeamDelete)
        pnlTeamInfo.Controls.Add(btnTeamAdd)
        pnlTeamInfo.Controls.Add(txtTeamName)
        pnlTeamInfo.Location = New Point(0, 125)
        pnlTeamInfo.Name = "pnlTeamInfo"
        pnlTeamInfo.Size = New Size(1071, 469)
        pnlTeamInfo.TabIndex = 10
        ' 
        ' btnRest
        ' 
        btnRest.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnRest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnRest.Depth = 0
        btnRest.HighEmphasis = True
        btnRest.Icon = Nothing
        btnRest.Location = New Point(652, 352)
        btnRest.Margin = New Padding(4, 6, 4, 6)
        btnRest.MouseState = MaterialSkin.MouseState.HOVER
        btnRest.Name = "btnRest"
        btnRest.NoAccentTextColor = Color.Empty
        btnRest.Size = New Size(65, 36)
        btnRest.TabIndex = 6
        btnRest.Text = "Reset"
        btnRest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnRest.UseAccentColor = False
        btnRest.UseVisualStyleBackColor = True
        ' 
        ' pbTeamDelete
        ' 
        pbTeamDelete.Image = CType(resources.GetObject("pbTeamDelete.Image"), Image)
        pbTeamDelete.Location = New Point(804, 157)
        pbTeamDelete.Name = "pbTeamDelete"
        pbTeamDelete.Size = New Size(100, 100)
        pbTeamDelete.TabIndex = 5
        pbTeamDelete.TabStop = False
        ' 
        ' pbTeamAdd
        ' 
        pbTeamAdd.Image = CType(resources.GetObject("pbTeamAdd.Image"), Image)
        pbTeamAdd.Location = New Point(173, 157)
        pbTeamAdd.Name = "pbTeamAdd"
        pbTeamAdd.Size = New Size(100, 100)
        pbTeamAdd.TabIndex = 4
        pbTeamAdd.TabStop = False
        ' 
        ' lbTeamList
        ' 
        lbTeamList.BackColor = SystemColors.Control
        lbTeamList.Font = New Font("Pretendard Variable Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTeamList.FormattingEnabled = True
        lbTeamList.ItemHeight = 23
        lbTeamList.Location = New Point(352, 55)
        lbTeamList.Name = "lbTeamList"
        lbTeamList.Size = New Size(365, 257)
        lbTeamList.TabIndex = 3
        ' 
        ' btnTeamDelete
        ' 
        btnTeamDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnTeamDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnTeamDelete.Depth = 0
        btnTeamDelete.HighEmphasis = True
        btnTeamDelete.Icon = Nothing
        btnTeamDelete.Location = New Point(495, 352)
        btnTeamDelete.Margin = New Padding(4, 6, 4, 6)
        btnTeamDelete.MouseState = MaterialSkin.MouseState.HOVER
        btnTeamDelete.Name = "btnTeamDelete"
        btnTeamDelete.NoAccentTextColor = Color.Empty
        btnTeamDelete.Size = New Size(73, 36)
        btnTeamDelete.TabIndex = 2
        btnTeamDelete.Text = "Delete"
        btnTeamDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnTeamDelete.UseAccentColor = False
        btnTeamDelete.UseVisualStyleBackColor = True
        ' 
        ' btnTeamAdd
        ' 
        btnTeamAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnTeamAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnTeamAdd.Depth = 0
        btnTeamAdd.HighEmphasis = True
        btnTeamAdd.Icon = Nothing
        btnTeamAdd.Location = New Point(352, 352)
        btnTeamAdd.Margin = New Padding(4, 6, 4, 6)
        btnTeamAdd.MouseState = MaterialSkin.MouseState.HOVER
        btnTeamAdd.Name = "btnTeamAdd"
        btnTeamAdd.NoAccentTextColor = Color.Empty
        btnTeamAdd.Size = New Size(64, 36)
        btnTeamAdd.TabIndex = 1
        btnTeamAdd.Text = "ADD"
        btnTeamAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnTeamAdd.UseAccentColor = False
        btnTeamAdd.UseVisualStyleBackColor = True
        ' 
        ' txtTeamName
        ' 
        txtTeamName.Location = New Point(352, 318)
        txtTeamName.Name = "txtTeamName"
        txtTeamName.Size = New Size(365, 23)
        txtTeamName.TabIndex = 0
        ' 
        ' pnlCreateTournament
        ' 
        pnlCreateTournament.AutoScroll = True
        pnlCreateTournament.Controls.Add(btnConfigureDouble)
        pnlCreateTournament.Controls.Add(pbTournament2)
        pnlCreateTournament.Controls.Add(pbTournament1)
        pnlCreateTournament.Controls.Add(lbTeamListFinal)
        pnlCreateTournament.Controls.Add(btnConfigureSingle)
        pnlCreateTournament.Location = New Point(0, 124)
        pnlCreateTournament.Name = "pnlCreateTournament"
        pnlCreateTournament.Size = New Size(1071, 469)
        pnlCreateTournament.TabIndex = 11
        ' 
        ' btnConfigureDouble
        ' 
        btnConfigureDouble.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnConfigureDouble.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnConfigureDouble.Depth = 0
        btnConfigureDouble.HighEmphasis = True
        btnConfigureDouble.Icon = Nothing
        btnConfigureDouble.Location = New Point(466, 401)
        btnConfigureDouble.Margin = New Padding(4, 6, 4, 6)
        btnConfigureDouble.MouseState = MaterialSkin.MouseState.HOVER
        btnConfigureDouble.Name = "btnConfigureDouble"
        btnConfigureDouble.NoAccentTextColor = Color.Empty
        btnConfigureDouble.Size = New Size(160, 36)
        btnConfigureDouble.TabIndex = 6
        btnConfigureDouble.Text = "Configure Double"
        btnConfigureDouble.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnConfigureDouble.UseAccentColor = False
        btnConfigureDouble.UseVisualStyleBackColor = True
        ' 
        ' pbTournament2
        ' 
        pbTournament2.Image = CType(resources.GetObject("pbTournament2.Image"), Image)
        pbTournament2.Location = New Point(804, 158)
        pbTournament2.Name = "pbTournament2"
        pbTournament2.Size = New Size(100, 100)
        pbTournament2.TabIndex = 5
        pbTournament2.TabStop = False
        ' 
        ' pbTournament1
        ' 
        pbTournament1.Image = CType(resources.GetObject("pbTournament1.Image"), Image)
        pbTournament1.Location = New Point(197, 158)
        pbTournament1.Name = "pbTournament1"
        pbTournament1.Size = New Size(100, 100)
        pbTournament1.TabIndex = 4
        pbTournament1.TabStop = False
        ' 
        ' lbTeamListFinal
        ' 
        lbTeamListFinal.BackColor = SystemColors.Control
        lbTeamListFinal.Font = New Font("Pretendard Variable Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTeamListFinal.FormattingEnabled = True
        lbTeamListFinal.ItemHeight = 23
        lbTeamListFinal.Location = New Point(371, 60)
        lbTeamListFinal.Name = "lbTeamListFinal"
        lbTeamListFinal.Size = New Size(365, 257)
        lbTeamListFinal.TabIndex = 3
        ' 
        ' btnConfigureSingle
        ' 
        btnConfigureSingle.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnConfigureSingle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnConfigureSingle.Depth = 0
        btnConfigureSingle.HighEmphasis = True
        btnConfigureSingle.Icon = Nothing
        btnConfigureSingle.Location = New Point(466, 338)
        btnConfigureSingle.Margin = New Padding(4, 6, 4, 6)
        btnConfigureSingle.MouseState = MaterialSkin.MouseState.HOVER
        btnConfigureSingle.Name = "btnConfigureSingle"
        btnConfigureSingle.NoAccentTextColor = Color.Empty
        btnConfigureSingle.Size = New Size(155, 36)
        btnConfigureSingle.TabIndex = 1
        btnConfigureSingle.Text = "Configure Single"
        btnConfigureSingle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnConfigureSingle.UseAccentColor = False
        btnConfigureSingle.UseVisualStyleBackColor = True
        ' 
        ' btnResult
        ' 
        btnResult.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnResult.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnResult.Depth = 0
        btnResult.Font = New Font("Pretendard Black", 9F, FontStyle.Bold)
        btnResult.HighEmphasis = True
        btnResult.Icon = Nothing
        btnResult.Location = New Point(741, 82)
        btnResult.Margin = New Padding(4, 6, 4, 6)
        btnResult.MouseState = MaterialSkin.MouseState.HOVER
        btnResult.Name = "btnResult"
        btnResult.NoAccentTextColor = Color.Empty
        btnResult.Size = New Size(74, 36)
        btnResult.TabIndex = 12
        btnResult.Text = "Result"
        btnResult.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnResult.UseAccentColor = False
        btnResult.UseVisualStyleBackColor = True
        ' 
        ' pnlTournamentInfo
        ' 
        pnlTournamentInfo.AutoScroll = True
        pnlTournamentInfo.Controls.Add(dgvTournament)
        pnlTournamentInfo.Location = New Point(0, 125)
        pnlTournamentInfo.Name = "pnlTournamentInfo"
        pnlTournamentInfo.Size = New Size(1071, 469)
        pnlTournamentInfo.TabIndex = 13
        ' 
        ' dgvTournament
        ' 
        dgvTournament.BackgroundColor = SystemColors.ControlLight
        dgvTournament.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Pretendard", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTournament.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTournament.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTournament.GridColor = SystemColors.ControlLight
        dgvTournament.Location = New Point(173, 85)
        dgvTournament.Name = "dgvTournament"
        dgvTournament.Size = New Size(718, 308)
        dgvTournament.TabIndex = 0
        ' 
        ' pnlResult
        ' 
        pnlResult.AutoScroll = True
        pnlResult.Controls.Add(lbSieger)
        pnlResult.Controls.Add(pbTrophaee)
        pnlResult.Location = New Point(0, 125)
        pnlResult.Name = "pnlResult"
        pnlResult.Size = New Size(1071, 469)
        pnlResult.TabIndex = 14
        ' 
        ' lbSieger
        ' 
        lbSieger.AutoSize = True
        lbSieger.Font = New Font("Pretendard ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbSieger.Location = New Point(480, 370)
        lbSieger.Name = "lbSieger"
        lbSieger.Size = New Size(116, 38)
        lbSieger.TabIndex = 1
        lbSieger.Text = "Label1"
        ' 
        ' pbTrophaee
        ' 
        pbTrophaee.Image = CType(resources.GetObject("pbTrophaee.Image"), Image)
        pbTrophaee.Location = New Point(398, 59)
        pbTrophaee.Name = "pbTrophaee"
        pbTrophaee.Size = New Size(300, 300)
        pbTrophaee.TabIndex = 0
        pbTrophaee.TabStop = False
        ' 
        ' pnlAboutMe
        ' 
        pnlAboutMe.AutoScroll = True
        pnlAboutMe.Controls.Add(lbEmailAdresse)
        pnlAboutMe.Controls.Add(lbEmail)
        pnlAboutMe.Controls.Add(lbFP2340)
        pnlAboutMe.Controls.Add(lbLehrgang)
        pnlAboutMe.Controls.Add(lbName)
        pnlAboutMe.Controls.Add(lbgegebeneName)
        pnlAboutMe.Controls.Add(lbAboutMe)
        pnlAboutMe.Location = New Point(0, 125)
        pnlAboutMe.Name = "pnlAboutMe"
        pnlAboutMe.Size = New Size(1071, 469)
        pnlAboutMe.TabIndex = 15
        ' 
        ' lbEmailAdresse
        ' 
        lbEmailAdresse.AutoSize = True
        lbEmailAdresse.Font = New Font("Pretendard ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbEmailAdresse.Location = New Point(451, 335)
        lbEmailAdresse.Name = "lbEmailAdresse"
        lbEmailAdresse.Size = New Size(445, 38)
        lbEmailAdresse.TabIndex = 7
        lbEmailAdresse.Text = "hyosuck.ham@drv-bund.de"
        ' 
        ' lbEmail
        ' 
        lbEmail.AutoSize = True
        lbEmail.Font = New Font("Pretendard ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbEmail.Location = New Point(235, 335)
        lbEmail.Name = "lbEmail"
        lbEmail.Size = New Size(116, 38)
        lbEmail.TabIndex = 6
        lbEmail.Text = "E-Mail"
        ' 
        ' lbFP2340
        ' 
        lbFP2340.AutoSize = True
        lbFP2340.Font = New Font("Pretendard ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbFP2340.Location = New Point(451, 261)
        lbFP2340.Name = "lbFP2340"
        lbFP2340.Size = New Size(158, 38)
        lbFP2340.TabIndex = 5
        lbFP2340.Text = "FP 23/40"
        ' 
        ' lbLehrgang
        ' 
        lbLehrgang.AutoSize = True
        lbLehrgang.Font = New Font("Pretendard ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbLehrgang.Location = New Point(235, 261)
        lbLehrgang.Name = "lbLehrgang"
        lbLehrgang.Size = New Size(164, 38)
        lbLehrgang.TabIndex = 4
        lbLehrgang.Text = "Lehrgang"
        ' 
        ' lbName
        ' 
        lbName.AutoSize = True
        lbName.Font = New Font("Pretendard ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbName.Location = New Point(235, 188)
        lbName.Name = "lbName"
        lbName.Size = New Size(106, 38)
        lbName.TabIndex = 2
        lbName.Text = "Name"
        ' 
        ' lbgegebeneName
        ' 
        lbgegebeneName.AutoSize = True
        lbgegebeneName.Font = New Font("Pretendard ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbgegebeneName.Location = New Point(451, 186)
        lbgegebeneName.Name = "lbgegebeneName"
        lbgegebeneName.Size = New Size(227, 38)
        lbgegebeneName.TabIndex = 3
        lbgegebeneName.Text = "Hyosuck Ham"
        ' 
        ' lbAboutMe
        ' 
        lbAboutMe.AutoSize = True
        lbAboutMe.Font = New Font("Pretendard ExtraBold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lbAboutMe.Location = New Point(451, 85)
        lbAboutMe.Name = "lbAboutMe"
        lbAboutMe.Size = New Size(249, 58)
        lbAboutMe.TabIndex = 1
        lbAboutMe.Text = "About Me"
        ' 
        ' btnLoadXML
        ' 
        btnLoadXML.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnLoadXML.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnLoadXML.Depth = 0
        btnLoadXML.HighEmphasis = True
        btnLoadXML.Icon = Nothing
        btnLoadXML.Location = New Point(838, 81)
        btnLoadXML.Margin = New Padding(4, 6, 4, 6)
        btnLoadXML.MouseState = MaterialSkin.MouseState.HOVER
        btnLoadXML.Name = "btnLoadXML"
        btnLoadXML.NoAccentTextColor = Color.Empty
        btnLoadXML.Size = New Size(110, 36)
        btnLoadXML.TabIndex = 16
        btnLoadXML.Text = "Import XML"
        btnLoadXML.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnLoadXML.UseAccentColor = False
        btnLoadXML.UseVisualStyleBackColor = True
        ' 
        ' pnlLoadedData
        ' 
        pnlLoadedData.AutoScroll = True
        pnlLoadedData.Controls.Add(dgvLoadedData)
        pnlLoadedData.Location = New Point(0, 125)
        pnlLoadedData.Name = "pnlLoadedData"
        pnlLoadedData.Size = New Size(1071, 469)
        pnlLoadedData.TabIndex = 17
        ' 
        ' dgvLoadedData
        ' 
        dgvLoadedData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLoadedData.Location = New Point(173, 85)
        dgvLoadedData.Name = "dgvLoadedData"
        dgvLoadedData.Size = New Size(718, 308)
        dgvLoadedData.TabIndex = 0
        ' 
        ' btnLoserBracket
        ' 
        btnLoserBracket.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnLoserBracket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnLoserBracket.Depth = 0
        btnLoserBracket.HighEmphasis = True
        btnLoserBracket.Icon = Nothing
        btnLoserBracket.Location = New Point(900, 550)
        btnLoserBracket.Margin = New Padding(4, 6, 4, 6)
        btnLoserBracket.MouseState = MaterialSkin.MouseState.HOVER
        btnLoserBracket.Name = "btnLoserBracket"
        btnLoserBracket.NoAccentTextColor = Color.Empty
        btnLoserBracket.Size = New Size(134, 36)
        btnLoserBracket.TabIndex = 7
        btnLoserBracket.Text = "Loser Bracket"
        btnLoserBracket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnLoserBracket.UseAccentColor = False
        btnLoserBracket.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1072, 595)
        Controls.Add(pnlCreateTournament)
        Controls.Add(pnlTeamInfo)
        Controls.Add(pnlTournamentInfo)
        Controls.Add(pnlResult)
        Controls.Add(pnlLoadedData)
        Controls.Add(pnlAboutMe)
        Controls.Add(lblWillkommen1)
        Controls.Add(lblWillkommen2)
        Controls.Add(lblWillkommen3)
        Controls.Add(pnlHintergrund)
        Controls.Add(btnHome)
        Controls.Add(btnTeamInfo)
        Controls.Add(btnCT)
        Controls.Add(btnTournamentInfo)
        Controls.Add(btnResult)
        Controls.Add(btnLoadXML)
        Controls.Add(btnAboutme)
        Controls.Add(btnLoserBracket)
        Name = "Form1"
        Text = "Tournament App"
        pnlTeamInfo.ResumeLayout(False)
        pnlTeamInfo.PerformLayout()
        CType(pbTeamDelete, ComponentModel.ISupportInitialize).EndInit()
        CType(pbTeamAdd, ComponentModel.ISupportInitialize).EndInit()
        pnlCreateTournament.ResumeLayout(False)
        pnlCreateTournament.PerformLayout()
        CType(pbTournament2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbTournament1, ComponentModel.ISupportInitialize).EndInit()
        pnlTournamentInfo.ResumeLayout(False)
        CType(dgvTournament, ComponentModel.ISupportInitialize).EndInit()
        pnlResult.ResumeLayout(False)
        pnlResult.PerformLayout()
        CType(pbTrophaee, ComponentModel.ISupportInitialize).EndInit()
        pnlAboutMe.ResumeLayout(False)
        pnlAboutMe.PerformLayout()
        pnlLoadedData.ResumeLayout(False)
        CType(dgvLoadedData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Friend WithEvents pnlHintergrund As Panel
    Friend WithEvents lblWillkommen1 As Label
    Friend WithEvents lblWillkommen2 As Label
    Friend WithEvents lblWillkommen3 As Label
    Friend WithEvents pnlTeamInfo As Panel
    Friend WithEvents lbTeamList As ListBox
    Friend WithEvents btnTeamDelete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnTeamAdd As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtTeamName As TextBox
    Friend WithEvents pbTeamDelete As PictureBox
    Friend WithEvents pbTeamAdd As PictureBox
    Friend WithEvents pnlCreateTournament As Panel
    Friend WithEvents lbTeamListFinal As ListBox
    Friend WithEvents btnConfigureSingle As MaterialSkin.Controls.MaterialButton
    Friend WithEvents pbTournament1 As PictureBox
    Friend WithEvents pbTournament2 As PictureBox
    Friend WithEvents btnResult As MaterialSkin.Controls.MaterialButton
    Friend WithEvents pnlTournamentInfo As Panel
    Friend WithEvents dgvTournament As DataGridView
    Friend WithEvents pnlResult As Panel
    Friend WithEvents pbTrophaee As PictureBox
    Friend WithEvents lbSieger As Label
    Friend WithEvents pnlAboutMe As Panel
    Friend WithEvents lbAboutMe As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbgegebeneName As Label
    Friend WithEvents lbLehrgang As Label
    Friend WithEvents lbEmailAdresse As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbFP2340 As Label
    Friend WithEvents btnLoadXML As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnRest As MaterialSkin.Controls.MaterialButton
    Friend WithEvents pnlLoadedData As Panel
    Friend WithEvents dgvLoadedData As DataGridView
    Friend WithEvents btnLoserBracket As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnConfigureDouble As MaterialSkin.Controls.MaterialButton

End Class
