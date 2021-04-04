namespace Example.Web.Infrastructure.Exceptions
{
    using System;

    public static class ExceptionExtensions
    {
        public static T MustExist<T>(this T value)
            where T : class
        {
            if (value is null)
            {
                throw new NotFoundException();
            }

            return value;
        }

        public static T NotFoundIf<T>(this T value, Func<T, bool> func)
            where T : class
        {
            if (func(value))
            {
                throw new NotFoundException();
            }

            return value;
        }

        public static T ForbidIf<T>(this T value, Func<T, bool> func)
        {
            if (func(value))
            {
                throw new ForbiddenException();
            }

            return value;
        }

        public static T BadRequestIf<T>(this T value, Func<T, bool> func)
        {
            if (func(value))
            {
                throw new BadRequestException();
            }

            return value;
        }
    }
}
