using AutoMapper;

namespace AcmeCursos.WCFClient
{
    public static class ObjectExtensions
    {
        public static TResult MapTo<TResult>(this object obj)
        {
            return Mapper.Map<TResult>(obj);
        }

        public static TResult MapTo<TSource, TResult>(this TSource obj, TResult dest)
        {
            return Mapper.Map(obj, dest);
        }
    }
}