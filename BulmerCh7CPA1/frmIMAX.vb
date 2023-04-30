' Program Name:		IMAX Theatre
' Author:			Mark Bulmer 
' Date:				March 28, 2022
' Purpose:			The IMAX Theatre app determines the showing and calculates the total cost of a specified number of tickets. 

Option Strict On

Public Class frmIMAX

	Private Sub cbolocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShowing.SelectedIndexChanged
		' This event handler allows the user to enter the showing choice
		Dim intShowingChoice As Integer

		intShowingChoice = cboShowing.SelectedIndex

		' Make items visible in the window 
		lblTickets.Visible = True
		txtTickets.Visible = True
		btnTicketCost.Visible = True
		btnClear.Visible = True
		lblCost.Visible = True
		' Clear the labels
		lblCost.Text = ""
		' Set focus on number in tickets text box
		txtTickets.Focus()
	End Sub
	Private Sub btnTicketCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTicketCost.Click
		' This button event handler determines the number of tickets and 
		' displays the cost


		Dim intTicketNumber As Integer
		Dim blnNumberOfTicketsIsValid As Boolean = False
		Dim intShowingChoice As Integer
		Dim decTotalCost As Decimal

		' Call a function to ensure the number of tickets is valid 
		blnNumberOfTicketsIsValid = ValidateNumberOfTickets()
		' If number of tickets is valid, calculate the cost 
		If (blnNumberOfTicketsIsValid) Then
			intTicketNumber = Convert.ToInt32(txtTickets.Text)
			intShowingChoice = cboShowing.SelectedIndex
			Select Case intShowingChoice
				Case 0
					decTotalCost = intTicketNumber * 16
				Case 1
					decTotalCost = intTicketNumber * 27
			End Select
			' Display the cost of the scuba dive 
			lblCost.Text = decTotalCost.ToString("C") & " for the tickets"
		End If
	End Sub

	Private Function ValidateNumberOfTickets() As Boolean
		' This procedure validates the value entered for the number of tickets selected
		Dim intTicketNumber As Integer
		Dim blnValidityCheck As Boolean = False
		Dim strNumberOfTicketsMessage As String = "Please enter the number of tickets (1-12)"
		Dim strMessageBoxTitle As String = "Error"

		Try
			intTicketNumber = Convert.ToInt32(txtTickets.Text)
			If intTicketNumber >= 1 And intTicketNumber <= 12 Then
				blnValidityCheck = True
			Else
				MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
				txtTickets.Focus()
				txtTickets.Clear()
			End If
		Catch Exception As FormatException
			MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
			txtTickets.Focus()
			txtTickets.Clear()
		Catch Exception As OverflowException
			MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
			txtTickets.Focus()
			txtTickets.Clear()
		Catch Exception As SystemException
			MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
			txtTickets.Focus()
			txtTickets.Clear()
		End Try
		Return blnValidityCheck
	End Function

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		' This event handler clears the form and resets the form for reuse when the user clicks the Clear button. 
		cboShowing.Text = "Select Location"
		txtTickets.Clear()
		lblCost.Text = ""
		lblTickets.Visible = False
		txtTickets.Visible = False
		btnTicketCost.Visible = False
		btnClear.Visible = False
		lblCost.Visible = False
	End Sub

	Private Sub frmIMAX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Hold the splash screen for 4 seconds 
		Threading.Thread.Sleep(4000)
	End Sub

	Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

	End Sub
End Class
