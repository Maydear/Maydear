using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Maydear.Utilities
{
    public static class XmlSerializerHelper
    {
        /// <summary>
        /// Xml字符串转实体对象
        /// </summary>
        /// <typeparam name="T">实体对象类型</typeparam>
        /// <param name="xmlStr">Xml字符串</param>
        /// <returns></returns>
        public static T Deserialize<T>(string xmlStr) where T : class
        {
            try
            {
                using (StringReader stringReader = new StringReader(xmlStr))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return serializer.Deserialize(stringReader) as T;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 实体对象转Xml字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize<T>(T entity) where T : class
        {
            try
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    XmlSerializer serializer = new XmlSerializer(entity.GetType());
                    serializer.Serialize(stringWriter, entity);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
