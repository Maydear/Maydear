using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Maydear.Infrastructure
{
    /// <summary>
    /// Excel电子表格简单读写基础设施
    /// </summary>
    public interface ISimpleExcelInfrastructure
    {
        /// <summary>
        /// 生成excel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="headers"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        Stream Generate<T>(IList<T> data, IDictionary<string, string> headers, string sheetName = "sheet1") where T : class;

        /// <summary>
        /// 生成excel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        Stream Generate<T>(IList<T> data, string sheetName = "sheet1") where T : class;

        /// <summary>
        /// 生成excel
        /// </summary>
        /// <param name="table"></param>
        /// <param name="headers"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        Stream Generate(DataTable table, IDictionary<string, string> headers, string sheetName = "sheet1");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        Stream Generate(DataTable table, string sheetName = "sheet1");

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <param name="headers"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        IList<T> Read<T>(Stream stream, IDictionary<string, string> headers, string sheetName = "sheet1");

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        IList<T> Read<T>(Stream stream, string sheetName = "sheet1");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="headers"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        DataTable ReadToDataTable(Stream stream, IDictionary<string, string> headers, string sheetName = "sheet1");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        DataTable ReadToDataTable(Stream stream, string sheetName = "sheet1");

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="headers"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        IList<T> Read<T>(string filePath, IDictionary<string, string> headers, string sheetName = "sheet1");

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        IList<T> Read<T>(string filePath, string sheetName = "sheet1");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="headers"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        DataTable ReadToDataTable(string filePath, IDictionary<string, string> headers, string sheetName = "sheet1");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        DataTable ReadToDataTable(string filePath, string sheetName = "sheet1");
    }
}
