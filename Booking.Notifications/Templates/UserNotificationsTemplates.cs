namespace Otus.Booking.Common.Booking.Notifications.Templates
{
    public record UserNotificationsTemplates
    {
        public static string UserCreatedTemplate => @"
            Добрый день @Model.Name @Model.LastName!

            Вы успешно зарегистрировались в системе Booking Entertaimont.
@if (!String.IsNullOrEmpty(Model.Company))
    {
<p>Вы зарегистрированы как сотрудник @Model.Company</p>

    }
            Ваш логином: @Model.Login.
        ";
    }
}
