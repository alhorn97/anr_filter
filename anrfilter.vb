Imports System.IO

Module Module1



    Sub Main()

        Dim varFILE As String
        varFILE = Command()
        'Dim SR As New StreamReader("c:\temp\path_check.txt")
        Dim SR As New StreamReader(varFILE)
        Dim input As String
        Dim varSTRING1 As String
        Dim ctr As Integer
        Dim line(700) As String
        ctr = 0



        Do
            input = SR.ReadLine
            varSTRING1 = LCase(Trim(input))

            If Not Left(varSTRING1, 3) = "anr" Then
                line(ctr) = varSTRING1
                ctr = ctr + 1
                'GoTo bottom1
            End If

        Loop Until input Is Nothing


bottom1:
        SR.Close()

        Dim tw As TextWriter = File.CreateText("c:\temp\results.txt")

        'tw.WriteLine("The following drives or paths are not online:")
        'tw.WriteLine()

        For i = 0 To ctr
            tw.WriteLine(line(i))
        Next

        'tw.WriteLine()
        'tw.WriteLine("Please check!")

        tw.close()

        ' Console.ReadKey()
        End


    End Sub

End Module
