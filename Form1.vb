
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Collections.Generic

Public Class Form1

    Friend WithEvents btnHome As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnTournamentInfo As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCT As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAboutme As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnTeamInfo As MaterialSkin.Controls.MaterialButton

    Private teams As New List(Of String)
    Private tournamentBracket As List(Of List(Of String))

    'Einstellungen für die Panel-Sichtbarkeit
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlTeamInfo.Visible = False
        pnlCreateTournament.Visible = False
        pnlTournamentInfo.Visible = False
        pnlResult.Visible = False
        pnlAboutMe.Visible = False
        pnlLoadedData.Visible = False

    End Sub


    'Alle Felder ausblenden und nur ausgewählte Felder anzeigen
    Private Sub SetPanelVisibility(selectedPanel As Panel)


        For Each panel As Panel In Me.Controls.OfType(Of Panel)()
            panel.Visible = False
        Next

        ' Sicherstellen, dass das ausgewählte Panel nicht leer ist und existiert
        If selectedPanel IsNot Nothing AndAlso Me.Controls.Contains(selectedPanel) Then
            selectedPanel.Visible = True

        Else
            ' Wenn das ausgewählte Panel nicht vorhanden ist oder nicht existiert, wird Formular1 angezeigt.
            Me.Visible = True
            SetPanelVisibility(pnlHintergrund)
        End If

    End Sub

    ' button click event handler
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ' Alle Panels schließen und nur das Form1 sichtbar machen
        SetPanelVisibility(Nothing)
    End Sub

    'zeigen das Team Information Panel
    Private Sub btnTeaminfo_Click(sender As Object, e As EventArgs) Handles btnTeamInfo.Click

        SetPanelVisibility(pnlTeamInfo)
    End Sub

    'TeamName hinzufügen Logik

    Private Sub TeamHinzufügen()
        ' Teamnamen aus TextBox abrufen
        Dim teamName As String = txtTeamName.Text.Trim()

        ' Überprüfen, ob der Teamname bereits existiert
        If teams.Contains(teamName) Then
            MessageBox.Show("Der Name existiert bereits." & vbCrLf & "Bitte geben Sie einen anderen Namen ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Überprüfen, ob der Teamname nicht leer ist
            If String.IsNullOrEmpty(teamName) Then
                MessageBox.Show("Bitte geben Sie einen Team Name ein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Nur wenn der Teamname nicht leer ist, füge ihn zur ListBox hinzu
                lbTeamList.Items.Add(teamName)
                teams.Add(teamName) ' Füge ihn auch zur Liste hinzu
                txtTeamName.Clear() ' txtTeamName leeren

            End If
        End If
    End Sub

    'TeamName hinzufüben mit dem Add Button
    Private Sub btnTeamAdd_Click(sender As Object, e As EventArgs) Handles btnTeamAdd.Click
        TeamHinzufügen()
    End Sub

    'TeamName hinzufügen mit Eingabe
    Private Sub txtTeamName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTeamName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TeamHinzufügen()
        End If
    End Sub

    'Team löschen
    Private Sub btnTeamDelete_Click(sender As Object, e As EventArgs) Handles btnTeamDelete.Click
        ' Wenn kein Element ausgewählt ist, eine Nachricht anzeigen und die Funktion beenden
        If lbTeamList.SelectedIndex = -1 Then
            MessageBox.Show("Bitte wählen Sie ein Team aus, um es zu löschen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Wenn ein Element ausgewählt ist, dann ausführen
        Dim selectedTeam As String = lbTeamList.SelectedItem.ToString()
        Dim confirmationMessage As String = $"Möchten Sie wirklich das Team '{selectedTeam}' löschen?"
        Dim result As DialogResult = MessageBox.Show(confirmationMessage, "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            lbTeamList.Items.Remove(selectedTeam)
            teams.Remove(selectedTeam)
        End If
    End Sub

    'Teamlist zurücksetzten
    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        ' Rückfrage zur Bestätigung anzeigen
        Dim confirmationMessage As String = "Möchten Sie wirklich alle Teams löschen und die Liste zurücksetzen?"
        Dim result As DialogResult = MessageBox.Show(confirmationMessage, "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' lbTeamList leeren
            lbTeamList.Items.Clear()

            ' teams Liste leeren
            teams.Clear()

            ' Nachricht anzeigen
            MessageBox.Show("Teamliste erfolgreich zurückgesetzt.")
        End If
    End Sub


    'Turnier erstellen Panel anzeigen
    Private Sub btnCT_Click(sender As Object, e As EventArgs) Handles btnCT.Click

        SetPanelVisibility(pnlCreateTournament)

        'Hole Teaminformationen aus lbTeamListFinal.
        lbTeamListFinal.Items.Clear()
        For Each item As Object In lbTeamList.Items
            lbTeamListFinal.Items.Add(item)
        Next

    End Sub

    ' Turnierbaum konfigurieren
    Private Sub btnConfigureSingle_Click(sender As Object, e As EventArgs) Handles btnConfigureSingle.Click
        Dim confirmation As DialogResult = MessageBox.Show("Haben Sie  alle Teams korrekt eingegeben?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            ' Turnierbaum erstellen
            Dim tournamentBracket As List(Of List(Of String)) = GenerateTournamentBracket(teams)
            ' Turnierbaum als XML importieren
            ExportTournamentBracketToXML(tournamentBracket)
            ' Turnierbaum anzeigen
            ShowSingleEliminationTournamentBracket(tournamentBracket)

            MessageBox.Show("Turnier wurde erfolgreich erstellt")

        ElseIf confirmation = DialogResult.No Then
            '' Wenn Nein geklickt wird, das TeamInfo-Panel anzeigen
            pnlCreateTournament.Visible = False
            pnlTeamInfo.Visible = True

        End If

    End Sub

    ' Funktion zur Simulation eines Matches basierend auf den Teamfähigkeiten
    Private Function SimulateMatchWithSkill(ByVal team1 As String, ByVal team2 As String, ByVal teamSkills As Dictionary(Of String, Double)) As String
        ' Fähigkeiten der Teams abrufen
        Dim skill1 As Double = teamSkills(team1)
        Dim skill2 As Double = teamSkills(team2)

        ' Siegchancen basierend auf den Fähigkeiten berechnen
        Dim totalSkills As Double = skill1 + skill2
        Dim probability1 As Double = skill1 / totalSkills

        ' Zufällige Auswahl des Siegerteams
        If RandomDouble() < probability1 Then
            Return team1
        Else
            Return team2
        End If
    End Function

    ' Funktion zur Generierung einer zufälligen Double-Zahl zwischen 0 und 1
    Private Function RandomDouble() As Double
        Return (New Random().NextDouble() * 4) + 1
    End Function


    Private Function GenerateTournamentBracket(teams As List(Of String)) As List(Of List(Of String))
        Dim tournamentBracket As New List(Of List(Of String))
        Dim remainingTeams As New List(Of String)(teams)  ' Variable zur Verfolgung der nicht ausgewählten Teams

        ' Erstellen der ersten Runde

        Dim boutNumber As Integer = 1 ' Spielnummer
        Dim currentRound As New List(Of String)
        While remainingTeams.Count > 1 ' Wiederholen, solange mehr als 1 Team übrig ist
            ' Zufällige Auswahl der Teams
            Dim team1Index As Integer = New Random().Next(0, remainingTeams.Count)
            Dim team1 As String = remainingTeams(team1Index)
            remainingTeams.RemoveAt(team1Index)

            ' Auswahl des zweiten Teams
            Dim team2Index As Integer = New Random().Next(0, remainingTeams.Count)
            Dim team2 As String = remainingTeams(team2Index)
            remainingTeams.RemoveAt(team2Index)

            ' Speichern der Match-Informationen für die aktuelle Runde
            currentRound.Add($"{boutNumber}. Spiel: {team1} gegen {team2}")
            boutNumber += 1
        End While

        ' Hinzufügen eines Freiloses, falls die Anzahl der Teams ungerade ist
        If remainingTeams.Count = 1 Then
            Dim freilosTeam As String = remainingTeams(0)
            currentRound.Add($"{boutNumber}. Spiel: {freilosTeam}")
            remainingTeams.Remove(freilosTeam)
        End If

        tournamentBracket.Add(currentRound)

        ' Erstellen der nachfolgenden Runden
        Dim previousRoundTeams As List(Of String) = currentRound.Select(Function(match) match.Split(":")(1).Trim().Split("gegen")(0).Trim()).ToList()
        Dim rounds As Integer = Math.Ceiling(Math.Log(teams.Count, 2))
        For roundNumber As Integer = 1 To rounds - 1
            Dim newRound As New List(Of String)
            boutNumber = 1 ' Zurücksetzen der Spielnummer für jede neue Runde
            Dim matchesInRound As Integer = Math.Ceiling(previousRoundTeams.Count / 2)

            ' Erstellen der Matches für die aktuelle Runde
            For i As Integer = 1 To matchesInRound
                ' Auswahl des Gewinners aus der vorherigen Runde
                If previousRoundTeams IsNot Nothing AndAlso previousRoundTeams.Count > 0 Then
                    Dim team1 As String = previousRoundTeams(0)
                    previousRoundTeams.RemoveAt(0)

                    ' Falls ein Freilos-Team ausgewählt wurde, wird nur der Teamname angezeigt
                    If team1 = "freilos" Then
                        newRound.Add($"{boutNumber}. Spiel: {team1}")
                    Else
                        Dim team2 As String = ""
                        If previousRoundTeams.Count > 0 Then
                            Dim team2Index As Integer = New Random().Next(0, previousRoundTeams.Count)
                            team2 = previousRoundTeams(team2Index)
                            previousRoundTeams.RemoveAt(team2Index)
                        End If

                        ' Falls kein Freilos-Team ausgewählt wurde, werden die Match-Informationen mit "gegen" angezeigt
                        If Not String.IsNullOrEmpty(team2) Then
                            newRound.Add($"{boutNumber}. Spiel: {team1} gegen {team2}")
                        Else
                            newRound.Add($"{boutNumber}. Spiel: {team1}")
                        End If


                        ' Falls das Freilos-Team gewinnt, wird sichergestellt, dass es in der nächsten Runde nicht mehr als Freilos bezeichnet wird
                        If team1 = "freilos" AndAlso Not String.IsNullOrEmpty(team2) Then
                            remainingTeams.Remove(team1)
                        ElseIf team2 = "freilos" AndAlso Not String.IsNullOrEmpty(team1) Then
                            remainingTeams.Remove(team2)
                        End If
                    End If
                    boutNumber += 1
                End If
            Next

            ' Aktualisierung der Liste der verwendeten Teams für die aktuelle Runde
            If newRound.Count > 0 Then
                previousRoundTeams = newRound.Select(Function(match) match.Split(":")(1).Trim().Split("gegen")(0).Trim()).ToList()
            End If

            ' Speichern der Match-Informationen für die aktuelle Runde
            If newRound.Count > 0 Then
                tournamentBracket.Add(newRound)
            End If
        Next

        Return tournamentBracket
    End Function

    ' Anzeigen des Turnierbrackets mit DataGridView
    Private Sub ShowSingleEliminationTournamentBracket(tournamentBracket As List(Of List(Of String)))

        If tournamentBracket Is Nothing OrElse tournamentBracket.Count = 0 Then
            MessageBox.Show("Kein Turnierbracket zum Anzeigen.")
            Return
        End If

        Dim dgv As New DataGridView()
        dgv.Dock = DockStyle.Fill
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.ReadOnly = True

        ' Hinzufügen jeder Zeile
        For roundNumber As Integer = 1 To tournamentBracket.Count
            dgv.Columns.Add($"Round{roundNumber}", $"Round {roundNumber}")
        Next

        ' Hinzufügen jeder Spalte
        Dim maxRows As Integer = tournamentBracket.Max(Function(round) round.Count)
        For rowIndex As Integer = 0 To maxRows - 1
            Dim rowData As New List(Of String)
            For roundNumber As Integer = 1 To tournamentBracket.Count
                If rowIndex < tournamentBracket(roundNumber - 1).Count Then
                    rowData.Add(tournamentBracket(roundNumber - 1)(rowIndex))
                Else
                    rowData.Add("") ' Leere Zelle hinzufügen
                End If
            Next
            dgv.Rows.Add(rowData.ToArray())
        Next

        ' DataGridView zum Panel hinzufügen
        pnlTournamentInfo.Controls.Clear()
        pnlTournamentInfo.Controls.Add(dgv)

        ' DisplayWinner-Funktion aufrufen, um die Informationen zum Gewinner anzuzeigen
        DisplayWinner(tournamentBracket)
    End Sub

    ' Den Gewinner aus der letzten Runde erhalten.
    Private Function GetWinner(tournamentBracket As List(Of List(Of String))) As String
        ' Den Gewinner aus dem Matchergebnis erhalten.
        Dim lastRound As List(Of String) = tournamentBracket.LastOrDefault()
        If lastRound IsNot Nothing AndAlso lastRound.Count > 0 Then

            Dim winnerMatch As String = lastRound(lastRound.Count - 1)
            ' Den Namen des Gewinners zurückgeben.
            Return winnerMatch.Split("gegen").Last().Trim()
        End If
        Return "noch nicht dafuer entschieden"
    End Function

    Private Sub DisplayWinner(tournamentBracket As List(Of List(Of String)))
        Dim winner As String = GetWinner(tournamentBracket)
        lbSieger.Text = $"Sieger: {winner}"
    End Sub

    'Zeigt Tournament Information panel 
    Private Sub btnTournamentInfo_Click(sender As Object, e As EventArgs) Handles btnTournamentInfo.Click
        SetPanelVisibility(pnlTournamentInfo)
    End Sub

    'zeigt Result Panel
    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        'Panel zeigen
        SetPanelVisibility(pnlResult)

    End Sub

    'zeigt Aboutme Panel
    Private Sub btnAboutme_Click(sender As Object, e As EventArgs) Handles btnAboutme.Click
        SetPanelVisibility(pnlAboutMe)
    End Sub



    Private Sub ExportTournamentBracketToXML(tournamentData As List(Of List(Of String)))
        ' Dateiauswahldialog anzeigen
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "XML-Dateien (*.xml)|*.xml"
        saveFileDialog.Title = "Turnier-Bracket speichern"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Ausgewählten Dateipfad zum Erstellen einer XML-Datei verwenden
            Dim filePath As String = saveFileDialog.FileName

            ' XML Dokument erstellen
            Dim xmlDocument As New XmlDocument()

            ' Wurzelelement erstellen
            Dim rootElement As XmlElement = xmlDocument.CreateElement("ArrayOfArrayOfString")
            xmlDocument.AppendChild(rootElement)

            ' Turnierdaten zur XML hinzufügen
            For Each matchData As List(Of String) In tournamentData
                Dim arrayElement As XmlElement = xmlDocument.CreateElement("ArrayOfString")

                ' Jede Match-Daten zur XML hinzufügen
                For Each data As String In matchData
                    Dim stringElement As XmlElement = xmlDocument.CreateElement("string")
                    stringElement.InnerText = data
                    arrayElement.AppendChild(stringElement)
                Next

                rootElement.AppendChild(arrayElement)
            Next

            Try
                ' XML-Datei speichern
                xmlDocument.Save(filePath)

                ' Erfolgsmeldung anzeigen
                MessageBox.Show("Turnier-Bracket erfolgreich als XML-Datei exportiert.")
            Catch ex As Exception
                ' Fehlermeldung anzeigen
                MessageBox.Show("Beim Speichern der XML-Datei ist ein Fehler aufgetreten: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Turnier-Bracket als XML-Datei wird nicht exportiert.")
        End If
    End Sub

    Private Sub btnLoadXML_Click(sender As Object, e As EventArgs) Handles btnLoadXML.Click
        'Zeigt ein Panel für Exportieren
        SetPanelVisibility(pnlLoadedData)

        Dim confirmationMessage As String = $"Möchten Sie XML Datei importieren?"
        Dim result As DialogResult = MessageBox.Show(confirmationMessage, "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            'Ruft XML Datei auf
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "XML-Dateien (*.xml)|*.xml"
            openFileDialog.Title = "XML-Datei auswählen"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName
                Dim tournamentData As List(Of List(Of String)) = LoadXMLData(filePath)
                If tournamentData IsNot Nothing Then
                    ShowDataInDataGridView(tournamentData)
                    ' Erfolgsmeldung anzeigen
                    MessageBox.Show("XML Datei ist  erfolgreich importiert.")
                End If
            Else
                pnlLoadedData.Visible = True
            End If


        End If

    End Sub

    Private Function LoadXMLData(filePath As String) As List(Of List(Of String))
        Dim tournamentData As New List(Of List(Of String))

        Try
            Dim xmlDocument As New XmlDocument()
            xmlDocument.Load(filePath)

            ' Daten aus XML lesen
            For Each arrayElement As XmlElement In xmlDocument.DocumentElement.ChildNodes
                Dim matchData As New List(Of String)
                For Each stringElement As XmlElement In arrayElement.ChildNodes
                    matchData.Add(stringElement.InnerText)
                Next
                tournamentData.Add(matchData)
            Next

            Return tournamentData
        Catch ex As Exception
            MessageBox.Show("Beim Importieren der XML-Datei ist ein Fehler aufgetreten: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub ShowDataInDataGridView(tournamentData As List(Of List(Of String)))
        ' DataGridView initialisieren
        dgvLoadedData.Rows.Clear()
        dgvLoadedData.Columns.Clear()

        ' Zeilen hinzufügen
        For roundIndex As Integer = 0 To tournamentData.Count - 1
            dgvLoadedData.Columns.Add($"Round{roundIndex + 1}", $"Round {roundIndex + 1}")
        Next

        ' Spalten hinzufügen
        For rowIndex As Integer = 0 To tournamentData.Max(Function(round) round.Count) - 1
            Dim rowData As New List(Of String)
            For roundIndex As Integer = 0 To tournamentData.Count - 1
                If rowIndex < tournamentData(roundIndex).Count Then
                    rowData.Add(tournamentData(roundIndex)(rowIndex))
                Else
                    rowData.Add("") ' Leere Zelle hinzufügen
                End If
            Next
            dgvLoadedData.Rows.Add(rowData.ToArray())
        Next

        ' DataGridView zur Panel hinzufügen
        pnlLoadedData.Controls.Clear()
        pnlLoadedData.Controls.Add(dgvLoadedData)
    End Sub

    ' Funktion zum Konfigurieren des Double-Elimination-Turniers
    Private Sub btnConfigureDouble_Click(sender As Object, e As EventArgs) Handles btnConfigureDouble.Click

        ' Benutzerbestätigung einholen
        Dim confirmation As DialogResult = MessageBox.Show("Haben Sie alle Teams korrekt eingegeben?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            ' Double-Elimination-Turnier erstellen
            Dim doubleEliminationBracket As List(Of List(Of String)) = GenerateDoubleEliminationBracket(teams)

            ExportTournamentBracketToXML(tournamentBracket)
            ' Double-Elimination-Turnier anzeigen
            ShowDoubleEliminationTournamentBracket(doubleEliminationBracket)

            MessageBox.Show("Turnier erfolgreich erstellt.")
        ElseIf confirmation = DialogResult.No Then
            ' Bei Nein das Team-Info-Panel anzeigen
            pnlCreateTournament.Visible = False
            pnlTeamInfo.Visible = True
        End If
    End Sub

    Private Function GenerateDoubleEliminationBracket(teams As List(Of String)) As List(Of List(Of String))
        Dim doubleEliminationBracket As New List(Of List(Of String))

        ' Erste Runde erstellen
        Dim winnersBracket As New List(Of String)
        Dim losersBracket As New List(Of String)

        For Each team As String In teams
            winnersBracket.Add(team)
        Next

        ' Spiele hinzufügen, während das Winners-Bracket und Losers-Bracket durchgeführt werden
        Dim roundNumber As Integer = 1

        While winnersBracket.Count > 1
            Dim currentRound As New List(Of String)
            Dim winnersBracketCopy As New List(Of String)(winnersBracket)
            For i As Integer = 0 To winnersBracketCopy.Count - 1 Step 2
                If i + 1 < winnersBracketCopy.Count Then ' 인덱스가 리스트의 범위를 벗어나지 않도록 확인
                    Dim team1 As String = winnersBracketCopy(i)
                    Dim opponentTeam As String = winnersBracketCopy(i + 1)
                    ' Spiel hinzufügen
                    currentRound.Add($" {roundNumber}.Spiel: {team1} gegen {opponentTeam}")
                Else
                    ' 만약 팀의 수가 홀수라면 한 팀은 자유로운 경기를 가집니다.
                    currentRound.Add($" {roundNumber}.Spiel:  {winnersBracketCopy(i)}")
                End If
            Next
            doubleEliminationBracket.Add(currentRound)
            roundNumber += 1

            ' Winners-Bracket aktualisieren
            winnersBracket.Clear()
            For Each roundGame As String In currentRound
                Dim gameParts() As String = roundGame.Split(" gegen ")
                If gameParts.Length = 2 Then
                    Dim winner As String = SimulateMatch(gameParts(0), gameParts(1)) ' Spiel simulieren, um tatsächlichen Gewinner zu bestimmen
                    winnersBracket.Add(winner)
                End If
            Next

            ' Losers-Bracket aktualisieren
            For i As Integer = 0 To winnersBracketCopy.Count - 1 Step 2
                If i + 1 < winnersBracketCopy.Count Then ' 인덱스가 리스트의 범위를 벗어나지 않도록 확인
                    Dim team1 As String = winnersBracketCopy(i)
                    Dim team2 As String = winnersBracketCopy(i + 1)
                    Dim loser As String = If(winnersBracket.Contains(team1), team2, team1)
                    losersBracket.Add(loser)
                End If
            Next
        End While

        ' Verbleibende Teams dem Losers-Bracket hinzufügen
        For Each team As String In losersBracket
            doubleEliminationBracket.Add(New List(Of String) From {team})
        Next

        Return doubleEliminationBracket
    End Function

    Private Sub ShowDoubleEliminationTournamentBracket(doubleEliminationBracket As List(Of List(Of String)))
        If doubleEliminationBracket Is Nothing OrElse doubleEliminationBracket.Count = 0 Then
            MessageBox.Show("Kein Double-Elimination-Turnierbracket zum Anzeigen.")
            Return
        End If

        Dim upperBracket As New DataGridView()
        upperBracket.Dock = DockStyle.Top
        upperBracket.AllowUserToAddRows = False
        upperBracket.AllowUserToDeleteRows = False
        upperBracket.ReadOnly = True

        Dim lowerBracket As New DataGridView()
        lowerBracket.Dock = DockStyle.Bottom
        lowerBracket.AllowUserToAddRows = False
        lowerBracket.AllowUserToDeleteRows = False
        lowerBracket.ReadOnly = True

        ' Upper Bracket 표시
        Dim upperBracketRounds As Integer = doubleEliminationBracket.Count \ 2 + 1
        For roundNumber As Integer = 1 To upperBracketRounds
            upperBracket.Columns.Add($"UpperBracketRound{roundNumber}", $"Upper Bracket Round {roundNumber}")
        Next

        ' Lower Bracket 표시 (결승전까지만)
        Dim lowerBracketRounds As Integer = doubleEliminationBracket.Count \ 2
        For roundNumber As Integer = 1 To lowerBracketRounds
            lowerBracket.Columns.Add($"LowerBracketRound{roundNumber}", $"Lower Bracket Round {roundNumber}")
        Next

        ' 각 Bracket에 데이터 추가
        Dim maxRows As Integer = doubleEliminationBracket.Max(Function(round) round.Count)

        For rowIndex As Integer = 0 To maxRows - 1
            Dim upperBracketRowData As New List(Of String)
            Dim lowerBracketRowData As New List(Of String)

            For roundNumber As Integer = 1 To doubleEliminationBracket.Count
                Dim bracketData As String = If(rowIndex < doubleEliminationBracket(roundNumber - 1).Count, doubleEliminationBracket(roundNumber - 1)(rowIndex), "")
                If roundNumber <= upperBracketRounds Then
                    upperBracketRowData.Add(bracketData)
                ElseIf roundNumber <= doubleEliminationBracket.Count Then
                    lowerBracketRowData.Add(bracketData)
                End If
            Next

            upperBracket.Rows.Add(upperBracketRowData.ToArray())
            lowerBracket.Rows.Add(lowerBracketRowData.ToArray())
        Next

        ' Panel에 DataGridView 추가
        pnlTournamentInfo.Controls.Clear()
        pnlTournamentInfo.Controls.Add(upperBracket)
        pnlTournamentInfo.Controls.Add(lowerBracket)

        ' 우승팀 정보 표시
        DisplayDoubleEliminationWinner(doubleEliminationBracket)
    End Sub








    ' Funktion zur Anzeige des Double-Elimination-Turnierbrackets
    'Private Sub ShowDoubleEliminationTournamentBracket(doubleEliminationBracket As List(Of List(Of String)))
    '    If doubleEliminationBracket Is Nothing OrElse doubleEliminationBracket.Count = 0 Then
    '        MessageBox.Show("Kein Double-Elimination-Turnierbracket zum Anzeigen.")
    '        Return
    '    End If

    '    Dim dgv As New DataGridView()
    '    dgv.Dock = DockStyle.Fill
    '    dgv.AllowUserToAddRows = False
    '    dgv.AllowUserToDeleteRows = False
    '    dgv.ReadOnly = True

    '    ' Jede Runde hinzufügen
    '    For roundNumber As Integer = 1 To doubleEliminationBracket.Count
    '        dgv.Columns.Add($"DoubleRound{roundNumber}", $"Double Round {roundNumber}")
    '    Next

    '    ' Jede Zeile hinzufügen
    '    Dim maxRows As Integer = doubleEliminationBracket.Max(Function(round) round.Count)
    '    For rowIndex As Integer = 0 To maxRows - 1
    '        Dim rowData As New List(Of String)
    '        For roundNumber As Integer = 1 To doubleEliminationBracket.Count
    '            If rowIndex < doubleEliminationBracket(roundNumber - 1).Count Then
    '                rowData.Add(doubleEliminationBracket(roundNumber - 1)(rowIndex))
    '            Else
    '                rowData.Add("") ' Leere Zelle hinzufügen
    '            End If
    '        Next
    '        dgv.Rows.Add(rowData.ToArray())
    '    Next

    '    ' DataGridView zum Panel hinzufügen
    '    pnlTournamentInfo.Controls.Clear()
    '    pnlTournamentInfo.Controls.Add(dgv)

    '    ' Gewinnerinformationen anzeigen
    '    DisplayDoubleEliminationWinner(doubleEliminationBracket)
    'End Sub



    Private Sub DisplayDoubleEliminationWinner(tournamentBracket As List(Of List(Of String)))
        Dim winner As String = GetWinner(tournamentBracket)
        lbSieger.Text = $"Sieger: {winner}"
    End Sub
    Private Function SimulateMatch(ByVal team1 As String, ByVal team2 As String) As String
        ' 각 팀의 능력치를 1부터 5까지의 랜덤한 값으로 설정
        Dim skill1 As Integer = New Random().Next(1, 6)
        Dim skill2 As Integer = New Random().Next(1, 6)

        ' 승자 결정
        If skill1 > skill2 Then
            Return team1
        ElseIf skill2 > skill1 Then
            Return team2
        Else
            ' 능력치가 같을 경우 무작위로 승자 선택
            If New Random().Next(2) = 0 Then
                Return team1
            Else
                Return team2
            End If
        End If
    End Function



End Class










