using System;

namespace S24S.Solr.Api.Http
{
    /// <summary>
    /// Basic interface to read/write jason syntax to .net objects
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHttpJson<T>
    {
        /// <summary>
        /// Gets the object from json string.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        T GetObjectFromJsonString(String json);
        /// <summary>
        /// Gets the object from json stream.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        T GetObjectFromJsonUrl(String url);
        /// <summary>
        /// Gets the object from json stream.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="userAgaent">The user agaent.</param>
        /// <returns></returns>
        T GetObjectFromJsonUrl(String url, String userAgaent);

        /// <summary>
        /// Gets the string from json URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="userAgent">The user agent.</param>
        /// <returns></returns>
		//string GetStringFromJsonUrl(String url, String userAgent);
        /// <summary>
        /// Writes the object to json string.
        /// </summary>
        /// <param name="sourceObject">The source object.</param>
        /// <returns></returns>
        String WriteObjectToJsonString(T sourceObject);
        /// <summary>
        /// Writes the object in json format to a text file.
        /// </summary>
        /// <param name="sourceObject">The source object.</param>
        /// <param name="fileUri">The file URI. e.g. d:\data\jsonObjects.txt</param>
        void WriteObjectToJsonFileStream(T sourceObject, String fileUri);
    }
}
