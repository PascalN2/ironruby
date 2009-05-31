﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Microsoft Public License. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Microsoft Public License, please send an email to 
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Microsoft Public License.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

using Microsoft.Scripting.Actions;
using Microsoft.Scripting.Generation;
using System.Linq.Expressions;
using IronPython.Runtime.Operations;
using Microsoft.Scripting;

namespace IronPython.Runtime.Binding {

    partial class BinaryRetTypeBinder : ComboBinder {
        public override T BindDelegate<T>(CallSite<T> site, object[] args) {
            if (_convBinder.Type == typeof(bool) && _opBinder is PythonBinaryOperationBinder) {
                T res = null;
                
                BinaryOperationBinder opBinder = (BinaryOperationBinder)_opBinder;

                #region Generated Python Fast Ops RetBool Chooser

                // *** BEGIN GENERATED CODE ***
                // generated by function: fast_op_ret_bool_chooser from: generate_ops.py

                if (CompilerHelpers.GetType(args[0]) == typeof(int) && CompilerHelpers.GetType(args[1]) == typeof(int)) {
                    if (typeof(T) == typeof(Func<CallSite, int, int, bool>)) {
                        res = (T)(object)GetIntIntIntDelegate(opBinder);
                    }
                    else if (typeof(T) == typeof(Func<CallSite, int, object, bool>)) {
                        res = (T)(object)GetIntIntObjectDelegate(opBinder);
                    }
                    else if (typeof(T) == typeof(Func<CallSite, object, int, bool>)) {
                        res = (T)(object)GetIntObjectIntDelegate(opBinder);
                    }
                    else if (typeof(T) == typeof(Func<CallSite, object, object, bool>)) {
                        res = (T)(object)GetIntObjectObjectDelegate(opBinder);
                    }
                }

                // *** END GENERATED CODE ***

                #endregion

                if (res != null) {
                    CacheTarget(res);
                    return res;
                }
            }

            return base.BindDelegate<T>(site, args);
        }
        /*
        private Func<CallSite, object, object, bool> GetStringObjectObjectDelegate(BinaryOperationBinder opBinder) {
            switch(opBinder.Operation) {
                case ExpressionType.Equal: return StringEqualRetBool;
                case ExpressionType.NotEqual: return StringNotEqualRetBool;
                case ExpressionType.GreaterThan: return StringGreaterThanRetBool;
                case ExpressionType.GreaterThanOrEqual: return StringGreaterThanOrEqualRetBool;
                case ExpressionType.LessThan: return StringLessThanOrEqualRetBool;
                case ExpressionType.LessThanOrEqual: return StringLessThanRetBool;
            }

            return null;
        }
        
        private Func<CallSite, object, string, bool> GetStringObjectStringDelegate(BinaryOperationBinder opBinder) {
            switch (opBinder.Operation) {
                case ExpressionType.Equal:
                    return StringEqualRetBool;
            }

            return null;
        }

        public bool StringEqualRetBool(CallSite site, object self, string other) {
            string selfStr = self as string;
            if (selfStr != null && other != null) {
                return selfStr == other;
            }
            if (CallSiteOps.NeedsUpdate(site)) {
                return false;
            }
            return ((CallSite<Func<CallSite, object, string, bool>>)site).Update(site, self, other);
        }

        public bool StringEqualRetBool(CallSite site, object self, object other) {
            string selfStr = self as string;
            if (selfStr != null) {
                string otherStr = other as string;
                if (otherStr != null) {
                    return selfStr == otherStr;
                }
            }

            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool StringNotEqualRetBool(CallSite site, object self, object other) {
            string selfStr = self as string;
            if (selfStr != null) {
                string otherStr = other as string;
                if (otherStr != null) {
                    return selfStr != otherStr;
                }
            }

            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool StringGreaterThanRetBool(CallSite site, object self, object other) {
            string selfStr = self as string;
            if (selfStr != null) {
                string otherStr = other as string;
                if (otherStr != null) {
                    return StringOps.GreaterThan(selfStr, otherStr);
                }
            }

            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool StringGreaterThanOrEqualRetBool(CallSite site, object self, object other) {
            string selfStr = self as string;
            if (selfStr != null) {
                string otherStr = other as string;
                if (otherStr != null) {
                    return StringOps.GreaterThanOrEqual(selfStr, otherStr);
                }
            }

            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool StringLessThanRetBool(CallSite site, object self, object other) {
            string selfStr = self as string;
            if (selfStr != null) {
                string otherStr = other as string;
                if (otherStr != null) {
                    return StringOps.LessThan(selfStr, otherStr);
                }
            }

            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool StringLessThanOrEqualRetBool(CallSite site, object self, object other) {
            if (self != null && self.GetType() == typeof(string)) {
                if (other != null && other.GetType() == typeof(string)) {
                    return StringOps.LessThanOrEqual((string)self, (string)other);
                }
            }

            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }
        */
        #region Generated Python Fast Ops Ret Bool

        // *** BEGIN GENERATED CODE ***
        // generated by function: fast_op_ret_bool from: generate_ops.py

        private Func<CallSite, object, object, bool> GetIntObjectObjectDelegate(BinaryOperationBinder opBinder) {
            switch (opBinder.Operation) {
                case ExpressionType.Equal: return IntEqualRetBool;
                case ExpressionType.NotEqual: return IntNotEqualRetBool; 
                case ExpressionType.GreaterThan: return IntGreaterThanRetBool;
                case ExpressionType.LessThan: return IntLessThanRetBool;
                case ExpressionType.GreaterThanOrEqual: return IntGreaterThanOrEqualRetBool;
                case ExpressionType.LessThanOrEqual:return IntLessThanOrEqualRetBool;
            }
            return null;
        }

        public bool IntEqualRetBool(CallSite site, object self, object other) {
            if (self != null && self.GetType() == typeof(int)) {
                if (other != null && other.GetType() == typeof(int)) {
                    return (int)self == (int)other;
                }
            }
            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool IntNotEqualRetBool(CallSite site, object self, object other) {
            if (self != null && self.GetType() == typeof(int)) {
                if (other != null && other.GetType() == typeof(int)) {
                    return (int)self != (int)other;
                }
            }
            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool IntGreaterThanRetBool(CallSite site, object self, object other) {
            if (self != null && self.GetType() == typeof(int)) {
                if (other != null && other.GetType() == typeof(int)) {
                    return (int)self > (int)other;
                }
            }
            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool IntLessThanRetBool(CallSite site, object self, object other) {
            if (self != null && self.GetType() == typeof(int)) {
                if (other != null && other.GetType() == typeof(int)) {
                    return (int)self < (int)other;
                }
            }
            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool IntGreaterThanOrEqualRetBool(CallSite site, object self, object other) {
            if (self != null && self.GetType() == typeof(int)) {
                if (other != null && other.GetType() == typeof(int)) {
                    return (int)self >= (int)other;
                }
            }
            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        public bool IntLessThanOrEqualRetBool(CallSite site, object self, object other) {
            if (self != null && self.GetType() == typeof(int)) {
                if (other != null && other.GetType() == typeof(int)) {
                    return (int)self <= (int)other;
                }
            }
            return ((CallSite<Func<CallSite, object, object, bool>>)site).Update(site, self, other);
        }

        private Func<CallSite, object, int, bool> GetIntObjectIntDelegate(BinaryOperationBinder opBinder) {
            switch (opBinder.Operation) {
                case ExpressionType.Equal: return IntEqualRetBool;
                case ExpressionType.NotEqual: return IntNotEqualRetBool; 
                case ExpressionType.GreaterThan: return IntGreaterThanRetBool;
                case ExpressionType.LessThan: return IntLessThanRetBool;
                case ExpressionType.GreaterThanOrEqual: return IntGreaterThanOrEqualRetBool;
                case ExpressionType.LessThanOrEqual:return IntLessThanOrEqualRetBool;
            }
            return null;
        }

        public bool IntEqualRetBool(CallSite site, object self, int other) {
            if (self != null && self.GetType() == typeof(int)) {
                return (int)self == (int)other;
            }
            return ((CallSite<Func<CallSite, object, int, bool>>)site).Update(site, self, other);
        }

        public bool IntNotEqualRetBool(CallSite site, object self, int other) {
            if (self != null && self.GetType() == typeof(int)) {
                return (int)self != (int)other;
            }
            return ((CallSite<Func<CallSite, object, int, bool>>)site).Update(site, self, other);
        }

        public bool IntGreaterThanRetBool(CallSite site, object self, int other) {
            if (self != null && self.GetType() == typeof(int)) {
                return (int)self > (int)other;
            }
            return ((CallSite<Func<CallSite, object, int, bool>>)site).Update(site, self, other);
        }

        public bool IntLessThanRetBool(CallSite site, object self, int other) {
            if (self != null && self.GetType() == typeof(int)) {
                return (int)self < (int)other;
            }
            return ((CallSite<Func<CallSite, object, int, bool>>)site).Update(site, self, other);
        }

        public bool IntGreaterThanOrEqualRetBool(CallSite site, object self, int other) {
            if (self != null && self.GetType() == typeof(int)) {
                return (int)self >= (int)other;
            }
            return ((CallSite<Func<CallSite, object, int, bool>>)site).Update(site, self, other);
        }

        public bool IntLessThanOrEqualRetBool(CallSite site, object self, int other) {
            if (self != null && self.GetType() == typeof(int)) {
                return (int)self <= (int)other;
            }
            return ((CallSite<Func<CallSite, object, int, bool>>)site).Update(site, self, other);
        }

        private Func<CallSite, int, object, bool> GetIntIntObjectDelegate(BinaryOperationBinder opBinder) {
            switch (opBinder.Operation) {
                case ExpressionType.Equal: return IntEqualRetBool;
                case ExpressionType.NotEqual: return IntNotEqualRetBool; 
                case ExpressionType.GreaterThan: return IntGreaterThanRetBool;
                case ExpressionType.LessThan: return IntLessThanRetBool;
                case ExpressionType.GreaterThanOrEqual: return IntGreaterThanOrEqualRetBool;
                case ExpressionType.LessThanOrEqual:return IntLessThanOrEqualRetBool;
            }
            return null;
        }

        public bool IntEqualRetBool(CallSite site, int self, object other) {
            if (other != null && other.GetType() == typeof(int)) {
                return (int)self == (int)other;
            }
            return ((CallSite<Func<CallSite, int, object, bool>>)site).Update(site, self, other);
        }

        public bool IntNotEqualRetBool(CallSite site, int self, object other) {
            if (other != null && other.GetType() == typeof(int)) {
                return (int)self != (int)other;
            }
            return ((CallSite<Func<CallSite, int, object, bool>>)site).Update(site, self, other);
        }

        public bool IntGreaterThanRetBool(CallSite site, int self, object other) {
            if (other != null && other.GetType() == typeof(int)) {
                return (int)self > (int)other;
            }
            return ((CallSite<Func<CallSite, int, object, bool>>)site).Update(site, self, other);
        }

        public bool IntLessThanRetBool(CallSite site, int self, object other) {
            if (other != null && other.GetType() == typeof(int)) {
                return (int)self < (int)other;
            }
            return ((CallSite<Func<CallSite, int, object, bool>>)site).Update(site, self, other);
        }

        public bool IntGreaterThanOrEqualRetBool(CallSite site, int self, object other) {
            if (other != null && other.GetType() == typeof(int)) {
                return (int)self >= (int)other;
            }
            return ((CallSite<Func<CallSite, int, object, bool>>)site).Update(site, self, other);
        }

        public bool IntLessThanOrEqualRetBool(CallSite site, int self, object other) {
            if (other != null && other.GetType() == typeof(int)) {
                return (int)self <= (int)other;
            }
            return ((CallSite<Func<CallSite, int, object, bool>>)site).Update(site, self, other);
        }

        private Func<CallSite, int, int, bool> GetIntIntIntDelegate(BinaryOperationBinder opBinder) {
            switch (opBinder.Operation) {
                case ExpressionType.Equal: return IntEqualRetBool;
                case ExpressionType.NotEqual: return IntNotEqualRetBool; 
                case ExpressionType.GreaterThan: return IntGreaterThanRetBool;
                case ExpressionType.LessThan: return IntLessThanRetBool;
                case ExpressionType.GreaterThanOrEqual: return IntGreaterThanOrEqualRetBool;
                case ExpressionType.LessThanOrEqual:return IntLessThanOrEqualRetBool;
            }
            return null;
        }

        public bool IntEqualRetBool(CallSite site, int self, int other) {
            return (int)self == (int)other;
        }

        public bool IntNotEqualRetBool(CallSite site, int self, int other) {
            return (int)self != (int)other;
        }

        public bool IntGreaterThanRetBool(CallSite site, int self, int other) {
            return (int)self > (int)other;
        }

        public bool IntLessThanRetBool(CallSite site, int self, int other) {
            return (int)self < (int)other;
        }

        public bool IntGreaterThanOrEqualRetBool(CallSite site, int self, int other) {
            return (int)self >= (int)other;
        }

        public bool IntLessThanOrEqualRetBool(CallSite site, int self, int other) {
            return (int)self <= (int)other;
        }


        // *** END GENERATED CODE ***

        #endregion

    }
}
