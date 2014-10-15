' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
    
    End Sub
    Private Sub txt1_Checked(sender As Object, e As RoutedEventArgs) Handles txt1.Checked
        txtString.Visibility = Windows.UI.Xaml.Visibility.Collapsed

    End Sub
    Private Sub txt1_UnChecked(sender As Object, e As RoutedEventArgs) Handles txt1.Unchecked
        txtString.Visibility = Windows.UI.Xaml.Visibility.Visible
    End Sub
End Class
