Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms


Public Class frmMain
    Public returnStr As String = ""
    Private WithEvents serialPort As SerialPort
    Private receivingThread As Thread
    Private keepReceiving As Boolean = True



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '첫 실행 시, 시리얼 포트 목록을 획득
        GetSerialPortNames()

        TreeView1.ExpandAll()
    End Sub

    'HW의 포트 구성요소를 획득하여 드랍다운 아이템에 추가
    Public Sub GetSerialPortNames()
        ' Show all available COM ports.
        Dim indexNum As Integer = 0
        tsSplitbtnPort.DropDownItems.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames

            tsSplitbtnPort.DropDownItems.Add(sp)
            indexNum = +1
        Next

        If tsSplitbtnPort.DropDownItems.Count <= 0 Then
            tsSplitbtnPort.Enabled = False
        Else
            tsSplitbtnPort.Enabled = True
        End If
    End Sub

    '드랍다운 아이템에서 선택한 아이템을 컴포넌트의 텍스트로 적용
    Private Sub tsSplitbtnPort_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsSplitbtnPort.DropDownItemClicked
        tsSplitbtnPort.Text = e.ClickedItem.Text
    End Sub

    Private Sub tsBtnConnect_Click(sender As Object, e As EventArgs) Handles tsBtnConnect.Click

        Try
            serialPort = New SerialPort(tsSplitbtnPort.Text, 115200, Parity.None, 8, StopBits.One)
            serialPort.Open()

            '정상적으로 연결되었는지 확인하기 위한 테스트 코드
            'SendData(Now() & ": 시리얼 통신 시작" & vbCrLf)
            'serialPort.ReadTimeout = 10000
            keepReceiving = True
            tsBtnConnect.Text = "disconnect"

        Catch ex As TimeoutException
            returnStr = "error : serial port read time out"
            MsgBox(returnStr)
        Catch ex As Exception
            returnStr = "error : reject connect"
            MsgBox(returnStr)
        Finally
            'If serialPort IsNot Nothing Then serialPort.Close()
        End Try
        Console.WriteLine(serialPort.ReceivedBytesThreshold)
    End Sub

    ' 데이터 수신을 위한 비동기 이벤트 핸들러
    Public Sub serialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        '수신된 메시지 자동 응답 함수 실행
        autoAnswer(serialPort.ReadExisting(), "$", "*", "<<")

    End Sub

    Private Function autoAnswer(ByVal receviedValue As String, startLetter As String, checksumLetter As String, msgDirect As String)
        '수신 데이터에 복수의 데이터가 포함되어 있을 수 있으므로, 수신 데이터를 $로 구분하여 배열에 저장
        Dim receivedDATAs() As String = Split(receviedValue, startLetter)
        '수신 데이터 배열의 인덱스를 구분하기 위한 변수
        Dim indexOfreceviedData As Integer = 0


        For indexOfreceviedData = 0 To receivedDATAs.Count - 1
            If receivedDATAs(indexOfreceviedData).Contains(checksumLetter) = True Then

                '수신 데이터이므로 <<를 추가
                addData(Now() & msgDirect & receivedDATAs(indexOfreceviedData), False)
                Dim autoSendValue As String = vbNullString
                Dim i As Integer = 0
                '수신 데이터의 명령을 트리뷰에서 찾아서 자식 노드의 응답값으로 자동 송신
                autoSendValue = vbNullString
                Dim strSearchstring As String
                '수신 데이터에서 체크섬 이후의 값을 삭제하여 검색어 생성.
                strSearchstring = Microsoft.VisualBasic.Strings.Left(receivedDATAs(indexOfreceviedData), InStr(receivedDATAs(indexOfreceviedData), checksumLetter) - 1)

                '트리 노드의 개수 만큼 for문 반복하여 각 노드의 정보 획득
                For i = 0 To TreeView1.Nodes.Count - 1
                    If TreeView1.Nodes.Item(i).Checked Then
                        If TreeView1.Nodes.Item(i).Text = strSearchstring Then
                            '자동 응답으로 전송하려는 응답값을 트리 노드에서 검색하여 존재할 경우 
                            autoSendValue = TreeView1.Nodes.Item(i).Nodes.Item(0).Text
                            SendData(autoSendValue)
                            Exit For
                            '자동 응답을 완료하지 못하면 false 반환
                            Return False
                        End If
                    End If
                    Console.WriteLine(i & strSearchstring)
                Next
            End If
        Next
        '자동 응답을 완료하면 true 반환
        Return True
    End Function


    ' 데이터 송신
    Public Function SendData(ByVal data As String) As Boolean
        Console.WriteLine(Me.Text & "포트 열림 상태" & serialPort.IsOpen)

        If serialPort IsNot Nothing AndAlso serialPort.IsOpen Then
            Console.WriteLine("데이터 전송합니다." & data)
            Try
                serialPort.WriteLine(data)
                addData(Now() & " >> " & data, True)
                Console.WriteLine("송신: " & data)
                Return True
            Catch ex As Exception

                Console.WriteLine("===============")
                Console.WriteLine("송신 오류: " & ex.Message)
                Console.WriteLine("오류 내용" & ex.GetBaseException.ToString)
                Console.WriteLine("===============")
                Return False
            End Try
        Else
            Console.WriteLine("포트 안 열려있는뎅")
            Return False
        End If
    End Function

    'Data를 List Box에 추가
    Public Sub addData(ByVal str_addDATA As String, isSendData As Boolean)
        If ListBox1.InvokeRequired Then
            ListBox1.Invoke(Sub() ListBox1.Items.Add(str_addDATA))
        Else
            ListBox1.Items.Add(str_addDATA)
        End If
    End Sub

    ' 데이터 송신  버튼의 이벤트 핸들러
    Private Sub Btn_DataSend_Click(sender As Object, e As EventArgs) Handles btn_DataSend.Click
        Dim data As String = tb_sendMessage.Text
        If SendData(data) Then
            Console.WriteLine("송신 성공: " & data)
        Else
            Console.WriteLine("송신 실패")
        End If
    End Sub

    ' 시리얼 포트 닫기
    Public Sub ClosePort()
        Try
            keepReceiving = False
            If serialPort IsNot Nothing AndAlso serialPort.IsOpen Then
                serialPort.Close()
                Console.WriteLine("시리얼 포트가 닫혔습니다.")
            End If
        Catch ex As Exception
            Console.WriteLine("포트 닫기 오류: " & ex.Message)
        End Try
    End Sub

    Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBox1.DrawItem
        If tsBtnConnect.Text = "Connect" Then
            Exit Sub
        Else
            e.DrawBackground()
            Dim brush As Brush = Brushes.Black
            Dim direction As String = ListBox1.Items(e.Index).ToString
            '수발신 데이터에 << 가 포함되어 있으면 수신, >>가 포함되어 있으면 송신으로 판단
            If direction.IndexOf("<<") > 0 Then
                direction = "<<"
            Else
                direction = ">>"
            End If
            ' 수발신 데이터에 따라 색상을 다르게 표시
            If direction = "<<" Then
                brush = Brushes.HotPink
            Else
                brush = Brushes.DarkGreen
            End If

            If e.Index >= 0 Then
                e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault)
            End If
        End If
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        tb_sendMessage.Text = e.Node.Text
        SendData(tb_sendMessage.Text)
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        tb_sendMessage.Text = e.Node.Text
    End Sub

    Private Sub tb_sendMessage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_sendMessage.KeyPress
        If e.KeyChar.Equals(Keys.Enter) Then SendData(tb_sendMessage.Text)
    End Sub
End Class


