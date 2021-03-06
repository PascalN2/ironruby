/* ****************************************************************************
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

using System.Runtime.CompilerServices;
using Microsoft.Scripting.Runtime;
using IronPython.Runtime.Operations;

namespace IronPython.Runtime.Types {
    public partial class OldInstance {
        #region Generated OldInstance Operators

        // *** BEGIN GENERATED CODE ***
        // generated by function: oldinstance_operators from: generate_ops.py

        [return: MaybeNotImplemented]
        public static object operator +([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorAdd);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseAdd);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        public static object operator +(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseAdd);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceAdd(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceAdd);
        }

        [return: MaybeNotImplemented]
        public static object operator -([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorSubtract);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseSubtract);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        public static object operator -(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseSubtract);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceSubtract(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceSubtract);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object Power([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorPower);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReversePower);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object Power(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReversePower);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlacePower(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlacePower);
        }

        [return: MaybeNotImplemented]
        public static object operator *([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorMultiply);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseMultiply);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        public static object operator *(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseMultiply);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceMultiply(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceMultiply);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object FloorDivide([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorFloorDivide);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseFloorDivide);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object FloorDivide(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseFloorDivide);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceFloorDivide(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceFloorDivide);
        }

        [return: MaybeNotImplemented]
        public static object operator /([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorDivide);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseDivide);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        public static object operator /(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseDivide);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceDivide(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceDivide);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object TrueDivide([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorTrueDivide);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseTrueDivide);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object TrueDivide(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseTrueDivide);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceTrueDivide(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceTrueDivide);
        }

        [return: MaybeNotImplemented]
        public static object operator %([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorMod);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseMod);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        public static object operator %(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseMod);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceMod(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceMod);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object LeftShift([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorLeftShift);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseLeftShift);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object LeftShift(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseLeftShift);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceLeftShift(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceLeftShift);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object RightShift([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorRightShift);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseRightShift);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public static object RightShift(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseRightShift);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceRightShift(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceRightShift);
        }

        [return: MaybeNotImplemented]
        public static object operator &([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorBitwiseAnd);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseBitwiseAnd);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        public static object operator &(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseBitwiseAnd);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceBitwiseAnd(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceBitwiseAnd);
        }

        [return: MaybeNotImplemented]
        public static object operator |([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorBitwiseOr);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseBitwiseOr);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        public static object operator |(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseBitwiseOr);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceBitwiseOr(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceBitwiseOr);
        }

        [return: MaybeNotImplemented]
        public static object operator ^([NotNull]OldInstance self, object other) {
            object res = InvokeOne(self, other, Symbols.OperatorExclusiveOr);
            if (res != NotImplementedType.Value) return res;

            OldInstance otherOc = other as OldInstance;
            if (otherOc != null) {
                return InvokeOne(otherOc, self, Symbols.OperatorReverseExclusiveOr);
            }
            return PythonOps.NotImplemented;
        }

        [return: MaybeNotImplemented]
        public static object operator ^(object other, [NotNull]OldInstance self) {
            return InvokeOne(self, other, Symbols.OperatorReverseExclusiveOr);
        }

        [return: MaybeNotImplemented]
        [SpecialName]
        public object InPlaceExclusiveOr(object other) {
            return InvokeOne(this, other, Symbols.OperatorInPlaceExclusiveOr);
        }


        // *** END GENERATED CODE ***

        #endregion

    }
}
