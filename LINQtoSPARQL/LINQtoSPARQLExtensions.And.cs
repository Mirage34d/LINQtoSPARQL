﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HelperExtensionsLibrary.Strings;

namespace LINQtoSPARQLSpace
{
    public static partial class LINQtoSPARQLExtensions
    {
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="S">subject</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, string S, string P, string O)
        {
            return source.Match<T>(S, P, O);
        }

        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, string P, string O)
        {
            return (ISPARQLMatchedQueryable<T>)source.And_2<T>(P, O);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        private static ISPARQLQueryable<T> And_2<T>(this ISPARQLQueryable source, string P, string O)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            return source.Provider.CreateSPARQLQuery<T>(Expression.Call(null, ((MethodInfo) MethodBase.GetCurrentMethod()).MakeGenericMethod(new Type[] { typeof(T) }),
                new Expression[] { source.Expression, Expression.Constant(P), Expression.Constant(O) }));
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, string O)
        {
            return (ISPARQLMatchedQueryable<T>)source.And_1<T>(O);
        }

        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        private static ISPARQLQueryable And_1<T>(this ISPARQLQueryable source, string O)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            return source.Provider.CreateSPARQLQuery<T>(Expression.Call(null, ((MethodInfo) MethodBase.GetCurrentMethod()).MakeGenericMethod(new Type[] { typeof(T) }),
                new Expression[] { source.Expression, Expression.Constant(O) }));
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="S">subject</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, Expression<Func<T, dynamic>> S, string P, string O)
        {
            return source.Match<T>(S, P, O);
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="S"></param>
        /// <param name="P"></param>
        /// <param name="O"></param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, string S, Expression<Func<T, dynamic>> P, string O)
        {
            return source.Match<T>(S, P, O);
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source"></param>
        /// <param name="S">subject</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns></returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, string S, string P, Expression<Func<T, dynamic>> O)
        {
            return source.Match<T>(S, P, O);
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="S">subject</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, Expression<Func<T, dynamic>> S, Expression<Func<T, dynamic>> P, string O)
        {
            return source.Match<T>(S, P, O);
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="S">subject</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, Expression<Func<T, dynamic>> S, string P, Expression<Func<T, dynamic>> O)
        {
            return source.Match<T>(S, P, O);
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="S">subject</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, string S, Expression<Func<T, dynamic>> P, Expression<Func<T, dynamic>> O)
        {
            return source.Match<T>(S, P, O);
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="S">subject</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, Expression<Func<T, dynamic>> S, Expression<Func<T, dynamic>> P, Expression<Func<T, dynamic>> O)
        {
            return source.Match<T>(S, P, O);
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, Expression<Func<T, dynamic>> P, string O)
        {
            string pName = "?" + ((MemberExpression)P.Body).Member.Name.ToLower();
            return (ISPARQLMatchedQueryable<T>)source.And_2<T>(pName, O);
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, Expression<Func<T, dynamic>> P, Expression<Func<T, dynamic>> O)
        {
            string pName = "?" + ((MemberExpression)P.Body).Member.Name.ToLower();
            string oName = "?" + ((MemberExpression)O.Body).Member.Name.ToLower();
            return (ISPARQLMatchedQueryable<T>)source.And_2<T>(pName, oName);
        }
        /// <summary>
        /// Match expression
        /// </summary>
        /// <typeparam name="T">element type</typeparam>
        /// <param name="source">query</param>
        /// <param name="P">predicate</param>
        /// <param name="O">object</param>
        /// <returns>query</returns>
        public static ISPARQLMatchedQueryable<T> And<T>(this ISPARQLMatchedQueryable<T> source, string P, Expression<Func<T, dynamic>> O)
        {
            string oName = "?" + ((MemberExpression)O.Body).Member.Name.ToLower();
            return (ISPARQLMatchedQueryable<T>)source.And_2<T>(P, oName);
        }

    }
}
