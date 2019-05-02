﻿Public Class BingoBonusCard
    Inherits BingoCard

    Public Overrides Function GameOver(ByVal calledNumbers As Integer(), ByVal tail As Integer) As Integer
        Dim matched As Integer
        matched = FullHouse(calledNumbers, tail)
        If matched = 15 Then
            Return 1 ' if all numbers matched then returns 1
        End If
        Console.WriteLine("You only matched " & matched)
        For x = 0 To 2
            matched = 0
            For y = 0 To 8
                If numbers(x, y) <> 0 Then
                    For z = 0 To tail ' 0 to amount of umbers called
                        If numbers(x, y) = calledNumbers(z) Then
                            matched += 1 ' checks if numbers matched with calledNUmbers
                        End If
                    Next

                End If

            Next


        Next



        Return 0 ' if no numbers matched returns 0



    End Function

    Private Function FullHouse(ByVal calledNumbers As Integer(), ByVal tail As Integer) As Integer
        Dim matched As Integer
        For x = 0 To 2
            For y = 0 To 8
                If numbers(x, y) <> 0 Then
                    For z = 0 To tail ' 0 to amount of umbers called
                        If numbers(x, y) = calledNumbers(z) Then
                            matched += 1 ' checks if numbers matched with calledNe Umbers
                        End If
                    Next
                End If

            Next
        Next
        Return matched
        'new loop to check if the user has a full row 

    End Function


End Class

