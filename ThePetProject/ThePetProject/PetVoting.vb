Public Class PetVoting
    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click

        'declare variables
        Dim vote As String
        Dim dogtally, cattally, fishtally, birdtally As Integer

        'do until loop to take in votes until user exits with E
        Do
            vote = InputBox("Vote For Your Favorite Pet! 
A: Dog, B: Cat, C: Fish, D: Bird, E: Exit", "Favorite Pet Voting")
            If (vote = "A") Then
                dogtally = dogtally + 1
            ElseIf (vote = "B") Then
                cattally = cattally + 1
            ElseIf (vote = "C") Then
                fishtally = fishtally + 1
            ElseIf (vote = "D") Then
                birdtally = birdtally + 1
            ElseIf (vote = "E") Then
                MessageBox.Show("Thank You For Voting!")
            Else
                MessageBox.Show("Please Enter a Valid Pet Candidate, Or Exit With 'E'")
            End If

        Loop Until (vote = "E")

        'count up the tally and display voting results in listbox
        lstOut.Items.Add("Dog Total Votes: " & dogtally)
        lstOut.Items.Add("Cat Total Votes: " & cattally)
        lstOut.Items.Add("Fish Total Votes: " & fishtally)
        lstOut.Items.Add("Bird Total Votes: " & birdtally)

        lstOut.Items.Add(" ")

        'calculate the winner of the voting
        If (dogtally > cattally) And (dogtally > fishtally) And (dogtally > birdtally) Then
            lstOut.Items.Add("Dog is the Favorite Pet!")
        ElseIf (cattally > dogtally) And (cattally > fishtally) And (cattally > birdtally) Then
            lstOut.Items.Add("Cat is the Favorite Pet!")
        ElseIf (fishtally > dogtally) And (fishtally > cattally) And (fishtally > birdtally) Then
            lstOut.Items.Add("Fish is the Favorite Pet!")
        ElseIf (birdtally > dogtally) And (birdtally > cattally) And (birdtally > fishtally) Then
            lstOut.Items.Add("Bird is the Favorite Pet!")
        End If

        'use if statements to show picture of winning pet
        If (dogtally > cattally) And (dogtally > fishtally) And (dogtally > birdtally) Then
            picDog.Visible = True
            picCat1.Visible = False
            picFish.Visible = False
            picBird.Visible = False

        ElseIf (cattally > dogtally) And (cattally > fishtally) And (cattally > birdtally) Then
            picDog.Visible = False
            picCat1.Visible = True
            picFish.Visible = False
            picBird.Visible = False

        ElseIf (fishtally > dogtally) And (fishtally > cattally) And (fishtally > birdtally) Then
            picDog.Visible = False
            picCat1.Visible = False
            picFish.Visible = True
            picBird.Visible = False

        ElseIf (birdtally > dogtally) And (birdtally > cattally) And (birdtally > fishtally) Then
            picDog.Visible = False
            picCat1.Visible = False
            picFish.Visible = False
            picBird.Visible = True
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear listbox values and make all pictures reappear 
        lstOut.Items.Clear()
        picDog.Visible = True
        picCat1.Visible = True
        picFish.Visible = True
        picBird.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'exit the program
        Application.Exit()

    End Sub

End Class
