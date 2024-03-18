namespace Otus.Booking.Common.Booking.NotificationsTemplates.Templates
{
    public record UserNotificationsTemplates
    {
        public static string UserCreatedBodyTemplate => @"
            Добрый день @Model.Name @Model.LastName!

            Вы успешно зарегистрировались в системе Booking Entertaimont.

            Ваш логином: @Model.Login.
        ";

        public static string UserCreatedSubjectTemplate =>
            "Вы успешно зарегистрировались в системе Booking Entertaimont.";
    }
}
