﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Couchbase.Linq.QueryGeneration.MethodCallTranslators
{
    class MetaMethodCallTranslator : IMethodCallTranslator
    {
        public static readonly MethodInfo[] SupportedMethods = {
            typeof (N1Ql).GetMethod("Meta")
        };

        public Expression Translate(MethodCallExpression methodCallExpression, N1QlExpressionTreeVisitor expressionTreeVisitor)
        {
            if (methodCallExpression == null)
            {
                throw new ArgumentNullException("methodCallExpression");
            }

            var expression = expressionTreeVisitor.Expression;

            expression.Append("META(");
            expressionTreeVisitor.VisitExpression(methodCallExpression.Arguments[0]);
            expression.Append(')');

            return methodCallExpression;
        }
    }
}
